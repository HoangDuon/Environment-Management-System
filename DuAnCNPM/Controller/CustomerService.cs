using DuAnCNPM.Controlers;
using DuAnCNPM.Datas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnCNPM.Controller
{
    class CustomerService
    {
        public CustomerService() { }

        //Tu phat sinh ma nhan vien
        public String generateCustomerID()
        {
            int count = 0;
            using (var context = new CTQLMTContext())
            {
                if (context.KhachHangs.Count() == 0)
                {
                    count = 1;
                }
                else
                {
                    int[] stt = new int[context.KhachHangs.Count()];
                    List<KhachHang> listKH = context.KhachHangs.ToList();
                    int i = 0;
                    foreach (KhachHang kh in listKH)
                    {
                        stt[i] = int.Parse(kh.MA_CONG_TY.Substring(2));
                        i++;
                    }
                    count = stt.Max() + 1;
                }
                    
            }
            String result = "KH"  + count.ToString();
            return result;
        }

        //Them khach moi vao danh sach khach hang da co
        public Boolean addCustomer(String TenCongTy, String SDT, String Gmail, String DiaChi, String MaSoThue)
        {
            Validating validate = new Validating();
            if (!validate.validateGmail(Gmail)) return false;
            if (!validate.validatePhoneNumber(SDT)) return false;

            using (var context = new CTQLMTContext())
            {
                var khachhang = new KhachHang
                {
                    MA_CONG_TY = generateCustomerID(),
                    TEN_CONG_TY = TenCongTy,
                    SDT_KHACHHANG = SDT,
                    GMAIL_KHACHHANG = Gmail,
                    DIA_CHI = DiaChi,
                    TRANG_THAI = true,
                    THOI_GIAN = DateTime.Today,
                    MA_SO_THUE = MaSoThue
                };
                context.KhachHangs.Add(khachhang);
                context.SaveChanges();
            }
            return true;
        }

        //Xoa mot khach hang trong danh sach
        public Boolean deleteCustomer(String MaKhachHang)
        {
            using (var context = new CTQLMTContext())
            {
                // Kiem tra khach hang can xoa co ton tai khong
                var khachhang = context.KhachHangs.Find(MaKhachHang);
                if (khachhang == null) return false;

                khachhang.TRANG_THAI = false;
                context.SaveChanges();
            }
            return true;
        }

        //Chinh sua ten cong ty khach hang
        public Boolean editCustomerName(String MaCongTy, String TenCongTy)
        {
            using (var context = new CTQLMTContext())
            {
                var khachhang = context.KhachHangs.Find(MaCongTy);
                if (khachhang == null) return false;
                khachhang.TEN_CONG_TY = TenCongTy;
                context.SaveChanges();
            }
            return true;
        }

        //Chinh sua sdt lien he cua cong ty khach hang
        public Boolean editCustomerPhoneNumber(String MaCongTy, String SDT)
        {
            Validating validate = new Validating();
            if (!validate.validatePhoneNumber(SDT)) return false;

            using (var context = new CTQLMTContext())
            {
                var khachhang = context.KhachHangs.Find(MaCongTy);
                if (khachhang == null) return false;
                khachhang.SDT_KHACHHANG = SDT;
                context.SaveChanges();
            }
            return true;
        }

        //chinh sua gmail cong ty khach hang
        public Boolean editCustomerGmail(String MaCongTy, String Gmail)
        {
            Validating validate = new Validating();
            if (!validate.validateGmail(Gmail)) return false;

            using (var context = new CTQLMTContext())
            {
                var khachhang = context.KhachHangs.Find(MaCongTy);
                if (khachhang == null) return false;
                khachhang.GMAIL_KHACHHANG = Gmail;
                context.SaveChanges();
            }
            return true;
        }

        //chinh sua dia chi cong ty khach hang
        public Boolean editCustomerAddress(String MaCongTy, String DiaChi)
        {
            using (var context = new CTQLMTContext())
            {
                var khachhang = context.KhachHangs.Find(MaCongTy);
                if (khachhang == null) return false;
                context.SaveChanges();
            }
            return true;
        }

        //search 
        // tim khach hang 
        //data search name
        public Dictionary<String, HashSet<String>> dataName()
        {
            Dictionary<String, HashSet<String>> data = new Dictionary<String, HashSet<String>>();
            using (var context = new CTQLMTContext())
            {
                var listKH = context.KhachHangs.ToList();
                foreach (KhachHang kh in listKH)
                {
                    String[] nameArr = kh.TEN_CONG_TY.ToLower().Trim().Split(' ');
                    for (int i = 0; i < nameArr.Length; i++)
                    {
                        if (data.ContainsKey(nameArr[i]))
                        {
                            data[nameArr[i]].Add(kh.MA_CONG_TY);
                        }
                        else
                        {
                            HashSet<String> set = new HashSet<String>();
                            set.Add(kh.MA_CONG_TY);
                            data.Add(nameArr[i], set);
                        }
                    }
                }
            }
            return data;
        }
        //tim theo ten khach hang
        private List<KhachHang> searchByCustomerName(String text)
        {
            var context = new CTQLMTContext();
            String[] textEle = text.Split(' ');
            Dictionary<String, HashSet<String>> data = dataName();
            List<HashSet<String>> saveResult = new List<HashSet<String>>();
            for (int i = 0; i < textEle.Length; i++)
            {
                if (data.ContainsKey(textEle[i]))
                {
                    saveResult.Add(data[textEle[i]]);
                }
            }
            List<KhachHang> result = new List<KhachHang>();
            if (saveResult.Count == 0) return result;
            if (saveResult.Count > 1)
            {
                for (int i = 1; i < saveResult.Count; i++)
                {
                    saveResult[0].IntersectWith(saveResult[i]);
                }
                foreach (String s in saveResult[0])
                {
                    result.Add(context.KhachHangs.Find(s));
                }
            }
            else
            {
                foreach (String s in saveResult[0])
                {
                    result.Add(context.KhachHangs.Find(s));
                }
            }
            return result;
        }

        // kiem tra ma khach hang
        private bool checkTextIsCustomerID(String text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= 2) return false;
            List<String> sample = new List<String>() { "KH" };
            String first = text.Substring(2);      // lấy stt
            String final = text.Substring(0, 2);   // lấy 5 kí tự đầu
            bool checkFinal = sample.Contains(final);
            bool checkFirst = int.TryParse(first, out int result);
            if (checkFinal && checkFirst) return true;
            return false;
        }

        //tìm kiếm Khach hang
        public List<KhachHang> searchCustomer(String text)
        {
            List<KhachHang> result = new List<KhachHang>();
            if (string.IsNullOrWhiteSpace(text)) return result;
            Validating validate = new Validating();
            Dictionary<String, String> dic = validate.listMST();


            // Phân tích chuỗi truyền vào laà mã nhân viên
            if (checkTextIsCustomerID(text))
            {
                using (var context = new CTQLMTContext())
                {
                    result.Add(context.KhachHangs.Find(text));
                }
                return result;
            }
            // Kiểm tra khách hàng có tồn tại không bằng mã số thuế
            else if (dic.ContainsKey(text))
            {
                using (var context = new CTQLMTContext())
                {
                    result.Add(context.KhachHangs.Find(dic[text]));
                }
                return result;
            }
            // phân tích chuỗi truyền vào là tên nhân viên
            else
            {
                return searchByCustomerName(text.ToLower());
            }
        }

        // tìm kiếm khách hàng cho nhân viên
        public List<KhachHang> searchCustomerForEmployee(String text)
        {
            List<KhachHang> listKH = searchCustomer(text);
            List<KhachHang> result = new List<KhachHang>();
            foreach (KhachHang kh in listKH)
            {
                if (kh.TRANG_THAI == true)
                {
                    result.Add(kh);
                }
            }
            return result;
        }

        //sort customer 
        // tạo data cho số thứ tự mã khách hàng
        public Dictionary<int, String> dataToSort()
        {
            Dictionary<int, String> dic = new Dictionary<int, string>();
            using (var context = new CTQLMTContext())
            {
                var listKH = context.KhachHangs.ToList();
                foreach (KhachHang nv in listKH)
                {
                    int stt = int.Parse(nv.MA_CONG_TY.Substring(2));
                    dic.Add(stt, nv.MA_CONG_TY);
                }
            }
            return dic;
        }
        // sort nhân viên 
        public List<KhachHang> sortCustomer()
        {
            List<KhachHang> result = new List<KhachHang>();
            Dictionary<int, String> dic = dataToSort();
            using (var context = new CTQLMTContext())
            {
                for (int i = 1; i <= dic.Count(); i++)
                {
                    var khachhang = context.KhachHangs.Find(dic[i]);
                    if (khachhang != null)
                    {
                        result.Add(khachhang);
                    }
                }
            }
            return result;
        }


        //Hien data tim kiem
        public void ShowCustomersSearch(List<KhachHang> khachHangs, DuAnCNPM.Views.DoubleBufferedPanel container, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 10;
                ////var khachHang = context.KhachHangs.ToList();
                //var khachHang = sortCustomer();
                foreach (var kh in khachHangs)
                {
                    var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                    if (kh.TRANG_THAI == false)
                    {
                        panel.BorderColor = System.Drawing.Color.Salmon;
                        panel.BorderRadius = 18;
                        panel.BorderThickness = 4;
                        panel.CustomBorderColor = System.Drawing.Color.AliceBlue;
                        panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                        panel.FillColor = System.Drawing.Color.Gainsboro;
                        panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                        panel.ForeColor = System.Drawing.Color.Black;
                        panel.Location = new System.Drawing.Point(5, yOffset);
                        panel.Name = "grbHDnv1";
                        panel.Size = new System.Drawing.Size(288, 53);
                        panel.TabIndex = 11;
                        panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }
                    else
                    {
                        panel.BorderColor = System.Drawing.Color.LightGray;
                        panel.BorderRadius = 18;
                        panel.BorderThickness = 2;
                        panel.CustomBorderColor = System.Drawing.Color.AliceBlue;
                        panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                        panel.FillColor = System.Drawing.Color.Gainsboro;
                        panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                        panel.ForeColor = System.Drawing.Color.Black;
                        panel.Location = new System.Drawing.Point(5, yOffset);
                        panel.Name = "grbHDnv1";
                        panel.Size = new System.Drawing.Size(288, 53);
                        panel.TabIndex = 11;
                        panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }

                    var lblNgayHetHan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblNgayHetHan.BackColor = System.Drawing.Color.Gainsboro;
                    lblNgayHetHan.BorderColor = System.Drawing.Color.Empty;
                    lblNgayHetHan.BorderThickness = 0;
                    lblNgayHetHan.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblNgayHetHan.DefaultText = "Mã Khách Hàng: " + kh.MA_CONG_TY;
                    lblNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    lblNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    lblNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblNgayHetHan.FillColor = System.Drawing.Color.Gainsboro;
                    lblNgayHetHan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                    lblNgayHetHan.ForeColor = System.Drawing.Color.Black;
                    lblNgayHetHan.Location = new System.Drawing.Point(11, 30);
                    lblNgayHetHan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                    lblNgayHetHan.Name = "txtNgayhethannv1";
                    lblNgayHetHan.PasswordChar = '\0';
                    lblNgayHetHan.PlaceholderText = "";
                    lblNgayHetHan.ReadOnly = true;
                    lblNgayHetHan.SelectedText = "";
                    lblNgayHetHan.Size = new System.Drawing.Size(266, 18);
                    lblNgayHetHan.TabIndex = 1;
                    lblNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    var lblTieuDe = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblTieuDe.BackColor = System.Drawing.Color.Gainsboro;
                    lblTieuDe.BorderColor = System.Drawing.Color.Empty;
                    lblTieuDe.BorderThickness = 0;
                    lblTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblTieuDe.DefaultText = kh.TEN_CONG_TY;
                    lblTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    lblTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    lblTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblTieuDe.FillColor = System.Drawing.Color.Gainsboro;
                    lblTieuDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    lblTieuDe.ForeColor = System.Drawing.Color.Black;
                    lblTieuDe.Location = new System.Drawing.Point(11, 8);
                    lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    lblTieuDe.Name = "txtHDnv1";
                    lblTieuDe.PasswordChar = '\0';
                    lblTieuDe.PlaceholderText = "";
                    lblTieuDe.ReadOnly = true;
                    lblTieuDe.SelectedText = "";
                    lblTieuDe.Size = new System.Drawing.Size(266, 18);
                    lblTieuDe.TabIndex = 0;
                    lblTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    panel.Controls.Add(lblNgayHetHan);
                    panel.Controls.Add(lblTieuDe);

                    container.Controls.Add(panel);

                    panel.Click += (s, e) => ShowCustomerDetail(kh, chitiet);
                    lblTieuDe.Click += (s, e) => ShowCustomerDetail(kh, chitiet);
                    lblNgayHetHan.Click += (s, e) => ShowCustomerDetail(kh, chitiet);

                    panel.MouseEnter += (s, e) =>
                    {
                        panel.FillColor = Color.DarkGray;

                        lblTieuDe.FillColor = Color.DarkGray;
                        lblNgayHetHan.FillColor = Color.DarkGray;
                    };

                    panel.MouseLeave += (s, e) =>
                    {
                        panel.FillColor = Color.Gainsboro;

                        lblTieuDe.FillColor = Color.Gainsboro;
                        lblNgayHetHan.FillColor = Color.Gainsboro;

                    };

                    yOffset += panel.Height + 10;

                }
        }

        //them moi dsach hop dong tu database
        public void ShowCustomers(DuAnCNPM.Views.DoubleBufferedPanel container, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 10;
            using (var context = new CTQLMTContext())
            {
                //var khachHang = context.KhachHangs.ToList();
                var khachHang = sortCustomer();
                foreach (var kh in khachHang)
                {
                        var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                        if (kh.TRANG_THAI == false)
                        {
                            panel.BorderColor = System.Drawing.Color.Salmon;
                            panel.BorderRadius = 18;
                            panel.BorderThickness = 4;
                            panel.CustomBorderColor = System.Drawing.Color.AliceBlue;
                            panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                            panel.FillColor = System.Drawing.Color.Gainsboro;
                            panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                            panel.ForeColor = System.Drawing.Color.Black;
                            panel.Location = new System.Drawing.Point(5, yOffset);
                            panel.Name = "grbHDnv1";
                            panel.Size = new System.Drawing.Size(288, 53);
                            panel.TabIndex = 11;
                            panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        }
                        else
                        {
                            panel.BorderColor = System.Drawing.Color.LightGray;
                            panel.BorderRadius = 18;
                            panel.BorderThickness = 2;
                            panel.CustomBorderColor = System.Drawing.Color.AliceBlue;
                            panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                            panel.FillColor = System.Drawing.Color.Gainsboro;
                            panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                            panel.ForeColor = System.Drawing.Color.Black;
                            panel.Location = new System.Drawing.Point(5, yOffset);
                            panel.Name = "grbHDnv1";
                            panel.Size = new System.Drawing.Size(288, 53);
                            panel.TabIndex = 11;
                            panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        }

                        var lblNgayHetHan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                        lblNgayHetHan.BackColor = System.Drawing.Color.Gainsboro;
                        lblNgayHetHan.BorderColor = System.Drawing.Color.Empty;
                        lblNgayHetHan.BorderThickness = 0;
                        lblNgayHetHan.Cursor = System.Windows.Forms.Cursors.IBeam;
                        lblNgayHetHan.DefaultText = "Mã Khách Hàng: " + kh.MA_CONG_TY;
                        lblNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                        lblNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                        lblNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        lblNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        lblNgayHetHan.FillColor = System.Drawing.Color.Gainsboro;
                        lblNgayHetHan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                        lblNgayHetHan.ForeColor = System.Drawing.Color.Black;
                        lblNgayHetHan.Location = new System.Drawing.Point(11, 30);
                        lblNgayHetHan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                        lblNgayHetHan.Name = "txtNgayhethannv1";
                        lblNgayHetHan.PasswordChar = '\0';
                        lblNgayHetHan.PlaceholderText = "";
                        lblNgayHetHan.ReadOnly = true;
                        lblNgayHetHan.SelectedText = "";
                        lblNgayHetHan.Size = new System.Drawing.Size(266, 18);
                        lblNgayHetHan.TabIndex = 1;
                        lblNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                        var lblTieuDe = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                        lblTieuDe.BackColor = System.Drawing.Color.Gainsboro;
                        lblTieuDe.BorderColor = System.Drawing.Color.Empty;
                        lblTieuDe.BorderThickness = 0;
                        lblTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
                        lblTieuDe.DefaultText = kh.TEN_CONG_TY;
                        lblTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                        lblTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                        lblTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        lblTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                        lblTieuDe.FillColor = System.Drawing.Color.Gainsboro;
                        lblTieuDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                        lblTieuDe.ForeColor = System.Drawing.Color.Black;
                        lblTieuDe.Location = new System.Drawing.Point(11, 8);
                        lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        lblTieuDe.Name = "txtHDnv1";
                        lblTieuDe.PasswordChar = '\0';
                        lblTieuDe.PlaceholderText = "";
                        lblTieuDe.ReadOnly = true;
                        lblTieuDe.SelectedText = "";
                        lblTieuDe.Size = new System.Drawing.Size(266, 18);
                        lblTieuDe.TabIndex = 0;
                        lblTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                        panel.Controls.Add(lblNgayHetHan);
                        panel.Controls.Add(lblTieuDe);

                        container.Controls.Add(panel);

                        panel.Click += (s, e) => ShowCustomerDetail(kh, chitiet);
                        lblTieuDe.Click += (s, e) => ShowCustomerDetail(kh, chitiet);
                        lblNgayHetHan.Click += (s, e) => ShowCustomerDetail(kh, chitiet);

                        panel.MouseEnter += (s, e) =>
                        {
                            panel.FillColor = Color.DarkGray;

                            lblTieuDe.FillColor = Color.DarkGray;
                            lblNgayHetHan.FillColor = Color.DarkGray;
                        };

                        panel.MouseLeave += (s, e) =>
                        {
                            panel.FillColor = Color.Gainsboro;

                            lblTieuDe.FillColor = Color.Gainsboro;
                            lblNgayHetHan.FillColor = Color.Gainsboro;

                        };

                        yOffset += panel.Height + 10;

                }
            }
        }

        private void ShowCustomerDetail(KhachHang kh, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel main)
        {
            (main.Controls["txtMaCty"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = kh.MA_CONG_TY;
            (main.Controls["txtTenCty"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = kh.TEN_CONG_TY;
            (main.Controls["txtDiachiCty"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = kh.DIA_CHI;
            (main.Controls["txtSDTCty"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = kh.SDT_KHACHHANG;
            (main.Controls["txtGmailCty"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = kh.GMAIL_KHACHHANG;
            (main.Controls["txtMST"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = kh.MA_SO_THUE;
            (main.Parent.Controls["btnLuuDSKH"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled= false;
            (main.Parent.Controls["btnSuaDSKH"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;
            (main.Parent.Controls["btnSuaDSKH"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = true;
            main.Visible = true;
        }
    }
}
