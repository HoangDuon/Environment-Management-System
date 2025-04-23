using DuAnCNPM.Datas;
using System;
using System.Linq;
using DuAnCNPM.Models;
using DuAnCNPM.Controlers;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;

namespace DuAnCNPM.Controller
{
    class EnviromentIndexService
    {
        public EnviromentIndexService() { }

        // tu phat sinh ma chi so
        // ma chi so se bao bao ten loai chi so + so thu tu
        private String generateEID(String LoaiMoiTruong)
        {
            int count = 0;
            using (var context = new CTQLMTContext())
            {
                if (context.ChiSoMoiTruongs.Count() == 0)
                {
                    count = 1;
                }
                else
                {
                    int[] stt = new int[context.ChiSoMoiTruongs.Count()];
                    List<ChiSoMoiTruong> listCSMT = context.ChiSoMoiTruongs.ToList();
                    int i = 0;
                    foreach (ChiSoMoiTruong csmt in listCSMT)
                    {
                        if (csmt.LOAI_MOI_TRUONG == "DAT")
                        {
                            stt[i] = int.Parse(csmt.MA_CHI_SO.Substring(3));
                        }
                        else if (csmt.LOAI_MOI_TRUONG == "NUOC")
                        {
                            stt[i] = int.Parse(csmt.MA_CHI_SO.Substring(4));
                        }
                        else if (csmt.LOAI_MOI_TRUONG == "KHONGKHI")
                        {
                            stt[i] = int.Parse(csmt.MA_CHI_SO.Substring(8));
                        }
                        else //KHITHAI
                        {
                            stt[i] = int.Parse(csmt.MA_CHI_SO.Substring(7));
                        }
                        i++;
                    }
                    count = stt.Max() + 1;
                }
            }
            String result = LoaiMoiTruong + count.ToString();
            return result;
        }
        private String generateEID(String LoaiMoiTruong, int index)
        {
            int count = 0;
            using (var context = new CTQLMTContext())
            {
                int[] stt = new int[context.ChiSoMoiTruongs.Count()];
                List<ChiSoMoiTruong> listCSMT = context.ChiSoMoiTruongs.ToList();
                int i = 0;
                foreach (ChiSoMoiTruong csmt in listCSMT)
                {
                    if (csmt.LOAI_MOI_TRUONG == "DAT")
                    {
                        stt[i] = int.Parse(csmt.MA_CHI_SO.Substring(3));
                    }
                    else if (csmt.LOAI_MOI_TRUONG == "NUOC")
                    {
                        stt[i] = int.Parse(csmt.MA_CHI_SO.Substring(4));
                    }
                    else if (csmt.LOAI_MOI_TRUONG == "KHONGKHI")
                    {
                        stt[i] = int.Parse(csmt.MA_CHI_SO.Substring(8));
                    }
                    else //KHITHAI
                    {
                        stt[i] = int.Parse(csmt.MA_CHI_SO.Substring(7));
                    }
                    i++;
                }
                count = stt.Max() + index - 1 ;
            }

            String result = LoaiMoiTruong + count.ToString();
            return result;
        }

        // tao mot chi so moi truong
        public Boolean addEnviromentIndex(String TenChiSo, String LoaiMoiTruong, String TieuChuan, String NoiNhap)
        {
            Validating validate = new Validating();
            if (!validate.enviromentTypeValidate(LoaiMoiTruong)) return false;

            using (var context = new CTQLMTContext())
            {
                var chisomoitruong = new ChiSoMoiTruong
                {
                    MA_CHI_SO = generateEID(LoaiMoiTruong),
                    TEN_CHI_SO = TenChiSo,
                    LOAI_MOI_TRUONG = LoaiMoiTruong,
                    TIEU_CHUAN = TieuChuan,
                    VI_TRI = "Vị trí 1",
                    NOI_NHAP = NoiNhap,
                    TRANG_THAI = true
                };
                context.ChiSoMoiTruongs.Add(chisomoitruong);
                context.SaveChanges();
            }

            using (var context = new CTQLMTContext())
            {
                var listchisomoitruong = new List<ChiSoMoiTruong>
                {
                    new ChiSoMoiTruong
                    {
                        MA_CHI_SO = generateEID(LoaiMoiTruong, 2),
                        TEN_CHI_SO = TenChiSo,
                        LOAI_MOI_TRUONG = LoaiMoiTruong,
                        TIEU_CHUAN = TieuChuan,
                        VI_TRI = "Vị trí 2",
                        NOI_NHAP = NoiNhap,
                        TRANG_THAI = true
                    },
                    new ChiSoMoiTruong
                    {
                        MA_CHI_SO = generateEID(LoaiMoiTruong, 3),
                        TEN_CHI_SO = TenChiSo,
                        LOAI_MOI_TRUONG = LoaiMoiTruong,
                        TIEU_CHUAN = TieuChuan,
                        VI_TRI = "Vị trí 3",
                        NOI_NHAP = NoiNhap,
                        TRANG_THAI = true
                    }
                };
                context.ChiSoMoiTruongs.AddRange(listchisomoitruong);
                context.SaveChanges();
            }
            return true;
        }

        // Xoa mot chi so
        public Boolean deleteEnviromentIndex(String MaChiSo)
        {
            using (var context = new CTQLMTContext())
            {
                var chisomoitruong = context.ChiSoMoiTruongs.Find(MaChiSo);
                if (chisomoitruong == null) return false;

                chisomoitruong.TRANG_THAI = false;
                context.SaveChanges();
            }
            return true;
        }

        //chinh sua ten chi so
        public Boolean editName(String MaChiSo, String TenChiSo)
        {
            using (var context = new CTQLMTContext())
            {
                var chisomoitruong = context.ChiSoMoiTruongs.Find(MaChiSo);
                if (chisomoitruong == null) return false;
                chisomoitruong.TEN_CHI_SO = TenChiSo;
                context.SaveChanges();
            }
            return true;
        }


        //chinh sua loai moi truong
        public Boolean editEnviromentType(String MaChiSo, String LoaiMoiTruong)
        {
            Validating validate = new Validating();
            if (!validate.enviromentTypeValidate(LoaiMoiTruong)) return false;

            using (var context = new CTQLMTContext())
            {
                var chisomoitruong = context.ChiSoMoiTruongs.Find(MaChiSo);
                if (chisomoitruong == null) return false;
                chisomoitruong.LOAI_MOI_TRUONG = LoaiMoiTruong;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua tieu chuan
        public Boolean editStandardIndex(String MaChiSo, string index)
        {
            using (var context = new CTQLMTContext())
            {
                var chisomoitruong = context.ChiSoMoiTruongs.Find(MaChiSo);
                if (chisomoitruong == null) return false;
                chisomoitruong.TIEU_CHUAN = index;
                context.SaveChanges();
            }
            return true;
        }

        public Boolean editViTri(String MaChiSo, String ViTri)
        {
            using (var context = new CTQLMTContext())
            {
                var chisomoitruong = context.ChiSoMoiTruongs.Find(MaChiSo);
                if (chisomoitruong == null) return false;
                chisomoitruong.VI_TRI = ViTri;
                context.SaveChanges();
            }
            return true;
        }

        //them moi dsach hop dong tu tim kiem
        public void ShowStatsSearch(List<ChiSoMoiTruong> chiSoMoiTruongs, DuAnCNPM.Views.DoubleBufferedPanel container, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
            //var nhanVien = sortEmployee();
            foreach (var cs in chiSoMoiTruongs)
            {
                var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                if (cs.TRANG_THAI == false)
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
                    panel.Size = new System.Drawing.Size(container.Width - 20, 53);
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
                    panel.Size = new System.Drawing.Size(container.Width - 20, 53);
                    panel.TabIndex = 11;
                    panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
                int width = panel.Width - 20;
                var lblNgayHetHan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                lblNgayHetHan.BackColor = System.Drawing.Color.Gainsboro;
                lblNgayHetHan.BorderColor = System.Drawing.Color.Empty;
                lblNgayHetHan.BorderThickness = 0;
                lblNgayHetHan.Cursor = System.Windows.Forms.Cursors.IBeam;
                lblNgayHetHan.DefaultText = "Loại Môi Trường: " + cs.LOAI_MOI_TRUONG;
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
                lblNgayHetHan.Size = new System.Drawing.Size(width, 18);
                lblNgayHetHan.TabIndex = 1;
                lblNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                var lblTieuDe = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                lblTieuDe.BackColor = System.Drawing.Color.Gainsboro;
                lblTieuDe.BorderColor = System.Drawing.Color.Empty;
                lblTieuDe.BorderThickness = 0;
                lblTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
                lblTieuDe.DefaultText = cs.MA_CHI_SO + " - " + cs.TEN_CHI_SO;
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
                lblTieuDe.Size = new System.Drawing.Size(width, 18);
                lblTieuDe.TabIndex = 0;
                lblTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                panel.Controls.Add(lblNgayHetHan);
                panel.Controls.Add(lblTieuDe);

                container.Controls.Add(panel);

                panel.Click += (s, e) => ShowStatsDetail(cs, chitiet);
                lblTieuDe.Click += (s, e) => ShowStatsDetail(cs, chitiet);
                lblNgayHetHan.Click += (s, e) => ShowStatsDetail(cs, chitiet);

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
        public void ShowStats(DuAnCNPM.Views.DoubleBufferedPanel container, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
            using (var context = new CTQLMTContext())
            {
                var chiSoMoiTruongs = context.ChiSoMoiTruongs.ToList();
                //var nhanVien = sortEmployee();
                foreach (var cs in chiSoMoiTruongs)
                {
                    var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                    if (cs.TRANG_THAI == false)
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
                        panel.Size = new System.Drawing.Size(container.Width - 20, 53);
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
                        panel.Size = new System.Drawing.Size(container.Width - 20, 53);
                        panel.TabIndex = 11;
                        panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }
                    int width = panel.Width - 20;
                    var lblNgayHetHan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblNgayHetHan.BackColor = System.Drawing.Color.Gainsboro;
                    lblNgayHetHan.BorderColor = System.Drawing.Color.Empty;
                    lblNgayHetHan.BorderThickness = 0;
                    lblNgayHetHan.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblNgayHetHan.DefaultText = "Loại Môi Trường: " + cs.LOAI_MOI_TRUONG;
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
                    lblNgayHetHan.Size = new System.Drawing.Size(width, 18);
                    lblNgayHetHan.TabIndex = 1;
                    lblNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    var lblTieuDe = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblTieuDe.BackColor = System.Drawing.Color.Gainsboro;
                    lblTieuDe.BorderColor = System.Drawing.Color.Empty;
                    lblTieuDe.BorderThickness = 0;
                    lblTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblTieuDe.DefaultText = cs.MA_CHI_SO + " - " + cs.TEN_CHI_SO;
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
                    lblTieuDe.Size = new System.Drawing.Size(width, 18);
                    lblTieuDe.TabIndex = 0;
                    lblTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    panel.Controls.Add(lblNgayHetHan);
                    panel.Controls.Add(lblTieuDe);

                    container.Controls.Add(panel);

                    panel.Click += (s, e) => ShowStatsDetail(cs, chitiet);
                    lblTieuDe.Click += (s, e) => ShowStatsDetail(cs, chitiet);
                    lblNgayHetHan.Click += (s, e) => ShowStatsDetail(cs, chitiet);

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

        private void ShowStatsDetail(ChiSoMoiTruong cs, Siticone.Desktop.UI.WinForms.SiticoneGradientPanel main)
        {
            (main.Controls["txtTieuChuan"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = cs.TIEU_CHUAN;
            (main.Controls["txtNoiNhap"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = cs.NOI_NHAP;
            (main.Controls["txtViTriCS"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = cs.VI_TRI;
            (main.Controls["txtLoaiChiSo"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = cs.LOAI_MOI_TRUONG;
            (main.Controls["txtTenChiSo"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = cs.TEN_CHI_SO;
            (main.Controls["txtMaCS"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = cs.MA_CHI_SO;
            (main.Parent.Controls["btnLuuTS"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;
            (main.Parent.Controls["btnSuaTS"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;
            (main.Parent.Controls["btnSuaTS"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = true;
            main.Visible = true;
        }

        // tìm kiếm một chỉ số theo tên chỉ số hoặc mã chỉ số 
        // chức năng tìm kiếm một chỉ số môi trường
        // cắt bỏ những chuổi sau dấu ngoặc
        private String textCutting(String text)
        {
            String result = "";
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '(')
                    {
                        result = text.Substring(0, i);
                        break;
                    }
                }
            }
            return result;
        }
        // tạo dictionary
        public Dictionary<String, HashSet<String>> dataName()
        {
            Dictionary<String, HashSet<String>> data = new Dictionary<String, HashSet<String>>();
            using (var context = new CTQLMTContext())
            {
                var listCSMT = context.ChiSoMoiTruongs.ToList();
                foreach (ChiSoMoiTruong cs in listCSMT)
                {
                    if (textCutting(cs.TEN_CHI_SO) != null)
                    {
                        String[] nameArr = textCutting(cs.TEN_CHI_SO).Trim().ToLower().Split(' ');
                        for (int i = 0; i < nameArr.Length; i++)
                        {
                            if (data.ContainsKey(nameArr[i].Trim().ToLower()))
                            {
                                data[nameArr[i].Trim().ToLower()].Add(cs.MA_CHI_SO);
                            }
                            else
                            {
                                if (!string.IsNullOrWhiteSpace(nameArr[i].Trim().ToLower()))
                                {
                                    HashSet<String> set = new HashSet<String>();
                                    set.Add(cs.MA_CHI_SO);
                                    data.Add(nameArr[i].Trim().ToLower(), set);
                                }
                            }
                        }
                    }
                }
            }
            return data;
        }
        // tìm kiếm qua mã
        public bool checkTextIsEnviromentIndexID(String text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= 3) return false;
            List<String> sample = new List<String>() { "DAT", "NUOC", "KHONGKHI", "KHITHAI" };
            // check phai la chi so loai dat
            if (text.Length > 3)
            {
                if (int.TryParse(text.Substring(3), out int result1) && sample.Contains(text.Substring(0, 3)))
                {
                    return true;
                }
            }
            // check phai la chi so loai nuoc
            if (text.Length > 4)
            {
                if (int.TryParse(text.Substring(4), out int result2) && sample.Contains(text.Substring(0, 4)))
                {
                    return true;
                }
            }
            // check phai la chi so loai khong khi
            if (text.Length > 8)
            {
                if (int.TryParse(text.Substring(8), out int result3) && sample.Contains(text.Substring(0, 8)))
                {
                    return true;
                }
            }
            // check phai la chi so loai khi thai
            if (text.Length > 7)
            {
                if (int.TryParse(text.Substring(7), out int result4) && sample.Contains(text.Substring(0, 7)))
                {
                    return true;
                }
            }
            return false;
        }
        // tìm kiếm qua tên
        public List<ChiSoMoiTruong> searchByEnviromentIndexName(String text)
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
            List<ChiSoMoiTruong> result = new List<ChiSoMoiTruong>();
            if (saveResult.Count == 0) return result;
            if (saveResult.Count > 1)
            {
                for (int i = 1; i < saveResult.Count; i++)
                {
                    saveResult[0].IntersectWith(saveResult[i]);
                }
                foreach (String s in saveResult[0])
                {
                    result.Add(context.ChiSoMoiTruongs.Find(s));
                }
            }
            else
            {
                foreach (String s in saveResult[0])
                {
                    result.Add(context.ChiSoMoiTruongs.Find(s));
                }
            }
            return result;
        }
        // tìm kiếm cho quản lí
        public List<ChiSoMoiTruong> searchEnviromentIndex(String text)
        {
            List<ChiSoMoiTruong> result = new List<ChiSoMoiTruong>();
            if (string.IsNullOrWhiteSpace(text)) return result;
            // Phân tích chuỗi truyền vào là mã chỉ số
            if (checkTextIsEnviromentIndexID(text))
            {
                using (var context = new CTQLMTContext())
                {
                    result.Add(context.ChiSoMoiTruongs.Find(text));
                }
                return result;
            }
            // phân tích chuỗi truyền vào là tên nhân viên
            else
            {
                return searchByEnviromentIndexName(text.ToLower().Trim());
            }
        }

        // tìm kiếm cho nhân viên
        public List<ChiSoMoiTruong> searchEnviromentIndexForEmployee(String text)
        {
            List<ChiSoMoiTruong> result = new List<ChiSoMoiTruong>();
            List<ChiSoMoiTruong> temp = searchEnviromentIndex(text);
            foreach (ChiSoMoiTruong cs in temp)
            {
                if (cs.TRANG_THAI == true)
                {
                    result.Add(cs);
                }
            }
            return result;
        }

        // tạo data cho số thứ tự mã chỉ số
        public Dictionary<int, String> dataToSort()
        {
            Dictionary<int, String> dic = new Dictionary<int, string>();
            using (var context = new CTQLMTContext())
            {
                var listCSMT = context.ChiSoMoiTruongs.ToList();
                foreach (ChiSoMoiTruong cs in listCSMT)
                {
                    int stt = 0;
                    switch (cs.LOAI_MOI_TRUONG)
                    {
                        case "DAT": 
                            stt = int.Parse(cs.MA_CHI_SO.Substring(3));
                            break;
                        case "NUOC":
                            stt = int.Parse(cs.MA_CHI_SO.Substring(4));
                            break;
                        case "KHONGKHI":
                            stt = int.Parse(cs.MA_CHI_SO.Substring(8));
                            break;
                        case "KHITHAI":
                            stt = int.Parse(cs.MA_CHI_SO.Substring(7));
                            break;
                    }
                    dic.Add(stt, cs.MA_CHI_SO);
                }
            }
            return dic;
        }
        // sort chỉ số theo mã chỉ số
        public List<ChiSoMoiTruong> sortEnviromentIndex()
        {
            List<ChiSoMoiTruong> result = new List<ChiSoMoiTruong>();
            Dictionary<int, String> dic = dataToSort();
            using (var context = new CTQLMTContext())
            {
                for (int i = 1; i <= dic.Count(); i++)
                {
                    var chiso = context.ChiSoMoiTruongs.Find(dic[i]);
                    if (chiso != null)
                    {
                        result.Add(chiso);
                    }
                }
            }
            return result;
        }
    }
}
