﻿using DuAnCNPM.Controlers;
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
    class AnnouncementService
    {
        public AnnouncementService() { }


        public void ShowAnnouncement(DuAnCNPM.Views.DoubleBufferedPanel container, Panel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
            using (var context = new CTQLMTContext())
            {
                var thongBao = context.ThongBaos.ToList();
                foreach (var tb in thongBao)
                {
                    var grbox = new SiticoneGroupBox();
                    var txtNgayHetHan = new SiticoneTextBox();
                    var txtTieuDe = new SiticoneTextBox();
                    container.Controls.Add(grbox);
                    grbox.Controls.Add(txtNgayHetHan);
                    grbox.Controls.Add(txtTieuDe);
                    grbox.BorderColor = System.Drawing.Color.Green;
                    grbox.BorderRadius = 18;
                    grbox.BorderThickness = 2;
                    grbox.CustomBorderColor = System.Drawing.Color.AliceBlue;
                    grbox.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                    grbox.FillColor = System.Drawing.Color.White;
                    grbox.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                    grbox.ForeColor = System.Drawing.Color.Black;
                    grbox.Location = new System.Drawing.Point(5, yOffset);
                    grbox.Name = tb.MA_THONG_BAO;
                    grbox.Visible = true;
                    grbox.Size = new System.Drawing.Size(container.Width - 20, 53);
                    grbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    int width = grbox.Width - 20;
                    txtNgayHetHan.BackColor = System.Drawing.Color.White;
                    txtNgayHetHan.BorderColor = System.Drawing.Color.White;
                    txtNgayHetHan.BorderThickness = 0;
                    txtNgayHetHan.DefaultText = tb.TIEU_DE;
                    txtNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    txtNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    txtNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    txtNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    txtNgayHetHan.FillColor = System.Drawing.Color.White;
                    txtNgayHetHan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                    txtNgayHetHan.ForeColor = System.Drawing.Color.Black;
                    txtNgayHetHan.Location = new System.Drawing.Point(11, 28);
                    txtNgayHetHan.Name = "txtNgayhethan-";
                    txtNgayHetHan.ReadOnly = true;
                    txtNgayHetHan.Cursor = default;
                    txtNgayHetHan.Visible = true;
                    txtNgayHetHan.Size = new System.Drawing.Size(width, 18);
                    txtNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    txtTieuDe.BackColor = System.Drawing.Color.White;
                    txtTieuDe.BorderColor = System.Drawing.Color.White;
                    txtTieuDe.BorderThickness = 0;
                    txtTieuDe.DefaultText = tb.MA_THONG_BAO;
                    txtTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    txtTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    txtTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    txtTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    txtTieuDe.FillColor = System.Drawing.Color.White;
                    txtTieuDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    txtTieuDe.ForeColor = System.Drawing.Color.Black;
                    txtTieuDe.Location = new System.Drawing.Point(11, 6);
                    txtTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    txtTieuDe.Name = tb.MA_THONG_BAO;
                    txtTieuDe.ReadOnly = true;
                    txtTieuDe.Cursor = default;
                    txtTieuDe.Visible = true;
                    txtTieuDe.Size = new System.Drawing.Size(width, 18);
                    txtTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    yOffset += grbox.Height + 5;

                    grbox.Click += (s, e) => ShowAnnouncementDetailEm(tb, chitiet);
                    txtTieuDe.Click += (s, e) => ShowAnnouncementDetailEm(tb, chitiet);
                    txtNgayHetHan.Click += (s, e) => ShowAnnouncementDetailEm(tb, chitiet);

                    bool isSelected = false;

                    grbox.MouseDown += (s, e) =>
                    {
                        isSelected = true;

                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.Red;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;

                    };

                    txtTieuDe.MouseDown += (s, e) =>
                    {
                        isSelected = true;

                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.Red;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                    };

                    txtNgayHetHan.MouseDown += (s, e) =>
                    {
                        isSelected = true;

                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.Red;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                    };

                    //grbox.MouseUp += (s, e) =>
                    //{
                    //    if (!grbox.Bounds.Contains(e.Location) &&
                    //        !txtTieuDe.Bounds.Contains(e.Location) &&
                    //        !txtNgayHetHan.Bounds.Contains(e.Location))
                    //    {
                    //        isSelected = false;
                    //    }
                    //};

                    //txtTieuDe.MouseUp += (s, e) =>
                    //{
                    //    if (!grbox.Bounds.Contains(e.Location) &&
                    //        !txtTieuDe.Bounds.Contains(e.Location) &&
                    //        !txtNgayHetHan.Bounds.Contains(e.Location))
                    //    {
                    //        isSelected = false;
                    //    }
                    //};

                    //txtNgayHetHan.MouseUp += (s, e) =>
                    //{
                    //    if (!grbox.Bounds.Contains(e.Location) &&
                    //        !txtTieuDe.Bounds.Contains(e.Location) &&
                    //        !txtNgayHetHan.Bounds.Contains(e.Location))
                    //    {
                    //        isSelected = false;
                    //    }
                    //};

                    grbox.MouseEnter += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.DeepSkyBlue;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                    };

                    txtTieuDe.MouseEnter += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.DeepSkyBlue;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                    };

                    txtNgayHetHan.MouseEnter += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.DeepSkyBlue;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                    };

                    grbox.MouseLeave += (s, e) =>
                    {
                        grbox.BorderColor = Color.Green;
                        grbox.FillColor = Color.White;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                        
                    };

                    txtTieuDe.MouseLeave += (s, e) =>
                    {
                        grbox.BorderColor = Color.Green;
                        grbox.FillColor = Color.White;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;

                    };

                    txtNgayHetHan.MouseLeave += (s, e) =>
                    {
                        
                        grbox.BorderColor = Color.Green;
                        grbox.FillColor = Color.White;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;

                    };
                }
            }
        }

        public void ShowAnnouncementSearch(List<ThongBao> thongBao,DuAnCNPM.Views.DoubleBufferedPanel container, Panel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
                foreach (var tb in thongBao)
                {
                    var grbox = new SiticoneGroupBox();
                    var txtNgayHetHan = new SiticoneTextBox();
                    var txtTieuDe = new SiticoneTextBox();
                    container.Controls.Add(grbox);
                    grbox.Controls.Add(txtNgayHetHan);
                    grbox.Controls.Add(txtTieuDe);
                    grbox.BorderColor = System.Drawing.Color.Green;
                    grbox.BorderRadius = 18;
                    grbox.BorderThickness = 2;
                    grbox.CustomBorderColor = System.Drawing.Color.AliceBlue;
                    grbox.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                    grbox.FillColor = System.Drawing.Color.White;
                    grbox.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                    grbox.ForeColor = System.Drawing.Color.Black;
                    grbox.Location = new System.Drawing.Point(5, yOffset);
                    grbox.Name = tb.MA_THONG_BAO;
                    grbox.Visible = true;
                    grbox.Size = new System.Drawing.Size(container.Width - 20, 53);
                    grbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    int width = grbox.Width - 20;
                    txtNgayHetHan.BackColor = System.Drawing.Color.White;
                    txtNgayHetHan.BorderColor = System.Drawing.Color.White;
                    txtNgayHetHan.BorderThickness = 0;
                    txtNgayHetHan.DefaultText = tb.TIEU_DE;
                    txtNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    txtNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    txtNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    txtNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    txtNgayHetHan.FillColor = System.Drawing.Color.White;
                    txtNgayHetHan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                    txtNgayHetHan.ForeColor = System.Drawing.Color.Black;
                    txtNgayHetHan.Location = new System.Drawing.Point(11, 28);
                    txtNgayHetHan.Name = "txtNgayhethan-";
                    txtNgayHetHan.ReadOnly = true;
                    txtNgayHetHan.Cursor = default;
                    txtNgayHetHan.Visible = true;
                    txtNgayHetHan.Size = new System.Drawing.Size(width, 18);
                    txtNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    txtTieuDe.BackColor = System.Drawing.Color.White;
                    txtTieuDe.BorderColor = System.Drawing.Color.White;
                    txtTieuDe.BorderThickness = 0;
                    txtTieuDe.DefaultText = tb.MA_THONG_BAO;
                    txtTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    txtTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    txtTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    txtTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    txtTieuDe.FillColor = System.Drawing.Color.White;
                    txtTieuDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    txtTieuDe.ForeColor = System.Drawing.Color.Black;
                    txtTieuDe.Location = new System.Drawing.Point(11, 6);
                    txtTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    txtTieuDe.Name = tb.MA_THONG_BAO;
                    txtTieuDe.ReadOnly = true;
                    txtTieuDe.Cursor = default;
                    txtTieuDe.Visible = true;
                    txtTieuDe.Size = new System.Drawing.Size(width, 18);
                    txtTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    yOffset += grbox.Height + 5;

                    grbox.Click += (s, e) => ShowAnnouncementDetailEm(tb, chitiet);
                    txtTieuDe.Click += (s, e) => ShowAnnouncementDetailEm(tb, chitiet);
                    txtNgayHetHan.Click += (s, e) => ShowAnnouncementDetailEm(tb, chitiet);

                    grbox.MouseEnter += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.DeepSkyBlue;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                    };

                    txtTieuDe.MouseEnter += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.DeepSkyBlue;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                    };

                    txtNgayHetHan.MouseEnter += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.DeepSkyBlue;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;
                    };

                    grbox.MouseLeave += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.Green;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;

                    };

                    txtTieuDe.MouseLeave += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.Green;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;

                    };

                    txtNgayHetHan.MouseLeave += (s, e) =>
                    {
                        grbox.FillColor = Color.White;
                        grbox.BorderColor = Color.Green;

                        txtTieuDe.FillColor = Color.White;
                        txtNgayHetHan.FillColor = Color.White;

                    };
            }
        }

        private void ShowAnnouncementDetailEm(ThongBao tb, Panel main)
        {
            (main.Controls["lblDateTB"] as SiticoneHtmlLabel).Text = tb.NGAY_PHAT_HANH.ToString();
            (main.Controls["lblTitleTB"] as SiticoneHtmlLabel).Text = tb.TIEU_DE;
            (main.Controls["ricNDungTB"] as RichTextBox).Text = tb.NOI_DUNG;
            main.Visible = true;
        }

        //them moi dsach hop dong tu database: container = panDSNV, chitiet=panDSNVchitiet
        public void ShowAnnouncementAdmin(DuAnCNPM.Views.DoubleBufferedPanel container, Panel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
            using (var context = new CTQLMTContext())
            {
                var thongBao = context.ThongBaos.ToList();
                //var nhanVien = sortEmployee();
                foreach (var tb in thongBao)
                {
                    var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                    panel.BorderColor = System.Drawing.Color.Green;
                    panel.BorderRadius = 18;
                    panel.BorderThickness = 2;
                    panel.CustomBorderColor = System.Drawing.Color.Green;
                    panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                    panel.FillColor = System.Drawing.Color.White;
                    panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                    panel.ForeColor = System.Drawing.Color.Black;
                    panel.Location = new System.Drawing.Point(5, yOffset);
                    panel.Name = "grbHDnv1";
                    panel.Size = new System.Drawing.Size(container.Width - 20, 53);
                    panel.TabIndex = 11;
                    panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    int width = panel.Width - 20;
                    var lblNgayHetHan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                    lblNgayHetHan.BackColor = System.Drawing.Color.White;
                    lblNgayHetHan.BorderColor = System.Drawing.Color.White;
                    lblNgayHetHan.BorderThickness = 0;
                    lblNgayHetHan.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblNgayHetHan.DefaultText = tb.TIEU_DE;
                    lblNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    lblNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    lblNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblNgayHetHan.FillColor = System.Drawing.Color.White;
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
                    lblTieuDe.BackColor = System.Drawing.Color.White;
                    lblTieuDe.BorderColor = System.Drawing.Color.White;
                    lblTieuDe.BorderThickness = 0;
                    lblTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
                    lblTieuDe.DefaultText = tb.MA_THONG_BAO;
                    lblTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                    lblTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                    lblTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                    lblTieuDe.FillColor = System.Drawing.Color.White;
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

                    panel.Click += (s, e) => ShowAnnouncementDetail(tb, chitiet);
                    lblTieuDe.Click += (s, e) => ShowAnnouncementDetail(tb, chitiet);
                    lblNgayHetHan.Click += (s, e) => ShowAnnouncementDetail(tb, chitiet);

                    lblTieuDe.MouseEnter += (s, e) =>
                    {
                        panel.FillColor = Color.White;
                        panel.BorderColor = System.Drawing.Color.DeepSkyBlue;

                        lblTieuDe.FillColor = Color.White;
                        lblNgayHetHan.FillColor = Color.White;
                    };

                    lblNgayHetHan.MouseEnter += (s, e) =>
                    {
                        panel.FillColor = Color.White;
                        panel.BorderColor = System.Drawing.Color.DeepSkyBlue;
                        lblTieuDe.FillColor = Color.White;
                        lblNgayHetHan.FillColor = Color.White;
                    };

                    panel.MouseEnter += (s, e) =>
                    {
                        panel.FillColor = Color.White;
                        panel.BorderColor = System.Drawing.Color.DeepSkyBlue;
                        lblTieuDe.FillColor = Color.White;
                        lblNgayHetHan.FillColor = Color.White;
                    };

                    panel.MouseLeave += (s, e) =>
                    {
                        panel.FillColor = Color.White;
                        panel.BorderColor = System.Drawing.Color.Green;

                        lblTieuDe.FillColor = Color.White;
                        lblNgayHetHan.FillColor = Color.White;

                    };

                    lblTieuDe.MouseLeave += (s, e) =>
                    {
                        panel.FillColor = Color.White;
                        panel.BorderColor = System.Drawing.Color.Green;

                        lblTieuDe.FillColor = Color.White;
                        lblNgayHetHan.FillColor = Color.White;
                    };

                    lblNgayHetHan.MouseLeave += (s, e) =>
                    {
                        panel.FillColor = Color.White;
                        panel.BorderColor = System.Drawing.Color.Green;

                        lblTieuDe.FillColor = Color.White;
                        lblNgayHetHan.FillColor = Color.White;
                    };



                    yOffset += panel.Height + 10;
                }
            }
        }

        public void ShowAnnouncementAdminSearch(List<ThongBao> thongBaos, Panel container, Panel chitiet)
        {
            container.Controls.Clear();

            int yOffset = 5;
            ////var nhanVien = context.NhanViens.ToList();
            //var nhanVien = sortEmployee();
            foreach (var tb in thongBaos)
            {
                var panel = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
                panel.BorderColor = System.Drawing.Color.Green;
                panel.BorderRadius = 18;
                panel.BorderThickness = 2;
                panel.CustomBorderColor = System.Drawing.Color.Green;
                panel.CustomBorderThickness = new System.Windows.Forms.Padding(0);
                panel.FillColor = System.Drawing.Color.White;
                panel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
                panel.ForeColor = System.Drawing.Color.Black;
                panel.Location = new System.Drawing.Point(5, yOffset);
                panel.Name = "grbHDnv1";
                panel.Size = new System.Drawing.Size(container.Width - 20, 53);
                panel.TabIndex = 11;
                panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                int width = panel.Width - 20;
                var lblNgayHetHan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
                lblNgayHetHan.BackColor = System.Drawing.Color.White;
                lblNgayHetHan.BorderColor = System.Drawing.Color.White;
                lblNgayHetHan.BorderThickness = 0;
                lblNgayHetHan.Cursor = System.Windows.Forms.Cursors.IBeam;
                lblNgayHetHan.DefaultText = tb.TIEU_DE;
                lblNgayHetHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                lblNgayHetHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                lblNgayHetHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                lblNgayHetHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                lblNgayHetHan.FillColor = System.Drawing.Color.White;
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
                lblTieuDe.BackColor = System.Drawing.Color.White;
                lblTieuDe.BorderColor = System.Drawing.Color.White;
                lblTieuDe.BorderThickness = 0;
                lblTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
                lblTieuDe.DefaultText = tb.MA_THONG_BAO;
                lblTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
                lblTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                lblTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                lblTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
                lblTieuDe.FillColor = System.Drawing.Color.White;
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

                panel.Click += (s, e) => ShowAnnouncementDetail(tb, chitiet);
                lblTieuDe.Click += (s, e) => ShowAnnouncementDetail(tb, chitiet);
                lblNgayHetHan.Click += (s, e) => ShowAnnouncementDetail(tb, chitiet);


                lblTieuDe.MouseEnter += (s, e) =>
                {
                    panel.FillColor = Color.White;
                    panel.BorderColor = System.Drawing.Color.DeepSkyBlue;

                    lblTieuDe.FillColor = Color.White;
                    lblNgayHetHan.FillColor = Color.White;
                };

                lblNgayHetHan.MouseEnter += (s, e) =>
                {
                    panel.FillColor = Color.White;
                    panel.BorderColor = System.Drawing.Color.DeepSkyBlue;

                    lblTieuDe.FillColor = Color.White;
                    lblNgayHetHan.FillColor = Color.White;
                };

                panel.MouseEnter += (s, e) =>
                {
                    panel.FillColor = Color.White;
                    panel.BorderColor = System.Drawing.Color.DeepSkyBlue;

                    lblTieuDe.FillColor = Color.White;
                    lblNgayHetHan.FillColor = Color.White;
                };

                panel.MouseLeave += (s, e) =>
                {
                    panel.FillColor = Color.White;
                    panel.BorderColor = System.Drawing.Color.Green;

                    lblTieuDe.FillColor = Color.White;
                    lblNgayHetHan.FillColor = Color.White;

                };

                lblTieuDe.MouseLeave += (s, e) =>
                {
                    panel.FillColor = Color.White;
                    panel.BorderColor = System.Drawing.Color.Green;

                    lblTieuDe.FillColor = Color.White;
                    lblNgayHetHan.FillColor = Color.White;
                };

                lblNgayHetHan.MouseLeave += (s, e) =>
                {
                    panel.FillColor = Color.White;
                    panel.BorderColor = System.Drawing.Color.Green;

                    lblTieuDe.FillColor = Color.White;
                    lblNgayHetHan.FillColor = Color.White;
                };

                yOffset += panel.Height + 10;
            }
        }

        private void ShowAnnouncementDetail(ThongBao tb, Panel main)
        {
            (main.Controls["txtTieuDe"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = tb.TIEU_DE;
            (main.Controls["txtNoidung"] as System.Windows.Forms.RichTextBox).Text = tb.NOI_DUNG;
            (main.Controls["txtMaThongBao"] as Siticone.Desktop.UI.WinForms.SiticoneTextBox).Text = tb.MA_THONG_BAO;
            (main.Controls["dtpNgayphathanh"] as Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker).Value = DateTime.Parse(tb.NGAY_PHAT_HANH.ToString());
            //((((main.Parent.Parent) as System.Windows.Forms.SplitContainer)
            //    .Panel1).Controls["btnBackNV"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Visible = true;
            ((main.Parent).Controls["btnSuaTB"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = true;
            ((main.Parent).Controls["btnLuuTB"] as Siticone.Desktop.UI.WinForms.SiticoneButton).Enabled = false;

            main.Visible = true;
        }
    }

}
