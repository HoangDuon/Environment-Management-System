using NAudio.Wave;
using System;
using System.IO;
using Vosk;

namespace DuAnCNPM.Controller
{
    class VoiceSearch
    {
        private Model _model;
        private VoskRecognizer recognizer;
        private WaveInEvent waveIn;

        // Tạo sự kiện
        public event Action<string> OnRecognized;

        public VoiceSearch()
        {
            try
            {
                string basePath = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
                string modelPath = Path.Combine(basePath, "Models", "vosk-model-vn-0.4");

                if (!Directory.Exists(modelPath))
                {
                    throw new Exception("Đường dẫn mô hình không hợp lệ hoặc không tìm thấy thư mục.");
                }

                _model = new Model(modelPath);
                recognizer = new VoskRecognizer(_model, 16000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi khởi tạo VoiceSearch: " + ex.Message);
            }
        }

        public void StartVoiceSearch()
        {
            if (waveIn != null)
            {
                StopVoiceSearch();
            }

            waveIn = new WaveInEvent
            {
                DeviceNumber = 0,
                WaveFormat = new WaveFormat(16000, 1)
            };

            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.StartRecording();
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
                {
                    string resultJson = recognizer.Result();
                    string recognizedText = ExtractTextFromResult(resultJson);

                    // Gọi sự kiện trả kết quả ra ngoài
                    OnRecognized?.Invoke(recognizedText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xử lý âm thanh: " + ex.Message);
            }
        }

        private string ExtractTextFromResult(string json)
        {
            int firstQuote = json.IndexOf(':');  // Tìm dấu ":" trong chuỗi JSON
            int secondQuote = json.IndexOf('"', firstQuote + 1);  // Tìm dấu ngoặc kép thứ hai sau dấu ":"

            if (firstQuote >= 0 && secondQuote >= 0)
            {
                // Trích xuất phần chuỗi giữa dấu ngoặc kép sau dấu ":" và dấu ngoặc kép cuối
                string result = json.Substring(secondQuote + 1, json.IndexOf('"', secondQuote + 1) - secondQuote - 1).Trim();

                // Loại bỏ dấu ngoặc kép ở đầu và cuối chuỗi nếu có
                if (result.StartsWith("\"") && result.EndsWith("\""))
                {
                    result = result.Substring(1, result.Length - 2);  // Cắt bỏ dấu ngoặc kép
                }

                return result;
            }

            return "";
        }

        public void StopVoiceSearch()
        {
            try
            {
                if (waveIn != null)
                {
                    waveIn.StopRecording();
                    waveIn.Dispose();
                    waveIn = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi dừng ghi âm: " + ex.Message);
            }
        }
    }
}
