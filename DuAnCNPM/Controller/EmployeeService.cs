using DuAnCNPM.Controlers;
using DuAnCNPM.Datas;
using DuAnCNPM.Views;
using Siticone.Desktop.UI.AnimatorNS;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnCNPM.Controller
{
    class EmployeeService
    {
        public EmployeeService() { }

        public void ShowEmployeeInformation(String ID, Siticone.Desktop.UI.WinForms.SiticonePanel pan)
        {
            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(ID);
                if (nhanvien != null)
                {
                    // hien thi thong tin nhan vien
                    (pan.Controls["grbMa"].Controls["txtManv"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nhanvien.MA_NHAN_VIEN;
                    (pan.Controls["grbName"].Controls["txtNamenv"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nhanvien.HO_TEN;
                    (pan.Controls["grbNgaysinh"].Controls["txtNgaysinhnv"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nhanvien.NGAY_SINH.ToString();
                    (pan.Controls["grbSdt"].Controls["txtSdtnv"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nhanvien.SO_DIEN_THOAI;
                    (pan.Controls["grbEmail"].Controls["txtEmailnv"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nhanvien.GMAIL;
                    (pan.Controls["grbSex"].Controls["cboSexnv"] as Siticone.Desktop.UI.WinForms.SiticoneComboBox).Text = nhanvien.GIOI_TINH;
                    (pan.Controls["grbChucvu"].Controls["txtChucvu"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nhanvien.CHUC_VU;
                    (pan.Controls["grbNoioCurrent"].Controls["txtNoioCurrent"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nhanvien.DIA_CHI;
                }
            }
        }

        //them ds nhan vien tim kiem
        public void ShowEmployeeSearch(List<NhanVien> nhanViens, DuAnCNPM.Views.DoubleBufferedPanel container)
        {
            container.Controls.Clear();

            int yOffset = 15;
                foreach (var nv in nhanViens)
                {
                if (nv.TRANG_THAI == true)
                {
                    Console.WriteLine(nv.MA_NHAN_VIEN);
                    Siticone.Desktop.UI.WinForms.SiticoneGroupBox grbTimthay = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                    grbTimthay.BorderColor = System.Drawing.Color.Transparent;
                    grbTimthay.BorderRadius = 15;
                    grbTimthay.CustomBorderColor = System.Drawing.Color.Transparent;
                    grbTimthay.FillColor = System.Drawing.Color.Transparent;
                    grbTimthay.Font = new System.Drawing.Font("Segoe UI", 9F);
                    grbTimthay.ForeColor = System.Drawing.Color.Transparent;
                    grbTimthay.Location = new System.Drawing.Point(13, yOffset);
                    grbTimthay.Name = "grbTimthay";
                    grbTimthay.Size = new System.Drawing.Size(935, 36);
                    grbTimthay.TabIndex = 111;

                    SiticoneHtmlLabel txtEmail = new SiticoneHtmlLabel();
                    txtEmail.AutoSize = false;
                    txtEmail.BackColor = System.Drawing.Color.Transparent;
                    txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    txtEmail.ForeColor = System.Drawing.Color.Black;
                    txtEmail.Location = new System.Drawing.Point(695, 0);
                    txtEmail.Name = "txtEmail";
                    txtEmail.Size = new System.Drawing.Size(236, 36);
                    txtEmail.TabIndex = 110;
                    txtEmail.Text = nv.GMAIL;
                    txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

                    SiticoneHtmlLabel txtSDT = new SiticoneHtmlLabel();
                    txtSDT.AutoSize = false;
                    txtSDT.BackColor = System.Drawing.Color.Transparent;
                    txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    txtSDT.ForeColor = System.Drawing.Color.Black;
                    txtSDT.Location = new System.Drawing.Point(540, 0);
                    txtSDT.Name = "txtSDT";
                    txtSDT.Size = new System.Drawing.Size(150, 36);
                    txtSDT.TabIndex = 109;
                    txtSDT.Text = nv.SO_DIEN_THOAI;
                    txtSDT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

                    SiticoneHtmlLabel lblPhongbanFind = new SiticoneHtmlLabel();
                    lblPhongbanFind.AutoSize = false;
                    lblPhongbanFind.BackColor = System.Drawing.Color.Transparent;
                    lblPhongbanFind.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    lblPhongbanFind.ForeColor = System.Drawing.Color.Black;
                    lblPhongbanFind.Location = new System.Drawing.Point(395, 0);
                    lblPhongbanFind.Name = "lblPhongbanFind";
                    lblPhongbanFind.Size = new System.Drawing.Size(140, 36);
                    lblPhongbanFind.TabIndex = 108;
                    lblPhongbanFind.Text = nv.CHUC_VU;
                    lblPhongbanFind.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

                    SiticoneHtmlLabel txtTenNV = new SiticoneHtmlLabel();
                    txtTenNV.AutoSize = false;
                    txtTenNV.BackColor = System.Drawing.Color.Transparent;
                    txtTenNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    txtTenNV.ForeColor = System.Drawing.Color.Black;
                    txtTenNV.Location = new System.Drawing.Point(150, 0);
                    txtTenNV.Name = "txtTenNV";
                    txtTenNV.Size = new System.Drawing.Size(240, 36);
                    txtTenNV.TabIndex = 107;
                    txtTenNV.Text = nv.HO_TEN;
                    txtTenNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

                    SiticoneHtmlLabel lblManhanvien = new SiticoneHtmlLabel();
                    lblManhanvien.AutoSize = false;
                    lblManhanvien.BackColor = System.Drawing.Color.Transparent;
                    lblManhanvien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    lblManhanvien.ForeColor = System.Drawing.Color.Black;
                    lblManhanvien.Location = new System.Drawing.Point(13, 0);
                    lblManhanvien.Name = "lblManhanvien";
                    lblManhanvien.Size = new System.Drawing.Size(132, 36);
                    lblManhanvien.TabIndex = 106;
                    lblManhanvien.Text = nv.MA_NHAN_VIEN;
                    lblManhanvien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

                    grbTimthay.Controls.Add(txtEmail);
                    grbTimthay.Controls.Add(txtSDT);
                    grbTimthay.Controls.Add(lblPhongbanFind);
                    grbTimthay.Controls.Add(txtTenNV);
                    grbTimthay.Controls.Add(lblManhanvien);
                    container.Controls.Add(grbTimthay);

                    yOffset += grbTimthay.Height + 10;
                }
                }
        }

        //them moi dsach hop dong tu database: container = panDSNV, chitiet=panDSNVchitiet
        public void ShowEmployeeAdmin(Panel container, Panel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
            using (var context = new CTQLMTContext())
            {
                //var nhanVien = context.NhanViens.ToList();
                var nhanVien = sortEmployee();
                foreach (var nv in nhanVien)
                {
                    var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                    if (nv.TRANG_THAI == false)
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
                    lblNgayHetHan.DefaultText = "Chức vụ: " + nv.CHUC_VU;
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
                    lblTieuDe.DefaultText = nv.MA_NHAN_VIEN+" - "+nv.HO_TEN;
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

                    panel.Click += (s, e) => ShowEmployeeDetail(nv, chitiet);
                    lblTieuDe.Click += (s, e) => ShowEmployeeDetail(nv, chitiet);
                    lblNgayHetHan.Click += (s, e) => ShowEmployeeDetail(nv, chitiet);

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

        public void ShowEmployeeAdminSearch(List<NhanVien> nhanViens, Panel container, Panel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
                ////var nhanVien = context.NhanViens.ToList();
                //var nhanVien = sortEmployee();
                foreach (var nv in nhanViens)
                {
                    var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                    if (nv.TRANG_THAI == false)
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
                    lblNgayHetHan.DefaultText = "Chức vụ: " + nv.CHUC_VU;
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
                    lblTieuDe.DefaultText = nv.MA_NHAN_VIEN + " - " + nv.HO_TEN;
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

                    panel.Click += (s, e) => ShowEmployeeDetail(nv, chitiet);
                    lblTieuDe.Click += (s, e) => ShowEmployeeDetail(nv, chitiet);
                    lblNgayHetHan.Click += (s, e) => ShowEmployeeDetail(nv, chitiet);

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

        private void ShowEmployeeDetail(NhanVien nv, Panel main)
        {
            (main.Controls["txtMachiso"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nv.MA_NHAN_VIEN;
            (main.Controls["txtChiso"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nv.HO_TEN;
            (main.Controls["txtChucvuTTNV"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nv.CHUC_VU;
            (main.Controls["dtpNgaycap"] as Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker).Value = DateTime.Parse(nv.NGAY_SINH.ToString());
            (main.Controls["cboSexTTNV"] as Siticone.Desktop.UI.WinForms.SiticoneComboBox).Text = nv.GIOI_TINH;
            (main.Controls["txtSDTTTNV"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nv.SO_DIEN_THOAI;
            (main.Controls["txtGmail"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nv.GMAIL;
            (main.Controls["checkTruongPhong"] as Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox).Checked = nv.TRUONG_PHONG;
            (main.Controls["txtDiachi"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = nv.DIA_CHI;
            //((((main.Parent.Parent) as System.Windows.Forms.SplitContainer)
            //    .Panel1).Controls["btnBackNV"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Visible = true;
            //((((main.Parent.Parent) as System.Windows.Forms.SplitContainer)
            //    .Panel1).Controls["btnSuaDSNV"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = true;
            main.Visible=true;
        }

        private String generateID(String ChucVu)
        {
            // Ma nhan vien bao gom ten phong ban va so thu tu
            // phong ke hoach: PKH, phong kinh doanh: PKD, phong quan trac: PQT, phong thi nghiem: PTN, phong ket qua: PKQ
            // vd: nhan vien 01 thuoc phong ke hoach: NVPKH0001
            //admin co ma nhan vien la "admin" + so thu tu
            int count = 0;
            using (var context = new CTQLMTContext())
            {
                if (context.NhanViens.Count()== 0)
                {
                    count = 1;
                }
                else
                {
                    int[] stt = new int[context.NhanViens.Count()];
                    List<NhanVien> listNV = context.NhanViens.ToList();
                    int i = 0;
                    foreach (NhanVien nv in listNV)
                    {
                        stt[i] = int.Parse(nv.MA_NHAN_VIEN.Substring(5));
                        i++;
                    }
                    count = stt.Max() + 1;
                }
                    
            }
            String result = "";
            if (ChucVu == "ADMIN")
            {
                result = ChucVu + count.ToString();
            }
            else
            {
                result = "NV" + ChucVu + count.ToString();
            }
                return result;
        }

        // tao them mot nhan vien moi

        public Boolean AddEmployee(String HoTen, String ChucVu,
                               DateTime NgaySinh, String MatKhau, String GioiTinh,
                               String SDT, String Gmail, Boolean TruongPhong, String DiaChi)
        {
            using (var context = new CTQLMTContext())
            {
                var nhanvien = new NhanVien
                {
                    MA_NHAN_VIEN = generateID(ChucVu),
                    HO_TEN = HoTen,
                    CHUC_VU = ChucVu,
                    NGAY_SINH = NgaySinh,
                    MAT_KHAU = BCrypt.Net.BCrypt.HashPassword(MatKhau),
                    GIOI_TINH = GioiTinh,
                    SO_DIEN_THOAI = SDT,
                    GMAIL = Gmail,
                    TRANG_THAI = true,
                    TRUONG_PHONG = TruongPhong,
                    THOI_GIAN = DateTime.Today,
                    DIA_CHI = DiaChi
                };
                context.NhanViens.Add(nhanvien);
                context.SaveChanges();
                return true;
            }
        }

        // xoa mot nhan vien
        public Boolean deleteEmployee(String MaNhanVien)
        {
            using (var context = new CTQLMTContext())
            {
                // Kiem tra nhan vien can xoa co ton tai
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;

                // xoa nhan vien
                nhanvien.TRANG_THAI = false;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua ho ten
        public Boolean editEmployeeName(String MaNhanVien, String newName)
        {
            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;
                nhanvien.HO_TEN = newName;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua gioi tinh
        public Boolean editEmployeeGender(String MaNhanVien, String gender)
        {
            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;
                nhanvien.GIOI_TINH = gender;
                context.SaveChanges();
            }
            return true;
        }

        //chinh sua chuc vu
        public Boolean editEmployeePosition(String MaNhanVien, String newPosition)
        {
            Validating validate = new Validating();
            if (!validate.position().Contains(newPosition)) return false;

            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;
                if (nhanvien.CHUC_VU == "ADMIN") return false;
                nhanvien.CHUC_VU = newPosition;
                context.SaveChanges();
            }
            return true;
        }
        // chinh sửa trưởng phòng 
        public Boolean editHeadOfRoom(String MaNhanVien, Boolean isTruongPhong)
        {
            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;
                nhanvien.TRUONG_PHONG = isTruongPhong;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua ngay sinh
        public Boolean editDateOfBirth(String MaNhanVien, DateTime newDate)
        {
            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;
                nhanvien.NGAY_SINH = newDate;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua dia chi 
        public Boolean editAddress(String MaNhanVien, String DiaChi)
        {
            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;
                nhanvien.DIA_CHI = DiaChi;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua so dien thoai
        public Boolean editPhoneNumber(String MaNhanVien, String newSDT)
        {
            // kiem tra so dien thoai hop le ?
            Validating numberValid = new Validating();
            if (!numberValid.validatePhoneNumber(newSDT)) return false;

            // tim kiem nhan vien de doi
            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;
                nhanvien.SO_DIEN_THOAI = newSDT;
                context.SaveChanges();
            }
            return true;
        }

        // chinh sua gmail
        public Boolean editGmail(String MaNhanVien, String newGmail)
        {
            // kiem tra gmail co dung dinh dang 
            Validating gmailValid = new Validating();
            if (!gmailValid.validateGmail(newGmail)) return false;

            using (var context = new CTQLMTContext())
            {
                var nhanvien = context.NhanViens.Find(MaNhanVien);
                if (nhanvien == null) return false;
                nhanvien.GMAIL = newGmail;
                context.SaveChanges();
            }
            return true;
        }

        // search 
        //data search name
        private Dictionary<String, HashSet<String>> dataName()
        {
            Dictionary<String, HashSet<String>> data = new Dictionary<String, HashSet<String>>();
            using (var context = new CTQLMTContext())
            {
                var listNV = context.NhanViens.ToList();
                foreach (NhanVien nv in listNV)
                {
                    String[] nameArr = nv.HO_TEN.ToLower().Trim().Split(' ');
                    for (int i = 0; i < nameArr.Length; i++)
                    {
                        if (data.ContainsKey(nameArr[i]))
                        {
                            data[nameArr[i]].Add(nv.MA_NHAN_VIEN);
                        }
                        else
                        {
                            HashSet<String> set = new HashSet<string>();
                            set.Add(nv.MA_NHAN_VIEN);
                            data.Add(nameArr[i], set);
                        }
                    }
                }
            }
            return data;
        }
        //tim theo ten nhan vien 
        private List<NhanVien> searchByEmployeeName(String text)
        {
            var context = new CTQLMTContext();
            String[] textEle = text.Trim().ToLower().Split(' ');
            Dictionary<String, HashSet<String>> data = dataName();
            List<HashSet<String>> saveResult = new List<HashSet<String>>();
            for (int i = 0; i < textEle.Length; i++)
            {
                if (data.ContainsKey(textEle[i]))
                {
                    saveResult.Add(data[textEle[i]]);
                }
            }
            List<NhanVien> result = new List<NhanVien>();
            if (saveResult.Count() == 0) return result;
            if (saveResult.Count() > 1)
            {
                for (int i = 1; i < saveResult.Count; i++)
                {
                    saveResult[0].IntersectWith(saveResult[i]);
                }
                foreach (String s in saveResult[0])
                {
                    result.Add(context.NhanViens.Find(s));
                }
            }
            else
            {
                foreach (String s in saveResult[0])
                {
                    result.Add(context.NhanViens.Find(s));
                }
            }

            return result;
        }

        // kiem tra ma nhan vien
        private bool checkTextIsEmployeeID(String text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= 5) return false;
            List<String> sample = new List<String>() { "NVPTN", "NVPKH", "NVPKD", "NVPQT", "NVPKQ", "ADMIN" };
            String first = text.Substring(5);      // lấy stt
            String final = text.Substring(0, 5);   // lấy 5 kí tự đầu
            bool checkFinal = sample.Contains(final);
            bool checkFirst = int.TryParse(first, out int result);
            if (checkFinal && checkFirst) return true;
            return false;
        }

        //tìm kiếm nhân viên dành cho admin
        public List<NhanVien> searchEmployee(String text)
        {
            List<NhanVien> result = new List<NhanVien>();
            if (string.IsNullOrWhiteSpace(text)) return result;
            // Phân tích chuỗi truyền vào laà mã nhân viên
            if (checkTextIsEmployeeID(text.Trim()))
            {
                using (var context = new CTQLMTContext())
                {
                    NhanVien nv = context.NhanViens.Find(text.Trim());
                    if (nv != null)
                    {
                        result.Add(nv);
                    }
                }
                return result;
            }
            // phân tích chuỗi truyền vào là tên nhân viên
            else
            {
                return searchByEmployeeName(text.ToLower());
            }
        }

        // chức năng tìm kiếm nhân viên cho nhân viên trong công ty
        public List<NhanVien> searchEmployeeForEmployee(String text)
        {
            List<NhanVien> temp = searchEmployee(text);
            List<NhanVien> result = new List<NhanVien>();
            foreach (NhanVien nv in temp)
            {
                if (nv.TRANG_THAI == true)
                {
                    result.Add(nv);
                }
            }
            return result;
        }



        // sort
        // tạo data cho số thứ tự mã nhân viên
        public Dictionary<int, String> dataToSort()
        {
            Dictionary<int, String> dic = new Dictionary<int, string>();
            using (var context = new CTQLMTContext())
            {
                var listNV = context.NhanViens.ToList();
                foreach (NhanVien nv in listNV)
                {
                    int stt = int.Parse(nv.MA_NHAN_VIEN.Substring(5));
                    dic.Add(stt, nv.MA_NHAN_VIEN);
                }
            }
            return dic;
        }
        // sort nhân viên 
        public List<NhanVien> sortEmployee()
        {
            List<NhanVien> result = new List<NhanVien>();
            Dictionary<int, String> dic = dataToSort();
            using(var context = new CTQLMTContext())
            {
                for (int i = 1; i <= dic.Count(); i++)
                {
                    var nhanvien = context.NhanViens.Find(dic[i]);
                    if (nhanvien != null)
                    {
                        result.Add(nhanvien);
                    }
                }
            }
            return result;
        }
    }
}
