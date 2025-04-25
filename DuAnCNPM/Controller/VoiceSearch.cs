using NAudio.Wave;
using System;
using System.IO;
using System.Reflection;
using System.Windows;
using Vosk;

namespace DuAnCNPM.Controller
{
    class VoiceSearch
    {
        private Model _model;
        private VoskRecognizer recognizer;
        private WaveInEvent waveIn;
        private MemoryStream audioStream;
        public VoiceSearch()
        {
            try
            {
                // Lấy đường dẫn gốc của thư mục đang chạy
                string basePath = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;

                // Nối với thư mục model
                string modelPath = Path.Combine(basePath, "Models", "vosk-model-vn-0.4");
                //Console.WriteLine(modelPath);
                // Kiểm tra xem modelPath có tồn tại hay không
                if (!Directory.Exists(modelPath))
                {
                    throw new Exception("Đường dẫn mô hình không hợp lệ hoặc không tìm thấy thư mục.");
                }

                _model = new Model(modelPath);

                // Khởi tạo recognizer
                recognizer = new VoskRecognizer(_model, 16000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi khởi tạo VoiceSearch: " + ex.Message);
            }
        }

        public void StartVoiceSearch()
        {
            // Kiểm tra nếu waveIn đã được khởi tạo
            if (waveIn != null)
            {
                StopVoiceSearch(); // Dừng ghi âm nếu đang hoạt động
            }

            waveIn = new WaveInEvent
            {
                DeviceNumber = 0, // Chọn thiết bị thu âm mặc định
                WaveFormat = new WaveFormat(16000, 1) // Đặt tần số mẫu 16kHz và 1 kênh (mono)
            };

            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.StartRecording();
        }
        string result = "";
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                // Gửi dữ liệu âm thanh vào VoskRecognizer
                if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
                {
                    result = recognizer.Result();
                    MessageBox.Show("Nhận diện: " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xử lý âm thanh: " + ex.Message);
            }
        }

        public void StopVoiceSearch()
        {
            try
            {
                // Dừng ghi âm và giải phóng tài nguyên
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
