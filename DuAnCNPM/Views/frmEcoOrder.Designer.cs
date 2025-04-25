using Siticone.Desktop.UI.WinForms;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;
using DuAnCNPM.Views;

namespace DuAnCNPM
{
    partial class frmEcoOrder
    {
        private System.ComponentModel.IContainer components = null;
            
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEcoOrder));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.erpLoidinhdang = new System.Windows.Forms.ErrorProvider(this.components);
            this.panHome = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panSignIn = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblHello = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.picEye = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lblForget = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtPass = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnSignIn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panVeUs = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picAboutUs = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.picVechungtoi = new System.Windows.Forms.PictureBox();
            this.picHuongdan = new System.Windows.Forms.PictureBox();
            this.lblVechungtoi = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblHuongdan = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblNote = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnFlag = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.picCancelEco = new System.Windows.Forms.PictureBox();
            this.picMinisize = new System.Windows.Forms.PictureBox();
            this.panForget = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblTitleForget = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblInstructionForget = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtInputEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnContinueForget = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnCancelForget = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panForgetChange = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.txtPasswordNewAgain = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtPasswordNew = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblPasswordNewAgain = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblPasswordNew = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblTitleChange = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblInstructionChange = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnContinueChange = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panForgetOTP = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblSentAgainOTP = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblNoteOTP = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblNameEmail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblTitleOTP = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblInstructionOTP = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtInputOTP = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnContinueOTP = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnCancelOTP = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panWork = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panAdmin = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnFindAdmin = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.txtFindAdmin = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TabcontrolAdmin = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabQLNV = new System.Windows.Forms.TabPage();
            this.panTTNVchitiet = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.cboSexTTNV = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.checkTruongPhong = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.lblTruongPhong = new System.Windows.Forms.Label();
            this.dtpNgaycap = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.txtGmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtSDTTTNV = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblSodt = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.siticoneCirclePictureBox5 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.txtChucvuTTNV = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtChiso = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMachiso = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblChuc = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblMasonv = new System.Windows.Forms.Label();
            this.btnTaiDSNV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSuaDSNV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoaDSNV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAddNV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSortNV = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblTTNV = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThemNV = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panDanhsachNV = new DuAnCNPM.Views.DoubleBufferedPanel();
            this.tabQLKH = new System.Windows.Forms.TabPage();
            this.btnAddKH = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSortKH = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panTTKHchitiet = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.txtMST = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblMasothue = new System.Windows.Forms.Label();
            this.txtMaCty = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblMasoct = new System.Windows.Forms.Label();
            this.txtGmailCty = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblGmailct = new System.Windows.Forms.Label();
            this.txtSDTCty = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiachiCty = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtTenCty = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTenct = new System.Windows.Forms.Label();
            this.btnLuuDSKH = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSuaDSKH = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoaDSKH = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panDSKH = new DuAnCNPM.Views.DoubleBufferedPanel();
            this.lblDanhsachKH = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThongtinKH = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThemKH = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tabQLHD = new System.Windows.Forms.TabPage();
            this.panDSHD = new DuAnCNPM.Views.DoubleBufferedPanel();
            this.btnAddHD = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSortHD = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panTTHDchitiet = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.dtpNgaytraKQQLHD = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.dtpNgaykyQLHD = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.panCSchitiet = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.dtpNgaynhapQLHD = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.btnSuaChiSoChiTiet = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.grpDulieuTS = new System.Windows.Forms.GroupBox();
            this.lvDulieuTS = new System.Windows.Forms.ListView();
            this.btnLuuCSchitiet = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel12 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblTSchitiet = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtGhiChuQLHD = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCS = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMaNVnhap = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMaCSQLHD = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblDatenhap = new System.Windows.Forms.Label();
            this.lblThongso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMathongso = new System.Windows.Forms.Label();
            this.btnXoaChiSoChiTiet = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtSotien = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMaHDQLHD = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMaNVQLHD = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMaCtyQLHD = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblSomoney = new System.Windows.Forms.Label();
            this.lblDategiao = new System.Windows.Forms.Label();
            this.lblDateky = new System.Windows.Forms.Label();
            this.lblMasnv = new System.Windows.Forms.Label();
            this.lblMact = new System.Windows.Forms.Label();
            this.lblMahd = new System.Windows.Forms.Label();
            this.btnLuuHD = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSuaHD = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoaHD = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblTTHD = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThemHD = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblDSHD = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tabQLTS = new System.Windows.Forms.TabPage();
            this.btnAddTS = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSortTS = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panTTTSchitiet = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.lblNoiNhap = new System.Windows.Forms.Label();
            this.txtNoiNhap = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtTieuChuan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtViTriCS = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblTieuchuan = new System.Windows.Forms.Label();
            this.txtLoaiChiSo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtTenChiSo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMaCS = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblVitri = new System.Windows.Forms.Label();
            this.lblLoaits = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMats = new System.Windows.Forms.Label();
            this.btnLuuTS = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSuaTS = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoaTS = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panDSTS = new DuAnCNPM.Views.DoubleBufferedPanel();
            this.lblDanhsachTS = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblTTTS = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThemCS = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tabQLTB = new System.Windows.Forms.TabPage();
            this.panDSTBchitiet = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.txtNoidung = new System.Windows.Forms.RichTextBox();
            this.txtTieuDe = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblNdungTB = new System.Windows.Forms.Label();
            this.lblDatephathanh = new System.Windows.Forms.Label();
            this.lblTieude = new System.Windows.Forms.Label();
            this.txtVitriTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblMaTB = new System.Windows.Forms.Label();
            this.dtpNgayphathanh = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.btnLuuTB = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSuaTB = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnXoaTB = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel10 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panDSTBAdmin = new DuAnCNPM.Views.DoubleBufferedPanel();
            this.btnAddTB = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSortThongbao = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblDanhsachTB = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panTK = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblYear = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.cboMoctgian = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblTK = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panChuthich = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblDHFinish = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblDHInProgress = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblDHQuahan = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtQuahan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtInProgress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblChuthich = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtFinish = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.panDSDH = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnSortDH = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panDSHDnvchitiet = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.splitDSHDnvchitiet = new System.Windows.Forms.SplitContainer();
            this.btnFindma = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.txtFindma = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.grbThongtinDH = new System.Windows.Forms.GroupBox();
            this.txtMaThongSo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMadonhang = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblMadonhang = new System.Windows.Forms.Label();
            this.lblGhichu = new System.Windows.Forms.Label();
            this.txtGhichu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtTenthongso = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtKetqua = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblTenthongso = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.grbChucnang = new System.Windows.Forms.GroupBox();
            this.btnPrint = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnLuu = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSua = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.grpDulieuDH = new System.Windows.Forms.GroupBox();
            this.lvDulieudonhang = new System.Windows.Forms.ListView();
            this.panDSHDnv = new DuAnCNPM.Views.DoubleBufferedPanel();
            this.lblDSDH = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panTTNV = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.grbQuoctich = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtQuoctich = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblQuoctich = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbDiachithuongtru = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtDiachithuongtru = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblDiachithuongtru = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbQuequan = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtQuequan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblQuequan = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbDantoc = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtDantoc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.grbNoioCurrent = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtNoioCurrent = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblDantoc = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblNoioCurrent = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbNoisinh = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtNoisinh = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblNoisinh = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThongtinCN = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblHinhanhCN = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.picInformation = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.grbChucvu = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtChucvu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblChucvu = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbPhongban = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtPhongban = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblPhongban = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbSex = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.cboSexnv = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.grbEmail = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtEmailnv = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblEmail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbName = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtNamenv = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblName = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblSex = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbNgaysinh = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtNgaysinhnv = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.grbSdt = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtSdtnv = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblNgaysinh = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblSdt = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbMa = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtManv = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblMa = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThongtinNhanvien = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panTB = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnSortTB = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblDSTB = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panDSTB = new DuAnCNPM.Views.DoubleBufferedPanel();
            this.lblGachngang = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panNoidungTB = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.ricNDungTB = new System.Windows.Forms.RichTextBox();
            this.lblDateTB = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblTitleTB = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnFindTB = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.txtFindTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.panDSNV = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panFindNV = new DuAnCNPM.Views.DoubleBufferedPanel();
            this.grbTimthay = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtEmail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtSDT = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblPhongbanFind = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtTenNV = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblManhanvien = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.grbAllTTNV = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblSodienthoai = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblPhongbanNV = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblMaNV = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnFindNV = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.txtFindNV = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.panLogOut = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.grbLogout = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.btnContinueLogout = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnCancelLogout = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblLogo = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblChucnangQL = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblDoimatkhau = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThongke = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThongbao = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblDanhsachNV = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblThongtinNV = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblDanhsachDH = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblTrangchu = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblNameNV = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.picStaff = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panDMK = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.grbChangepass = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.txtPasscurrent = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblPasscurrent = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtPassnewagain = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtPassnew = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnContinueDMK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblPassnewagain = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lblPassnew = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnCancelchange = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panReport = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnIn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.picClosePdf = new System.Windows.Forms.PictureBox();
            this.reportBaocao = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.erpLoidinhdang)).BeginInit();
            this.panHome.SuspendLayout();
            this.panSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            this.panVeUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVechungtoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHuongdan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelEco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinisize)).BeginInit();
            this.panForget.SuspendLayout();
            this.panForgetChange.SuspendLayout();
            this.panForgetOTP.SuspendLayout();
            this.panWork.SuspendLayout();
            this.panAdmin.SuspendLayout();
            this.TabcontrolAdmin.SuspendLayout();
            this.tabQLNV.SuspendLayout();
            this.panTTNVchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox5)).BeginInit();
            this.tabQLKH.SuspendLayout();
            this.panTTKHchitiet.SuspendLayout();
            this.tabQLHD.SuspendLayout();
            this.panTTHDchitiet.SuspendLayout();
            this.panCSchitiet.SuspendLayout();
            this.grpDulieuTS.SuspendLayout();
            this.tabQLTS.SuspendLayout();
            this.panTTTSchitiet.SuspendLayout();
            this.tabQLTB.SuspendLayout();
            this.panDSTBchitiet.SuspendLayout();
            this.panTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panChuthich.SuspendLayout();
            this.panDSDH.SuspendLayout();
            this.panDSHDnvchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDSHDnvchitiet)).BeginInit();
            this.splitDSHDnvchitiet.Panel1.SuspendLayout();
            this.splitDSHDnvchitiet.Panel2.SuspendLayout();
            this.splitDSHDnvchitiet.SuspendLayout();
            this.grbThongtinDH.SuspendLayout();
            this.grbChucnang.SuspendLayout();
            this.grpDulieuDH.SuspendLayout();
            this.panTTNV.SuspendLayout();
            this.grbQuoctich.SuspendLayout();
            this.grbDiachithuongtru.SuspendLayout();
            this.grbQuequan.SuspendLayout();
            this.grbDantoc.SuspendLayout();
            this.grbNoioCurrent.SuspendLayout();
            this.grbNoisinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInformation)).BeginInit();
            this.grbChucvu.SuspendLayout();
            this.grbPhongban.SuspendLayout();
            this.grbSex.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbName.SuspendLayout();
            this.grbNgaysinh.SuspendLayout();
            this.grbSdt.SuspendLayout();
            this.grbMa.SuspendLayout();
            this.panTB.SuspendLayout();
            this.panNoidungTB.SuspendLayout();
            this.panDSNV.SuspendLayout();
            this.panFindNV.SuspendLayout();
            this.grbTimthay.SuspendLayout();
            this.grbAllTTNV.SuspendLayout();
            this.panLogOut.SuspendLayout();
            this.grbLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.panDMK.SuspendLayout();
            this.grbChangepass.SuspendLayout();
            this.panReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClosePdf)).BeginInit();
            this.SuspendLayout();
            // 
            // erpLoidinhdang
            // 
            this.erpLoidinhdang.ContainerControl = this;
            // 
            // panHome
            // 
            this.panHome.BackColor = System.Drawing.Color.Transparent;
            this.panHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panHome.BackgroundImage")));
            this.panHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panHome.Controls.Add(this.panSignIn);
            this.panHome.Controls.Add(this.panVeUs);
            this.panHome.Controls.Add(this.picVechungtoi);
            this.panHome.Controls.Add(this.picHuongdan);
            this.panHome.Controls.Add(this.lblVechungtoi);
            this.panHome.Controls.Add(this.lblHuongdan);
            this.panHome.Controls.Add(this.lblNote);
            this.panHome.Controls.Add(this.btnFlag);
            this.panHome.Controls.Add(this.picCancelEco);
            this.panHome.Controls.Add(this.picMinisize);
            this.panHome.Controls.Add(this.panForget);
            this.panHome.Controls.Add(this.panForgetChange);
            this.panHome.Controls.Add(this.panForgetOTP);
            this.panHome.Location = new System.Drawing.Point(0, 0);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(1200, 650);
            this.panHome.TabIndex = 71;
            // 
            // panSignIn
            // 
            this.panSignIn.BackColor = System.Drawing.Color.Transparent;
            this.panSignIn.BorderColor = System.Drawing.Color.Transparent;
            this.panSignIn.Controls.Add(this.lblHello);
            this.panSignIn.Controls.Add(this.picEye);
            this.panSignIn.Controls.Add(this.lblForget);
            this.panSignIn.Controls.Add(this.txtPass);
            this.panSignIn.Controls.Add(this.txtName);
            this.panSignIn.Controls.Add(this.btnSignIn);
            this.panSignIn.Location = new System.Drawing.Point(714, 69);
            this.panSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.panSignIn.Name = "panSignIn";
            this.panSignIn.Size = new System.Drawing.Size(483, 451);
            this.panSignIn.TabIndex = 59;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = false;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold);
            this.lblHello.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblHello.Location = new System.Drawing.Point(0, 65);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(483, 57);
            this.lblHello.TabIndex = 47;
            this.lblHello.Text = "Xin Chào";
            this.lblHello.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picEye
            // 
            this.picEye.BackColor = System.Drawing.Color.MintCream;
            this.picEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye.FillColor = System.Drawing.Color.MintCream;
            this.picEye.Image = global::DuAnCNPM.Properties.Resources.eyeClose;
            this.picEye.ImageRotate = 0F;
            this.picEye.Location = new System.Drawing.Point(386, 248);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(30, 30);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEye.TabIndex = 45;
            this.picEye.TabStop = false;
            this.picEye.Click += new System.EventHandler(this.picEye_Click);
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = false;
            this.lblForget.BackColor = System.Drawing.Color.Transparent;
            this.lblForget.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblForget.ForeColor = System.Drawing.Color.Black;
            this.lblForget.Location = new System.Drawing.Point(230, 298);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(190, 30);
            this.lblForget.TabIndex = 44;
            this.lblForget.Text = "Quên mật khẩu ?";
            this.lblForget.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblForget.Click += new System.EventHandler(this.lblForget_Click);
            // 
            // txtPass
            // 
            this.txtPass.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPass.BorderRadius = 10;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FillColor = System.Drawing.Color.MintCream;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HoverState.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.Location = new System.Drawing.Point(70, 235);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.LightSlateGray;
            this.txtPass.PlaceholderText = "Mật khẩu";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(350, 55);
            this.txtPass.TabIndex = 42;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.MintCream;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtName.Location = new System.Drawing.Point(70, 168);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.LightSlateGray;
            this.txtName.PlaceholderText = "Tài khoản";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(350, 55);
            this.txtName.TabIndex = 43;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.btnSignIn.BorderRadius = 22;
            this.btnSignIn.BorderThickness = 1;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnSignIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnSignIn.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnSignIn.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(164, 353);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(175, 48);
            this.btnSignIn.TabIndex = 41;
            this.btnSignIn.Text = "Đăng Nhập";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panVeUs
            // 
            this.panVeUs.BackColor = System.Drawing.Color.Transparent;
            this.panVeUs.Controls.Add(this.picClose);
            this.panVeUs.Controls.Add(this.picAboutUs);
            this.panVeUs.Location = new System.Drawing.Point(22, 3);
            this.panVeUs.Margin = new System.Windows.Forms.Padding(2);
            this.panVeUs.Name = "panVeUs";
            this.panVeUs.Size = new System.Drawing.Size(560, 636);
            this.panVeUs.TabIndex = 103;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.White;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(517, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(40, 40);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 23;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picAboutUs
            // 
            this.picAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.picAboutUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAboutUs.BorderRadius = 5;
            this.picAboutUs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picAboutUs.Image = global::DuAnCNPM.Properties.Resources.AboutUs;
            this.picAboutUs.ImageRotate = 0F;
            this.picAboutUs.Location = new System.Drawing.Point(0, 3);
            this.picAboutUs.Name = "picAboutUs";
            this.picAboutUs.Size = new System.Drawing.Size(560, 641);
            this.picAboutUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAboutUs.TabIndex = 18;
            this.picAboutUs.TabStop = false;
            // 
            // picVechungtoi
            // 
            this.picVechungtoi.Image = ((System.Drawing.Image)(resources.GetObject("picVechungtoi.Image")));
            this.picVechungtoi.Location = new System.Drawing.Point(1048, 620);
            this.picVechungtoi.Name = "picVechungtoi";
            this.picVechungtoi.Size = new System.Drawing.Size(28, 28);
            this.picVechungtoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVechungtoi.TabIndex = 102;
            this.picVechungtoi.TabStop = false;
            this.picVechungtoi.Click += new System.EventHandler(this.picVechungtoi_Click);
            // 
            // picHuongdan
            // 
            this.picHuongdan.Image = ((System.Drawing.Image)(resources.GetObject("picHuongdan.Image")));
            this.picHuongdan.Location = new System.Drawing.Point(919, 620);
            this.picHuongdan.Name = "picHuongdan";
            this.picHuongdan.Size = new System.Drawing.Size(28, 28);
            this.picHuongdan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHuongdan.TabIndex = 101;
            this.picHuongdan.TabStop = false;
            // 
            // lblVechungtoi
            // 
            this.lblVechungtoi.AutoSize = false;
            this.lblVechungtoi.BackColor = System.Drawing.Color.Transparent;
            this.lblVechungtoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblVechungtoi.ForeColor = System.Drawing.Color.Black;
            this.lblVechungtoi.Location = new System.Drawing.Point(1059, 627);
            this.lblVechungtoi.Name = "lblVechungtoi";
            this.lblVechungtoi.Size = new System.Drawing.Size(138, 20);
            this.lblVechungtoi.TabIndex = 66;
            this.lblVechungtoi.Text = "Về chúng tôi";
            this.lblVechungtoi.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVechungtoi.Click += new System.EventHandler(this.lblVechungtoi_Click);
            // 
            // lblHuongdan
            // 
            this.lblHuongdan.AutoSize = false;
            this.lblHuongdan.BackColor = System.Drawing.Color.Transparent;
            this.lblHuongdan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblHuongdan.ForeColor = System.Drawing.Color.Black;
            this.lblHuongdan.Location = new System.Drawing.Point(936, 627);
            this.lblHuongdan.Name = "lblHuongdan";
            this.lblHuongdan.Size = new System.Drawing.Size(117, 20);
            this.lblHuongdan.TabIndex = 65;
            this.lblHuongdan.Text = "Hướng dẫn ";
            this.lblHuongdan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = false;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(0, 350);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(412, 50);
            this.lblNote.TabIndex = 48;
            this.lblNote.Text = "ĐƠN HÀNG XANH - GIAO DỊCH BỀN VỮNG";
            this.lblNote.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFlag
            // 
            this.btnFlag.BackColor = System.Drawing.Color.White;
            this.btnFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlag.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFlag.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFlag.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFlag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFlag.FillColor = System.Drawing.Color.White;
            this.btnFlag.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFlag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFlag.ForeColor = System.Drawing.Color.White;
            this.btnFlag.Image = global::DuAnCNPM.Properties.Resources.FlagVN;
            this.btnFlag.ImageSize = new System.Drawing.Size(38, 38);
            this.btnFlag.Location = new System.Drawing.Point(1093, 3);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(37, 26);
            this.btnFlag.TabIndex = 64;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // picCancelEco
            // 
            this.picCancelEco.BackColor = System.Drawing.Color.Transparent;
            this.picCancelEco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCancelEco.Image = ((System.Drawing.Image)(resources.GetObject("picCancelEco.Image")));
            this.picCancelEco.Location = new System.Drawing.Point(1172, 3);
            this.picCancelEco.Name = "picCancelEco";
            this.picCancelEco.Size = new System.Drawing.Size(25, 25);
            this.picCancelEco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancelEco.TabIndex = 55;
            this.picCancelEco.TabStop = false;
            this.picCancelEco.Click += new System.EventHandler(this.picCancelEco_Click);
            // 
            // picMinisize
            // 
            this.picMinisize.BackColor = System.Drawing.Color.Transparent;
            this.picMinisize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinisize.Image = ((System.Drawing.Image)(resources.GetObject("picMinisize.Image")));
            this.picMinisize.Location = new System.Drawing.Point(1136, 0);
            this.picMinisize.Name = "picMinisize";
            this.picMinisize.Size = new System.Drawing.Size(28, 30);
            this.picMinisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinisize.TabIndex = 63;
            this.picMinisize.TabStop = false;
            this.picMinisize.Click += new System.EventHandler(this.picMinisize_Click);
            // 
            // panForget
            // 
            this.panForget.BackColor = System.Drawing.Color.Honeydew;
            this.panForget.BorderColor = System.Drawing.Color.Transparent;
            this.panForget.Controls.Add(this.lblTitleForget);
            this.panForget.Controls.Add(this.lblInstructionForget);
            this.panForget.Controls.Add(this.txtInputEmail);
            this.panForget.Controls.Add(this.btnContinueForget);
            this.panForget.Controls.Add(this.btnCancelForget);
            this.panForget.Location = new System.Drawing.Point(731, 190);
            this.panForget.Margin = new System.Windows.Forms.Padding(2);
            this.panForget.Name = "panForget";
            this.panForget.Size = new System.Drawing.Size(450, 280);
            this.panForget.TabIndex = 67;
            // 
            // lblTitleForget
            // 
            this.lblTitleForget.AutoSize = false;
            this.lblTitleForget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.lblTitleForget.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForget.ForeColor = System.Drawing.Color.White;
            this.lblTitleForget.Location = new System.Drawing.Point(0, 0);
            this.lblTitleForget.Name = "lblTitleForget";
            this.lblTitleForget.Size = new System.Drawing.Size(450, 50);
            this.lblTitleForget.TabIndex = 17;
            this.lblTitleForget.Text = "TÌM TÀI KHOẢN";
            this.lblTitleForget.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructionForget
            // 
            this.lblInstructionForget.AutoSize = false;
            this.lblInstructionForget.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructionForget.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionForget.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInstructionForget.Location = new System.Drawing.Point(0, 56);
            this.lblInstructionForget.Name = "lblInstructionForget";
            this.lblInstructionForget.Size = new System.Drawing.Size(450, 25);
            this.lblInstructionForget.TabIndex = 18;
            this.lblInstructionForget.Text = "Nhập Email để tìm kiếm tài khoản của bạn:";
            this.lblInstructionForget.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInputEmail
            // 
            this.txtInputEmail.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInputEmail.BorderRadius = 27;
            this.txtInputEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInputEmail.DefaultText = "";
            this.txtInputEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtInputEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputEmail.ForeColor = System.Drawing.Color.Black;
            this.txtInputEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInputEmail.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtInputEmail.Location = new System.Drawing.Point(51, 109);
            this.txtInputEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputEmail.Name = "txtInputEmail";
            this.txtInputEmail.PasswordChar = '\0';
            this.txtInputEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInputEmail.PlaceholderText = "Tài khoản Email";
            this.txtInputEmail.SelectedText = "";
            this.txtInputEmail.Size = new System.Drawing.Size(352, 55);
            this.txtInputEmail.TabIndex = 19;
            // 
            // btnContinueForget
            // 
            this.btnContinueForget.BorderRadius = 22;
            this.btnContinueForget.BorderThickness = 1;
            this.btnContinueForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueForget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnContinueForget.FocusedColor = System.Drawing.Color.Green;
            this.btnContinueForget.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueForget.ForeColor = System.Drawing.Color.White;
            this.btnContinueForget.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnContinueForget.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnContinueForget.HoverState.ForeColor = System.Drawing.Color.LightCyan;
            this.btnContinueForget.Location = new System.Drawing.Point(278, 201);
            this.btnContinueForget.Name = "btnContinueForget";
            this.btnContinueForget.Size = new System.Drawing.Size(125, 45);
            this.btnContinueForget.TabIndex = 21;
            this.btnContinueForget.Text = "Tiếp tục";
            this.btnContinueForget.Click += new System.EventHandler(this.btnContinueForget_Click);
            // 
            // btnCancelForget
            // 
            this.btnCancelForget.BorderRadius = 22;
            this.btnCancelForget.BorderThickness = 1;
            this.btnCancelForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelForget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnCancelForget.FocusedColor = System.Drawing.Color.Red;
            this.btnCancelForget.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelForget.ForeColor = System.Drawing.Color.White;
            this.btnCancelForget.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelForget.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancelForget.HoverState.ForeColor = System.Drawing.Color.LightCyan;
            this.btnCancelForget.Location = new System.Drawing.Point(51, 201);
            this.btnCancelForget.Name = "btnCancelForget";
            this.btnCancelForget.Size = new System.Drawing.Size(125, 45);
            this.btnCancelForget.TabIndex = 20;
            this.btnCancelForget.Text = "Hủy";
            this.btnCancelForget.Click += new System.EventHandler(this.btnCancelForget_Click);
            // 
            // panForgetChange
            // 
            this.panForgetChange.BackColor = System.Drawing.Color.Honeydew;
            this.panForgetChange.BorderColor = System.Drawing.Color.Transparent;
            this.panForgetChange.Controls.Add(this.txtPasswordNewAgain);
            this.panForgetChange.Controls.Add(this.txtPasswordNew);
            this.panForgetChange.Controls.Add(this.lblPasswordNewAgain);
            this.panForgetChange.Controls.Add(this.lblPasswordNew);
            this.panForgetChange.Controls.Add(this.lblTitleChange);
            this.panForgetChange.Controls.Add(this.lblInstructionChange);
            this.panForgetChange.Controls.Add(this.btnContinueChange);
            this.panForgetChange.Location = new System.Drawing.Point(731, 183);
            this.panForgetChange.Margin = new System.Windows.Forms.Padding(2);
            this.panForgetChange.Name = "panForgetChange";
            this.panForgetChange.Size = new System.Drawing.Size(450, 296);
            this.panForgetChange.TabIndex = 100;
            // 
            // txtPasswordNewAgain
            // 
            this.txtPasswordNewAgain.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPasswordNewAgain.BorderRadius = 25;
            this.txtPasswordNewAgain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordNewAgain.DefaultText = "";
            this.txtPasswordNewAgain.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordNewAgain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNewAgain.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordNewAgain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPasswordNewAgain.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPasswordNewAgain.Location = new System.Drawing.Point(214, 153);
            this.txtPasswordNewAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordNewAgain.Name = "txtPasswordNewAgain";
            this.txtPasswordNewAgain.PasswordChar = '\0';
            this.txtPasswordNewAgain.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPasswordNewAgain.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtPasswordNewAgain.SelectedText = "";
            this.txtPasswordNewAgain.Size = new System.Drawing.Size(216, 50);
            this.txtPasswordNewAgain.TabIndex = 103;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPasswordNew.BorderRadius = 25;
            this.txtPasswordNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordNew.DefaultText = "";
            this.txtPasswordNew.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNew.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordNew.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPasswordNew.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPasswordNew.Location = new System.Drawing.Point(214, 96);
            this.txtPasswordNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '\0';
            this.txtPasswordNew.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPasswordNew.PlaceholderText = "Nhập mật khẩu mới";
            this.txtPasswordNew.SelectedText = "";
            this.txtPasswordNew.Size = new System.Drawing.Size(216, 50);
            this.txtPasswordNew.TabIndex = 102;
            // 
            // lblPasswordNewAgain
            // 
            this.lblPasswordNewAgain.AutoSize = false;
            this.lblPasswordNewAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordNewAgain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNewAgain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPasswordNewAgain.Location = new System.Drawing.Point(12, 163);
            this.lblPasswordNewAgain.Name = "lblPasswordNewAgain";
            this.lblPasswordNewAgain.Size = new System.Drawing.Size(204, 29);
            this.lblPasswordNewAgain.TabIndex = 101;
            this.lblPasswordNewAgain.Text = "Nhập lại mật khẩu mới:";
            this.lblPasswordNewAgain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = false;
            this.lblPasswordNew.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNew.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPasswordNew.Location = new System.Drawing.Point(12, 108);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(195, 29);
            this.lblPasswordNew.TabIndex = 100;
            this.lblPasswordNew.Text = "Mật khẩu mới:";
            this.lblPasswordNew.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleChange
            // 
            this.lblTitleChange.AutoSize = false;
            this.lblTitleChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.lblTitleChange.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChange.ForeColor = System.Drawing.Color.White;
            this.lblTitleChange.Location = new System.Drawing.Point(0, 0);
            this.lblTitleChange.Name = "lblTitleChange";
            this.lblTitleChange.Size = new System.Drawing.Size(450, 50);
            this.lblTitleChange.TabIndex = 17;
            this.lblTitleChange.Text = "THAY ĐỔI MẬT KHẨU";
            this.lblTitleChange.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructionChange
            // 
            this.lblInstructionChange.AutoSize = false;
            this.lblInstructionChange.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructionChange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionChange.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInstructionChange.Location = new System.Drawing.Point(16, 56);
            this.lblInstructionChange.Name = "lblInstructionChange";
            this.lblInstructionChange.Size = new System.Drawing.Size(417, 29);
            this.lblInstructionChange.TabIndex = 18;
            this.lblInstructionChange.Text = "Nhập mật khẩu mới của bạn:";
            this.lblInstructionChange.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinueChange
            // 
            this.btnContinueChange.BorderRadius = 22;
            this.btnContinueChange.BorderThickness = 1;
            this.btnContinueChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnContinueChange.FocusedColor = System.Drawing.Color.Green;
            this.btnContinueChange.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueChange.ForeColor = System.Drawing.Color.White;
            this.btnContinueChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnContinueChange.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnContinueChange.HoverState.ForeColor = System.Drawing.Color.LightCyan;
            this.btnContinueChange.Location = new System.Drawing.Point(162, 223);
            this.btnContinueChange.Name = "btnContinueChange";
            this.btnContinueChange.Size = new System.Drawing.Size(125, 45);
            this.btnContinueChange.TabIndex = 21;
            this.btnContinueChange.Text = "Tiếp tục";
            this.btnContinueChange.Click += new System.EventHandler(this.btnContinueChange_Click);
            // 
            // panForgetOTP
            // 
            this.panForgetOTP.BackColor = System.Drawing.Color.Honeydew;
            this.panForgetOTP.BorderColor = System.Drawing.Color.Transparent;
            this.panForgetOTP.Controls.Add(this.lblSentAgainOTP);
            this.panForgetOTP.Controls.Add(this.lblNoteOTP);
            this.panForgetOTP.Controls.Add(this.lblNameEmail);
            this.panForgetOTP.Controls.Add(this.lblTitleOTP);
            this.panForgetOTP.Controls.Add(this.lblInstructionOTP);
            this.panForgetOTP.Controls.Add(this.txtInputOTP);
            this.panForgetOTP.Controls.Add(this.btnContinueOTP);
            this.panForgetOTP.Controls.Add(this.btnCancelOTP);
            this.panForgetOTP.Location = new System.Drawing.Point(731, 183);
            this.panForgetOTP.Margin = new System.Windows.Forms.Padding(2);
            this.panForgetOTP.Name = "panForgetOTP";
            this.panForgetOTP.Size = new System.Drawing.Size(450, 296);
            this.panForgetOTP.TabIndex = 68;
            // 
            // lblSentAgainOTP
            // 
            this.lblSentAgainOTP.AutoSize = false;
            this.lblSentAgainOTP.BackColor = System.Drawing.Color.Transparent;
            this.lblSentAgainOTP.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblSentAgainOTP.ForeColor = System.Drawing.Color.Black;
            this.lblSentAgainOTP.Location = new System.Drawing.Point(16, 178);
            this.lblSentAgainOTP.Name = "lblSentAgainOTP";
            this.lblSentAgainOTP.Size = new System.Drawing.Size(216, 30);
            this.lblSentAgainOTP.TabIndex = 99;
            this.lblSentAgainOTP.Text = "Gửi lại mã xác nhận !";
            this.lblSentAgainOTP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSentAgainOTP.Click += new System.EventHandler(this.lblSentAgainOTP_Click);
            // 
            // lblNoteOTP
            // 
            this.lblNoteOTP.AutoSize = false;
            this.lblNoteOTP.BackColor = System.Drawing.Color.Transparent;
            this.lblNoteOTP.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblNoteOTP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNoteOTP.Location = new System.Drawing.Point(237, 125);
            this.lblNoteOTP.Name = "lblNoteOTP";
            this.lblNoteOTP.Size = new System.Drawing.Size(208, 20);
            this.lblNoteOTP.TabIndex = 97;
            this.lblNoteOTP.Text = "Đã gửi đến tài khoản: ";
            this.lblNoteOTP.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameEmail
            // 
            this.lblNameEmail.AutoSize = false;
            this.lblNameEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblNameEmail.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblNameEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNameEmail.Location = new System.Drawing.Point(237, 150);
            this.lblNameEmail.Name = "lblNameEmail";
            this.lblNameEmail.Size = new System.Drawing.Size(206, 29);
            this.lblNameEmail.TabIndex = 98;
            this.lblNameEmail.Text = "hoangcongthehe@gmail.com";
            this.lblNameEmail.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitleOTP
            // 
            this.lblTitleOTP.AutoSize = false;
            this.lblTitleOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.lblTitleOTP.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOTP.ForeColor = System.Drawing.Color.White;
            this.lblTitleOTP.Location = new System.Drawing.Point(0, 0);
            this.lblTitleOTP.Name = "lblTitleOTP";
            this.lblTitleOTP.Size = new System.Drawing.Size(450, 50);
            this.lblTitleOTP.TabIndex = 17;
            this.lblTitleOTP.Text = "NHẬP MÃ XÁC NHẬN OTP";
            this.lblTitleOTP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructionOTP
            // 
            this.lblInstructionOTP.AutoSize = false;
            this.lblInstructionOTP.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructionOTP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionOTP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInstructionOTP.Location = new System.Drawing.Point(16, 56);
            this.lblInstructionOTP.Name = "lblInstructionOTP";
            this.lblInstructionOTP.Size = new System.Drawing.Size(417, 41);
            this.lblInstructionOTP.TabIndex = 18;
            this.lblInstructionOTP.Text = "Kiểm tra mã xác nhận trong Email của bạn. Mã có hiệu lực trong vòng 2 phút:";
            this.lblInstructionOTP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInputOTP
            // 
            this.txtInputOTP.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInputOTP.BorderRadius = 27;
            this.txtInputOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInputOTP.DefaultText = "";
            this.txtInputOTP.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtInputOTP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputOTP.ForeColor = System.Drawing.Color.Black;
            this.txtInputOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInputOTP.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtInputOTP.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtInputOTP.IconLeft")));
            this.txtInputOTP.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtInputOTP.IconRight = ((System.Drawing.Image)(resources.GetObject("txtInputOTP.IconRight")));
            this.txtInputOTP.IconRightSize = new System.Drawing.Size(33, 33);
            this.txtInputOTP.Location = new System.Drawing.Point(16, 116);
            this.txtInputOTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputOTP.Name = "txtInputOTP";
            this.txtInputOTP.PasswordChar = '\0';
            this.txtInputOTP.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInputOTP.PlaceholderText = "Mã xác nhận";
            this.txtInputOTP.SelectedText = "";
            this.txtInputOTP.Size = new System.Drawing.Size(216, 55);
            this.txtInputOTP.TabIndex = 19;
            // 
            // btnContinueOTP
            // 
            this.btnContinueOTP.BorderRadius = 22;
            this.btnContinueOTP.BorderThickness = 1;
            this.btnContinueOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueOTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnContinueOTP.FocusedColor = System.Drawing.Color.Green;
            this.btnContinueOTP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueOTP.ForeColor = System.Drawing.Color.White;
            this.btnContinueOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnContinueOTP.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnContinueOTP.HoverState.ForeColor = System.Drawing.Color.LightCyan;
            this.btnContinueOTP.Location = new System.Drawing.Point(285, 223);
            this.btnContinueOTP.Name = "btnContinueOTP";
            this.btnContinueOTP.Size = new System.Drawing.Size(125, 45);
            this.btnContinueOTP.TabIndex = 21;
            this.btnContinueOTP.Text = "Tiếp tục";
            this.btnContinueOTP.Click += new System.EventHandler(this.btnContinueOTP_Click);
            // 
            // btnCancelOTP
            // 
            this.btnCancelOTP.BorderRadius = 22;
            this.btnCancelOTP.BorderThickness = 1;
            this.btnCancelOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnCancelOTP.FocusedColor = System.Drawing.Color.Red;
            this.btnCancelOTP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOTP.ForeColor = System.Drawing.Color.White;
            this.btnCancelOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelOTP.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancelOTP.HoverState.ForeColor = System.Drawing.Color.LightCyan;
            this.btnCancelOTP.Location = new System.Drawing.Point(41, 223);
            this.btnCancelOTP.Name = "btnCancelOTP";
            this.btnCancelOTP.Size = new System.Drawing.Size(125, 45);
            this.btnCancelOTP.TabIndex = 20;
            this.btnCancelOTP.Text = "Quay lại";
            this.btnCancelOTP.Click += new System.EventHandler(this.btnCancelOTP_Click);
            // 
            // panWork
            // 
            this.panWork.BackColor = System.Drawing.Color.Transparent;
            this.panWork.BackgroundImage = global::DuAnCNPM.Properties.Resources.Design__1_;
            this.panWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panWork.Controls.Add(this.panDSDH);
            this.panWork.Controls.Add(this.panAdmin);
            this.panWork.Controls.Add(this.panTK);
            this.panWork.Controls.Add(this.panTTNV);
            this.panWork.Controls.Add(this.panTB);
            this.panWork.Controls.Add(this.panDSNV);
            this.panWork.Controls.Add(this.panLogOut);
            this.panWork.Controls.Add(this.lblLogo);
            this.panWork.Controls.Add(this.picLogo);
            this.panWork.Controls.Add(this.lblChucnangQL);
            this.panWork.Controls.Add(this.lblDoimatkhau);
            this.panWork.Controls.Add(this.lblThongke);
            this.panWork.Controls.Add(this.lblThongbao);
            this.panWork.Controls.Add(this.lblDanhsachNV);
            this.panWork.Controls.Add(this.lblThongtinNV);
            this.panWork.Controls.Add(this.lblDanhsachDH);
            this.panWork.Controls.Add(this.lblTrangchu);
            this.panWork.Controls.Add(this.lblNameNV);
            this.panWork.Controls.Add(this.picStaff);
            this.panWork.Controls.Add(this.lblLogOut);
            this.panWork.Controls.Add(this.picLogout);
            this.panWork.Controls.Add(this.panDMK);
            this.panWork.Location = new System.Drawing.Point(0, 0);
            this.panWork.Margin = new System.Windows.Forms.Padding(2);
            this.panWork.Name = "panWork";
            this.panWork.Size = new System.Drawing.Size(1200, 650);
            this.panWork.TabIndex = 72;
            // 
            // panAdmin
            // 
            this.panAdmin.BackColor = System.Drawing.Color.Transparent;
            this.panAdmin.Controls.Add(this.btnFindAdmin);
            this.panAdmin.Controls.Add(this.txtFindAdmin);
            this.panAdmin.Controls.Add(this.TabcontrolAdmin);
            this.panAdmin.FillColor = System.Drawing.Color.White;
            this.panAdmin.Location = new System.Drawing.Point(220, 65);
            this.panAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.panAdmin.Name = "panAdmin";
            this.panAdmin.Size = new System.Drawing.Size(980, 585);
            this.panAdmin.TabIndex = 125;
            // 
            // btnFindAdmin
            // 
            this.btnFindAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnFindAdmin.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnFindAdmin.BorderThickness = 1;
            this.btnFindAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindAdmin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindAdmin.FillColor = System.Drawing.Color.MintCream;
            this.btnFindAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindAdmin.ForeColor = System.Drawing.Color.White;
            this.btnFindAdmin.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnFindAdmin.HoverState.FillColor = System.Drawing.Color.Honeydew;
            this.btnFindAdmin.Image = global::DuAnCNPM.Properties.Resources.magnifying_glass_search;
            this.btnFindAdmin.ImageSize = new System.Drawing.Size(28, 28);
            this.btnFindAdmin.Location = new System.Drawing.Point(14, 11);
            this.btnFindAdmin.Name = "btnFindAdmin";
            this.btnFindAdmin.Size = new System.Drawing.Size(40, 40);
            this.btnFindAdmin.TabIndex = 26;
            this.btnFindAdmin.UseTransparentBackground = true;
            this.btnFindAdmin.Click += new System.EventHandler(this.btnFindAdmin_Click);
            // 
            // txtFindAdmin
            // 
            this.txtFindAdmin.BackColor = System.Drawing.Color.Transparent;
            this.txtFindAdmin.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFindAdmin.BorderRadius = 21;
            this.txtFindAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindAdmin.DefaultText = "";
            this.txtFindAdmin.FillColor = System.Drawing.Color.MintCream;
            this.txtFindAdmin.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFindAdmin.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtFindAdmin.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFindAdmin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtFindAdmin.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFindAdmin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtFindAdmin.Location = new System.Drawing.Point(61, 8);
            this.txtFindAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindAdmin.Name = "txtFindAdmin";
            this.txtFindAdmin.PasswordChar = '\0';
            this.txtFindAdmin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFindAdmin.PlaceholderText = "Tìm kiếm ";
            this.txtFindAdmin.SelectedText = "";
            this.txtFindAdmin.Size = new System.Drawing.Size(907, 45);
            this.txtFindAdmin.TabIndex = 25;
            // 
            // TabcontrolAdmin
            // 
            this.TabcontrolAdmin.Controls.Add(this.tabQLNV);
            this.TabcontrolAdmin.Controls.Add(this.tabQLKH);
            this.TabcontrolAdmin.Controls.Add(this.tabQLHD);
            this.TabcontrolAdmin.Controls.Add(this.tabQLTS);
            this.TabcontrolAdmin.Controls.Add(this.tabQLTB);
            this.TabcontrolAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabcontrolAdmin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabcontrolAdmin.ItemSize = new System.Drawing.Size(195, 40);
            this.TabcontrolAdmin.Location = new System.Drawing.Point(3, 60);
            this.TabcontrolAdmin.Name = "TabcontrolAdmin";
            this.TabcontrolAdmin.SelectedIndex = 0;
            this.TabcontrolAdmin.Size = new System.Drawing.Size(980, 525);
            this.TabcontrolAdmin.TabButtonHoverState.BorderColor = System.Drawing.Color.Honeydew;
            this.TabcontrolAdmin.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TabcontrolAdmin.TabButtonHoverState.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.TabcontrolAdmin.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabcontrolAdmin.TabButtonHoverState.InnerColor = System.Drawing.Color.MintCream;
            this.TabcontrolAdmin.TabButtonIdleState.BorderColor = System.Drawing.Color.Honeydew;
            this.TabcontrolAdmin.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TabcontrolAdmin.TabButtonIdleState.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.TabcontrolAdmin.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.TabcontrolAdmin.TabButtonIdleState.InnerColor = System.Drawing.Color.MintCream;
            this.TabcontrolAdmin.TabButtonSelectedState.BorderColor = System.Drawing.Color.Honeydew;
            this.TabcontrolAdmin.TabButtonSelectedState.FillColor = System.Drawing.Color.SeaGreen;
            this.TabcontrolAdmin.TabButtonSelectedState.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.TabcontrolAdmin.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabcontrolAdmin.TabButtonSelectedState.InnerColor = System.Drawing.Color.MintCream;
            this.TabcontrolAdmin.TabButtonSize = new System.Drawing.Size(195, 40);
            this.TabcontrolAdmin.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.TabcontrolAdmin.TabIndex = 2;
            this.TabcontrolAdmin.TabMenuBackColor = System.Drawing.Color.White;
            this.TabcontrolAdmin.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            this.TabcontrolAdmin.SelectedIndexChanged += new System.EventHandler(this.TabcontrolAdmin_SelectedIndexChanged);
            // 
            // tabQLNV
            // 
            this.tabQLNV.BackColor = System.Drawing.Color.White;
            this.tabQLNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabQLNV.Controls.Add(this.panTTNVchitiet);
            this.tabQLNV.Controls.Add(this.btnTaiDSNV);
            this.tabQLNV.Controls.Add(this.btnSuaDSNV);
            this.tabQLNV.Controls.Add(this.btnXoaDSNV);
            this.tabQLNV.Controls.Add(this.btnAddNV);
            this.tabQLNV.Controls.Add(this.btnSortNV);
            this.tabQLNV.Controls.Add(this.siticoneHtmlLabel7);
            this.tabQLNV.Controls.Add(this.lblTTNV);
            this.tabQLNV.Controls.Add(this.lblThemNV);
            this.tabQLNV.Controls.Add(this.panDanhsachNV);
            this.tabQLNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabQLNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabQLNV.Location = new System.Drawing.Point(4, 44);
            this.tabQLNV.Name = "tabQLNV";
            this.tabQLNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLNV.Size = new System.Drawing.Size(972, 477);
            this.tabQLNV.TabIndex = 0;
            this.tabQLNV.Text = "Quản lý nhân viên";
            // 
            // panTTNVchitiet
            // 
            this.panTTNVchitiet.AutoScroll = true;
            this.panTTNVchitiet.BackColor = System.Drawing.Color.Transparent;
            this.panTTNVchitiet.BorderColor = System.Drawing.Color.SeaGreen;
            this.panTTNVchitiet.BorderRadius = 8;
            this.panTTNVchitiet.Controls.Add(this.cboSexTTNV);
            this.panTTNVchitiet.Controls.Add(this.checkTruongPhong);
            this.panTTNVchitiet.Controls.Add(this.lblTruongPhong);
            this.panTTNVchitiet.Controls.Add(this.dtpNgaycap);
            this.panTTNVchitiet.Controls.Add(this.txtGmail);
            this.panTTNVchitiet.Controls.Add(this.txtSDTTTNV);
            this.panTTNVchitiet.Controls.Add(this.lblSodt);
            this.panTTNVchitiet.Controls.Add(this.lblGioitinh);
            this.panTTNVchitiet.Controls.Add(this.lblMatkhau);
            this.panTTNVchitiet.Controls.Add(this.siticoneCirclePictureBox5);
            this.panTTNVchitiet.Controls.Add(this.txtChucvuTTNV);
            this.panTTNVchitiet.Controls.Add(this.txtChiso);
            this.panTTNVchitiet.Controls.Add(this.txtMachiso);
            this.panTTNVchitiet.Controls.Add(this.lblDate);
            this.panTTNVchitiet.Controls.Add(this.lblChuc);
            this.panTTNVchitiet.Controls.Add(this.lblHoten);
            this.panTTNVchitiet.Controls.Add(this.lblMasonv);
            this.panTTNVchitiet.FillColor = System.Drawing.Color.White;
            this.panTTNVchitiet.FillColor2 = System.Drawing.Color.White;
            this.panTTNVchitiet.Location = new System.Drawing.Point(284, 49);
            this.panTTNVchitiet.Name = "panTTNVchitiet";
            this.panTTNVchitiet.Size = new System.Drawing.Size(688, 426);
            this.panTTNVchitiet.TabIndex = 58;
            // 
            // cboSexTTNV
            // 
            this.cboSexTTNV.BackColor = System.Drawing.Color.Transparent;
            this.cboSexTTNV.BorderColor = System.Drawing.Color.Black;
            this.cboSexTTNV.BorderRadius = 10;
            this.cboSexTTNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSexTTNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexTTNV.Enabled = false;
            this.cboSexTTNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSexTTNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSexTTNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexTTNV.ForeColor = System.Drawing.Color.Black;
            this.cboSexTTNV.IntegralHeight = false;
            this.cboSexTTNV.ItemHeight = 44;
            this.cboSexTTNV.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cboSexTTNV.Location = new System.Drawing.Point(179, 223);
            this.cboSexTTNV.Name = "cboSexTTNV";
            this.cboSexTTNV.Size = new System.Drawing.Size(295, 50);
            this.cboSexTTNV.TabIndex = 45;
            // 
            // checkTruongPhong
            // 
            this.checkTruongPhong.Checked = true;
            this.checkTruongPhong.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkTruongPhong.CheckedState.BorderRadius = 2;
            this.checkTruongPhong.CheckedState.BorderThickness = 0;
            this.checkTruongPhong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkTruongPhong.Enabled = false;
            this.checkTruongPhong.Location = new System.Drawing.Point(631, 228);
            this.checkTruongPhong.Margin = new System.Windows.Forms.Padding(2);
            this.checkTruongPhong.Name = "checkTruongPhong";
            this.checkTruongPhong.Size = new System.Drawing.Size(25, 25);
            this.checkTruongPhong.TabIndex = 47;
            this.checkTruongPhong.Text = "siticoneCustomCheckBox1";
            this.checkTruongPhong.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkTruongPhong.UncheckedState.BorderRadius = 2;
            this.checkTruongPhong.UncheckedState.BorderThickness = 0;
            this.checkTruongPhong.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblTruongPhong
            // 
            this.lblTruongPhong.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruongPhong.Location = new System.Drawing.Point(497, 228);
            this.lblTruongPhong.Name = "lblTruongPhong";
            this.lblTruongPhong.Size = new System.Drawing.Size(188, 25);
            this.lblTruongPhong.TabIndex = 46;
            this.lblTruongPhong.Text = "Trưởng phòng:";
            this.lblTruongPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgaycap
            // 
            this.dtpNgaycap.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgaycap.BorderRadius = 10;
            this.dtpNgaycap.BorderThickness = 1;
            this.dtpNgaycap.CausesValidation = false;
            this.dtpNgaycap.Checked = true;
            this.dtpNgaycap.Enabled = false;
            this.dtpNgaycap.FillColor = System.Drawing.Color.Honeydew;
            this.dtpNgaycap.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaycap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaycap.Location = new System.Drawing.Point(179, 170);
            this.dtpNgaycap.MaxDate = new System.DateTime(2025, 4, 11, 0, 0, 0, 0);
            this.dtpNgaycap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaycap.Name = "dtpNgaycap";
            this.dtpNgaycap.Size = new System.Drawing.Size(295, 45);
            this.dtpNgaycap.TabIndex = 37;
            this.dtpNgaycap.Value = new System.DateTime(2025, 3, 28, 1, 18, 56, 808);
            // 
            // txtGmail
            // 
            this.txtGmail.BackColor = System.Drawing.Color.Transparent;
            this.txtGmail.BorderColor = System.Drawing.Color.Black;
            this.txtGmail.BorderRadius = 10;
            this.txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmail.DefaultText = "";
            this.txtGmail.Enabled = false;
            this.txtGmail.FillColor = System.Drawing.SystemColors.Window;
            this.txtGmail.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtGmail.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtGmail.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtGmail.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGmail.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.ForeColor = System.Drawing.Color.Black;
            this.txtGmail.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtGmail.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtGmail.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtGmail.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGmail.Location = new System.Drawing.Point(179, 334);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.PasswordChar = '\0';
            this.txtGmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGmail.PlaceholderText = "Gmail";
            this.txtGmail.SelectedText = "";
            this.txtGmail.Size = new System.Drawing.Size(295, 45);
            this.txtGmail.TabIndex = 35;
            // 
            // txtSDTTTNV
            // 
            this.txtSDTTTNV.BackColor = System.Drawing.Color.Transparent;
            this.txtSDTTTNV.BorderColor = System.Drawing.Color.Black;
            this.txtSDTTTNV.BorderRadius = 10;
            this.txtSDTTTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDTTTNV.DefaultText = "";
            this.txtSDTTTNV.Enabled = false;
            this.txtSDTTTNV.FillColor = System.Drawing.SystemColors.Window;
            this.txtSDTTTNV.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtSDTTTNV.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtSDTTTNV.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtSDTTTNV.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSDTTTNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTTTNV.ForeColor = System.Drawing.Color.Black;
            this.txtSDTTTNV.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtSDTTTNV.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtSDTTTNV.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtSDTTTNV.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSDTTTNV.Location = new System.Drawing.Point(179, 281);
            this.txtSDTTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTTTNV.Name = "txtSDTTTNV";
            this.txtSDTTTNV.PasswordChar = '\0';
            this.txtSDTTTNV.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSDTTTNV.PlaceholderText = "Số điện thoại";
            this.txtSDTTTNV.SelectedText = "";
            this.txtSDTTTNV.Size = new System.Drawing.Size(295, 45);
            this.txtSDTTTNV.TabIndex = 33;
            // 
            // lblSodt
            // 
            this.lblSodt.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodt.Location = new System.Drawing.Point(26, 344);
            this.lblSodt.Name = "lblSodt";
            this.lblSodt.Size = new System.Drawing.Size(166, 25);
            this.lblSodt.TabIndex = 30;
            this.lblSodt.Text = "Gmail:";
            this.lblSodt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(26, 291);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(166, 25);
            this.lblGioitinh.TabIndex = 29;
            this.lblGioitinh.Text = "Số điện thoại:";
            this.lblGioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(26, 237);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(166, 25);
            this.lblMatkhau.TabIndex = 28;
            this.lblMatkhau.Text = "Giới tính";
            this.lblMatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneCirclePictureBox5
            // 
            this.siticoneCirclePictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox5.Image")));
            this.siticoneCirclePictureBox5.ImageLocation = "";
            this.siticoneCirclePictureBox5.ImageRotate = 0F;
            this.siticoneCirclePictureBox5.Location = new System.Drawing.Point(492, 11);
            this.siticoneCirclePictureBox5.Name = "siticoneCirclePictureBox5";
            this.siticoneCirclePictureBox5.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox5.Size = new System.Drawing.Size(174, 200);
            this.siticoneCirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox5.TabIndex = 27;
            this.siticoneCirclePictureBox5.TabStop = false;
            // 
            // txtChucvuTTNV
            // 
            this.txtChucvuTTNV.BackColor = System.Drawing.Color.Transparent;
            this.txtChucvuTTNV.BorderColor = System.Drawing.Color.Black;
            this.txtChucvuTTNV.BorderRadius = 10;
            this.txtChucvuTTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChucvuTTNV.DefaultText = "";
            this.txtChucvuTTNV.Enabled = false;
            this.txtChucvuTTNV.FillColor = System.Drawing.SystemColors.Window;
            this.txtChucvuTTNV.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtChucvuTTNV.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtChucvuTTNV.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtChucvuTTNV.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtChucvuTTNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucvuTTNV.ForeColor = System.Drawing.Color.Black;
            this.txtChucvuTTNV.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtChucvuTTNV.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtChucvuTTNV.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtChucvuTTNV.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtChucvuTTNV.Location = new System.Drawing.Point(179, 117);
            this.txtChucvuTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucvuTTNV.Name = "txtChucvuTTNV";
            this.txtChucvuTTNV.PasswordChar = '\0';
            this.txtChucvuTTNV.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtChucvuTTNV.PlaceholderText = "Chức vụ";
            this.txtChucvuTTNV.SelectedText = "";
            this.txtChucvuTTNV.Size = new System.Drawing.Size(295, 45);
            this.txtChucvuTTNV.TabIndex = 26;
            // 
            // txtChiso
            // 
            this.txtChiso.BackColor = System.Drawing.Color.Transparent;
            this.txtChiso.BorderColor = System.Drawing.Color.Black;
            this.txtChiso.BorderRadius = 10;
            this.txtChiso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChiso.DefaultText = "";
            this.txtChiso.Enabled = false;
            this.txtChiso.FillColor = System.Drawing.SystemColors.Window;
            this.txtChiso.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtChiso.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtChiso.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtChiso.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtChiso.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiso.ForeColor = System.Drawing.Color.Black;
            this.txtChiso.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtChiso.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtChiso.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtChiso.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtChiso.Location = new System.Drawing.Point(179, 64);
            this.txtChiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtChiso.Name = "txtChiso";
            this.txtChiso.PasswordChar = '\0';
            this.txtChiso.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtChiso.PlaceholderText = "Họ Tên";
            this.txtChiso.SelectedText = "";
            this.txtChiso.Size = new System.Drawing.Size(295, 45);
            this.txtChiso.TabIndex = 25;
            // 
            // txtMachiso
            // 
            this.txtMachiso.BackColor = System.Drawing.Color.Transparent;
            this.txtMachiso.BorderColor = System.Drawing.Color.Black;
            this.txtMachiso.BorderRadius = 10;
            this.txtMachiso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMachiso.DefaultText = "";
            this.txtMachiso.Enabled = false;
            this.txtMachiso.FillColor = System.Drawing.SystemColors.Window;
            this.txtMachiso.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMachiso.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMachiso.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMachiso.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMachiso.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachiso.ForeColor = System.Drawing.Color.Black;
            this.txtMachiso.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMachiso.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMachiso.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMachiso.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMachiso.Location = new System.Drawing.Point(179, 11);
            this.txtMachiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtMachiso.Name = "txtMachiso";
            this.txtMachiso.PasswordChar = '\0';
            this.txtMachiso.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMachiso.PlaceholderText = "Mã chỉ số";
            this.txtMachiso.SelectedText = "";
            this.txtMachiso.Size = new System.Drawing.Size(295, 45);
            this.txtMachiso.TabIndex = 22;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(26, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(166, 25);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Ngày sinh:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChuc
            // 
            this.lblChuc.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuc.Location = new System.Drawing.Point(26, 127);
            this.lblChuc.Name = "lblChuc";
            this.lblChuc.Size = new System.Drawing.Size(166, 25);
            this.lblChuc.TabIndex = 23;
            this.lblChuc.Text = "Chức vụ:";
            this.lblChuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoten
            // 
            this.lblHoten.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(26, 73);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(166, 25);
            this.lblHoten.TabIndex = 21;
            this.lblHoten.Text = "Họ và tên:";
            this.lblHoten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMasonv
            // 
            this.lblMasonv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasonv.Location = new System.Drawing.Point(26, 20);
            this.lblMasonv.Name = "lblMasonv";
            this.lblMasonv.Size = new System.Drawing.Size(166, 25);
            this.lblMasonv.TabIndex = 36;
            this.lblMasonv.Text = "Mã nhân viên:";
            this.lblMasonv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTaiDSNV
            // 
            this.btnTaiDSNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnTaiDSNV.BorderRadius = 5;
            this.btnTaiDSNV.BorderThickness = 1;
            this.btnTaiDSNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiDSNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiDSNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiDSNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiDSNV.Enabled = false;
            this.btnTaiDSNV.FillColor = System.Drawing.Color.Transparent;
            this.btnTaiDSNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTaiDSNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaiDSNV.ForeColor = System.Drawing.Color.White;
            this.btnTaiDSNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTaiDSNV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTaiDSNV.Image = global::DuAnCNPM.Properties.Resources.diskette;
            this.btnTaiDSNV.ImageSize = new System.Drawing.Size(34, 34);
            this.btnTaiDSNV.Location = new System.Drawing.Point(824, 3);
            this.btnTaiDSNV.Name = "btnTaiDSNV";
            this.btnTaiDSNV.Size = new System.Drawing.Size(45, 45);
            this.btnTaiDSNV.TabIndex = 55;
            this.btnTaiDSNV.Click += new System.EventHandler(this.btnTaiDSNV_Click);
            // 
            // btnSuaDSNV
            // 
            this.btnSuaDSNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaDSNV.BorderRadius = 5;
            this.btnSuaDSNV.BorderThickness = 1;
            this.btnSuaDSNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaDSNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaDSNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaDSNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaDSNV.Enabled = false;
            this.btnSuaDSNV.FillColor = System.Drawing.Color.Transparent;
            this.btnSuaDSNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaDSNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaDSNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaDSNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaDSNV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaDSNV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDSNV.Image")));
            this.btnSuaDSNV.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSuaDSNV.Location = new System.Drawing.Point(924, 3);
            this.btnSuaDSNV.Name = "btnSuaDSNV";
            this.btnSuaDSNV.Size = new System.Drawing.Size(45, 45);
            this.btnSuaDSNV.TabIndex = 54;
            this.btnSuaDSNV.Click += new System.EventHandler(this.btnSuaDSNV_Click);
            // 
            // btnXoaDSNV
            // 
            this.btnXoaDSNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaDSNV.BorderRadius = 5;
            this.btnXoaDSNV.BorderThickness = 1;
            this.btnXoaDSNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDSNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDSNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaDSNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaDSNV.Enabled = false;
            this.btnXoaDSNV.FillColor = System.Drawing.Color.Transparent;
            this.btnXoaDSNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoaDSNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaDSNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDSNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaDSNV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaDSNV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDSNV.Image")));
            this.btnXoaDSNV.ImageSize = new System.Drawing.Size(35, 35);
            this.btnXoaDSNV.Location = new System.Drawing.Point(874, 3);
            this.btnXoaDSNV.Name = "btnXoaDSNV";
            this.btnXoaDSNV.Size = new System.Drawing.Size(45, 45);
            this.btnXoaDSNV.TabIndex = 53;
            this.btnXoaDSNV.Click += new System.EventHandler(this.btnXoaDSNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddNV.BorderRadius = 5;
            this.btnAddNV.BorderThickness = 1;
            this.btnAddNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNV.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNV.ForeColor = System.Drawing.Color.White;
            this.btnAddNV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNV.Image = global::DuAnCNPM.Properties.Resources.add;
            this.btnAddNV.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddNV.Location = new System.Drawing.Point(200, 3);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(39, 40);
            this.btnAddNV.TabIndex = 30;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnSortNV
            // 
            this.btnSortNV.BackColor = System.Drawing.Color.Transparent;
            this.btnSortNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnSortNV.BorderRadius = 5;
            this.btnSortNV.BorderThickness = 1;
            this.btnSortNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortNV.FillColor = System.Drawing.Color.Transparent;
            this.btnSortNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortNV.ForeColor = System.Drawing.Color.White;
            this.btnSortNV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortNV.Image = global::DuAnCNPM.Properties.Resources.sortGiam;
            this.btnSortNV.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSortNV.Location = new System.Drawing.Point(243, 3);
            this.btnSortNV.Name = "btnSortNV";
            this.btnSortNV.Size = new System.Drawing.Size(39, 40);
            this.btnSortNV.TabIndex = 29;
            this.btnSortNV.Click += new System.EventHandler(this.btnSortNV_Click);
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.AutoSize = false;
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(0, 0);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(282, 47);
            this.siticoneHtmlLabel7.TabIndex = 28;
            this.siticoneHtmlLabel7.Text = "Danh sách nhân viên";
            this.siticoneHtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTTNV
            // 
            this.lblTTNV.AutoSize = false;
            this.lblTTNV.BackColor = System.Drawing.Color.Transparent;
            this.lblTTNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTNV.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTTNV.Location = new System.Drawing.Point(323, 7);
            this.lblTTNV.Name = "lblTTNV";
            this.lblTTNV.Size = new System.Drawing.Size(410, 40);
            this.lblTTNV.TabIndex = 56;
            this.lblTTNV.Text = "Thông tin nhân viên";
            this.lblTTNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThemNV
            // 
            this.lblThemNV.AutoSize = false;
            this.lblThemNV.BackColor = System.Drawing.Color.Transparent;
            this.lblThemNV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemNV.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblThemNV.Location = new System.Drawing.Point(323, 8);
            this.lblThemNV.Name = "lblThemNV";
            this.lblThemNV.Size = new System.Drawing.Size(410, 40);
            this.lblThemNV.TabIndex = 57;
            this.lblThemNV.Text = "Thêm nhân viên";
            this.lblThemNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panDanhsachNV
            // 
            this.panDanhsachNV.AutoScroll = true;
            this.panDanhsachNV.BackColor = System.Drawing.Color.Transparent;
            this.panDanhsachNV.BorderColor = System.Drawing.Color.SeaGreen;
            this.panDanhsachNV.BorderRadius = 5;
            this.panDanhsachNV.BorderThickness = 1;
            this.panDanhsachNV.FillColor = System.Drawing.Color.White;
            this.panDanhsachNV.Location = new System.Drawing.Point(0, 49);
            this.panDanhsachNV.Name = "panDanhsachNV";
            this.panDanhsachNV.Size = new System.Drawing.Size(282, 426);
            this.panDanhsachNV.TabIndex = 31;
            // 
            // tabQLKH
            // 
            this.tabQLKH.BackColor = System.Drawing.Color.White;
            this.tabQLKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabQLKH.Controls.Add(this.btnAddKH);
            this.tabQLKH.Controls.Add(this.btnSortKH);
            this.tabQLKH.Controls.Add(this.panTTKHchitiet);
            this.tabQLKH.Controls.Add(this.btnLuuDSKH);
            this.tabQLKH.Controls.Add(this.btnSuaDSKH);
            this.tabQLKH.Controls.Add(this.btnXoaDSKH);
            this.tabQLKH.Controls.Add(this.panDSKH);
            this.tabQLKH.Controls.Add(this.lblDanhsachKH);
            this.tabQLKH.Controls.Add(this.lblThongtinKH);
            this.tabQLKH.Controls.Add(this.lblThemKH);
            this.tabQLKH.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabQLKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLKH.Location = new System.Drawing.Point(4, 44);
            this.tabQLKH.Name = "tabQLKH";
            this.tabQLKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLKH.Size = new System.Drawing.Size(972, 477);
            this.tabQLKH.TabIndex = 1;
            this.tabQLKH.Text = "Quản lý khách hàng";
            // 
            // btnAddKH
            // 
            this.btnAddKH.BackColor = System.Drawing.Color.Transparent;
            this.btnAddKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddKH.BorderRadius = 5;
            this.btnAddKH.BorderThickness = 1;
            this.btnAddKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddKH.FillColor = System.Drawing.Color.Transparent;
            this.btnAddKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddKH.ForeColor = System.Drawing.Color.White;
            this.btnAddKH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddKH.Image = global::DuAnCNPM.Properties.Resources.add;
            this.btnAddKH.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddKH.Location = new System.Drawing.Point(200, 6);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(39, 40);
            this.btnAddKH.TabIndex = 26;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnSortKH
            // 
            this.btnSortKH.BackColor = System.Drawing.Color.Transparent;
            this.btnSortKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnSortKH.BorderRadius = 5;
            this.btnSortKH.BorderThickness = 1;
            this.btnSortKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortKH.FillColor = System.Drawing.Color.Transparent;
            this.btnSortKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortKH.ForeColor = System.Drawing.Color.White;
            this.btnSortKH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortKH.Image = global::DuAnCNPM.Properties.Resources.sortGiam;
            this.btnSortKH.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSortKH.Location = new System.Drawing.Point(243, 6);
            this.btnSortKH.Name = "btnSortKH";
            this.btnSortKH.Size = new System.Drawing.Size(39, 40);
            this.btnSortKH.TabIndex = 25;
            this.btnSortKH.Click += new System.EventHandler(this.btnSortKH_Click);
            // 
            // panTTKHchitiet
            // 
            this.panTTKHchitiet.AutoScroll = true;
            this.panTTKHchitiet.BackColor = System.Drawing.Color.Transparent;
            this.panTTKHchitiet.BorderColor = System.Drawing.Color.LightBlue;
            this.panTTKHchitiet.BorderRadius = 8;
            this.panTTKHchitiet.Controls.Add(this.txtMST);
            this.panTTKHchitiet.Controls.Add(this.lblMasothue);
            this.panTTKHchitiet.Controls.Add(this.txtMaCty);
            this.panTTKHchitiet.Controls.Add(this.lblMasoct);
            this.panTTKHchitiet.Controls.Add(this.txtGmailCty);
            this.panTTKHchitiet.Controls.Add(this.lblGmailct);
            this.panTTKHchitiet.Controls.Add(this.txtSDTCty);
            this.panTTKHchitiet.Controls.Add(this.label1);
            this.panTTKHchitiet.Controls.Add(this.txtDiachiCty);
            this.panTTKHchitiet.Controls.Add(this.txtTenCty);
            this.panTTKHchitiet.Controls.Add(this.lblDiachi);
            this.panTTKHchitiet.Controls.Add(this.lblTenct);
            this.panTTKHchitiet.FillColor = System.Drawing.Color.White;
            this.panTTKHchitiet.FillColor2 = System.Drawing.Color.White;
            this.panTTKHchitiet.Location = new System.Drawing.Point(284, 49);
            this.panTTKHchitiet.Name = "panTTKHchitiet";
            this.panTTKHchitiet.Size = new System.Drawing.Size(688, 426);
            this.panTTKHchitiet.TabIndex = 59;
            // 
            // txtMST
            // 
            this.txtMST.BackColor = System.Drawing.Color.Transparent;
            this.txtMST.BorderColor = System.Drawing.Color.Black;
            this.txtMST.BorderRadius = 10;
            this.txtMST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMST.DefaultText = "";
            this.txtMST.Enabled = false;
            this.txtMST.FillColor = System.Drawing.SystemColors.Window;
            this.txtMST.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMST.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMST.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMST.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMST.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMST.ForeColor = System.Drawing.Color.Black;
            this.txtMST.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMST.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMST.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMST.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMST.Location = new System.Drawing.Point(197, 281);
            this.txtMST.Margin = new System.Windows.Forms.Padding(4);
            this.txtMST.Name = "txtMST";
            this.txtMST.PasswordChar = '\0';
            this.txtMST.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMST.PlaceholderText = "Mã số thuế";
            this.txtMST.SelectedText = "";
            this.txtMST.Size = new System.Drawing.Size(407, 45);
            this.txtMST.TabIndex = 39;
            // 
            // lblMasothue
            // 
            this.lblMasothue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasothue.Location = new System.Drawing.Point(28, 292);
            this.lblMasothue.Name = "lblMasothue";
            this.lblMasothue.Size = new System.Drawing.Size(165, 25);
            this.lblMasothue.TabIndex = 38;
            this.lblMasothue.Text = "Mã số thuế:";
            this.lblMasothue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaCty
            // 
            this.txtMaCty.BackColor = System.Drawing.Color.Transparent;
            this.txtMaCty.BorderColor = System.Drawing.Color.Black;
            this.txtMaCty.BorderRadius = 10;
            this.txtMaCty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCty.DefaultText = "";
            this.txtMaCty.Enabled = false;
            this.txtMaCty.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaCty.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMaCty.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMaCty.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaCty.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaCty.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCty.ForeColor = System.Drawing.Color.Black;
            this.txtMaCty.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaCty.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMaCty.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMaCty.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaCty.Location = new System.Drawing.Point(197, 16);
            this.txtMaCty.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCty.Name = "txtMaCty";
            this.txtMaCty.PasswordChar = '\0';
            this.txtMaCty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaCty.PlaceholderText = "Mã công ty";
            this.txtMaCty.SelectedText = "";
            this.txtMaCty.Size = new System.Drawing.Size(407, 45);
            this.txtMaCty.TabIndex = 37;
            // 
            // lblMasoct
            // 
            this.lblMasoct.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasoct.Location = new System.Drawing.Point(27, 26);
            this.lblMasoct.Name = "lblMasoct";
            this.lblMasoct.Size = new System.Drawing.Size(165, 25);
            this.lblMasoct.TabIndex = 36;
            this.lblMasoct.Text = "Mã công ty:";
            this.lblMasoct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGmailCty
            // 
            this.txtGmailCty.BackColor = System.Drawing.Color.Transparent;
            this.txtGmailCty.BorderColor = System.Drawing.Color.Black;
            this.txtGmailCty.BorderRadius = 10;
            this.txtGmailCty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmailCty.DefaultText = "";
            this.txtGmailCty.Enabled = false;
            this.txtGmailCty.FillColor = System.Drawing.SystemColors.Window;
            this.txtGmailCty.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtGmailCty.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtGmailCty.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtGmailCty.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGmailCty.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmailCty.ForeColor = System.Drawing.Color.Black;
            this.txtGmailCty.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtGmailCty.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtGmailCty.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtGmailCty.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGmailCty.Location = new System.Drawing.Point(197, 228);
            this.txtGmailCty.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmailCty.Name = "txtGmailCty";
            this.txtGmailCty.PasswordChar = '\0';
            this.txtGmailCty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGmailCty.PlaceholderText = "Gmail";
            this.txtGmailCty.SelectedText = "";
            this.txtGmailCty.Size = new System.Drawing.Size(407, 45);
            this.txtGmailCty.TabIndex = 35;
            // 
            // lblGmailct
            // 
            this.lblGmailct.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmailct.Location = new System.Drawing.Point(27, 239);
            this.lblGmailct.Name = "lblGmailct";
            this.lblGmailct.Size = new System.Drawing.Size(165, 25);
            this.lblGmailct.TabIndex = 34;
            this.lblGmailct.Text = "Gmail:";
            this.lblGmailct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSDTCty
            // 
            this.txtSDTCty.BackColor = System.Drawing.Color.Transparent;
            this.txtSDTCty.BorderColor = System.Drawing.Color.Black;
            this.txtSDTCty.BorderRadius = 10;
            this.txtSDTCty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDTCty.DefaultText = "";
            this.txtSDTCty.Enabled = false;
            this.txtSDTCty.FillColor = System.Drawing.SystemColors.Window;
            this.txtSDTCty.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtSDTCty.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtSDTCty.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtSDTCty.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSDTCty.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTCty.ForeColor = System.Drawing.Color.Black;
            this.txtSDTCty.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtSDTCty.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtSDTCty.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtSDTCty.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSDTCty.Location = new System.Drawing.Point(197, 175);
            this.txtSDTCty.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTCty.Name = "txtSDTCty";
            this.txtSDTCty.PasswordChar = '\0';
            this.txtSDTCty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSDTCty.PlaceholderText = "Số điện thoại";
            this.txtSDTCty.SelectedText = "";
            this.txtSDTCty.Size = new System.Drawing.Size(407, 45);
            this.txtSDTCty.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Số điện thoại:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiachiCty
            // 
            this.txtDiachiCty.BackColor = System.Drawing.Color.Transparent;
            this.txtDiachiCty.BorderColor = System.Drawing.Color.Black;
            this.txtDiachiCty.BorderRadius = 10;
            this.txtDiachiCty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachiCty.DefaultText = "";
            this.txtDiachiCty.Enabled = false;
            this.txtDiachiCty.FillColor = System.Drawing.SystemColors.Window;
            this.txtDiachiCty.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtDiachiCty.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtDiachiCty.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtDiachiCty.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDiachiCty.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachiCty.ForeColor = System.Drawing.Color.Black;
            this.txtDiachiCty.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtDiachiCty.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtDiachiCty.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtDiachiCty.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiachiCty.Location = new System.Drawing.Point(197, 122);
            this.txtDiachiCty.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachiCty.Name = "txtDiachiCty";
            this.txtDiachiCty.PasswordChar = '\0';
            this.txtDiachiCty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiachiCty.PlaceholderText = "Địa chỉ";
            this.txtDiachiCty.SelectedText = "";
            this.txtDiachiCty.Size = new System.Drawing.Size(407, 45);
            this.txtDiachiCty.TabIndex = 25;
            // 
            // txtTenCty
            // 
            this.txtTenCty.BackColor = System.Drawing.Color.Transparent;
            this.txtTenCty.BorderColor = System.Drawing.Color.Black;
            this.txtTenCty.BorderRadius = 10;
            this.txtTenCty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCty.DefaultText = "";
            this.txtTenCty.Enabled = false;
            this.txtTenCty.FillColor = System.Drawing.SystemColors.Window;
            this.txtTenCty.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtTenCty.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtTenCty.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTenCty.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenCty.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCty.ForeColor = System.Drawing.Color.Black;
            this.txtTenCty.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtTenCty.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtTenCty.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtTenCty.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenCty.Location = new System.Drawing.Point(197, 69);
            this.txtTenCty.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCty.Name = "txtTenCty";
            this.txtTenCty.PasswordChar = '\0';
            this.txtTenCty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenCty.PlaceholderText = "Tên công ty";
            this.txtTenCty.SelectedText = "";
            this.txtTenCty.Size = new System.Drawing.Size(407, 45);
            this.txtTenCty.TabIndex = 22;
            // 
            // lblDiachi
            // 
            this.lblDiachi.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(28, 133);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(165, 25);
            this.lblDiachi.TabIndex = 23;
            this.lblDiachi.Text = "Địa chỉ:";
            this.lblDiachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenct
            // 
            this.lblTenct.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenct.Location = new System.Drawing.Point(28, 80);
            this.lblTenct.Name = "lblTenct";
            this.lblTenct.Size = new System.Drawing.Size(165, 25);
            this.lblTenct.TabIndex = 21;
            this.lblTenct.Text = "Tên công ty:";
            this.lblTenct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLuuDSKH
            // 
            this.btnLuuDSKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuuDSKH.BorderRadius = 5;
            this.btnLuuDSKH.BorderThickness = 1;
            this.btnLuuDSKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuDSKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuDSKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuDSKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuDSKH.Enabled = false;
            this.btnLuuDSKH.FillColor = System.Drawing.Color.Transparent;
            this.btnLuuDSKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuuDSKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuDSKH.ForeColor = System.Drawing.Color.White;
            this.btnLuuDSKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuDSKH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuDSKH.Image = global::DuAnCNPM.Properties.Resources.diskette;
            this.btnLuuDSKH.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLuuDSKH.Location = new System.Drawing.Point(823, 3);
            this.btnLuuDSKH.Name = "btnLuuDSKH";
            this.btnLuuDSKH.Size = new System.Drawing.Size(45, 45);
            this.btnLuuDSKH.TabIndex = 57;
            this.btnLuuDSKH.Click += new System.EventHandler(this.btnLuuDSKH_Click);
            // 
            // btnSuaDSKH
            // 
            this.btnSuaDSKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaDSKH.BorderRadius = 5;
            this.btnSuaDSKH.BorderThickness = 1;
            this.btnSuaDSKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaDSKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaDSKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaDSKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaDSKH.Enabled = false;
            this.btnSuaDSKH.FillColor = System.Drawing.Color.Transparent;
            this.btnSuaDSKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaDSKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaDSKH.ForeColor = System.Drawing.Color.White;
            this.btnSuaDSKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaDSKH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaDSKH.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDSKH.Image")));
            this.btnSuaDSKH.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSuaDSKH.Location = new System.Drawing.Point(923, 3);
            this.btnSuaDSKH.Name = "btnSuaDSKH";
            this.btnSuaDSKH.Size = new System.Drawing.Size(45, 45);
            this.btnSuaDSKH.TabIndex = 55;
            this.btnSuaDSKH.Click += new System.EventHandler(this.btnSuaDSKH_Click);
            // 
            // btnXoaDSKH
            // 
            this.btnXoaDSKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaDSKH.BorderRadius = 5;
            this.btnXoaDSKH.BorderThickness = 1;
            this.btnXoaDSKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDSKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaDSKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaDSKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaDSKH.Enabled = false;
            this.btnXoaDSKH.FillColor = System.Drawing.Color.Transparent;
            this.btnXoaDSKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoaDSKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaDSKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaDSKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaDSKH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaDSKH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDSKH.Image")));
            this.btnXoaDSKH.ImageSize = new System.Drawing.Size(35, 35);
            this.btnXoaDSKH.Location = new System.Drawing.Point(873, 3);
            this.btnXoaDSKH.Name = "btnXoaDSKH";
            this.btnXoaDSKH.Size = new System.Drawing.Size(45, 45);
            this.btnXoaDSKH.TabIndex = 54;
            this.btnXoaDSKH.Click += new System.EventHandler(this.btnXoaDSKH_Click);
            // 
            // panDSKH
            // 
            this.panDSKH.AutoScroll = true;
            this.panDSKH.BackColor = System.Drawing.Color.Transparent;
            this.panDSKH.BorderColor = System.Drawing.Color.SeaGreen;
            this.panDSKH.BorderRadius = 5;
            this.panDSKH.BorderThickness = 1;
            this.panDSKH.FillColor = System.Drawing.Color.White;
            this.panDSKH.Location = new System.Drawing.Point(0, 49);
            this.panDSKH.Name = "panDSKH";
            this.panDSKH.Size = new System.Drawing.Size(282, 426);
            this.panDSKH.TabIndex = 32;
            // 
            // lblDanhsachKH
            // 
            this.lblDanhsachKH.AutoSize = false;
            this.lblDanhsachKH.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhsachKH.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsachKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDanhsachKH.Location = new System.Drawing.Point(2, 1);
            this.lblDanhsachKH.Name = "lblDanhsachKH";
            this.lblDanhsachKH.Size = new System.Drawing.Size(280, 47);
            this.lblDanhsachKH.TabIndex = 24;
            this.lblDanhsachKH.Text = "Danh sách khách hàng";
            this.lblDanhsachKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThongtinKH
            // 
            this.lblThongtinKH.AutoSize = false;
            this.lblThongtinKH.BackColor = System.Drawing.Color.Transparent;
            this.lblThongtinKH.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinKH.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblThongtinKH.Location = new System.Drawing.Point(321, 8);
            this.lblThongtinKH.Name = "lblThongtinKH";
            this.lblThongtinKH.Size = new System.Drawing.Size(412, 40);
            this.lblThongtinKH.TabIndex = 56;
            this.lblThongtinKH.Text = "Thông tin khách hàng";
            this.lblThongtinKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThemKH
            // 
            this.lblThemKH.AutoSize = false;
            this.lblThemKH.BackColor = System.Drawing.Color.Transparent;
            this.lblThemKH.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemKH.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblThemKH.Location = new System.Drawing.Point(321, 6);
            this.lblThemKH.Name = "lblThemKH";
            this.lblThemKH.Size = new System.Drawing.Size(412, 40);
            this.lblThemKH.TabIndex = 58;
            this.lblThemKH.Text = "Thêm khách hàng";
            this.lblThemKH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabQLHD
            // 
            this.tabQLHD.AutoScroll = true;
            this.tabQLHD.BackColor = System.Drawing.Color.White;
            this.tabQLHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabQLHD.Controls.Add(this.panDSHD);
            this.tabQLHD.Controls.Add(this.btnAddHD);
            this.tabQLHD.Controls.Add(this.btnSortHD);
            this.tabQLHD.Controls.Add(this.panTTHDchitiet);
            this.tabQLHD.Controls.Add(this.btnLuuHD);
            this.tabQLHD.Controls.Add(this.btnSuaHD);
            this.tabQLHD.Controls.Add(this.btnXoaHD);
            this.tabQLHD.Controls.Add(this.lblTTHD);
            this.tabQLHD.Controls.Add(this.lblThemHD);
            this.tabQLHD.Controls.Add(this.lblDSHD);
            this.tabQLHD.Controls.Add(this.siticoneButton4);
            this.tabQLHD.Controls.Add(this.siticoneButton5);
            this.tabQLHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLHD.Location = new System.Drawing.Point(4, 44);
            this.tabQLHD.Name = "tabQLHD";
            this.tabQLHD.Size = new System.Drawing.Size(972, 477);
            this.tabQLHD.TabIndex = 2;
            this.tabQLHD.Text = "Quản lý hợp đồng";
            // 
            // panDSHD
            // 
            this.panDSHD.AutoScroll = true;
            this.panDSHD.BackColor = System.Drawing.Color.Transparent;
            this.panDSHD.BorderColor = System.Drawing.Color.SeaGreen;
            this.panDSHD.BorderRadius = 5;
            this.panDSHD.BorderThickness = 1;
            this.panDSHD.FillColor = System.Drawing.Color.White;
            this.panDSHD.Location = new System.Drawing.Point(0, 48);
            this.panDSHD.Name = "panDSHD";
            this.panDSHD.Size = new System.Drawing.Size(282, 426);
            this.panDSHD.TabIndex = 50;
            // 
            // btnAddHD
            // 
            this.btnAddHD.BackColor = System.Drawing.Color.Transparent;
            this.btnAddHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddHD.BorderRadius = 5;
            this.btnAddHD.BorderThickness = 1;
            this.btnAddHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddHD.FillColor = System.Drawing.Color.Transparent;
            this.btnAddHD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddHD.ForeColor = System.Drawing.Color.White;
            this.btnAddHD.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddHD.Image = global::DuAnCNPM.Properties.Resources.add;
            this.btnAddHD.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddHD.Location = new System.Drawing.Point(198, 5);
            this.btnAddHD.Name = "btnAddHD";
            this.btnAddHD.Size = new System.Drawing.Size(39, 40);
            this.btnAddHD.TabIndex = 59;
            this.btnAddHD.Click += new System.EventHandler(this.btnAddHD_Click);
            // 
            // btnSortHD
            // 
            this.btnSortHD.BackColor = System.Drawing.Color.Transparent;
            this.btnSortHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnSortHD.BorderRadius = 5;
            this.btnSortHD.BorderThickness = 1;
            this.btnSortHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortHD.FillColor = System.Drawing.Color.Transparent;
            this.btnSortHD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortHD.ForeColor = System.Drawing.Color.White;
            this.btnSortHD.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortHD.Image = global::DuAnCNPM.Properties.Resources.sortGiam;
            this.btnSortHD.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSortHD.Location = new System.Drawing.Point(241, 5);
            this.btnSortHD.Name = "btnSortHD";
            this.btnSortHD.Size = new System.Drawing.Size(39, 40);
            this.btnSortHD.TabIndex = 58;
            this.btnSortHD.Click += new System.EventHandler(this.btnSortHD_Click);
            // 
            // panTTHDchitiet
            // 
            this.panTTHDchitiet.AutoScroll = true;
            this.panTTHDchitiet.BackColor = System.Drawing.Color.Transparent;
            this.panTTHDchitiet.BorderColor = System.Drawing.Color.LightBlue;
            this.panTTHDchitiet.BorderRadius = 8;
            this.panTTHDchitiet.Controls.Add(this.dtpNgaytraKQQLHD);
            this.panTTHDchitiet.Controls.Add(this.dtpNgaykyQLHD);
            this.panTTHDchitiet.Controls.Add(this.panCSchitiet);
            this.panTTHDchitiet.Controls.Add(this.txtSotien);
            this.panTTHDchitiet.Controls.Add(this.txtMaHDQLHD);
            this.panTTHDchitiet.Controls.Add(this.txtMaNVQLHD);
            this.panTTHDchitiet.Controls.Add(this.txtMaCtyQLHD);
            this.panTTHDchitiet.Controls.Add(this.lblSomoney);
            this.panTTHDchitiet.Controls.Add(this.lblDategiao);
            this.panTTHDchitiet.Controls.Add(this.lblDateky);
            this.panTTHDchitiet.Controls.Add(this.lblMasnv);
            this.panTTHDchitiet.Controls.Add(this.lblMact);
            this.panTTHDchitiet.Controls.Add(this.lblMahd);
            this.panTTHDchitiet.FillColor = System.Drawing.Color.White;
            this.panTTHDchitiet.FillColor2 = System.Drawing.Color.White;
            this.panTTHDchitiet.Location = new System.Drawing.Point(284, 48);
            this.panTTHDchitiet.Name = "panTTHDchitiet";
            this.panTTHDchitiet.Size = new System.Drawing.Size(688, 426);
            this.panTTHDchitiet.TabIndex = 57;
            // 
            // dtpNgaytraKQQLHD
            // 
            this.dtpNgaytraKQQLHD.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgaytraKQQLHD.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.dtpNgaytraKQQLHD.BorderRadius = 10;
            this.dtpNgaytraKQQLHD.BorderThickness = 1;
            this.dtpNgaytraKQQLHD.CausesValidation = false;
            this.dtpNgaytraKQQLHD.Checked = true;
            this.dtpNgaytraKQQLHD.Enabled = false;
            this.dtpNgaytraKQQLHD.FillColor = System.Drawing.Color.Honeydew;
            this.dtpNgaytraKQQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaytraKQQLHD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaytraKQQLHD.Location = new System.Drawing.Point(238, 234);
            this.dtpNgaytraKQQLHD.MaxDate = new System.DateTime(2031, 1, 4, 0, 0, 0, 0);
            this.dtpNgaytraKQQLHD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaytraKQQLHD.Name = "dtpNgaytraKQQLHD";
            this.dtpNgaytraKQQLHD.Size = new System.Drawing.Size(407, 45);
            this.dtpNgaytraKQQLHD.TabIndex = 59;
            this.dtpNgaytraKQQLHD.Value = new System.DateTime(2025, 3, 28, 1, 18, 56, 808);
            // 
            // dtpNgaykyQLHD
            // 
            this.dtpNgaykyQLHD.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgaykyQLHD.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.dtpNgaykyQLHD.BorderRadius = 10;
            this.dtpNgaykyQLHD.BorderThickness = 1;
            this.dtpNgaykyQLHD.CausesValidation = false;
            this.dtpNgaykyQLHD.Checked = true;
            this.dtpNgaykyQLHD.Enabled = false;
            this.dtpNgaykyQLHD.FillColor = System.Drawing.Color.Honeydew;
            this.dtpNgaykyQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaykyQLHD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaykyQLHD.Location = new System.Drawing.Point(238, 181);
            this.dtpNgaykyQLHD.MaxDate = new System.DateTime(2030, 12, 28, 0, 0, 0, 0);
            this.dtpNgaykyQLHD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaykyQLHD.Name = "dtpNgaykyQLHD";
            this.dtpNgaykyQLHD.Size = new System.Drawing.Size(407, 45);
            this.dtpNgaykyQLHD.TabIndex = 58;
            this.dtpNgaykyQLHD.Value = new System.DateTime(2025, 3, 28, 1, 18, 56, 808);
            // 
            // panCSchitiet
            // 
            this.panCSchitiet.AutoScroll = true;
            this.panCSchitiet.AutoSize = true;
            this.panCSchitiet.BackColor = System.Drawing.Color.Transparent;
            this.panCSchitiet.BorderColor = System.Drawing.Color.LightBlue;
            this.panCSchitiet.BorderRadius = 8;
            this.panCSchitiet.Controls.Add(this.dtpNgaynhapQLHD);
            this.panCSchitiet.Controls.Add(this.btnSuaChiSoChiTiet);
            this.panCSchitiet.Controls.Add(this.grpDulieuTS);
            this.panCSchitiet.Controls.Add(this.btnLuuCSchitiet);
            this.panCSchitiet.Controls.Add(this.siticoneHtmlLabel12);
            this.panCSchitiet.Controls.Add(this.lblTSchitiet);
            this.panCSchitiet.Controls.Add(this.txtGhiChuQLHD);
            this.panCSchitiet.Controls.Add(this.label2);
            this.panCSchitiet.Controls.Add(this.txtTenCS);
            this.panCSchitiet.Controls.Add(this.txtMaNVnhap);
            this.panCSchitiet.Controls.Add(this.txtMaCSQLHD);
            this.panCSchitiet.Controls.Add(this.lblDatenhap);
            this.panCSchitiet.Controls.Add(this.lblThongso);
            this.panCSchitiet.Controls.Add(this.label3);
            this.panCSchitiet.Controls.Add(this.lblMathongso);
            this.panCSchitiet.Controls.Add(this.btnXoaChiSoChiTiet);
            this.panCSchitiet.Location = new System.Drawing.Point(0, 338);
            this.panCSchitiet.Name = "panCSchitiet";
            this.panCSchitiet.Size = new System.Drawing.Size(683, 561);
            this.panCSchitiet.TabIndex = 57;
            // 
            // dtpNgaynhapQLHD
            // 
            this.dtpNgaynhapQLHD.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgaynhapQLHD.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.dtpNgaynhapQLHD.BorderRadius = 10;
            this.dtpNgaynhapQLHD.BorderThickness = 1;
            this.dtpNgaynhapQLHD.CausesValidation = false;
            this.dtpNgaynhapQLHD.Checked = true;
            this.dtpNgaynhapQLHD.Enabled = false;
            this.dtpNgaynhapQLHD.FillColor = System.Drawing.Color.Honeydew;
            this.dtpNgaynhapQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaynhapQLHD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaynhapQLHD.Location = new System.Drawing.Point(238, 209);
            this.dtpNgaynhapQLHD.MaxDate = new System.DateTime(2030, 12, 28, 0, 0, 0, 0);
            this.dtpNgaynhapQLHD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaynhapQLHD.Name = "dtpNgaynhapQLHD";
            this.dtpNgaynhapQLHD.Size = new System.Drawing.Size(407, 45);
            this.dtpNgaynhapQLHD.TabIndex = 60;
            this.dtpNgaynhapQLHD.Value = new System.DateTime(2025, 3, 28, 1, 18, 56, 808);
            // 
            // btnSuaChiSoChiTiet
            // 
            this.btnSuaChiSoChiTiet.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaChiSoChiTiet.BorderRadius = 5;
            this.btnSuaChiSoChiTiet.BorderThickness = 1;
            this.btnSuaChiSoChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaChiSoChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaChiSoChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaChiSoChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaChiSoChiTiet.Enabled = false;
            this.btnSuaChiSoChiTiet.FillColor = System.Drawing.Color.Transparent;
            this.btnSuaChiSoChiTiet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaChiSoChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaChiSoChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnSuaChiSoChiTiet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaChiSoChiTiet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaChiSoChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaChiSoChiTiet.Image")));
            this.btnSuaChiSoChiTiet.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSuaChiSoChiTiet.Location = new System.Drawing.Point(593, 3);
            this.btnSuaChiSoChiTiet.Name = "btnSuaChiSoChiTiet";
            this.btnSuaChiSoChiTiet.Size = new System.Drawing.Size(45, 45);
            this.btnSuaChiSoChiTiet.TabIndex = 52;
            // 
            // grpDulieuTS
            // 
            this.grpDulieuTS.Controls.Add(this.lvDulieuTS);
            this.grpDulieuTS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDulieuTS.Location = new System.Drawing.Point(10, 312);
            this.grpDulieuTS.Name = "grpDulieuTS";
            this.grpDulieuTS.Size = new System.Drawing.Size(650, 246);
            this.grpDulieuTS.TabIndex = 43;
            this.grpDulieuTS.TabStop = false;
            this.grpDulieuTS.Text = "Dữ liệu thông số";
            // 
            // lvDulieuTS
            // 
            this.lvDulieuTS.BackColor = System.Drawing.Color.Honeydew;
            this.lvDulieuTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDulieuTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDulieuTS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDulieuTS.ForeColor = System.Drawing.Color.Black;
            this.lvDulieuTS.FullRowSelect = true;
            this.lvDulieuTS.GridLines = true;
            this.lvDulieuTS.HideSelection = false;
            this.lvDulieuTS.Location = new System.Drawing.Point(3, 25);
            this.lvDulieuTS.Name = "lvDulieuTS";
            this.lvDulieuTS.Size = new System.Drawing.Size(644, 218);
            this.lvDulieuTS.TabIndex = 1;
            this.lvDulieuTS.TileSize = new System.Drawing.Size(300, 40);
            this.lvDulieuTS.UseCompatibleStateImageBehavior = false;
            this.lvDulieuTS.View = System.Windows.Forms.View.Details;
            this.lvDulieuTS.SelectedIndexChanged += new System.EventHandler(this.lvDulieuTS_SelectedIndexChanged);
            // 
            // btnLuuCSchitiet
            // 
            this.btnLuuCSchitiet.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuuCSchitiet.BorderRadius = 5;
            this.btnLuuCSchitiet.BorderThickness = 1;
            this.btnLuuCSchitiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuCSchitiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuCSchitiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuCSchitiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuCSchitiet.Enabled = false;
            this.btnLuuCSchitiet.FillColor = System.Drawing.Color.Transparent;
            this.btnLuuCSchitiet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuuCSchitiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuCSchitiet.ForeColor = System.Drawing.Color.White;
            this.btnLuuCSchitiet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuCSchitiet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuCSchitiet.Image = global::DuAnCNPM.Properties.Resources.diskette;
            this.btnLuuCSchitiet.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLuuCSchitiet.Location = new System.Drawing.Point(491, 3);
            this.btnLuuCSchitiet.Name = "btnLuuCSchitiet";
            this.btnLuuCSchitiet.Size = new System.Drawing.Size(45, 45);
            this.btnLuuCSchitiet.TabIndex = 42;
            // 
            // siticoneHtmlLabel12
            // 
            this.siticoneHtmlLabel12.AutoSize = false;
            this.siticoneHtmlLabel12.BackColor = System.Drawing.Color.Black;
            this.siticoneHtmlLabel12.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.siticoneHtmlLabel12.Location = new System.Drawing.Point(25, 48);
            this.siticoneHtmlLabel12.Name = "siticoneHtmlLabel12";
            this.siticoneHtmlLabel12.Size = new System.Drawing.Size(650, 2);
            this.siticoneHtmlLabel12.TabIndex = 41;
            this.siticoneHtmlLabel12.Text = null;
            this.siticoneHtmlLabel12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTSchitiet
            // 
            this.lblTSchitiet.AutoSize = false;
            this.lblTSchitiet.BackColor = System.Drawing.Color.Transparent;
            this.lblTSchitiet.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSchitiet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTSchitiet.Location = new System.Drawing.Point(48, 0);
            this.lblTSchitiet.Name = "lblTSchitiet";
            this.lblTSchitiet.Size = new System.Drawing.Size(308, 51);
            this.lblTSchitiet.TabIndex = 40;
            this.lblTSchitiet.Text = "Thông số chi tiết";
            this.lblTSchitiet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGhiChuQLHD
            // 
            this.txtGhiChuQLHD.BackColor = System.Drawing.Color.Transparent;
            this.txtGhiChuQLHD.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.txtGhiChuQLHD.BorderRadius = 10;
            this.txtGhiChuQLHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChuQLHD.DefaultText = "";
            this.txtGhiChuQLHD.Enabled = false;
            this.txtGhiChuQLHD.FillColor = System.Drawing.SystemColors.Window;
            this.txtGhiChuQLHD.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtGhiChuQLHD.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtGhiChuQLHD.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChuQLHD.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGhiChuQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChuQLHD.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChuQLHD.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtGhiChuQLHD.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtGhiChuQLHD.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChuQLHD.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGhiChuQLHD.Location = new System.Drawing.Point(238, 260);
            this.txtGhiChuQLHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChuQLHD.Name = "txtGhiChuQLHD";
            this.txtGhiChuQLHD.PasswordChar = '\0';
            this.txtGhiChuQLHD.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGhiChuQLHD.PlaceholderText = "Ghi chú";
            this.txtGhiChuQLHD.SelectedText = "";
            this.txtGhiChuQLHD.Size = new System.Drawing.Size(407, 45);
            this.txtGhiChuQLHD.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ghi chú:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenCS
            // 
            this.txtTenCS.BackColor = System.Drawing.Color.Transparent;
            this.txtTenCS.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.txtTenCS.BorderRadius = 10;
            this.txtTenCS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCS.DefaultText = "";
            this.txtTenCS.Enabled = false;
            this.txtTenCS.FillColor = System.Drawing.SystemColors.Window;
            this.txtTenCS.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtTenCS.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtTenCS.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTenCS.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenCS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCS.ForeColor = System.Drawing.Color.Black;
            this.txtTenCS.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtTenCS.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtTenCS.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtTenCS.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenCS.Location = new System.Drawing.Point(238, 158);
            this.txtTenCS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenCS.Name = "txtTenCS";
            this.txtTenCS.PasswordChar = '\0';
            this.txtTenCS.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenCS.PlaceholderText = "Thông số";
            this.txtTenCS.SelectedText = "";
            this.txtTenCS.Size = new System.Drawing.Size(407, 45);
            this.txtTenCS.TabIndex = 26;
            // 
            // txtMaNVnhap
            // 
            this.txtMaNVnhap.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNVnhap.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.txtMaNVnhap.BorderRadius = 10;
            this.txtMaNVnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNVnhap.DefaultText = "";
            this.txtMaNVnhap.Enabled = false;
            this.txtMaNVnhap.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaNVnhap.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMaNVnhap.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMaNVnhap.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaNVnhap.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaNVnhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVnhap.ForeColor = System.Drawing.Color.Black;
            this.txtMaNVnhap.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaNVnhap.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMaNVnhap.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMaNVnhap.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaNVnhap.Location = new System.Drawing.Point(238, 107);
            this.txtMaNVnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNVnhap.Name = "txtMaNVnhap";
            this.txtMaNVnhap.PasswordChar = '\0';
            this.txtMaNVnhap.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaNVnhap.PlaceholderText = "Mã nhân viên nhập";
            this.txtMaNVnhap.SelectedText = "";
            this.txtMaNVnhap.Size = new System.Drawing.Size(407, 45);
            this.txtMaNVnhap.TabIndex = 25;
            // 
            // txtMaCSQLHD
            // 
            this.txtMaCSQLHD.BackColor = System.Drawing.Color.Transparent;
            this.txtMaCSQLHD.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.txtMaCSQLHD.BorderRadius = 10;
            this.txtMaCSQLHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCSQLHD.DefaultText = "";
            this.txtMaCSQLHD.Enabled = false;
            this.txtMaCSQLHD.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaCSQLHD.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMaCSQLHD.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMaCSQLHD.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaCSQLHD.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaCSQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCSQLHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaCSQLHD.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaCSQLHD.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMaCSQLHD.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMaCSQLHD.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaCSQLHD.Location = new System.Drawing.Point(238, 56);
            this.txtMaCSQLHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaCSQLHD.Name = "txtMaCSQLHD";
            this.txtMaCSQLHD.PasswordChar = '\0';
            this.txtMaCSQLHD.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaCSQLHD.PlaceholderText = "Mã chỉ số";
            this.txtMaCSQLHD.SelectedText = "";
            this.txtMaCSQLHD.Size = new System.Drawing.Size(407, 45);
            this.txtMaCSQLHD.TabIndex = 22;
            // 
            // lblDatenhap
            // 
            this.lblDatenhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatenhap.Location = new System.Drawing.Point(59, 220);
            this.lblDatenhap.Name = "lblDatenhap";
            this.lblDatenhap.Size = new System.Drawing.Size(200, 25);
            this.lblDatenhap.TabIndex = 24;
            this.lblDatenhap.Text = "Ngày nhập:";
            this.lblDatenhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThongso
            // 
            this.lblThongso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongso.Location = new System.Drawing.Point(59, 168);
            this.lblThongso.Name = "lblThongso";
            this.lblThongso.Size = new System.Drawing.Size(200, 25);
            this.lblThongso.TabIndex = 23;
            this.lblThongso.Text = "Thông số:";
            this.lblThongso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã nhân viên nhập:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMathongso
            // 
            this.lblMathongso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathongso.Location = new System.Drawing.Point(59, 66);
            this.lblMathongso.Name = "lblMathongso";
            this.lblMathongso.Size = new System.Drawing.Size(200, 25);
            this.lblMathongso.TabIndex = 36;
            this.lblMathongso.Text = "Mã thông số:";
            this.lblMathongso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXoaChiSoChiTiet
            // 
            this.btnXoaChiSoChiTiet.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaChiSoChiTiet.BorderRadius = 5;
            this.btnXoaChiSoChiTiet.BorderThickness = 1;
            this.btnXoaChiSoChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaChiSoChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaChiSoChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaChiSoChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaChiSoChiTiet.Enabled = false;
            this.btnXoaChiSoChiTiet.FillColor = System.Drawing.Color.Transparent;
            this.btnXoaChiSoChiTiet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoaChiSoChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaChiSoChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXoaChiSoChiTiet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaChiSoChiTiet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaChiSoChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaChiSoChiTiet.Image")));
            this.btnXoaChiSoChiTiet.ImageSize = new System.Drawing.Size(35, 35);
            this.btnXoaChiSoChiTiet.Location = new System.Drawing.Point(542, 3);
            this.btnXoaChiSoChiTiet.Name = "btnXoaChiSoChiTiet";
            this.btnXoaChiSoChiTiet.Size = new System.Drawing.Size(45, 45);
            this.btnXoaChiSoChiTiet.TabIndex = 52;
            // 
            // txtSotien
            // 
            this.txtSotien.BackColor = System.Drawing.Color.Transparent;
            this.txtSotien.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.txtSotien.BorderRadius = 10;
            this.txtSotien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSotien.DefaultText = "";
            this.txtSotien.Enabled = false;
            this.txtSotien.FillColor = System.Drawing.SystemColors.Window;
            this.txtSotien.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtSotien.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtSotien.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtSotien.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSotien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSotien.ForeColor = System.Drawing.Color.Black;
            this.txtSotien.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtSotien.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtSotien.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtSotien.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSotien.Location = new System.Drawing.Point(238, 287);
            this.txtSotien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.PasswordChar = '\0';
            this.txtSotien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSotien.PlaceholderText = "Số tiền";
            this.txtSotien.SelectedText = "";
            this.txtSotien.Size = new System.Drawing.Size(407, 45);
            this.txtSotien.TabIndex = 49;
            // 
            // txtMaHDQLHD
            // 
            this.txtMaHDQLHD.BackColor = System.Drawing.Color.Transparent;
            this.txtMaHDQLHD.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.txtMaHDQLHD.BorderRadius = 10;
            this.txtMaHDQLHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHDQLHD.DefaultText = "";
            this.txtMaHDQLHD.Enabled = false;
            this.txtMaHDQLHD.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaHDQLHD.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMaHDQLHD.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMaHDQLHD.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaHDQLHD.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaHDQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDQLHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaHDQLHD.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaHDQLHD.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMaHDQLHD.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMaHDQLHD.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaHDQLHD.Location = new System.Drawing.Point(238, 22);
            this.txtMaHDQLHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHDQLHD.Name = "txtMaHDQLHD";
            this.txtMaHDQLHD.PasswordChar = '\0';
            this.txtMaHDQLHD.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaHDQLHD.PlaceholderText = "Mã hợp đồng";
            this.txtMaHDQLHD.SelectedText = "";
            this.txtMaHDQLHD.Size = new System.Drawing.Size(407, 45);
            this.txtMaHDQLHD.TabIndex = 48;
            // 
            // txtMaNVQLHD
            // 
            this.txtMaNVQLHD.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNVQLHD.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.txtMaNVQLHD.BorderRadius = 10;
            this.txtMaNVQLHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNVQLHD.DefaultText = "";
            this.txtMaNVQLHD.Enabled = false;
            this.txtMaNVQLHD.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaNVQLHD.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMaNVQLHD.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMaNVQLHD.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaNVQLHD.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaNVQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVQLHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaNVQLHD.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaNVQLHD.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMaNVQLHD.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMaNVQLHD.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaNVQLHD.Location = new System.Drawing.Point(238, 128);
            this.txtMaNVQLHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNVQLHD.Name = "txtMaNVQLHD";
            this.txtMaNVQLHD.PasswordChar = '\0';
            this.txtMaNVQLHD.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaNVQLHD.PlaceholderText = "Mã nhân viên";
            this.txtMaNVQLHD.SelectedText = "";
            this.txtMaNVQLHD.Size = new System.Drawing.Size(407, 45);
            this.txtMaNVQLHD.TabIndex = 45;
            // 
            // txtMaCtyQLHD
            // 
            this.txtMaCtyQLHD.BackColor = System.Drawing.Color.Transparent;
            this.txtMaCtyQLHD.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.txtMaCtyQLHD.BorderRadius = 10;
            this.txtMaCtyQLHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCtyQLHD.DefaultText = "";
            this.txtMaCtyQLHD.Enabled = false;
            this.txtMaCtyQLHD.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaCtyQLHD.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMaCtyQLHD.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMaCtyQLHD.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaCtyQLHD.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaCtyQLHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCtyQLHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaCtyQLHD.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaCtyQLHD.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMaCtyQLHD.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMaCtyQLHD.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaCtyQLHD.Location = new System.Drawing.Point(238, 75);
            this.txtMaCtyQLHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaCtyQLHD.Name = "txtMaCtyQLHD";
            this.txtMaCtyQLHD.PasswordChar = '\0';
            this.txtMaCtyQLHD.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaCtyQLHD.PlaceholderText = "Mã công ty";
            this.txtMaCtyQLHD.SelectedText = "";
            this.txtMaCtyQLHD.Size = new System.Drawing.Size(407, 45);
            this.txtMaCtyQLHD.TabIndex = 44;
            // 
            // lblSomoney
            // 
            this.lblSomoney.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomoney.Location = new System.Drawing.Point(60, 298);
            this.lblSomoney.Name = "lblSomoney";
            this.lblSomoney.Size = new System.Drawing.Size(192, 25);
            this.lblSomoney.TabIndex = 29;
            this.lblSomoney.Text = "Số tiền:";
            this.lblSomoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDategiao
            // 
            this.lblDategiao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDategiao.Location = new System.Drawing.Point(60, 244);
            this.lblDategiao.Name = "lblDategiao";
            this.lblDategiao.Size = new System.Drawing.Size(192, 25);
            this.lblDategiao.TabIndex = 28;
            this.lblDategiao.Text = "Ngày trả KQ:";
            this.lblDategiao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateky
            // 
            this.lblDateky.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateky.Location = new System.Drawing.Point(60, 191);
            this.lblDateky.Name = "lblDateky";
            this.lblDateky.Size = new System.Drawing.Size(192, 25);
            this.lblDateky.TabIndex = 24;
            this.lblDateky.Text = "Ngày ký:";
            this.lblDateky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMasnv
            // 
            this.lblMasnv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasnv.Location = new System.Drawing.Point(60, 137);
            this.lblMasnv.Name = "lblMasnv";
            this.lblMasnv.Size = new System.Drawing.Size(192, 25);
            this.lblMasnv.TabIndex = 23;
            this.lblMasnv.Text = "Mã nhân viên:";
            this.lblMasnv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMact
            // 
            this.lblMact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMact.Location = new System.Drawing.Point(60, 85);
            this.lblMact.Name = "lblMact";
            this.lblMact.Size = new System.Drawing.Size(192, 25);
            this.lblMact.TabIndex = 21;
            this.lblMact.Text = "Mã công ty:";
            this.lblMact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMahd
            // 
            this.lblMahd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahd.Location = new System.Drawing.Point(60, 31);
            this.lblMahd.Name = "lblMahd";
            this.lblMahd.Size = new System.Drawing.Size(192, 25);
            this.lblMahd.TabIndex = 36;
            this.lblMahd.Text = "Mã hợp đồng:";
            this.lblMahd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuuHD.BorderRadius = 5;
            this.btnLuuHD.BorderThickness = 1;
            this.btnLuuHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuHD.Enabled = false;
            this.btnLuuHD.FillColor = System.Drawing.Color.Transparent;
            this.btnLuuHD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuuHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuHD.ForeColor = System.Drawing.Color.White;
            this.btnLuuHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuHD.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuHD.Image = global::DuAnCNPM.Properties.Resources.diskette;
            this.btnLuuHD.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLuuHD.Location = new System.Drawing.Point(824, 3);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(45, 45);
            this.btnLuuHD.TabIndex = 54;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaHD.BorderRadius = 5;
            this.btnSuaHD.BorderThickness = 1;
            this.btnSuaHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaHD.Enabled = false;
            this.btnSuaHD.FillColor = System.Drawing.Color.Transparent;
            this.btnSuaHD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaHD.ForeColor = System.Drawing.Color.White;
            this.btnSuaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaHD.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHD.Image")));
            this.btnSuaHD.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSuaHD.Location = new System.Drawing.Point(924, 3);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(45, 45);
            this.btnSuaHD.TabIndex = 53;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaHD.BorderRadius = 5;
            this.btnXoaHD.BorderThickness = 1;
            this.btnXoaHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaHD.Enabled = false;
            this.btnXoaHD.FillColor = System.Drawing.Color.Transparent;
            this.btnXoaHD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaHD.ForeColor = System.Drawing.Color.White;
            this.btnXoaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaHD.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHD.Image")));
            this.btnXoaHD.ImageSize = new System.Drawing.Size(35, 35);
            this.btnXoaHD.Location = new System.Drawing.Point(874, 3);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(45, 45);
            this.btnXoaHD.TabIndex = 52;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // lblTTHD
            // 
            this.lblTTHD.AutoSize = false;
            this.lblTTHD.BackColor = System.Drawing.Color.Transparent;
            this.lblTTHD.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTHD.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTTHD.Location = new System.Drawing.Point(322, 8);
            this.lblTTHD.Name = "lblTTHD";
            this.lblTTHD.Size = new System.Drawing.Size(308, 40);
            this.lblTTHD.TabIndex = 55;
            this.lblTTHD.Text = "Thông tin hợp đồng";
            this.lblTTHD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThemHD
            // 
            this.lblThemHD.AutoSize = false;
            this.lblThemHD.BackColor = System.Drawing.Color.Transparent;
            this.lblThemHD.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemHD.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblThemHD.Location = new System.Drawing.Point(322, 8);
            this.lblThemHD.Name = "lblThemHD";
            this.lblThemHD.Size = new System.Drawing.Size(308, 40);
            this.lblThemHD.TabIndex = 56;
            this.lblThemHD.Text = "Thêm hợp đồng";
            this.lblThemHD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDSHD
            // 
            this.lblDSHD.AutoSize = false;
            this.lblDSHD.BackColor = System.Drawing.Color.Transparent;
            this.lblDSHD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDSHD.Location = new System.Drawing.Point(2, 0);
            this.lblDSHD.Name = "lblDSHD";
            this.lblDSHD.Size = new System.Drawing.Size(280, 47);
            this.lblDSHD.TabIndex = 47;
            this.lblDSHD.Text = "Danh sách hợp đồng";
            this.lblDSHD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.BorderRadius = 5;
            this.siticoneButton4.BorderThickness = 1;
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.siticoneButton4.Image = global::DuAnCNPM.Properties.Resources.add;
            this.siticoneButton4.ImageSize = new System.Drawing.Size(25, 25);
            this.siticoneButton4.Location = new System.Drawing.Point(200, 5);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.Size = new System.Drawing.Size(39, 40);
            this.siticoneButton4.TabIndex = 49;
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton5.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton5.BorderRadius = 5;
            this.siticoneButton5.BorderThickness = 1;
            this.siticoneButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton5.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton5.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.siticoneButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.siticoneButton5.Image = global::DuAnCNPM.Properties.Resources.sortGiam;
            this.siticoneButton5.ImageSize = new System.Drawing.Size(35, 35);
            this.siticoneButton5.Location = new System.Drawing.Point(243, 5);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.Size = new System.Drawing.Size(39, 40);
            this.siticoneButton5.TabIndex = 48;
            this.siticoneButton5.Click += new System.EventHandler(this.siticoneButton5_Click);
            // 
            // tabQLTS
            // 
            this.tabQLTS.BackColor = System.Drawing.Color.White;
            this.tabQLTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabQLTS.Controls.Add(this.btnAddTS);
            this.tabQLTS.Controls.Add(this.btnSortTS);
            this.tabQLTS.Controls.Add(this.panTTTSchitiet);
            this.tabQLTS.Controls.Add(this.btnLuuTS);
            this.tabQLTS.Controls.Add(this.btnSuaTS);
            this.tabQLTS.Controls.Add(this.btnXoaTS);
            this.tabQLTS.Controls.Add(this.panDSTS);
            this.tabQLTS.Controls.Add(this.lblDanhsachTS);
            this.tabQLTS.Controls.Add(this.lblTTTS);
            this.tabQLTS.Controls.Add(this.lblThemCS);
            this.tabQLTS.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabQLTS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLTS.Location = new System.Drawing.Point(4, 44);
            this.tabQLTS.Name = "tabQLTS";
            this.tabQLTS.Size = new System.Drawing.Size(972, 477);
            this.tabQLTS.TabIndex = 3;
            this.tabQLTS.Text = "Quản lý thông số";
            // 
            // btnAddTS
            // 
            this.btnAddTS.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTS.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddTS.BorderRadius = 5;
            this.btnAddTS.BorderThickness = 1;
            this.btnAddTS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTS.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddTS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTS.ForeColor = System.Drawing.Color.White;
            this.btnAddTS.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddTS.Image = global::DuAnCNPM.Properties.Resources.add;
            this.btnAddTS.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddTS.Location = new System.Drawing.Point(201, 5);
            this.btnAddTS.Name = "btnAddTS";
            this.btnAddTS.Size = new System.Drawing.Size(39, 40);
            this.btnAddTS.TabIndex = 53;
            this.btnAddTS.Click += new System.EventHandler(this.btnAddTS_Click);
            // 
            // btnSortTS
            // 
            this.btnSortTS.BackColor = System.Drawing.Color.Transparent;
            this.btnSortTS.BorderColor = System.Drawing.Color.Transparent;
            this.btnSortTS.BorderRadius = 5;
            this.btnSortTS.BorderThickness = 1;
            this.btnSortTS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortTS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortTS.FillColor = System.Drawing.Color.Transparent;
            this.btnSortTS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortTS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortTS.ForeColor = System.Drawing.Color.White;
            this.btnSortTS.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortTS.Image = global::DuAnCNPM.Properties.Resources.sortGiam;
            this.btnSortTS.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSortTS.Location = new System.Drawing.Point(244, 5);
            this.btnSortTS.Name = "btnSortTS";
            this.btnSortTS.Size = new System.Drawing.Size(39, 40);
            this.btnSortTS.TabIndex = 52;
            this.btnSortTS.Click += new System.EventHandler(this.btnSortTS_Click);
            // 
            // panTTTSchitiet
            // 
            this.panTTTSchitiet.AutoSize = true;
            this.panTTTSchitiet.BackColor = System.Drawing.Color.Transparent;
            this.panTTTSchitiet.BorderColor = System.Drawing.Color.LightBlue;
            this.panTTTSchitiet.BorderRadius = 8;
            this.panTTTSchitiet.Controls.Add(this.lblNoiNhap);
            this.panTTTSchitiet.Controls.Add(this.txtNoiNhap);
            this.panTTTSchitiet.Controls.Add(this.txtTieuChuan);
            this.panTTTSchitiet.Controls.Add(this.txtViTriCS);
            this.panTTTSchitiet.Controls.Add(this.lblTieuchuan);
            this.panTTTSchitiet.Controls.Add(this.txtLoaiChiSo);
            this.panTTTSchitiet.Controls.Add(this.txtTenChiSo);
            this.panTTTSchitiet.Controls.Add(this.txtMaCS);
            this.panTTTSchitiet.Controls.Add(this.lblVitri);
            this.panTTTSchitiet.Controls.Add(this.lblLoaits);
            this.panTTTSchitiet.Controls.Add(this.label6);
            this.panTTTSchitiet.Controls.Add(this.lblMats);
            this.panTTTSchitiet.FillColor = System.Drawing.Color.White;
            this.panTTTSchitiet.Location = new System.Drawing.Point(284, 48);
            this.panTTTSchitiet.Name = "panTTTSchitiet";
            this.panTTTSchitiet.Size = new System.Drawing.Size(688, 426);
            this.panTTTSchitiet.TabIndex = 60;
            // 
            // lblNoiNhap
            // 
            this.lblNoiNhap.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiNhap.Location = new System.Drawing.Point(49, 292);
            this.lblNoiNhap.Name = "lblNoiNhap";
            this.lblNoiNhap.Size = new System.Drawing.Size(148, 25);
            this.lblNoiNhap.TabIndex = 38;
            this.lblNoiNhap.Text = "Nơi nhập:";
            this.lblNoiNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNoiNhap
            // 
            this.txtNoiNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtNoiNhap.BorderColor = System.Drawing.Color.Black;
            this.txtNoiNhap.BorderRadius = 10;
            this.txtNoiNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiNhap.DefaultText = "";
            this.txtNoiNhap.Enabled = false;
            this.txtNoiNhap.FillColor = System.Drawing.SystemColors.Window;
            this.txtNoiNhap.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtNoiNhap.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtNoiNhap.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtNoiNhap.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNoiNhap.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiNhap.ForeColor = System.Drawing.Color.Black;
            this.txtNoiNhap.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtNoiNhap.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtNoiNhap.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtNoiNhap.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNoiNhap.Location = new System.Drawing.Point(204, 281);
            this.txtNoiNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiNhap.Name = "txtNoiNhap";
            this.txtNoiNhap.PasswordChar = '\0';
            this.txtNoiNhap.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNoiNhap.PlaceholderText = "Nơi nhập";
            this.txtNoiNhap.SelectedText = "";
            this.txtNoiNhap.Size = new System.Drawing.Size(407, 45);
            this.txtNoiNhap.TabIndex = 37;
            // 
            // txtTieuChuan
            // 
            this.txtTieuChuan.BackColor = System.Drawing.Color.Transparent;
            this.txtTieuChuan.BorderColor = System.Drawing.Color.Black;
            this.txtTieuChuan.BorderRadius = 10;
            this.txtTieuChuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTieuChuan.DefaultText = "";
            this.txtTieuChuan.Enabled = false;
            this.txtTieuChuan.FillColor = System.Drawing.SystemColors.Window;
            this.txtTieuChuan.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtTieuChuan.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtTieuChuan.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTieuChuan.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTieuChuan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuChuan.ForeColor = System.Drawing.Color.Black;
            this.txtTieuChuan.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtTieuChuan.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtTieuChuan.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtTieuChuan.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTieuChuan.Location = new System.Drawing.Point(204, 228);
            this.txtTieuChuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTieuChuan.Name = "txtTieuChuan";
            this.txtTieuChuan.PasswordChar = '\0';
            this.txtTieuChuan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTieuChuan.PlaceholderText = "Tiêu chuẩn";
            this.txtTieuChuan.SelectedText = "";
            this.txtTieuChuan.Size = new System.Drawing.Size(407, 45);
            this.txtTieuChuan.TabIndex = 32;
            // 
            // txtViTriCS
            // 
            this.txtViTriCS.BackColor = System.Drawing.Color.Transparent;
            this.txtViTriCS.BorderColor = System.Drawing.Color.Black;
            this.txtViTriCS.BorderRadius = 10;
            this.txtViTriCS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtViTriCS.DefaultText = "";
            this.txtViTriCS.Enabled = false;
            this.txtViTriCS.FillColor = System.Drawing.SystemColors.Window;
            this.txtViTriCS.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtViTriCS.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtViTriCS.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtViTriCS.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtViTriCS.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTriCS.ForeColor = System.Drawing.Color.Black;
            this.txtViTriCS.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtViTriCS.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtViTriCS.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtViTriCS.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtViTriCS.Location = new System.Drawing.Point(204, 175);
            this.txtViTriCS.Margin = new System.Windows.Forms.Padding(4);
            this.txtViTriCS.Name = "txtViTriCS";
            this.txtViTriCS.PasswordChar = '\0';
            this.txtViTriCS.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtViTriCS.PlaceholderText = "Vị trí";
            this.txtViTriCS.SelectedText = "";
            this.txtViTriCS.Size = new System.Drawing.Size(407, 45);
            this.txtViTriCS.TabIndex = 31;
            // 
            // lblTieuchuan
            // 
            this.lblTieuchuan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuchuan.Location = new System.Drawing.Point(49, 239);
            this.lblTieuchuan.Name = "lblTieuchuan";
            this.lblTieuchuan.Size = new System.Drawing.Size(148, 25);
            this.lblTieuchuan.TabIndex = 28;
            this.lblTieuchuan.Text = "Tiêu chuẩn:";
            this.lblTieuchuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLoaiChiSo
            // 
            this.txtLoaiChiSo.BackColor = System.Drawing.Color.Transparent;
            this.txtLoaiChiSo.BorderColor = System.Drawing.Color.Black;
            this.txtLoaiChiSo.BorderRadius = 10;
            this.txtLoaiChiSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiChiSo.DefaultText = "";
            this.txtLoaiChiSo.Enabled = false;
            this.txtLoaiChiSo.FillColor = System.Drawing.SystemColors.Window;
            this.txtLoaiChiSo.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtLoaiChiSo.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtLoaiChiSo.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiChiSo.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLoaiChiSo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiChiSo.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiChiSo.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtLoaiChiSo.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtLoaiChiSo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiChiSo.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLoaiChiSo.Location = new System.Drawing.Point(204, 122);
            this.txtLoaiChiSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiChiSo.Name = "txtLoaiChiSo";
            this.txtLoaiChiSo.PasswordChar = '\0';
            this.txtLoaiChiSo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLoaiChiSo.PlaceholderText = "Loại chỉ số";
            this.txtLoaiChiSo.SelectedText = "";
            this.txtLoaiChiSo.Size = new System.Drawing.Size(407, 45);
            this.txtLoaiChiSo.TabIndex = 26;
            // 
            // txtTenChiSo
            // 
            this.txtTenChiSo.BackColor = System.Drawing.Color.Transparent;
            this.txtTenChiSo.BorderColor = System.Drawing.Color.Black;
            this.txtTenChiSo.BorderRadius = 10;
            this.txtTenChiSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChiSo.DefaultText = "";
            this.txtTenChiSo.Enabled = false;
            this.txtTenChiSo.FillColor = System.Drawing.SystemColors.Window;
            this.txtTenChiSo.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtTenChiSo.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtTenChiSo.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTenChiSo.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenChiSo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChiSo.ForeColor = System.Drawing.Color.Black;
            this.txtTenChiSo.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtTenChiSo.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtTenChiSo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtTenChiSo.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenChiSo.Location = new System.Drawing.Point(204, 69);
            this.txtTenChiSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenChiSo.Name = "txtTenChiSo";
            this.txtTenChiSo.PasswordChar = '\0';
            this.txtTenChiSo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenChiSo.PlaceholderText = "Tên chỉ số";
            this.txtTenChiSo.SelectedText = "";
            this.txtTenChiSo.Size = new System.Drawing.Size(407, 45);
            this.txtTenChiSo.TabIndex = 25;
            // 
            // txtMaCS
            // 
            this.txtMaCS.BackColor = System.Drawing.Color.Transparent;
            this.txtMaCS.BorderColor = System.Drawing.Color.Black;
            this.txtMaCS.BorderRadius = 10;
            this.txtMaCS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCS.DefaultText = "";
            this.txtMaCS.Enabled = false;
            this.txtMaCS.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaCS.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMaCS.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMaCS.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaCS.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaCS.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCS.ForeColor = System.Drawing.Color.Black;
            this.txtMaCS.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaCS.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMaCS.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMaCS.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaCS.Location = new System.Drawing.Point(204, 16);
            this.txtMaCS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.PasswordChar = '\0';
            this.txtMaCS.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaCS.PlaceholderText = "Mã chỉ số";
            this.txtMaCS.SelectedText = "";
            this.txtMaCS.Size = new System.Drawing.Size(407, 45);
            this.txtMaCS.TabIndex = 22;
            // 
            // lblVitri
            // 
            this.lblVitri.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitri.Location = new System.Drawing.Point(49, 184);
            this.lblVitri.Name = "lblVitri";
            this.lblVitri.Size = new System.Drawing.Size(148, 25);
            this.lblVitri.TabIndex = 24;
            this.lblVitri.Text = "Vị trí:";
            this.lblVitri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoaits
            // 
            this.lblLoaits.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaits.Location = new System.Drawing.Point(49, 133);
            this.lblLoaits.Name = "lblLoaits";
            this.lblLoaits.Size = new System.Drawing.Size(148, 25);
            this.lblLoaits.TabIndex = 23;
            this.lblLoaits.Text = "Loại thông số:";
            this.lblLoaits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tên thông số:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMats
            // 
            this.lblMats.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMats.Location = new System.Drawing.Point(49, 26);
            this.lblMats.Name = "lblMats";
            this.lblMats.Size = new System.Drawing.Size(148, 25);
            this.lblMats.TabIndex = 36;
            this.lblMats.Text = " Mã thông số:";
            this.lblMats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLuuTS
            // 
            this.btnLuuTS.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuuTS.BorderRadius = 5;
            this.btnLuuTS.BorderThickness = 1;
            this.btnLuuTS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuTS.Enabled = false;
            this.btnLuuTS.FillColor = System.Drawing.Color.Transparent;
            this.btnLuuTS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuuTS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuTS.ForeColor = System.Drawing.Color.White;
            this.btnLuuTS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuTS.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuTS.Image = global::DuAnCNPM.Properties.Resources.diskette;
            this.btnLuuTS.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLuuTS.Location = new System.Drawing.Point(824, 2);
            this.btnLuuTS.Name = "btnLuuTS";
            this.btnLuuTS.Size = new System.Drawing.Size(45, 45);
            this.btnLuuTS.TabIndex = 57;
            this.btnLuuTS.Click += new System.EventHandler(this.btnLuuTS_Click);
            // 
            // btnSuaTS
            // 
            this.btnSuaTS.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaTS.BorderRadius = 5;
            this.btnSuaTS.BorderThickness = 1;
            this.btnSuaTS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaTS.Enabled = false;
            this.btnSuaTS.FillColor = System.Drawing.Color.Transparent;
            this.btnSuaTS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaTS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaTS.ForeColor = System.Drawing.Color.White;
            this.btnSuaTS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaTS.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaTS.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTS.Image")));
            this.btnSuaTS.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSuaTS.Location = new System.Drawing.Point(924, 2);
            this.btnSuaTS.Name = "btnSuaTS";
            this.btnSuaTS.Size = new System.Drawing.Size(45, 45);
            this.btnSuaTS.TabIndex = 56;
            this.btnSuaTS.Click += new System.EventHandler(this.btnSuaTS_Click);
            // 
            // btnXoaTS
            // 
            this.btnXoaTS.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaTS.BorderRadius = 5;
            this.btnXoaTS.BorderThickness = 1;
            this.btnXoaTS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTS.Enabled = false;
            this.btnXoaTS.FillColor = System.Drawing.Color.Transparent;
            this.btnXoaTS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoaTS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaTS.ForeColor = System.Drawing.Color.White;
            this.btnXoaTS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaTS.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaTS.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTS.Image")));
            this.btnXoaTS.ImageSize = new System.Drawing.Size(35, 35);
            this.btnXoaTS.Location = new System.Drawing.Point(874, 2);
            this.btnXoaTS.Name = "btnXoaTS";
            this.btnXoaTS.Size = new System.Drawing.Size(45, 45);
            this.btnXoaTS.TabIndex = 55;
            this.btnXoaTS.Click += new System.EventHandler(this.btnXoaTS_Click);
            // 
            // panDSTS
            // 
            this.panDSTS.AutoScroll = true;
            this.panDSTS.BackColor = System.Drawing.Color.Transparent;
            this.panDSTS.BorderColor = System.Drawing.Color.SeaGreen;
            this.panDSTS.BorderRadius = 5;
            this.panDSTS.BorderThickness = 1;
            this.panDSTS.FillColor = System.Drawing.Color.White;
            this.panDSTS.Location = new System.Drawing.Point(1, 48);
            this.panDSTS.Name = "panDSTS";
            this.panDSTS.Size = new System.Drawing.Size(282, 426);
            this.panDSTS.TabIndex = 54;
            // 
            // lblDanhsachTS
            // 
            this.lblDanhsachTS.AutoSize = false;
            this.lblDanhsachTS.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhsachTS.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsachTS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDanhsachTS.Location = new System.Drawing.Point(3, 0);
            this.lblDanhsachTS.Name = "lblDanhsachTS";
            this.lblDanhsachTS.Size = new System.Drawing.Size(280, 47);
            this.lblDanhsachTS.TabIndex = 51;
            this.lblDanhsachTS.Text = "Danh sách thông số";
            this.lblDanhsachTS.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTTTS
            // 
            this.lblTTTS.AutoSize = false;
            this.lblTTTS.BackColor = System.Drawing.Color.Transparent;
            this.lblTTTS.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTTS.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTTTS.Location = new System.Drawing.Point(324, 5);
            this.lblTTTS.Name = "lblTTTS";
            this.lblTTTS.Size = new System.Drawing.Size(410, 40);
            this.lblTTTS.TabIndex = 58;
            this.lblTTTS.Text = "Thông tin thông số";
            this.lblTTTS.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThemCS
            // 
            this.lblThemCS.AutoSize = false;
            this.lblThemCS.BackColor = System.Drawing.Color.Transparent;
            this.lblThemCS.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemCS.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblThemCS.Location = new System.Drawing.Point(324, 5);
            this.lblThemCS.Name = "lblThemCS";
            this.lblThemCS.Size = new System.Drawing.Size(410, 40);
            this.lblThemCS.TabIndex = 59;
            this.lblThemCS.Text = "Thêm thông số";
            this.lblThemCS.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabQLTB
            // 
            this.tabQLTB.AutoScroll = true;
            this.tabQLTB.BackColor = System.Drawing.Color.White;
            this.tabQLTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabQLTB.Controls.Add(this.panDSTBchitiet);
            this.tabQLTB.Controls.Add(this.btnLuuTB);
            this.tabQLTB.Controls.Add(this.btnSuaTB);
            this.tabQLTB.Controls.Add(this.btnXoaTB);
            this.tabQLTB.Controls.Add(this.siticoneHtmlLabel10);
            this.tabQLTB.Controls.Add(this.panDSTBAdmin);
            this.tabQLTB.Controls.Add(this.btnAddTB);
            this.tabQLTB.Controls.Add(this.btnSortThongbao);
            this.tabQLTB.Controls.Add(this.lblDanhsachTB);
            this.tabQLTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabQLTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLTB.Location = new System.Drawing.Point(4, 44);
            this.tabQLTB.Name = "tabQLTB";
            this.tabQLTB.Size = new System.Drawing.Size(972, 477);
            this.tabQLTB.TabIndex = 4;
            this.tabQLTB.Text = "Quản lý thông báo";
            // 
            // panDSTBchitiet
            // 
            this.panDSTBchitiet.AutoScroll = true;
            this.panDSTBchitiet.BackColor = System.Drawing.Color.Transparent;
            this.panDSTBchitiet.BorderColor = System.Drawing.Color.Black;
            this.panDSTBchitiet.BorderRadius = 8;
            this.panDSTBchitiet.Controls.Add(this.txtNoidung);
            this.panDSTBchitiet.Controls.Add(this.txtTieuDe);
            this.panDSTBchitiet.Controls.Add(this.lblNdungTB);
            this.panDSTBchitiet.Controls.Add(this.lblDatephathanh);
            this.panDSTBchitiet.Controls.Add(this.lblTieude);
            this.panDSTBchitiet.Controls.Add(this.txtVitriTB);
            this.panDSTBchitiet.Controls.Add(this.lblMaTB);
            this.panDSTBchitiet.Controls.Add(this.dtpNgayphathanh);
            this.panDSTBchitiet.FillColor = System.Drawing.Color.White;
            this.panDSTBchitiet.Location = new System.Drawing.Point(284, 48);
            this.panDSTBchitiet.Name = "panDSTBchitiet";
            this.panDSTBchitiet.Size = new System.Drawing.Size(688, 426);
            this.panDSTBchitiet.TabIndex = 65;
            // 
            // txtNoidung
            // 
            this.txtNoidung.BackColor = System.Drawing.Color.White;
            this.txtNoidung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoidung.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoidung.Location = new System.Drawing.Point(204, 176);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(408, 248);
            this.txtNoidung.TabIndex = 37;
            this.txtNoidung.Text = "";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.txtTieuDe.BorderColor = System.Drawing.Color.Black;
            this.txtTieuDe.BorderRadius = 10;
            this.txtTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTieuDe.DefaultText = "";
            this.txtTieuDe.Enabled = false;
            this.txtTieuDe.FillColor = System.Drawing.SystemColors.Window;
            this.txtTieuDe.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtTieuDe.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtTieuDe.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTieuDe.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTieuDe.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.ForeColor = System.Drawing.Color.Black;
            this.txtTieuDe.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtTieuDe.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtTieuDe.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtTieuDe.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTieuDe.Location = new System.Drawing.Point(204, 69);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.PasswordChar = '\0';
            this.txtTieuDe.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTieuDe.PlaceholderText = "Mã chỉ số";
            this.txtTieuDe.SelectedText = "";
            this.txtTieuDe.Size = new System.Drawing.Size(407, 45);
            this.txtTieuDe.TabIndex = 22;
            // 
            // lblNdungTB
            // 
            this.lblNdungTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdungTB.Location = new System.Drawing.Point(49, 186);
            this.lblNdungTB.Name = "lblNdungTB";
            this.lblNdungTB.Size = new System.Drawing.Size(177, 25);
            this.lblNdungTB.TabIndex = 23;
            this.lblNdungTB.Text = "Nội dung TB:";
            this.lblNdungTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatephathanh
            // 
            this.lblDatephathanh.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatephathanh.Location = new System.Drawing.Point(49, 133);
            this.lblDatephathanh.Name = "lblDatephathanh";
            this.lblDatephathanh.Size = new System.Drawing.Size(148, 25);
            this.lblDatephathanh.TabIndex = 21;
            this.lblDatephathanh.Text = "Ngày phát hành:";
            this.lblDatephathanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTieude
            // 
            this.lblTieude.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.Location = new System.Drawing.Point(49, 79);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(148, 25);
            this.lblTieude.TabIndex = 36;
            this.lblTieude.Text = "Tiêu đề:";
            this.lblTieude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVitriTB
            // 
            this.txtVitriTB.BackColor = System.Drawing.Color.Transparent;
            this.txtVitriTB.BorderColor = System.Drawing.Color.Black;
            this.txtVitriTB.BorderRadius = 10;
            this.txtVitriTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVitriTB.DefaultText = "";
            this.txtVitriTB.Enabled = false;
            this.txtVitriTB.FillColor = System.Drawing.SystemColors.Window;
            this.txtVitriTB.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtVitriTB.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtVitriTB.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtVitriTB.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVitriTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVitriTB.ForeColor = System.Drawing.Color.Black;
            this.txtVitriTB.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtVitriTB.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtVitriTB.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtVitriTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtVitriTB.Location = new System.Drawing.Point(204, 16);
            this.txtVitriTB.Margin = new System.Windows.Forms.Padding(4);
            this.txtVitriTB.Name = "txtVitriTB";
            this.txtVitriTB.PasswordChar = '\0';
            this.txtVitriTB.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtVitriTB.PlaceholderText = "Vị trí";
            this.txtVitriTB.SelectedText = "";
            this.txtVitriTB.Size = new System.Drawing.Size(407, 45);
            this.txtVitriTB.TabIndex = 31;
            // 
            // lblMaTB
            // 
            this.lblMaTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTB.Location = new System.Drawing.Point(49, 25);
            this.lblMaTB.Name = "lblMaTB";
            this.lblMaTB.Size = new System.Drawing.Size(148, 25);
            this.lblMaTB.TabIndex = 24;
            this.lblMaTB.Text = "Mã thông báo:";
            this.lblMaTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayphathanh
            // 
            this.dtpNgayphathanh.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayphathanh.BorderRadius = 10;
            this.dtpNgayphathanh.BorderThickness = 1;
            this.dtpNgayphathanh.CausesValidation = false;
            this.dtpNgayphathanh.Checked = true;
            this.dtpNgayphathanh.Enabled = false;
            this.dtpNgayphathanh.FillColor = System.Drawing.Color.Honeydew;
            this.dtpNgayphathanh.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayphathanh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayphathanh.Location = new System.Drawing.Point(204, 122);
            this.dtpNgayphathanh.MaxDate = new System.DateTime(2025, 4, 11, 0, 0, 0, 0);
            this.dtpNgayphathanh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayphathanh.Name = "dtpNgayphathanh";
            this.dtpNgayphathanh.Size = new System.Drawing.Size(407, 45);
            this.dtpNgayphathanh.TabIndex = 38;
            this.dtpNgayphathanh.Value = new System.DateTime(2025, 3, 28, 1, 18, 56, 808);
            // 
            // btnLuuTB
            // 
            this.btnLuuTB.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuuTB.BorderRadius = 5;
            this.btnLuuTB.BorderThickness = 1;
            this.btnLuuTB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuTB.Enabled = false;
            this.btnLuuTB.FillColor = System.Drawing.Color.Transparent;
            this.btnLuuTB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuuTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuTB.ForeColor = System.Drawing.Color.White;
            this.btnLuuTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuTB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuTB.Image = global::DuAnCNPM.Properties.Resources.diskette;
            this.btnLuuTB.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLuuTB.Location = new System.Drawing.Point(824, 2);
            this.btnLuuTB.Name = "btnLuuTB";
            this.btnLuuTB.Size = new System.Drawing.Size(45, 45);
            this.btnLuuTB.TabIndex = 63;
            this.btnLuuTB.Click += new System.EventHandler(this.btnLuuTB_Click);
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaTB.BorderRadius = 5;
            this.btnSuaTB.BorderThickness = 1;
            this.btnSuaTB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaTB.Enabled = false;
            this.btnSuaTB.FillColor = System.Drawing.Color.Transparent;
            this.btnSuaTB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaTB.ForeColor = System.Drawing.Color.White;
            this.btnSuaTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaTB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSuaTB.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTB.Image")));
            this.btnSuaTB.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSuaTB.Location = new System.Drawing.Point(924, 2);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(45, 45);
            this.btnSuaTB.TabIndex = 62;
            this.btnSuaTB.Click += new System.EventHandler(this.btnSuaTB_Click);
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaTB.BorderRadius = 5;
            this.btnXoaTB.BorderThickness = 1;
            this.btnXoaTB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTB.Enabled = false;
            this.btnXoaTB.FillColor = System.Drawing.Color.Transparent;
            this.btnXoaTB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoaTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaTB.ForeColor = System.Drawing.Color.White;
            this.btnXoaTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaTB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoaTB.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTB.Image")));
            this.btnXoaTB.ImageSize = new System.Drawing.Size(35, 35);
            this.btnXoaTB.Location = new System.Drawing.Point(874, 2);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(45, 45);
            this.btnXoaTB.TabIndex = 61;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // siticoneHtmlLabel10
            // 
            this.siticoneHtmlLabel10.AutoSize = false;
            this.siticoneHtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.siticoneHtmlLabel10.Location = new System.Drawing.Point(324, 5);
            this.siticoneHtmlLabel10.Name = "siticoneHtmlLabel10";
            this.siticoneHtmlLabel10.Size = new System.Drawing.Size(410, 40);
            this.siticoneHtmlLabel10.TabIndex = 64;
            this.siticoneHtmlLabel10.Text = "Thông tin thông báo";
            this.siticoneHtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panDSTBAdmin
            // 
            this.panDSTBAdmin.AutoScroll = true;
            this.panDSTBAdmin.AutoSize = true;
            this.panDSTBAdmin.BackColor = System.Drawing.Color.Transparent;
            this.panDSTBAdmin.BorderColor = System.Drawing.Color.SeaGreen;
            this.panDSTBAdmin.BorderRadius = 5;
            this.panDSTBAdmin.BorderThickness = 1;
            this.panDSTBAdmin.FillColor = System.Drawing.Color.White;
            this.panDSTBAdmin.Location = new System.Drawing.Point(1, 48);
            this.panDSTBAdmin.Name = "panDSTBAdmin";
            this.panDSTBAdmin.Size = new System.Drawing.Size(282, 426);
            this.panDSTBAdmin.TabIndex = 58;
            // 
            // btnAddTB
            // 
            this.btnAddTB.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTB.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddTB.BorderRadius = 5;
            this.btnAddTB.BorderThickness = 1;
            this.btnAddTB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTB.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTB.ForeColor = System.Drawing.Color.White;
            this.btnAddTB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddTB.Image = global::DuAnCNPM.Properties.Resources.add;
            this.btnAddTB.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddTB.Location = new System.Drawing.Point(201, 5);
            this.btnAddTB.Name = "btnAddTB";
            this.btnAddTB.Size = new System.Drawing.Size(39, 40);
            this.btnAddTB.TabIndex = 57;
            this.btnAddTB.Click += new System.EventHandler(this.btnAddTB_Click);
            // 
            // btnSortThongbao
            // 
            this.btnSortThongbao.BackColor = System.Drawing.Color.Transparent;
            this.btnSortThongbao.BorderColor = System.Drawing.Color.Transparent;
            this.btnSortThongbao.BorderRadius = 5;
            this.btnSortThongbao.BorderThickness = 1;
            this.btnSortThongbao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortThongbao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortThongbao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortThongbao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortThongbao.FillColor = System.Drawing.Color.Transparent;
            this.btnSortThongbao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortThongbao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortThongbao.ForeColor = System.Drawing.Color.White;
            this.btnSortThongbao.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortThongbao.Image = global::DuAnCNPM.Properties.Resources.sortGiam;
            this.btnSortThongbao.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSortThongbao.Location = new System.Drawing.Point(244, 5);
            this.btnSortThongbao.Name = "btnSortThongbao";
            this.btnSortThongbao.Size = new System.Drawing.Size(39, 40);
            this.btnSortThongbao.TabIndex = 56;
            this.btnSortThongbao.Click += new System.EventHandler(this.btnSortThongbao_Click);
            // 
            // lblDanhsachTB
            // 
            this.lblDanhsachTB.AutoSize = false;
            this.lblDanhsachTB.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhsachTB.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsachTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDanhsachTB.Location = new System.Drawing.Point(3, 0);
            this.lblDanhsachTB.Name = "lblDanhsachTB";
            this.lblDanhsachTB.Size = new System.Drawing.Size(280, 47);
            this.lblDanhsachTB.TabIndex = 55;
            this.lblDanhsachTB.Text = "Danh sách thông báo";
            this.lblDanhsachTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panTK
            // 
            this.panTK.BackColor = System.Drawing.Color.Transparent;
            this.panTK.Controls.Add(this.lblYear);
            this.panTK.Controls.Add(this.cboMoctgian);
            this.panTK.Controls.Add(this.chart2);
            this.panTK.Controls.Add(this.chart1);
            this.panTK.Controls.Add(this.siticoneHtmlLabel6);
            this.panTK.Controls.Add(this.lblTK);
            this.panTK.Controls.Add(this.panChuthich);
            this.panTK.FillColor = System.Drawing.Color.White;
            this.panTK.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panTK.Location = new System.Drawing.Point(220, 65);
            this.panTK.Margin = new System.Windows.Forms.Padding(2);
            this.panTK.Name = "panTK";
            this.panTK.Size = new System.Drawing.Size(980, 585);
            this.panTK.TabIndex = 120;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = false;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(38, 77);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(169, 33);
            this.lblYear.TabIndex = 48;
            this.lblYear.Text = "Chọn mốc thời gian";
            this.lblYear.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboMoctgian
            // 
            this.cboMoctgian.BackColor = System.Drawing.Color.Transparent;
            this.cboMoctgian.BorderColor = System.Drawing.Color.Lavender;
            this.cboMoctgian.BorderRadius = 15;
            this.cboMoctgian.BorderThickness = 0;
            this.cboMoctgian.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoctgian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoctgian.FillColor = System.Drawing.Color.Honeydew;
            this.cboMoctgian.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMoctgian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMoctgian.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cboMoctgian.ForeColor = System.Drawing.Color.Black;
            this.cboMoctgian.IntegralHeight = false;
            this.cboMoctgian.ItemHeight = 30;
            this.cboMoctgian.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cboMoctgian.Location = new System.Drawing.Point(216, 70);
            this.cboMoctgian.Name = "cboMoctgian";
            this.cboMoctgian.Size = new System.Drawing.Size(163, 36);
            this.cboMoctgian.TabIndex = 63;
            this.cboMoctgian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboMoctgian.SelectedIndexChanged += new System.EventHandler(this.cboMoctgian_SelectedIndexChanged);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(569, 257);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(395, 285);
            this.chart2.TabIndex = 53;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(15, 168);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(550, 394);
            this.chart1.TabIndex = 54;
            this.chart1.Text = "chart1";
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.AutoSize = false;
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(15, 55);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(550, 2);
            this.siticoneHtmlLabel6.TabIndex = 47;
            this.siticoneHtmlLabel6.Text = null;
            this.siticoneHtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = false;
            this.lblTK.BackColor = System.Drawing.Color.Transparent;
            this.lblTK.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.ForeColor = System.Drawing.Color.Black;
            this.lblTK.Location = new System.Drawing.Point(40, 13);
            this.lblTK.Margin = new System.Windows.Forms.Padding(4);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(464, 44);
            this.lblTK.TabIndex = 46;
            this.lblTK.Text = "Thông kê";
            this.lblTK.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panChuthich
            // 
            this.panChuthich.Controls.Add(this.lblDHFinish);
            this.panChuthich.Controls.Add(this.lblDHInProgress);
            this.panChuthich.Controls.Add(this.lblDHQuahan);
            this.panChuthich.Controls.Add(this.txtQuahan);
            this.panChuthich.Controls.Add(this.txtInProgress);
            this.panChuthich.Controls.Add(this.lblChuthich);
            this.panChuthich.Controls.Add(this.txtFinish);
            this.panChuthich.Location = new System.Drawing.Point(606, 55);
            this.panChuthich.Name = "panChuthich";
            this.panChuthich.Size = new System.Drawing.Size(337, 175);
            this.panChuthich.TabIndex = 62;
            // 
            // lblDHFinish
            // 
            this.lblDHFinish.AutoSize = false;
            this.lblDHFinish.BackColor = System.Drawing.Color.Transparent;
            this.lblDHFinish.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDHFinish.ForeColor = System.Drawing.Color.Green;
            this.lblDHFinish.Location = new System.Drawing.Point(13, 43);
            this.lblDHFinish.Margin = new System.Windows.Forms.Padding(4);
            this.lblDHFinish.Name = "lblDHFinish";
            this.lblDHFinish.Size = new System.Drawing.Size(210, 33);
            this.lblDHFinish.TabIndex = 58;
            this.lblDHFinish.Text = "Đơn hàng thành công:";
            this.lblDHFinish.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDHInProgress
            // 
            this.lblDHInProgress.AutoSize = false;
            this.lblDHInProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblDHInProgress.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDHInProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDHInProgress.Location = new System.Drawing.Point(6, 89);
            this.lblDHInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.lblDHInProgress.Name = "lblDHInProgress";
            this.lblDHInProgress.Size = new System.Drawing.Size(220, 33);
            this.lblDHInProgress.TabIndex = 57;
            this.lblDHInProgress.Text = "Đơn hàng đang thực hiện:";
            this.lblDHInProgress.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDHQuahan
            // 
            this.lblDHQuahan.AutoSize = false;
            this.lblDHQuahan.BackColor = System.Drawing.Color.Transparent;
            this.lblDHQuahan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDHQuahan.ForeColor = System.Drawing.Color.Red;
            this.lblDHQuahan.Location = new System.Drawing.Point(13, 127);
            this.lblDHQuahan.Margin = new System.Windows.Forms.Padding(4);
            this.lblDHQuahan.Name = "lblDHQuahan";
            this.lblDHQuahan.Size = new System.Drawing.Size(197, 33);
            this.lblDHQuahan.TabIndex = 56;
            this.lblDHQuahan.Text = "Đơn hàng đã quá hạn:";
            this.lblDHQuahan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuahan
            // 
            this.txtQuahan.BackColor = System.Drawing.Color.Transparent;
            this.txtQuahan.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtQuahan.BorderRadius = 10;
            this.txtQuahan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuahan.DefaultText = "";
            this.txtQuahan.FillColor = System.Drawing.Color.MintCream;
            this.txtQuahan.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtQuahan.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtQuahan.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQuahan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuahan.ForeColor = System.Drawing.Color.Black;
            this.txtQuahan.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtQuahan.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtQuahan.Location = new System.Drawing.Point(234, 127);
            this.txtQuahan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuahan.Name = "txtQuahan";
            this.txtQuahan.PasswordChar = '\0';
            this.txtQuahan.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQuahan.PlaceholderText = "";
            this.txtQuahan.SelectedText = "";
            this.txtQuahan.Size = new System.Drawing.Size(89, 35);
            this.txtQuahan.TabIndex = 60;
            // 
            // txtInProgress
            // 
            this.txtInProgress.BackColor = System.Drawing.Color.Transparent;
            this.txtInProgress.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInProgress.BorderRadius = 10;
            this.txtInProgress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInProgress.DefaultText = "";
            this.txtInProgress.FillColor = System.Drawing.Color.MintCream;
            this.txtInProgress.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInProgress.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtInProgress.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInProgress.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInProgress.ForeColor = System.Drawing.Color.Black;
            this.txtInProgress.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtInProgress.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtInProgress.Location = new System.Drawing.Point(234, 84);
            this.txtInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.txtInProgress.Name = "txtInProgress";
            this.txtInProgress.PasswordChar = '\0';
            this.txtInProgress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtInProgress.PlaceholderText = "";
            this.txtInProgress.SelectedText = "";
            this.txtInProgress.Size = new System.Drawing.Size(89, 35);
            this.txtInProgress.TabIndex = 61;
            // 
            // lblChuthich
            // 
            this.lblChuthich.AutoSize = false;
            this.lblChuthich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.lblChuthich.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChuthich.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuthich.ForeColor = System.Drawing.Color.White;
            this.lblChuthich.Location = new System.Drawing.Point(0, 0);
            this.lblChuthich.Margin = new System.Windows.Forms.Padding(4);
            this.lblChuthich.Name = "lblChuthich";
            this.lblChuthich.Size = new System.Drawing.Size(337, 33);
            this.lblChuthich.TabIndex = 55;
            this.lblChuthich.Text = "Bảng chú thích";
            this.lblChuthich.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFinish
            // 
            this.txtFinish.BackColor = System.Drawing.Color.Transparent;
            this.txtFinish.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFinish.BorderRadius = 10;
            this.txtFinish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinish.DefaultText = "";
            this.txtFinish.FillColor = System.Drawing.Color.MintCream;
            this.txtFinish.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFinish.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtFinish.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFinish.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinish.ForeColor = System.Drawing.Color.Black;
            this.txtFinish.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFinish.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtFinish.Location = new System.Drawing.Point(234, 41);
            this.txtFinish.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.PasswordChar = '\0';
            this.txtFinish.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFinish.PlaceholderText = "";
            this.txtFinish.SelectedText = "";
            this.txtFinish.Size = new System.Drawing.Size(89, 35);
            this.txtFinish.TabIndex = 59;
            // 
            // panDSDH
            // 
            this.panDSDH.Controls.Add(this.btnSortDH);
            this.panDSDH.Controls.Add(this.panDSHDnvchitiet);
            this.panDSDH.Controls.Add(this.panDSHDnv);
            this.panDSDH.Controls.Add(this.lblDSDH);
            this.panDSDH.Location = new System.Drawing.Point(220, 65);
            this.panDSDH.Name = "panDSDH";
            this.panDSDH.Size = new System.Drawing.Size(980, 585);
            this.panDSDH.TabIndex = 116;
            // 
            // btnSortDH
            // 
            this.btnSortDH.BackColor = System.Drawing.Color.MintCream;
            this.btnSortDH.BorderColor = System.Drawing.Color.MintCream;
            this.btnSortDH.BorderRadius = 5;
            this.btnSortDH.BorderThickness = 1;
            this.btnSortDH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortDH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortDH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortDH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortDH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortDH.FillColor = System.Drawing.Color.MintCream;
            this.btnSortDH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSortDH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortDH.ForeColor = System.Drawing.Color.White;
            this.btnSortDH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSortDH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortDH.Image = global::DuAnCNPM.Properties.Resources.sortGiam;
            this.btnSortDH.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSortDH.Location = new System.Drawing.Point(936, 9);
            this.btnSortDH.Name = "btnSortDH";
            this.btnSortDH.Size = new System.Drawing.Size(41, 41);
            this.btnSortDH.TabIndex = 79;
            this.btnSortDH.Click += new System.EventHandler(this.btnSortDH_Click);
            // 
            // panDSHDnvchitiet
            // 
            this.panDSHDnvchitiet.BackColor = System.Drawing.Color.Transparent;
            this.panDSHDnvchitiet.BorderRadius = 5;
            this.panDSHDnvchitiet.Controls.Add(this.splitDSHDnvchitiet);
            this.panDSHDnvchitiet.FillColor = System.Drawing.Color.Honeydew;
            this.panDSHDnvchitiet.FillColor2 = System.Drawing.Color.MintCream;
            this.panDSHDnvchitiet.FillColor3 = System.Drawing.Color.Honeydew;
            this.panDSHDnvchitiet.Location = new System.Drawing.Point(0, 0);
            this.panDSHDnvchitiet.Name = "panDSHDnvchitiet";
            this.panDSHDnvchitiet.Size = new System.Drawing.Size(720, 585);
            this.panDSHDnvchitiet.TabIndex = 77;
            // 
            // splitDSHDnvchitiet
            // 
            this.splitDSHDnvchitiet.BackColor = System.Drawing.Color.White;
            this.splitDSHDnvchitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDSHDnvchitiet.IsSplitterFixed = true;
            this.splitDSHDnvchitiet.Location = new System.Drawing.Point(0, 0);
            this.splitDSHDnvchitiet.Name = "splitDSHDnvchitiet";
            this.splitDSHDnvchitiet.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDSHDnvchitiet.Panel1
            // 
            this.splitDSHDnvchitiet.Panel1.BackColor = System.Drawing.Color.White;
            this.splitDSHDnvchitiet.Panel1.Controls.Add(this.btnFindma);
            this.splitDSHDnvchitiet.Panel1.Controls.Add(this.txtFindma);
            // 
            // splitDSHDnvchitiet.Panel2
            // 
            this.splitDSHDnvchitiet.Panel2.BackColor = System.Drawing.Color.White;
            this.splitDSHDnvchitiet.Panel2.Controls.Add(this.grbThongtinDH);
            this.splitDSHDnvchitiet.Panel2.Controls.Add(this.grbChucnang);
            this.splitDSHDnvchitiet.Panel2.Controls.Add(this.grpDulieuDH);
            this.splitDSHDnvchitiet.Size = new System.Drawing.Size(720, 585);
            this.splitDSHDnvchitiet.SplitterDistance = 57;
            this.splitDSHDnvchitiet.TabIndex = 0;
            // 
            // btnFindma
            // 
            this.btnFindma.BackColor = System.Drawing.Color.Transparent;
            this.btnFindma.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnFindma.BorderThickness = 1;
            this.btnFindma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindma.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindma.FillColor = System.Drawing.Color.MintCream;
            this.btnFindma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindma.ForeColor = System.Drawing.Color.White;
            this.btnFindma.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnFindma.HoverState.FillColor = System.Drawing.Color.Honeydew;
            this.btnFindma.Image = global::DuAnCNPM.Properties.Resources.magnifying_glass_search;
            this.btnFindma.ImageSize = new System.Drawing.Size(28, 28);
            this.btnFindma.Location = new System.Drawing.Point(17, 10);
            this.btnFindma.Name = "btnFindma";
            this.btnFindma.Size = new System.Drawing.Size(40, 40);
            this.btnFindma.TabIndex = 22;
            this.btnFindma.UseTransparentBackground = true;
            this.btnFindma.Click += new System.EventHandler(this.btnFindma_Click);
            // 
            // txtFindma
            // 
            this.txtFindma.BackColor = System.Drawing.Color.White;
            this.txtFindma.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFindma.BorderRadius = 21;
            this.txtFindma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindma.DefaultText = "";
            this.txtFindma.FillColor = System.Drawing.Color.MintCream;
            this.txtFindma.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFindma.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtFindma.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFindma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindma.ForeColor = System.Drawing.Color.Black;
            this.txtFindma.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFindma.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtFindma.Location = new System.Drawing.Point(64, 8);
            this.txtFindma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindma.Name = "txtFindma";
            this.txtFindma.PasswordChar = '\0';
            this.txtFindma.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFindma.PlaceholderText = "Tìm kiếm theo mã đơn hàng";
            this.txtFindma.SelectedText = "";
            this.txtFindma.Size = new System.Drawing.Size(650, 45);
            this.txtFindma.TabIndex = 21;
            // 
            // grbThongtinDH
            // 
            this.grbThongtinDH.Controls.Add(this.txtMaThongSo);
            this.grbThongtinDH.Controls.Add(this.label4);
            this.grbThongtinDH.Controls.Add(this.txtMadonhang);
            this.grbThongtinDH.Controls.Add(this.lblMadonhang);
            this.grbThongtinDH.Controls.Add(this.lblGhichu);
            this.grbThongtinDH.Controls.Add(this.txtGhichu);
            this.grbThongtinDH.Controls.Add(this.txtTenthongso);
            this.grbThongtinDH.Controls.Add(this.txtKetqua);
            this.grbThongtinDH.Controls.Add(this.lblTenthongso);
            this.grbThongtinDH.Controls.Add(this.lblKetqua);
            this.grbThongtinDH.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongtinDH.ForeColor = System.Drawing.Color.Black;
            this.grbThongtinDH.Location = new System.Drawing.Point(3, 3);
            this.grbThongtinDH.Name = "grbThongtinDH";
            this.grbThongtinDH.Size = new System.Drawing.Size(714, 171);
            this.grbThongtinDH.TabIndex = 8;
            this.grbThongtinDH.TabStop = false;
            this.grbThongtinDH.Text = "Thông tin đơn hàng";
            // 
            // txtMaThongSo
            // 
            this.txtMaThongSo.BackColor = System.Drawing.Color.Transparent;
            this.txtMaThongSo.BorderColor = System.Drawing.Color.Black;
            this.txtMaThongSo.BorderRadius = 15;
            this.txtMaThongSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaThongSo.DefaultText = "";
            this.txtMaThongSo.Enabled = false;
            this.txtMaThongSo.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaThongSo.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMaThongSo.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMaThongSo.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMaThongSo.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaThongSo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThongSo.ForeColor = System.Drawing.Color.Black;
            this.txtMaThongSo.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaThongSo.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMaThongSo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMaThongSo.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaThongSo.Location = new System.Drawing.Point(467, 29);
            this.txtMaThongSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThongSo.Name = "txtMaThongSo";
            this.txtMaThongSo.PasswordChar = '\0';
            this.txtMaThongSo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaThongSo.PlaceholderText = "Mã thông số";
            this.txtMaThongSo.SelectedText = "";
            this.txtMaThongSo.Size = new System.Drawing.Size(225, 35);
            this.txtMaThongSo.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mã";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMadonhang
            // 
            this.txtMadonhang.BackColor = System.Drawing.Color.Transparent;
            this.txtMadonhang.BorderColor = System.Drawing.Color.Black;
            this.txtMadonhang.BorderRadius = 15;
            this.txtMadonhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMadonhang.DefaultText = "";
            this.txtMadonhang.Enabled = false;
            this.txtMadonhang.FillColor = System.Drawing.SystemColors.Window;
            this.txtMadonhang.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtMadonhang.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtMadonhang.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtMadonhang.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMadonhang.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadonhang.ForeColor = System.Drawing.Color.Black;
            this.txtMadonhang.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMadonhang.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtMadonhang.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtMadonhang.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMadonhang.Location = new System.Drawing.Point(137, 30);
            this.txtMadonhang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMadonhang.Name = "txtMadonhang";
            this.txtMadonhang.PasswordChar = '\0';
            this.txtMadonhang.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMadonhang.PlaceholderText = "Mã đơn hàng";
            this.txtMadonhang.SelectedText = "";
            this.txtMadonhang.Size = new System.Drawing.Size(225, 35);
            this.txtMadonhang.TabIndex = 26;
            // 
            // lblMadonhang
            // 
            this.lblMadonhang.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadonhang.Location = new System.Drawing.Point(10, 35);
            this.lblMadonhang.Name = "lblMadonhang";
            this.lblMadonhang.Size = new System.Drawing.Size(148, 25);
            this.lblMadonhang.TabIndex = 25;
            this.lblMadonhang.Text = "Mã đơn hàng:";
            this.lblMadonhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGhichu
            // 
            this.lblGhichu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhichu.Location = new System.Drawing.Point(10, 125);
            this.lblGhichu.Name = "lblGhichu";
            this.lblGhichu.Size = new System.Drawing.Size(125, 25);
            this.lblGhichu.TabIndex = 24;
            this.lblGhichu.Text = "Ghi chú:";
            this.lblGhichu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGhichu
            // 
            this.txtGhichu.BackColor = System.Drawing.Color.Transparent;
            this.txtGhichu.BorderColor = System.Drawing.Color.Black;
            this.txtGhichu.BorderRadius = 15;
            this.txtGhichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhichu.DefaultText = "";
            this.txtGhichu.Enabled = false;
            this.txtGhichu.FillColor = System.Drawing.SystemColors.Window;
            this.txtGhichu.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtGhichu.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtGhichu.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtGhichu.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGhichu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.ForeColor = System.Drawing.Color.Black;
            this.txtGhichu.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtGhichu.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtGhichu.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtGhichu.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGhichu.Location = new System.Drawing.Point(137, 120);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.PasswordChar = '\0';
            this.txtGhichu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGhichu.PlaceholderText = "Ghi chú";
            this.txtGhichu.SelectedText = "";
            this.txtGhichu.Size = new System.Drawing.Size(555, 35);
            this.txtGhichu.TabIndex = 23;
            // 
            // txtTenthongso
            // 
            this.txtTenthongso.BackColor = System.Drawing.Color.Transparent;
            this.txtTenthongso.BorderColor = System.Drawing.Color.Black;
            this.txtTenthongso.BorderRadius = 15;
            this.txtTenthongso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenthongso.DefaultText = "";
            this.txtTenthongso.Enabled = false;
            this.txtTenthongso.FillColor = System.Drawing.SystemColors.Window;
            this.txtTenthongso.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtTenthongso.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtTenthongso.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtTenthongso.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenthongso.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenthongso.ForeColor = System.Drawing.Color.Black;
            this.txtTenthongso.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtTenthongso.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtTenthongso.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtTenthongso.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenthongso.Location = new System.Drawing.Point(137, 75);
            this.txtTenthongso.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenthongso.Name = "txtTenthongso";
            this.txtTenthongso.PasswordChar = '\0';
            this.txtTenthongso.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenthongso.PlaceholderText = "Tên thông số";
            this.txtTenthongso.SelectedText = "";
            this.txtTenthongso.Size = new System.Drawing.Size(225, 35);
            this.txtTenthongso.TabIndex = 21;
            // 
            // txtKetqua
            // 
            this.txtKetqua.BackColor = System.Drawing.Color.Transparent;
            this.txtKetqua.BorderColor = System.Drawing.Color.Black;
            this.txtKetqua.BorderRadius = 15;
            this.txtKetqua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKetqua.DefaultText = "";
            this.txtKetqua.Enabled = false;
            this.txtKetqua.FillColor = System.Drawing.SystemColors.Window;
            this.txtKetqua.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.txtKetqua.FocusedState.FillColor = System.Drawing.Color.Honeydew;
            this.txtKetqua.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtKetqua.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKetqua.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetqua.ForeColor = System.Drawing.Color.Black;
            this.txtKetqua.HoverState.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtKetqua.HoverState.FillColor = System.Drawing.Color.Azure;
            this.txtKetqua.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtKetqua.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKetqua.Location = new System.Drawing.Point(467, 75);
            this.txtKetqua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.PasswordChar = '\0';
            this.txtKetqua.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKetqua.PlaceholderText = "Kết quả";
            this.txtKetqua.SelectedText = "";
            this.txtKetqua.Size = new System.Drawing.Size(225, 35);
            this.txtKetqua.TabIndex = 20;
            // 
            // lblTenthongso
            // 
            this.lblTenthongso.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenthongso.Location = new System.Drawing.Point(10, 80);
            this.lblTenthongso.Name = "lblTenthongso";
            this.lblTenthongso.Size = new System.Drawing.Size(125, 25);
            this.lblTenthongso.TabIndex = 17;
            this.lblTenthongso.Text = "Tên thông số:";
            this.lblTenthongso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKetqua
            // 
            this.lblKetqua.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(382, 80);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(111, 25);
            this.lblKetqua.TabIndex = 16;
            this.lblKetqua.Text = "Kết quả:";
            this.lblKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbChucnang
            // 
            this.grbChucnang.BackColor = System.Drawing.Color.White;
            this.grbChucnang.Controls.Add(this.btnPrint);
            this.grbChucnang.Controls.Add(this.btnLuu);
            this.grbChucnang.Controls.Add(this.btnSua);
            this.grbChucnang.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucnang.ForeColor = System.Drawing.Color.Black;
            this.grbChucnang.Location = new System.Drawing.Point(3, 180);
            this.grbChucnang.Name = "grbChucnang";
            this.grbChucnang.Size = new System.Drawing.Size(714, 61);
            this.grbChucnang.TabIndex = 9;
            this.grbChucnang.TabStop = false;
            this.grbChucnang.Text = "Chức năng";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnPrint.BorderRadius = 15;
            this.btnPrint.BorderThickness = 1;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Enabled = false;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnPrint.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnPrint.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(320, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 40);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "In";
            this.btnPrint.UseTransparentBackground = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnLuu.BorderRadius = 15;
            this.btnLuu.BorderThickness = 1;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Enabled = false;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnLuu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.Magenta;
            this.btnLuu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(230, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 40);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseTransparentBackground = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnSua.BorderRadius = 15;
            this.btnSua.BorderThickness = 1;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Enabled = false;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnSua.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnSua.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.btnSua.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(140, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 40);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseTransparentBackground = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grpDulieuDH
            // 
            this.grpDulieuDH.BackColor = System.Drawing.Color.White;
            this.grpDulieuDH.Controls.Add(this.lvDulieudonhang);
            this.grpDulieuDH.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDulieuDH.Location = new System.Drawing.Point(3, 247);
            this.grpDulieuDH.Name = "grpDulieuDH";
            this.grpDulieuDH.Size = new System.Drawing.Size(714, 273);
            this.grpDulieuDH.TabIndex = 10;
            this.grpDulieuDH.TabStop = false;
            this.grpDulieuDH.Text = "Dữ liệu đơn hàng";
            // 
            // lvDulieudonhang
            // 
            this.lvDulieudonhang.BackColor = System.Drawing.Color.White;
            this.lvDulieudonhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDulieudonhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDulieudonhang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDulieudonhang.ForeColor = System.Drawing.Color.Black;
            this.lvDulieudonhang.FullRowSelect = true;
            this.lvDulieudonhang.GridLines = true;
            this.lvDulieudonhang.HideSelection = false;
            this.lvDulieudonhang.Location = new System.Drawing.Point(3, 25);
            this.lvDulieudonhang.Name = "lvDulieudonhang";
            this.lvDulieudonhang.Size = new System.Drawing.Size(708, 245);
            this.lvDulieudonhang.TabIndex = 1;
            this.lvDulieudonhang.TileSize = new System.Drawing.Size(300, 40);
            this.lvDulieudonhang.UseCompatibleStateImageBehavior = false;
            this.lvDulieudonhang.View = System.Windows.Forms.View.Details;
            this.lvDulieudonhang.SelectedIndexChanged += new System.EventHandler(this.lvDulieudonhang_SelectedIndexChanged);
            // 
            // panDSHDnv
            // 
            this.panDSHDnv.AutoScroll = true;
            this.panDSHDnv.BackColor = System.Drawing.Color.White;
            this.panDSHDnv.BorderColor = System.Drawing.Color.White;
            this.panDSHDnv.FillColor = System.Drawing.Color.White;
            this.panDSHDnv.Location = new System.Drawing.Point(721, 60);
            this.panDSHDnv.Name = "panDSHDnv";
            this.panDSHDnv.Size = new System.Drawing.Size(259, 525);
            this.panDSHDnv.TabIndex = 80;
            // 
            // lblDSDH
            // 
            this.lblDSDH.AutoSize = false;
            this.lblDSDH.BackColor = System.Drawing.Color.White;
            this.lblDSDH.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSDH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDSDH.Location = new System.Drawing.Point(721, 0);
            this.lblDSDH.Name = "lblDSDH";
            this.lblDSDH.Size = new System.Drawing.Size(259, 60);
            this.lblDSDH.TabIndex = 78;
            this.lblDSDH.Text = "Danh sách đơn hàng";
            this.lblDSDH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panTTNV
            // 
            this.panTTNV.AutoScroll = true;
            this.panTTNV.BackColor = System.Drawing.Color.Transparent;
            this.panTTNV.Controls.Add(this.grbQuoctich);
            this.panTTNV.Controls.Add(this.lblQuoctich);
            this.panTTNV.Controls.Add(this.grbDiachithuongtru);
            this.panTTNV.Controls.Add(this.lblDiachithuongtru);
            this.panTTNV.Controls.Add(this.grbQuequan);
            this.panTTNV.Controls.Add(this.lblQuequan);
            this.panTTNV.Controls.Add(this.grbDantoc);
            this.panTTNV.Controls.Add(this.grbNoioCurrent);
            this.panTTNV.Controls.Add(this.lblDantoc);
            this.panTTNV.Controls.Add(this.lblNoioCurrent);
            this.panTTNV.Controls.Add(this.grbNoisinh);
            this.panTTNV.Controls.Add(this.lblNoisinh);
            this.panTTNV.Controls.Add(this.lblThongtinCN);
            this.panTTNV.Controls.Add(this.lblHinhanhCN);
            this.panTTNV.Controls.Add(this.picInformation);
            this.panTTNV.Controls.Add(this.grbChucvu);
            this.panTTNV.Controls.Add(this.lblChucvu);
            this.panTTNV.Controls.Add(this.grbPhongban);
            this.panTTNV.Controls.Add(this.lblPhongban);
            this.panTTNV.Controls.Add(this.grbSex);
            this.panTTNV.Controls.Add(this.grbEmail);
            this.panTTNV.Controls.Add(this.lblEmail);
            this.panTTNV.Controls.Add(this.grbName);
            this.panTTNV.Controls.Add(this.lblName);
            this.panTTNV.Controls.Add(this.lblSex);
            this.panTTNV.Controls.Add(this.grbNgaysinh);
            this.panTTNV.Controls.Add(this.grbSdt);
            this.panTTNV.Controls.Add(this.lblNgaysinh);
            this.panTTNV.Controls.Add(this.lblSdt);
            this.panTTNV.Controls.Add(this.grbMa);
            this.panTTNV.Controls.Add(this.lblMa);
            this.panTTNV.Controls.Add(this.lblThongtinNhanvien);
            this.panTTNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panTTNV.Location = new System.Drawing.Point(220, 65);
            this.panTTNV.Margin = new System.Windows.Forms.Padding(2);
            this.panTTNV.Name = "panTTNV";
            this.panTTNV.Size = new System.Drawing.Size(980, 585);
            this.panTTNV.TabIndex = 117;
            // 
            // grbQuoctich
            // 
            this.grbQuoctich.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbQuoctich.BorderRadius = 20;
            this.grbQuoctich.Controls.Add(this.txtQuoctich);
            this.grbQuoctich.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbQuoctich.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbQuoctich.FillColor = System.Drawing.Color.Honeydew;
            this.grbQuoctich.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbQuoctich.ForeColor = System.Drawing.Color.Black;
            this.grbQuoctich.Location = new System.Drawing.Point(757, 527);
            this.grbQuoctich.Name = "grbQuoctich";
            this.grbQuoctich.Size = new System.Drawing.Size(194, 45);
            this.grbQuoctich.TabIndex = 50;
            this.grbQuoctich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuoctich
            // 
            this.txtQuoctich.BorderColor = System.Drawing.Color.Lavender;
            this.txtQuoctich.BorderRadius = 15;
            this.txtQuoctich.BorderThickness = 0;
            this.txtQuoctich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuoctich.DefaultText = "NV001";
            this.txtQuoctich.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuoctich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuoctich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuoctich.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuoctich.FillColor = System.Drawing.Color.Honeydew;
            this.txtQuoctich.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuoctich.ForeColor = System.Drawing.Color.Black;
            this.txtQuoctich.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuoctich.Location = new System.Drawing.Point(15, 8);
            this.txtQuoctich.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuoctich.Name = "txtQuoctich";
            this.txtQuoctich.PasswordChar = '\0';
            this.txtQuoctich.PlaceholderText = "";
            this.txtQuoctich.ReadOnly = true;
            this.txtQuoctich.SelectedText = "";
            this.txtQuoctich.Size = new System.Drawing.Size(163, 30);
            this.txtQuoctich.TabIndex = 0;
            this.txtQuoctich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuoctich
            // 
            this.lblQuoctich.AutoSize = false;
            this.lblQuoctich.BackColor = System.Drawing.Color.Transparent;
            this.lblQuoctich.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoctich.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuoctich.Location = new System.Drawing.Point(777, 502);
            this.lblQuoctich.Name = "lblQuoctich";
            this.lblQuoctich.Size = new System.Drawing.Size(200, 24);
            this.lblQuoctich.TabIndex = 51;
            this.lblQuoctich.Text = "Quốc tịch";
            this.lblQuoctich.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbDiachithuongtru
            // 
            this.grbDiachithuongtru.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbDiachithuongtru.BorderRadius = 20;
            this.grbDiachithuongtru.Controls.Add(this.txtDiachithuongtru);
            this.grbDiachithuongtru.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbDiachithuongtru.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbDiachithuongtru.FillColor = System.Drawing.Color.Honeydew;
            this.grbDiachithuongtru.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbDiachithuongtru.ForeColor = System.Drawing.Color.Black;
            this.grbDiachithuongtru.Location = new System.Drawing.Point(498, 602);
            this.grbDiachithuongtru.Name = "grbDiachithuongtru";
            this.grbDiachithuongtru.Size = new System.Drawing.Size(453, 45);
            this.grbDiachithuongtru.TabIndex = 48;
            this.grbDiachithuongtru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiachithuongtru
            // 
            this.txtDiachithuongtru.BorderColor = System.Drawing.Color.Lavender;
            this.txtDiachithuongtru.BorderRadius = 15;
            this.txtDiachithuongtru.BorderThickness = 0;
            this.txtDiachithuongtru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachithuongtru.DefaultText = "thehoang.acc@gmail.com";
            this.txtDiachithuongtru.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachithuongtru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachithuongtru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachithuongtru.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachithuongtru.FillColor = System.Drawing.Color.Honeydew;
            this.txtDiachithuongtru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachithuongtru.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtDiachithuongtru.ForeColor = System.Drawing.Color.Black;
            this.txtDiachithuongtru.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachithuongtru.Location = new System.Drawing.Point(15, 8);
            this.txtDiachithuongtru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachithuongtru.Name = "txtDiachithuongtru";
            this.txtDiachithuongtru.PasswordChar = '\0';
            this.txtDiachithuongtru.PlaceholderText = "";
            this.txtDiachithuongtru.ReadOnly = true;
            this.txtDiachithuongtru.SelectedText = "";
            this.txtDiachithuongtru.Size = new System.Drawing.Size(422, 30);
            this.txtDiachithuongtru.TabIndex = 2;
            this.txtDiachithuongtru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiachithuongtru
            // 
            this.lblDiachithuongtru.AutoSize = false;
            this.lblDiachithuongtru.BackColor = System.Drawing.Color.Transparent;
            this.lblDiachithuongtru.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachithuongtru.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDiachithuongtru.Location = new System.Drawing.Point(513, 578);
            this.lblDiachithuongtru.Name = "lblDiachithuongtru";
            this.lblDiachithuongtru.Size = new System.Drawing.Size(337, 24);
            this.lblDiachithuongtru.TabIndex = 49;
            this.lblDiachithuongtru.Text = "Địa chỉ thường trú";
            this.lblDiachithuongtru.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbQuequan
            // 
            this.grbQuequan.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbQuequan.BorderRadius = 20;
            this.grbQuequan.Controls.Add(this.txtQuequan);
            this.grbQuequan.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbQuequan.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbQuequan.FillColor = System.Drawing.Color.Honeydew;
            this.grbQuequan.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbQuequan.ForeColor = System.Drawing.Color.Black;
            this.grbQuequan.Location = new System.Drawing.Point(289, 527);
            this.grbQuequan.Name = "grbQuequan";
            this.grbQuequan.Size = new System.Drawing.Size(247, 45);
            this.grbQuequan.TabIndex = 42;
            this.grbQuequan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuequan
            // 
            this.txtQuequan.BorderColor = System.Drawing.Color.Lavender;
            this.txtQuequan.BorderRadius = 15;
            this.txtQuequan.BorderThickness = 0;
            this.txtQuequan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuequan.DefaultText = "Hoàng Công Tài Thế ";
            this.txtQuequan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuequan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuequan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuequan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuequan.FillColor = System.Drawing.Color.Honeydew;
            this.txtQuequan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuequan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuequan.ForeColor = System.Drawing.Color.Black;
            this.txtQuequan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuequan.Location = new System.Drawing.Point(15, 8);
            this.txtQuequan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.PasswordChar = '\0';
            this.txtQuequan.PlaceholderText = "";
            this.txtQuequan.ReadOnly = true;
            this.txtQuequan.SelectedText = "";
            this.txtQuequan.Size = new System.Drawing.Size(235, 33);
            this.txtQuequan.TabIndex = 1;
            this.txtQuequan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuequan
            // 
            this.lblQuequan.AutoSize = false;
            this.lblQuequan.BackColor = System.Drawing.Color.Transparent;
            this.lblQuequan.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuequan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuequan.Location = new System.Drawing.Point(319, 502);
            this.lblQuequan.Name = "lblQuequan";
            this.lblQuequan.Size = new System.Drawing.Size(200, 24);
            this.lblQuequan.TabIndex = 43;
            this.lblQuequan.Text = "Quê quán";
            this.lblQuequan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbDantoc
            // 
            this.grbDantoc.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbDantoc.BorderRadius = 20;
            this.grbDantoc.Controls.Add(this.txtDantoc);
            this.grbDantoc.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbDantoc.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbDantoc.FillColor = System.Drawing.Color.Honeydew;
            this.grbDantoc.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbDantoc.ForeColor = System.Drawing.Color.Black;
            this.grbDantoc.Location = new System.Drawing.Point(551, 527);
            this.grbDantoc.Name = "grbDantoc";
            this.grbDantoc.Size = new System.Drawing.Size(194, 45);
            this.grbDantoc.TabIndex = 44;
            this.grbDantoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDantoc
            // 
            this.txtDantoc.BorderColor = System.Drawing.Color.Lavender;
            this.txtDantoc.BorderRadius = 15;
            this.txtDantoc.BorderThickness = 0;
            this.txtDantoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDantoc.DefaultText = "20/01/2005";
            this.txtDantoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDantoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDantoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDantoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDantoc.FillColor = System.Drawing.Color.Honeydew;
            this.txtDantoc.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDantoc.ForeColor = System.Drawing.Color.Black;
            this.txtDantoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDantoc.Location = new System.Drawing.Point(16, 8);
            this.txtDantoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDantoc.Name = "txtDantoc";
            this.txtDantoc.PasswordChar = '\0';
            this.txtDantoc.PlaceholderText = "";
            this.txtDantoc.ReadOnly = true;
            this.txtDantoc.SelectedText = "";
            this.txtDantoc.Size = new System.Drawing.Size(163, 30);
            this.txtDantoc.TabIndex = 81;
            this.txtDantoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbNoioCurrent
            // 
            this.grbNoioCurrent.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbNoioCurrent.BorderRadius = 20;
            this.grbNoioCurrent.Controls.Add(this.txtNoioCurrent);
            this.grbNoioCurrent.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbNoioCurrent.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbNoioCurrent.FillColor = System.Drawing.Color.Honeydew;
            this.grbNoioCurrent.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbNoioCurrent.ForeColor = System.Drawing.Color.Black;
            this.grbNoioCurrent.Location = new System.Drawing.Point(29, 602);
            this.grbNoioCurrent.Name = "grbNoioCurrent";
            this.grbNoioCurrent.Size = new System.Drawing.Size(453, 45);
            this.grbNoioCurrent.TabIndex = 46;
            this.grbNoioCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoioCurrent
            // 
            this.txtNoioCurrent.BorderColor = System.Drawing.Color.Lavender;
            this.txtNoioCurrent.BorderRadius = 15;
            this.txtNoioCurrent.BorderThickness = 0;
            this.txtNoioCurrent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoioCurrent.DefaultText = "0373606590";
            this.txtNoioCurrent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoioCurrent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoioCurrent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoioCurrent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoioCurrent.FillColor = System.Drawing.Color.Honeydew;
            this.txtNoioCurrent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoioCurrent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtNoioCurrent.ForeColor = System.Drawing.Color.Black;
            this.txtNoioCurrent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoioCurrent.Location = new System.Drawing.Point(15, 8);
            this.txtNoioCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoioCurrent.Name = "txtNoioCurrent";
            this.txtNoioCurrent.PasswordChar = '\0';
            this.txtNoioCurrent.PlaceholderText = "";
            this.txtNoioCurrent.ReadOnly = true;
            this.txtNoioCurrent.SelectedText = "";
            this.txtNoioCurrent.Size = new System.Drawing.Size(422, 30);
            this.txtNoioCurrent.TabIndex = 1;
            this.txtNoioCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDantoc
            // 
            this.lblDantoc.AutoSize = false;
            this.lblDantoc.BackColor = System.Drawing.Color.Transparent;
            this.lblDantoc.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDantoc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDantoc.Location = new System.Drawing.Point(571, 502);
            this.lblDantoc.Name = "lblDantoc";
            this.lblDantoc.Size = new System.Drawing.Size(200, 24);
            this.lblDantoc.TabIndex = 45;
            this.lblDantoc.Text = "Dân tộc";
            this.lblDantoc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoioCurrent
            // 
            this.lblNoioCurrent.AutoSize = false;
            this.lblNoioCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblNoioCurrent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoioCurrent.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNoioCurrent.Location = new System.Drawing.Point(44, 578);
            this.lblNoioCurrent.Name = "lblNoioCurrent";
            this.lblNoioCurrent.Size = new System.Drawing.Size(200, 24);
            this.lblNoioCurrent.TabIndex = 47;
            this.lblNoioCurrent.Text = "Nơi ở hiện nay";
            this.lblNoioCurrent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbNoisinh
            // 
            this.grbNoisinh.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbNoisinh.BorderRadius = 20;
            this.grbNoisinh.Controls.Add(this.txtNoisinh);
            this.grbNoisinh.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbNoisinh.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbNoisinh.FillColor = System.Drawing.Color.Honeydew;
            this.grbNoisinh.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbNoisinh.ForeColor = System.Drawing.Color.Black;
            this.grbNoisinh.Location = new System.Drawing.Point(29, 527);
            this.grbNoisinh.Name = "grbNoisinh";
            this.grbNoisinh.Size = new System.Drawing.Size(247, 45);
            this.grbNoisinh.TabIndex = 40;
            this.grbNoisinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoisinh
            // 
            this.txtNoisinh.BorderColor = System.Drawing.Color.Lavender;
            this.txtNoisinh.BorderRadius = 15;
            this.txtNoisinh.BorderThickness = 0;
            this.txtNoisinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoisinh.DefaultText = "NV001";
            this.txtNoisinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoisinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoisinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoisinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoisinh.FillColor = System.Drawing.Color.Honeydew;
            this.txtNoisinh.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoisinh.ForeColor = System.Drawing.Color.Black;
            this.txtNoisinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoisinh.Location = new System.Drawing.Point(15, 8);
            this.txtNoisinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoisinh.Name = "txtNoisinh";
            this.txtNoisinh.PasswordChar = '\0';
            this.txtNoisinh.PlaceholderText = "";
            this.txtNoisinh.ReadOnly = true;
            this.txtNoisinh.SelectedText = "";
            this.txtNoisinh.Size = new System.Drawing.Size(220, 30);
            this.txtNoisinh.TabIndex = 0;
            this.txtNoisinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNoisinh
            // 
            this.lblNoisinh.AutoSize = false;
            this.lblNoisinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNoisinh.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoisinh.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNoisinh.Location = new System.Drawing.Point(49, 502);
            this.lblNoisinh.Name = "lblNoisinh";
            this.lblNoisinh.Size = new System.Drawing.Size(200, 24);
            this.lblNoisinh.TabIndex = 41;
            this.lblNoisinh.Text = "Nơi sinh";
            this.lblNoisinh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThongtinCN
            // 
            this.lblThongtinCN.AutoSize = false;
            this.lblThongtinCN.BackColor = System.Drawing.Color.Transparent;
            this.lblThongtinCN.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinCN.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblThongtinCN.Location = new System.Drawing.Point(0, 456);
            this.lblThongtinCN.Name = "lblThongtinCN";
            this.lblThongtinCN.Size = new System.Drawing.Size(980, 40);
            this.lblThongtinCN.TabIndex = 39;
            this.lblThongtinCN.Text = "Thông tin cá nhân";
            this.lblThongtinCN.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHinhanhCN
            // 
            this.lblHinhanhCN.AutoSize = false;
            this.lblHinhanhCN.BackColor = System.Drawing.Color.Transparent;
            this.lblHinhanhCN.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhanhCN.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHinhanhCN.Location = new System.Drawing.Point(0, 197);
            this.lblHinhanhCN.Name = "lblHinhanhCN";
            this.lblHinhanhCN.Size = new System.Drawing.Size(980, 40);
            this.lblHinhanhCN.TabIndex = 38;
            this.lblHinhanhCN.Text = "Hình ảnh cá nhân";
            this.lblHinhanhCN.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picInformation
            // 
            this.picInformation.Image = ((System.Drawing.Image)(resources.GetObject("picInformation.Image")));
            this.picInformation.ImageLocation = "";
            this.picInformation.ImageRotate = 0F;
            this.picInformation.Location = new System.Drawing.Point(403, 243);
            this.picInformation.Name = "picInformation";
            this.picInformation.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.picInformation.Size = new System.Drawing.Size(174, 200);
            this.picInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInformation.TabIndex = 37;
            this.picInformation.TabStop = false;
            // 
            // grbChucvu
            // 
            this.grbChucvu.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbChucvu.BorderRadius = 20;
            this.grbChucvu.Controls.Add(this.txtChucvu);
            this.grbChucvu.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbChucvu.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbChucvu.FillColor = System.Drawing.Color.Honeydew;
            this.grbChucvu.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbChucvu.ForeColor = System.Drawing.Color.Black;
            this.grbChucvu.Location = new System.Drawing.Point(757, 146);
            this.grbChucvu.Name = "grbChucvu";
            this.grbChucvu.Size = new System.Drawing.Size(194, 45);
            this.grbChucvu.TabIndex = 35;
            this.grbChucvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChucvu
            // 
            this.txtChucvu.BorderColor = System.Drawing.Color.Lavender;
            this.txtChucvu.BorderRadius = 15;
            this.txtChucvu.BorderThickness = 0;
            this.txtChucvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChucvu.DefaultText = "0373606590";
            this.txtChucvu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChucvu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChucvu.FillColor = System.Drawing.Color.Honeydew;
            this.txtChucvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChucvu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucvu.ForeColor = System.Drawing.Color.Black;
            this.txtChucvu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChucvu.Location = new System.Drawing.Point(15, 8);
            this.txtChucvu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.PasswordChar = '\0';
            this.txtChucvu.PlaceholderText = "";
            this.txtChucvu.ReadOnly = true;
            this.txtChucvu.SelectedText = "";
            this.txtChucvu.Size = new System.Drawing.Size(163, 30);
            this.txtChucvu.TabIndex = 1;
            this.txtChucvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = false;
            this.lblChucvu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucvu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblChucvu.Location = new System.Drawing.Point(777, 121);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(200, 24);
            this.lblChucvu.TabIndex = 36;
            this.lblChucvu.Text = "Chức vụ";
            this.lblChucvu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbPhongban
            // 
            this.grbPhongban.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbPhongban.BorderRadius = 20;
            this.grbPhongban.Controls.Add(this.txtPhongban);
            this.grbPhongban.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbPhongban.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbPhongban.FillColor = System.Drawing.Color.Honeydew;
            this.grbPhongban.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbPhongban.ForeColor = System.Drawing.Color.Black;
            this.grbPhongban.Location = new System.Drawing.Point(757, 71);
            this.grbPhongban.Name = "grbPhongban";
            this.grbPhongban.Size = new System.Drawing.Size(194, 45);
            this.grbPhongban.TabIndex = 33;
            this.grbPhongban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhongban
            // 
            this.txtPhongban.BorderColor = System.Drawing.Color.Lavender;
            this.txtPhongban.BorderRadius = 15;
            this.txtPhongban.BorderThickness = 0;
            this.txtPhongban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhongban.DefaultText = "NV001";
            this.txtPhongban.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhongban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhongban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhongban.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhongban.FillColor = System.Drawing.Color.Honeydew;
            this.txtPhongban.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongban.ForeColor = System.Drawing.Color.Black;
            this.txtPhongban.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhongban.Location = new System.Drawing.Point(15, 8);
            this.txtPhongban.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhongban.Name = "txtPhongban";
            this.txtPhongban.PasswordChar = '\0';
            this.txtPhongban.PlaceholderText = "";
            this.txtPhongban.ReadOnly = true;
            this.txtPhongban.SelectedText = "";
            this.txtPhongban.Size = new System.Drawing.Size(163, 30);
            this.txtPhongban.TabIndex = 0;
            this.txtPhongban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhongban
            // 
            this.lblPhongban.AutoSize = false;
            this.lblPhongban.BackColor = System.Drawing.Color.Transparent;
            this.lblPhongban.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongban.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPhongban.Location = new System.Drawing.Point(777, 46);
            this.lblPhongban.Name = "lblPhongban";
            this.lblPhongban.Size = new System.Drawing.Size(200, 24);
            this.lblPhongban.TabIndex = 34;
            this.lblPhongban.Text = "Phòng ban";
            this.lblPhongban.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbSex
            // 
            this.grbSex.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbSex.BorderRadius = 20;
            this.grbSex.Controls.Add(this.cboSexnv);
            this.grbSex.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbSex.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbSex.Enabled = false;
            this.grbSex.FillColor = System.Drawing.Color.Honeydew;
            this.grbSex.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSex.ForeColor = System.Drawing.Color.Black;
            this.grbSex.Location = new System.Drawing.Point(551, 146);
            this.grbSex.Name = "grbSex";
            this.grbSex.Size = new System.Drawing.Size(194, 45);
            this.grbSex.TabIndex = 27;
            this.grbSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboSexnv
            // 
            this.cboSexnv.BackColor = System.Drawing.Color.Transparent;
            this.cboSexnv.BorderColor = System.Drawing.Color.Lavender;
            this.cboSexnv.BorderRadius = 15;
            this.cboSexnv.BorderThickness = 0;
            this.cboSexnv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSexnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexnv.FillColor = System.Drawing.Color.Honeydew;
            this.cboSexnv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSexnv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSexnv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cboSexnv.ForeColor = System.Drawing.Color.Black;
            this.cboSexnv.IntegralHeight = false;
            this.cboSexnv.ItemHeight = 30;
            this.cboSexnv.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cboSexnv.Location = new System.Drawing.Point(16, 5);
            this.cboSexnv.Name = "cboSexnv";
            this.cboSexnv.Size = new System.Drawing.Size(163, 36);
            this.cboSexnv.TabIndex = 44;
            this.cboSexnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbEmail
            // 
            this.grbEmail.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbEmail.BorderRadius = 20;
            this.grbEmail.Controls.Add(this.txtEmailnv);
            this.grbEmail.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbEmail.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbEmail.FillColor = System.Drawing.Color.Honeydew;
            this.grbEmail.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbEmail.ForeColor = System.Drawing.Color.Black;
            this.grbEmail.Location = new System.Drawing.Point(236, 144);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(300, 45);
            this.grbEmail.TabIndex = 30;
            this.grbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmailnv
            // 
            this.txtEmailnv.BorderColor = System.Drawing.Color.Lavender;
            this.txtEmailnv.BorderRadius = 15;
            this.txtEmailnv.BorderThickness = 0;
            this.txtEmailnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailnv.DefaultText = "thehoang.acc@gmail.com";
            this.txtEmailnv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailnv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailnv.FillColor = System.Drawing.Color.Honeydew;
            this.txtEmailnv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailnv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailnv.ForeColor = System.Drawing.Color.Black;
            this.txtEmailnv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailnv.Location = new System.Drawing.Point(15, 8);
            this.txtEmailnv.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailnv.Name = "txtEmailnv";
            this.txtEmailnv.PasswordChar = '\0';
            this.txtEmailnv.PlaceholderText = "";
            this.txtEmailnv.ReadOnly = true;
            this.txtEmailnv.SelectedText = "";
            this.txtEmailnv.Size = new System.Drawing.Size(273, 30);
            this.txtEmailnv.TabIndex = 2;
            this.txtEmailnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmail.Location = new System.Drawing.Point(255, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(200, 24);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbName
            // 
            this.grbName.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbName.BorderRadius = 20;
            this.grbName.Controls.Add(this.txtNamenv);
            this.grbName.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbName.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbName.FillColor = System.Drawing.Color.Honeydew;
            this.grbName.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbName.ForeColor = System.Drawing.Color.Black;
            this.grbName.Location = new System.Drawing.Point(236, 71);
            this.grbName.Name = "grbName";
            this.grbName.Size = new System.Drawing.Size(300, 45);
            this.grbName.TabIndex = 23;
            this.grbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNamenv
            // 
            this.txtNamenv.BorderColor = System.Drawing.Color.Lavender;
            this.txtNamenv.BorderRadius = 15;
            this.txtNamenv.BorderThickness = 0;
            this.txtNamenv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamenv.DefaultText = "Hoàng Công Tài Thế ";
            this.txtNamenv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamenv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamenv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamenv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamenv.FillColor = System.Drawing.Color.Honeydew;
            this.txtNamenv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamenv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamenv.ForeColor = System.Drawing.Color.Black;
            this.txtNamenv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamenv.Location = new System.Drawing.Point(15, 8);
            this.txtNamenv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamenv.Name = "txtNamenv";
            this.txtNamenv.PasswordChar = '\0';
            this.txtNamenv.PlaceholderText = "";
            this.txtNamenv.ReadOnly = true;
            this.txtNamenv.SelectedText = "";
            this.txtNamenv.Size = new System.Drawing.Size(273, 30);
            this.txtNamenv.TabIndex = 1;
            this.txtNamenv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblName.Location = new System.Drawing.Point(255, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 24);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Họ và tên";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = false;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSex.Location = new System.Drawing.Point(571, 121);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(200, 24);
            this.lblSex.TabIndex = 32;
            this.lblSex.Text = "Giới tính";
            this.lblSex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbNgaysinh
            // 
            this.grbNgaysinh.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbNgaysinh.BorderRadius = 20;
            this.grbNgaysinh.Controls.Add(this.txtNgaysinhnv);
            this.grbNgaysinh.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbNgaysinh.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbNgaysinh.FillColor = System.Drawing.Color.Honeydew;
            this.grbNgaysinh.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbNgaysinh.ForeColor = System.Drawing.Color.Black;
            this.grbNgaysinh.Location = new System.Drawing.Point(551, 71);
            this.grbNgaysinh.Name = "grbNgaysinh";
            this.grbNgaysinh.Size = new System.Drawing.Size(194, 45);
            this.grbNgaysinh.TabIndex = 25;
            this.grbNgaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNgaysinhnv
            // 
            this.txtNgaysinhnv.BorderColor = System.Drawing.Color.Lavender;
            this.txtNgaysinhnv.BorderRadius = 15;
            this.txtNgaysinhnv.BorderThickness = 0;
            this.txtNgaysinhnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgaysinhnv.DefaultText = "20/01/2005";
            this.txtNgaysinhnv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgaysinhnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgaysinhnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgaysinhnv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgaysinhnv.FillColor = System.Drawing.Color.Honeydew;
            this.txtNgaysinhnv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaysinhnv.ForeColor = System.Drawing.Color.Black;
            this.txtNgaysinhnv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgaysinhnv.Location = new System.Drawing.Point(17, 8);
            this.txtNgaysinhnv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgaysinhnv.Name = "txtNgaysinhnv";
            this.txtNgaysinhnv.PasswordChar = '\0';
            this.txtNgaysinhnv.PlaceholderText = "";
            this.txtNgaysinhnv.ReadOnly = true;
            this.txtNgaysinhnv.SelectedText = "";
            this.txtNgaysinhnv.Size = new System.Drawing.Size(173, 33);
            this.txtNgaysinhnv.TabIndex = 81;
            this.txtNgaysinhnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbSdt
            // 
            this.grbSdt.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbSdt.BorderRadius = 20;
            this.grbSdt.Controls.Add(this.txtSdtnv);
            this.grbSdt.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbSdt.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbSdt.FillColor = System.Drawing.Color.Honeydew;
            this.grbSdt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbSdt.ForeColor = System.Drawing.Color.Black;
            this.grbSdt.Location = new System.Drawing.Point(29, 146);
            this.grbSdt.Name = "grbSdt";
            this.grbSdt.Size = new System.Drawing.Size(194, 45);
            this.grbSdt.TabIndex = 28;
            this.grbSdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSdtnv
            // 
            this.txtSdtnv.BorderColor = System.Drawing.Color.Lavender;
            this.txtSdtnv.BorderRadius = 15;
            this.txtSdtnv.BorderThickness = 0;
            this.txtSdtnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdtnv.DefaultText = "0373606590";
            this.txtSdtnv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdtnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdtnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdtnv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdtnv.FillColor = System.Drawing.Color.Honeydew;
            this.txtSdtnv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdtnv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdtnv.ForeColor = System.Drawing.Color.Black;
            this.txtSdtnv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdtnv.Location = new System.Drawing.Point(15, 8);
            this.txtSdtnv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSdtnv.Name = "txtSdtnv";
            this.txtSdtnv.PasswordChar = '\0';
            this.txtSdtnv.PlaceholderText = "";
            this.txtSdtnv.ReadOnly = true;
            this.txtSdtnv.SelectedText = "";
            this.txtSdtnv.Size = new System.Drawing.Size(173, 33);
            this.txtSdtnv.TabIndex = 1;
            this.txtSdtnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = false;
            this.lblNgaysinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaysinh.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNgaysinh.Location = new System.Drawing.Point(571, 46);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(200, 24);
            this.lblNgaysinh.TabIndex = 26;
            this.lblNgaysinh.Text = "Ngày sinh";
            this.lblNgaysinh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = false;
            this.lblSdt.BackColor = System.Drawing.Color.Transparent;
            this.lblSdt.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSdt.Location = new System.Drawing.Point(49, 121);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(200, 24);
            this.lblSdt.TabIndex = 29;
            this.lblSdt.Text = "Số điện thoại";
            this.lblSdt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbMa
            // 
            this.grbMa.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbMa.BorderRadius = 20;
            this.grbMa.Controls.Add(this.txtManv);
            this.grbMa.CustomBorderColor = System.Drawing.Color.LightCyan;
            this.grbMa.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grbMa.FillColor = System.Drawing.Color.Honeydew;
            this.grbMa.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.grbMa.ForeColor = System.Drawing.Color.Black;
            this.grbMa.Location = new System.Drawing.Point(29, 71);
            this.grbMa.Name = "grbMa";
            this.grbMa.Size = new System.Drawing.Size(194, 45);
            this.grbMa.TabIndex = 21;
            this.grbMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtManv
            // 
            this.txtManv.BorderColor = System.Drawing.Color.Lavender;
            this.txtManv.BorderRadius = 15;
            this.txtManv.BorderThickness = 0;
            this.txtManv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManv.DefaultText = "NV001";
            this.txtManv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtManv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtManv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtManv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtManv.FillColor = System.Drawing.Color.Honeydew;
            this.txtManv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.ForeColor = System.Drawing.Color.Black;
            this.txtManv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtManv.Location = new System.Drawing.Point(15, 8);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4);
            this.txtManv.Name = "txtManv";
            this.txtManv.PasswordChar = '\0';
            this.txtManv.PlaceholderText = "";
            this.txtManv.ReadOnly = true;
            this.txtManv.SelectedText = "";
            this.txtManv.Size = new System.Drawing.Size(163, 30);
            this.txtManv.TabIndex = 0;
            this.txtManv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = false;
            this.lblMa.BackColor = System.Drawing.Color.Transparent;
            this.lblMa.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMa.Location = new System.Drawing.Point(49, 46);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(200, 24);
            this.lblMa.TabIndex = 22;
            this.lblMa.Text = "Mã số nhân viên";
            this.lblMa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThongtinNhanvien
            // 
            this.lblThongtinNhanvien.AutoSize = false;
            this.lblThongtinNhanvien.BackColor = System.Drawing.Color.Transparent;
            this.lblThongtinNhanvien.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinNhanvien.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblThongtinNhanvien.Location = new System.Drawing.Point(0, 0);
            this.lblThongtinNhanvien.Name = "lblThongtinNhanvien";
            this.lblThongtinNhanvien.Size = new System.Drawing.Size(980, 40);
            this.lblThongtinNhanvien.TabIndex = 7;
            this.lblThongtinNhanvien.Text = "Thông tin nhân viên";
            this.lblThongtinNhanvien.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panTB
            // 
            this.panTB.BackColor = System.Drawing.Color.Transparent;
            this.panTB.Controls.Add(this.btnSortTB);
            this.panTB.Controls.Add(this.lblDSTB);
            this.panTB.Controls.Add(this.panDSTB);
            this.panTB.Controls.Add(this.lblGachngang);
            this.panTB.Controls.Add(this.siticoneHtmlLabel5);
            this.panTB.Controls.Add(this.panNoidungTB);
            this.panTB.Controls.Add(this.btnFindTB);
            this.panTB.Controls.Add(this.txtFindTB);
            this.panTB.FillColor = System.Drawing.Color.MintCream;
            this.panTB.Location = new System.Drawing.Point(220, 65);
            this.panTB.Margin = new System.Windows.Forms.Padding(2);
            this.panTB.Name = "panTB";
            this.panTB.Size = new System.Drawing.Size(980, 585);
            this.panTB.TabIndex = 119;
            // 
            // btnSortTB
            // 
            this.btnSortTB.BackColor = System.Drawing.Color.MintCream;
            this.btnSortTB.BorderColor = System.Drawing.Color.MintCream;
            this.btnSortTB.BorderRadius = 5;
            this.btnSortTB.BorderThickness = 1;
            this.btnSortTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortTB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortTB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortTB.FillColor = System.Drawing.Color.MintCream;
            this.btnSortTB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSortTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSortTB.ForeColor = System.Drawing.Color.White;
            this.btnSortTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSortTB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortTB.Image = global::DuAnCNPM.Properties.Resources.sortGiam;
            this.btnSortTB.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSortTB.Location = new System.Drawing.Point(936, 10);
            this.btnSortTB.Name = "btnSortTB";
            this.btnSortTB.Size = new System.Drawing.Size(41, 41);
            this.btnSortTB.TabIndex = 83;
            // 
            // lblDSTB
            // 
            this.lblDSTB.AutoSize = false;
            this.lblDSTB.BackColor = System.Drawing.Color.MintCream;
            this.lblDSTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDSTB.Location = new System.Drawing.Point(721, 3);
            this.lblDSTB.Name = "lblDSTB";
            this.lblDSTB.Size = new System.Drawing.Size(259, 57);
            this.lblDSTB.TabIndex = 81;
            this.lblDSTB.Text = "Danh sách thông báo\r\n";
            this.lblDSTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panDSTB
            // 
            this.panDSTB.AutoScroll = true;
            this.panDSTB.BackColor = System.Drawing.Color.Transparent;
            this.panDSTB.BorderColor = System.Drawing.Color.Honeydew;
            this.panDSTB.FillColor = System.Drawing.Color.MintCream;
            this.panDSTB.Location = new System.Drawing.Point(721, 60);
            this.panDSTB.Name = "panDSTB";
            this.panDSTB.Size = new System.Drawing.Size(259, 525);
            this.panDSTB.TabIndex = 82;
            // 
            // lblGachngang
            // 
            this.lblGachngang.AutoSize = false;
            this.lblGachngang.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblGachngang.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblGachngang.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGachngang.Location = new System.Drawing.Point(15, 100);
            this.lblGachngang.Name = "lblGachngang";
            this.lblGachngang.Size = new System.Drawing.Size(700, 2);
            this.lblGachngang.TabIndex = 47;
            this.lblGachngang.Text = null;
            this.lblGachngang.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.AutoSize = false;
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(62, 58);
            this.siticoneHtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(464, 44);
            this.siticoneHtmlLabel5.TabIndex = 46;
            this.siticoneHtmlLabel5.Text = "Thông báo";
            this.siticoneHtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panNoidungTB
            // 
            this.panNoidungTB.Controls.Add(this.ricNDungTB);
            this.panNoidungTB.Controls.Add(this.lblDateTB);
            this.panNoidungTB.Controls.Add(this.lblTitleTB);
            this.panNoidungTB.FillColor = System.Drawing.Color.Honeydew;
            this.panNoidungTB.Location = new System.Drawing.Point(15, 108);
            this.panNoidungTB.Name = "panNoidungTB";
            this.panNoidungTB.Size = new System.Drawing.Size(700, 464);
            this.panNoidungTB.TabIndex = 26;
            // 
            // ricNDungTB
            // 
            this.ricNDungTB.BackColor = System.Drawing.Color.Honeydew;
            this.ricNDungTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ricNDungTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ricNDungTB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ricNDungTB.Location = new System.Drawing.Point(22, 89);
            this.ricNDungTB.Name = "ricNDungTB";
            this.ricNDungTB.ReadOnly = true;
            this.ricNDungTB.Size = new System.Drawing.Size(656, 358);
            this.ricNDungTB.TabIndex = 50;
            this.ricNDungTB.Text = "Nội dung thông báo";
            // 
            // lblDateTB
            // 
            this.lblDateTB.AutoSize = false;
            this.lblDateTB.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateTB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDateTB.Location = new System.Drawing.Point(262, 57);
            this.lblDateTB.Margin = new System.Windows.Forms.Padding(4);
            this.lblDateTB.Name = "lblDateTB";
            this.lblDateTB.Size = new System.Drawing.Size(438, 25);
            this.lblDateTB.TabIndex = 49;
            this.lblDateTB.Text = "Ngày";
            this.lblDateTB.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleTB
            // 
            this.lblTitleTB.AutoSize = false;
            this.lblTitleTB.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitleTB.Location = new System.Drawing.Point(3, 19);
            this.lblTitleTB.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitleTB.Name = "lblTitleTB";
            this.lblTitleTB.Size = new System.Drawing.Size(696, 39);
            this.lblTitleTB.TabIndex = 48;
            this.lblTitleTB.Text = "Tiêu đề thông báo";
            this.lblTitleTB.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindTB
            // 
            this.btnFindTB.BackColor = System.Drawing.Color.Transparent;
            this.btnFindTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnFindTB.BorderThickness = 1;
            this.btnFindTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindTB.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindTB.FillColor = System.Drawing.Color.MintCream;
            this.btnFindTB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindTB.ForeColor = System.Drawing.Color.White;
            this.btnFindTB.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnFindTB.HoverState.FillColor = System.Drawing.Color.Honeydew;
            this.btnFindTB.Image = global::DuAnCNPM.Properties.Resources.magnifying_glass_search;
            this.btnFindTB.ImageSize = new System.Drawing.Size(28, 28);
            this.btnFindTB.Location = new System.Drawing.Point(15, 13);
            this.btnFindTB.Name = "btnFindTB";
            this.btnFindTB.Size = new System.Drawing.Size(40, 40);
            this.btnFindTB.TabIndex = 24;
            this.btnFindTB.UseTransparentBackground = true;
            // 
            // txtFindTB
            // 
            this.txtFindTB.BackColor = System.Drawing.Color.Transparent;
            this.txtFindTB.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFindTB.BorderRadius = 21;
            this.txtFindTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindTB.DefaultText = "";
            this.txtFindTB.FillColor = System.Drawing.Color.MintCream;
            this.txtFindTB.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFindTB.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtFindTB.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFindTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindTB.ForeColor = System.Drawing.Color.Black;
            this.txtFindTB.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFindTB.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtFindTB.Location = new System.Drawing.Point(62, 10);
            this.txtFindTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindTB.Name = "txtFindTB";
            this.txtFindTB.PasswordChar = '\0';
            this.txtFindTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFindTB.PlaceholderText = "Tìm kiếm thông báo";
            this.txtFindTB.SelectedText = "";
            this.txtFindTB.Size = new System.Drawing.Size(653, 45);
            this.txtFindTB.TabIndex = 23;
            // 
            // panDSNV
            // 
            this.panDSNV.BackColor = System.Drawing.Color.Transparent;
            this.panDSNV.Controls.Add(this.panFindNV);
            this.panDSNV.Controls.Add(this.grbAllTTNV);
            this.panDSNV.Controls.Add(this.btnFindNV);
            this.panDSNV.Controls.Add(this.txtFindNV);
            this.panDSNV.FillColor = System.Drawing.Color.MintCream;
            this.panDSNV.Location = new System.Drawing.Point(220, 65);
            this.panDSNV.Margin = new System.Windows.Forms.Padding(2);
            this.panDSNV.Name = "panDSNV";
            this.panDSNV.Size = new System.Drawing.Size(980, 585);
            this.panDSNV.TabIndex = 118;
            // 
            // panFindNV
            // 
            this.panFindNV.Controls.Add(this.grbTimthay);
            this.panFindNV.FillColor = System.Drawing.Color.Honeydew;
            this.panFindNV.Location = new System.Drawing.Point(15, 109);
            this.panFindNV.Name = "panFindNV";
            this.panFindNV.Size = new System.Drawing.Size(949, 463);
            this.panFindNV.TabIndex = 26;
            // 
            // grbTimthay
            // 
            this.grbTimthay.BorderColor = System.Drawing.Color.Transparent;
            this.grbTimthay.BorderRadius = 15;
            this.grbTimthay.Controls.Add(this.txtEmail);
            this.grbTimthay.Controls.Add(this.txtSDT);
            this.grbTimthay.Controls.Add(this.lblPhongbanFind);
            this.grbTimthay.Controls.Add(this.txtTenNV);
            this.grbTimthay.Controls.Add(this.lblManhanvien);
            this.grbTimthay.CustomBorderColor = System.Drawing.Color.Transparent;
            this.grbTimthay.FillColor = System.Drawing.Color.Transparent;
            this.grbTimthay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbTimthay.ForeColor = System.Drawing.Color.Transparent;
            this.grbTimthay.Location = new System.Drawing.Point(0, 10);
            this.grbTimthay.Name = "grbTimthay";
            this.grbTimthay.Size = new System.Drawing.Size(949, 36);
            this.grbTimthay.TabIndex = 111;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = false;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(695, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 36);
            this.txtEmail.TabIndex = 110;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = false;
            this.txtSDT.BackColor = System.Drawing.Color.Transparent;
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(540, 0);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 36);
            this.txtSDT.TabIndex = 109;
            this.txtSDT.Text = "Số điện thoại";
            this.txtSDT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhongbanFind
            // 
            this.lblPhongbanFind.AutoSize = false;
            this.lblPhongbanFind.BackColor = System.Drawing.Color.Transparent;
            this.lblPhongbanFind.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhongbanFind.ForeColor = System.Drawing.Color.Black;
            this.lblPhongbanFind.Location = new System.Drawing.Point(395, 0);
            this.lblPhongbanFind.Name = "lblPhongbanFind";
            this.lblPhongbanFind.Size = new System.Drawing.Size(140, 36);
            this.lblPhongbanFind.TabIndex = 108;
            this.lblPhongbanFind.Text = "Phòng ban";
            this.lblPhongbanFind.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoSize = false;
            this.txtTenNV.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.Location = new System.Drawing.Point(150, 0);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(240, 36);
            this.txtTenNV.TabIndex = 107;
            this.txtTenNV.Text = "Tên nhân viên";
            this.txtTenNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblManhanvien
            // 
            this.lblManhanvien.AutoSize = false;
            this.lblManhanvien.BackColor = System.Drawing.Color.Transparent;
            this.lblManhanvien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblManhanvien.ForeColor = System.Drawing.Color.Black;
            this.lblManhanvien.Location = new System.Drawing.Point(13, 0);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(132, 36);
            this.lblManhanvien.TabIndex = 106;
            this.lblManhanvien.Text = "Mã nhân viên";
            this.lblManhanvien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbAllTTNV
            // 
            this.grbAllTTNV.BorderColor = System.Drawing.Color.Transparent;
            this.grbAllTTNV.BorderRadius = 15;
            this.grbAllTTNV.Controls.Add(this.siticoneHtmlLabel3);
            this.grbAllTTNV.Controls.Add(this.lblSodienthoai);
            this.grbAllTTNV.Controls.Add(this.lblPhongbanNV);
            this.grbAllTTNV.Controls.Add(this.siticoneHtmlLabel4);
            this.grbAllTTNV.Controls.Add(this.lblMaNV);
            this.grbAllTTNV.CustomBorderColor = System.Drawing.Color.Transparent;
            this.grbAllTTNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.grbAllTTNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbAllTTNV.ForeColor = System.Drawing.Color.Transparent;
            this.grbAllTTNV.Location = new System.Drawing.Point(15, 67);
            this.grbAllTTNV.Name = "grbAllTTNV";
            this.grbAllTTNV.Size = new System.Drawing.Size(949, 36);
            this.grbAllTTNV.TabIndex = 25;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.AutoSize = false;
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(695, 0);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(236, 36);
            this.siticoneHtmlLabel3.TabIndex = 110;
            this.siticoneHtmlLabel3.Text = "Email";
            this.siticoneHtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSodienthoai
            // 
            this.lblSodienthoai.AutoSize = false;
            this.lblSodienthoai.BackColor = System.Drawing.Color.Transparent;
            this.lblSodienthoai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblSodienthoai.ForeColor = System.Drawing.Color.White;
            this.lblSodienthoai.Location = new System.Drawing.Point(540, 0);
            this.lblSodienthoai.Name = "lblSodienthoai";
            this.lblSodienthoai.Size = new System.Drawing.Size(150, 36);
            this.lblSodienthoai.TabIndex = 109;
            this.lblSodienthoai.Text = "Số điện thoại";
            this.lblSodienthoai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhongbanNV
            // 
            this.lblPhongbanNV.AutoSize = false;
            this.lblPhongbanNV.BackColor = System.Drawing.Color.Transparent;
            this.lblPhongbanNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhongbanNV.ForeColor = System.Drawing.Color.White;
            this.lblPhongbanNV.Location = new System.Drawing.Point(395, 0);
            this.lblPhongbanNV.Name = "lblPhongbanNV";
            this.lblPhongbanNV.Size = new System.Drawing.Size(140, 36);
            this.lblPhongbanNV.TabIndex = 108;
            this.lblPhongbanNV.Text = "Phòng ban";
            this.lblPhongbanNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.AutoSize = false;
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(150, 0);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(240, 36);
            this.siticoneHtmlLabel4.TabIndex = 107;
            this.siticoneHtmlLabel4.Text = "Tên nhân viên";
            this.siticoneHtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = false;
            this.lblMaNV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.ForeColor = System.Drawing.Color.White;
            this.lblMaNV.Location = new System.Drawing.Point(13, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(132, 36);
            this.lblMaNV.TabIndex = 106;
            this.lblMaNV.Text = "Mã nhân viên";
            this.lblMaNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFindNV
            // 
            this.btnFindNV.BackColor = System.Drawing.Color.Transparent;
            this.btnFindNV.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnFindNV.BorderThickness = 1;
            this.btnFindNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindNV.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindNV.FillColor = System.Drawing.Color.MintCream;
            this.btnFindNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFindNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindNV.ForeColor = System.Drawing.Color.White;
            this.btnFindNV.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnFindNV.HoverState.FillColor = System.Drawing.Color.Honeydew;
            this.btnFindNV.Image = global::DuAnCNPM.Properties.Resources.magnifying_glass_search;
            this.btnFindNV.ImageSize = new System.Drawing.Size(28, 28);
            this.btnFindNV.Location = new System.Drawing.Point(15, 13);
            this.btnFindNV.Name = "btnFindNV";
            this.btnFindNV.Size = new System.Drawing.Size(40, 40);
            this.btnFindNV.TabIndex = 24;
            this.btnFindNV.UseTransparentBackground = true;
            this.btnFindNV.Click += new System.EventHandler(this.btnFindNV_Click);
            // 
            // txtFindNV
            // 
            this.txtFindNV.BackColor = System.Drawing.Color.Transparent;
            this.txtFindNV.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFindNV.BorderRadius = 21;
            this.txtFindNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindNV.DefaultText = "";
            this.txtFindNV.FillColor = System.Drawing.Color.MintCream;
            this.txtFindNV.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFindNV.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtFindNV.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFindNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindNV.ForeColor = System.Drawing.Color.Black;
            this.txtFindNV.HoverState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFindNV.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtFindNV.Location = new System.Drawing.Point(62, 10);
            this.txtFindNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindNV.Name = "txtFindNV";
            this.txtFindNV.PasswordChar = '\0';
            this.txtFindNV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFindNV.PlaceholderText = "Tìm kiếm theo mã nhân viên";
            this.txtFindNV.SelectedText = "";
            this.txtFindNV.Size = new System.Drawing.Size(902, 45);
            this.txtFindNV.TabIndex = 23;
            // 
            // panLogOut
            // 
            this.panLogOut.BackColor = System.Drawing.Color.Transparent;
            this.panLogOut.Controls.Add(this.grbLogout);
            this.panLogOut.FillColor = System.Drawing.Color.Transparent;
            this.panLogOut.Location = new System.Drawing.Point(220, 65);
            this.panLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.panLogOut.Name = "panLogOut";
            this.panLogOut.Size = new System.Drawing.Size(980, 585);
            this.panLogOut.TabIndex = 126;
            // 
            // grbLogout
            // 
            this.grbLogout.BackColor = System.Drawing.Color.Transparent;
            this.grbLogout.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbLogout.BorderRadius = 18;
            this.grbLogout.Controls.Add(this.btnContinueLogout);
            this.grbLogout.Controls.Add(this.siticoneHtmlLabel11);
            this.grbLogout.Controls.Add(this.btnCancelLogout);
            this.grbLogout.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.grbLogout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grbLogout.FillColor = System.Drawing.Color.Transparent;
            this.grbLogout.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLogout.ForeColor = System.Drawing.Color.White;
            this.grbLogout.Location = new System.Drawing.Point(140, 124);
            this.grbLogout.Name = "grbLogout";
            this.grbLogout.Size = new System.Drawing.Size(700, 320);
            this.grbLogout.TabIndex = 63;
            this.grbLogout.Text = "ĐĂNG XUẤT";
            this.grbLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnContinueLogout
            // 
            this.btnContinueLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnContinueLogout.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnContinueLogout.BorderRadius = 22;
            this.btnContinueLogout.BorderThickness = 1;
            this.btnContinueLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueLogout.FillColor = System.Drawing.Color.Green;
            this.btnContinueLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueLogout.ForeColor = System.Drawing.Color.White;
            this.btnContinueLogout.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnContinueLogout.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnContinueLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnContinueLogout.Location = new System.Drawing.Point(432, 239);
            this.btnContinueLogout.Name = "btnContinueLogout";
            this.btnContinueLogout.Size = new System.Drawing.Size(175, 50);
            this.btnContinueLogout.TabIndex = 96;
            this.btnContinueLogout.Text = "Tiếp tục";
            this.btnContinueLogout.Click += new System.EventHandler(this.btnContinueLogout_Click);
            // 
            // siticoneHtmlLabel11
            // 
            this.siticoneHtmlLabel11.AutoSize = false;
            this.siticoneHtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel11.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.siticoneHtmlLabel11.Location = new System.Drawing.Point(32, 69);
            this.siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
            this.siticoneHtmlLabel11.Size = new System.Drawing.Size(633, 152);
            this.siticoneHtmlLabel11.TabIndex = 94;
            this.siticoneHtmlLabel11.Text = "Bạn có chắc chắn muốn đăng xuất ?";
            this.siticoneHtmlLabel11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelLogout
            // 
            this.btnCancelLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelLogout.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCancelLogout.BorderRadius = 22;
            this.btnCancelLogout.BorderThickness = 1;
            this.btnCancelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogout.ForeColor = System.Drawing.Color.White;
            this.btnCancelLogout.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnCancelLogout.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancelLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelLogout.Location = new System.Drawing.Point(96, 239);
            this.btnCancelLogout.Name = "btnCancelLogout";
            this.btnCancelLogout.Size = new System.Drawing.Size(175, 50);
            this.btnCancelLogout.TabIndex = 89;
            this.btnCancelLogout.Text = "Hủy";
            this.btnCancelLogout.Click += new System.EventHandler(this.btnCancelLogout_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = false;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(49, 607);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(171, 40);
            this.lblLogo.TabIndex = 114;
            this.lblLogo.Text = "Copyright by Techhive Company";
            this.lblLogo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::DuAnCNPM.Properties.Resources.z6523765316768_b4e94238b9f84f27e6672fffaaf1b7d01;
            this.picLogo.Location = new System.Drawing.Point(3, 602);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 113;
            this.picLogo.TabStop = false;
            // 
            // lblChucnangQL
            // 
            this.lblChucnangQL.AutoSize = false;
            this.lblChucnangQL.BackColor = System.Drawing.Color.Transparent;
            this.lblChucnangQL.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucnangQL.ForeColor = System.Drawing.Color.White;
            this.lblChucnangQL.Location = new System.Drawing.Point(0, 496);
            this.lblChucnangQL.Name = "lblChucnangQL";
            this.lblChucnangQL.Size = new System.Drawing.Size(220, 50);
            this.lblChucnangQL.TabIndex = 112;
            this.lblChucnangQL.Text = "Chức năng quản lý";
            this.lblChucnangQL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChucnangQL.Click += new System.EventHandler(this.lblChucnangQL_Click);
            // 
            // lblDoimatkhau
            // 
            this.lblDoimatkhau.AutoSize = false;
            this.lblDoimatkhau.BackColor = System.Drawing.Color.Transparent;
            this.lblDoimatkhau.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoimatkhau.ForeColor = System.Drawing.Color.White;
            this.lblDoimatkhau.Location = new System.Drawing.Point(0, 446);
            this.lblDoimatkhau.Name = "lblDoimatkhau";
            this.lblDoimatkhau.Size = new System.Drawing.Size(220, 50);
            this.lblDoimatkhau.TabIndex = 111;
            this.lblDoimatkhau.Text = "Đổi mật khẩu";
            this.lblDoimatkhau.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDoimatkhau.Click += new System.EventHandler(this.lblDoimatkhau_Click);
            // 
            // lblThongke
            // 
            this.lblThongke.AutoSize = false;
            this.lblThongke.BackColor = System.Drawing.Color.Transparent;
            this.lblThongke.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongke.ForeColor = System.Drawing.Color.White;
            this.lblThongke.Location = new System.Drawing.Point(0, 396);
            this.lblThongke.Name = "lblThongke";
            this.lblThongke.Size = new System.Drawing.Size(220, 50);
            this.lblThongke.TabIndex = 110;
            this.lblThongke.Text = "Thống kê";
            this.lblThongke.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongke.Click += new System.EventHandler(this.lblThongke_Click);
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = false;
            this.lblThongbao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongbao.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.ForeColor = System.Drawing.Color.White;
            this.lblThongbao.Location = new System.Drawing.Point(0, 346);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(220, 50);
            this.lblThongbao.TabIndex = 109;
            this.lblThongbao.Text = "Thông báo";
            this.lblThongbao.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongbao.Click += new System.EventHandler(this.lblThongbao_Click);
            // 
            // lblDanhsachNV
            // 
            this.lblDanhsachNV.AutoSize = false;
            this.lblDanhsachNV.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhsachNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsachNV.ForeColor = System.Drawing.Color.White;
            this.lblDanhsachNV.Location = new System.Drawing.Point(0, 296);
            this.lblDanhsachNV.Name = "lblDanhsachNV";
            this.lblDanhsachNV.Size = new System.Drawing.Size(220, 50);
            this.lblDanhsachNV.TabIndex = 108;
            this.lblDanhsachNV.Text = "Danh sách nhân viên";
            this.lblDanhsachNV.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDanhsachNV.Click += new System.EventHandler(this.lblDanhsachNV_Click);
            // 
            // lblThongtinNV
            // 
            this.lblThongtinNV.AutoSize = false;
            this.lblThongtinNV.BackColor = System.Drawing.Color.Transparent;
            this.lblThongtinNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinNV.ForeColor = System.Drawing.Color.White;
            this.lblThongtinNV.Location = new System.Drawing.Point(0, 246);
            this.lblThongtinNV.Name = "lblThongtinNV";
            this.lblThongtinNV.Size = new System.Drawing.Size(220, 50);
            this.lblThongtinNV.TabIndex = 107;
            this.lblThongtinNV.Text = "Thông tin nhân viên";
            this.lblThongtinNV.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongtinNV.Click += new System.EventHandler(this.lblThongtinNV_Click);
            // 
            // lblDanhsachDH
            // 
            this.lblDanhsachDH.AutoSize = false;
            this.lblDanhsachDH.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhsachDH.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsachDH.ForeColor = System.Drawing.Color.White;
            this.lblDanhsachDH.Location = new System.Drawing.Point(0, 196);
            this.lblDanhsachDH.Name = "lblDanhsachDH";
            this.lblDanhsachDH.Size = new System.Drawing.Size(220, 50);
            this.lblDanhsachDH.TabIndex = 106;
            this.lblDanhsachDH.Text = "Danh sách đơn hàng";
            this.lblDanhsachDH.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDanhsachDH.Click += new System.EventHandler(this.lblDanhsachDH_Click);
            // 
            // lblTrangchu
            // 
            this.lblTrangchu.AutoSize = false;
            this.lblTrangchu.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangchu.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangchu.ForeColor = System.Drawing.Color.White;
            this.lblTrangchu.Location = new System.Drawing.Point(0, 146);
            this.lblTrangchu.Name = "lblTrangchu";
            this.lblTrangchu.Size = new System.Drawing.Size(220, 50);
            this.lblTrangchu.TabIndex = 105;
            this.lblTrangchu.Text = "Trang chủ";
            this.lblTrangchu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrangchu.Click += new System.EventHandler(this.lblTrangchu_Click);
            // 
            // lblNameNV
            // 
            this.lblNameNV.AutoSize = false;
            this.lblNameNV.BackColor = System.Drawing.Color.Transparent;
            this.lblNameNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNV.ForeColor = System.Drawing.Color.White;
            this.lblNameNV.Location = new System.Drawing.Point(314, 13);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(378, 35);
            this.lblNameNV.TabIndex = 104;
            this.lblNameNV.Text = "Hoàng Công Tài Thế";
            this.lblNameNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picStaff
            // 
            this.picStaff.Image = global::DuAnCNPM.Properties.Resources.logout;
            this.picStaff.Location = new System.Drawing.Point(246, 3);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(58, 58);
            this.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStaff.TabIndex = 104;
            this.picStaff.TabStop = false;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = false;
            this.lblLogOut.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOut.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(1053, 13);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(97, 35);
            this.lblLogOut.TabIndex = 103;
            this.lblLogOut.Text = "Đăng xuất";
            this.lblLogOut.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // picLogout
            // 
            this.picLogout.Image = global::DuAnCNPM.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(1153, 13);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(35, 35);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 102;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // panDMK
            // 
            this.panDMK.BackColor = System.Drawing.Color.Transparent;
            this.panDMK.Controls.Add(this.grbChangepass);
            this.panDMK.FillColor = System.Drawing.Color.Transparent;
            this.panDMK.Location = new System.Drawing.Point(220, 65);
            this.panDMK.Margin = new System.Windows.Forms.Padding(2);
            this.panDMK.Name = "panDMK";
            this.panDMK.Size = new System.Drawing.Size(980, 585);
            this.panDMK.TabIndex = 122;
            // 
            // grbChangepass
            // 
            this.grbChangepass.BackColor = System.Drawing.Color.Transparent;
            this.grbChangepass.BorderColor = System.Drawing.Color.SeaGreen;
            this.grbChangepass.BorderRadius = 18;
            this.grbChangepass.Controls.Add(this.txtPasscurrent);
            this.grbChangepass.Controls.Add(this.lblPasscurrent);
            this.grbChangepass.Controls.Add(this.txtPassnewagain);
            this.grbChangepass.Controls.Add(this.txtPassnew);
            this.grbChangepass.Controls.Add(this.btnContinueDMK);
            this.grbChangepass.Controls.Add(this.lblPassnewagain);
            this.grbChangepass.Controls.Add(this.lblPassnew);
            this.grbChangepass.Controls.Add(this.btnCancelchange);
            this.grbChangepass.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.grbChangepass.CustomBorderThickness = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.grbChangepass.FillColor = System.Drawing.Color.Transparent;
            this.grbChangepass.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChangepass.ForeColor = System.Drawing.Color.White;
            this.grbChangepass.Location = new System.Drawing.Point(140, 107);
            this.grbChangepass.Name = "grbChangepass";
            this.grbChangepass.Size = new System.Drawing.Size(700, 354);
            this.grbChangepass.TabIndex = 63;
            this.grbChangepass.Text = "THAY ĐỔI MẬT KHẨU";
            this.grbChangepass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPasscurrent
            // 
            this.txtPasscurrent.BackColor = System.Drawing.Color.Transparent;
            this.txtPasscurrent.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPasscurrent.BorderRadius = 8;
            this.txtPasscurrent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasscurrent.DefaultText = "";
            this.txtPasscurrent.FillColor = System.Drawing.Color.MintCream;
            this.txtPasscurrent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasscurrent.ForeColor = System.Drawing.Color.Black;
            this.txtPasscurrent.HoverState.BorderColor = System.Drawing.Color.LightCyan;
            this.txtPasscurrent.HoverState.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPasscurrent.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtPasscurrent.Location = new System.Drawing.Point(327, 65);
            this.txtPasscurrent.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasscurrent.Name = "txtPasscurrent";
            this.txtPasscurrent.PasswordChar = '\0';
            this.txtPasscurrent.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPasscurrent.PlaceholderText = "Nhập mật khẩu hiện tại";
            this.txtPasscurrent.SelectedText = "";
            this.txtPasscurrent.Size = new System.Drawing.Size(328, 55);
            this.txtPasscurrent.TabIndex = 97;
            // 
            // lblPasscurrent
            // 
            this.lblPasscurrent.AutoSize = false;
            this.lblPasscurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblPasscurrent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasscurrent.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPasscurrent.Location = new System.Drawing.Point(32, 65);
            this.lblPasscurrent.Name = "lblPasscurrent";
            this.lblPasscurrent.Size = new System.Drawing.Size(270, 55);
            this.lblPasscurrent.TabIndex = 98;
            this.lblPasscurrent.Text = "Mật khẩu hiện tại:";
            this.lblPasscurrent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassnewagain
            // 
            this.txtPassnewagain.BackColor = System.Drawing.Color.Transparent;
            this.txtPassnewagain.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassnewagain.BorderRadius = 8;
            this.txtPassnewagain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassnewagain.DefaultText = "";
            this.txtPassnewagain.FillColor = System.Drawing.Color.MintCream;
            this.txtPassnewagain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassnewagain.ForeColor = System.Drawing.Color.Black;
            this.txtPassnewagain.HoverState.BorderColor = System.Drawing.Color.LightCyan;
            this.txtPassnewagain.HoverState.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassnewagain.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtPassnewagain.Location = new System.Drawing.Point(327, 195);
            this.txtPassnewagain.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassnewagain.Name = "txtPassnewagain";
            this.txtPassnewagain.PasswordChar = '\0';
            this.txtPassnewagain.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassnewagain.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtPassnewagain.SelectedText = "";
            this.txtPassnewagain.Size = new System.Drawing.Size(328, 55);
            this.txtPassnewagain.TabIndex = 93;
            // 
            // txtPassnew
            // 
            this.txtPassnew.BackColor = System.Drawing.Color.Transparent;
            this.txtPassnew.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassnew.BorderRadius = 8;
            this.txtPassnew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassnew.DefaultText = "";
            this.txtPassnew.FillColor = System.Drawing.Color.MintCream;
            this.txtPassnew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassnew.ForeColor = System.Drawing.Color.Black;
            this.txtPassnew.HoverState.BorderColor = System.Drawing.Color.LightCyan;
            this.txtPassnew.HoverState.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassnew.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtPassnew.Location = new System.Drawing.Point(327, 130);
            this.txtPassnew.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassnew.Name = "txtPassnew";
            this.txtPassnew.PasswordChar = '\0';
            this.txtPassnew.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassnew.PlaceholderText = "Nhập mật khẩu mới";
            this.txtPassnew.SelectedText = "";
            this.txtPassnew.Size = new System.Drawing.Size(328, 55);
            this.txtPassnew.TabIndex = 92;
            // 
            // btnContinueDMK
            // 
            this.btnContinueDMK.BackColor = System.Drawing.Color.Transparent;
            this.btnContinueDMK.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnContinueDMK.BorderRadius = 22;
            this.btnContinueDMK.BorderThickness = 1;
            this.btnContinueDMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueDMK.FillColor = System.Drawing.Color.Green;
            this.btnContinueDMK.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueDMK.ForeColor = System.Drawing.Color.White;
            this.btnContinueDMK.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnContinueDMK.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnContinueDMK.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnContinueDMK.Location = new System.Drawing.Point(430, 270);
            this.btnContinueDMK.Name = "btnContinueDMK";
            this.btnContinueDMK.Size = new System.Drawing.Size(175, 50);
            this.btnContinueDMK.TabIndex = 96;
            this.btnContinueDMK.Text = "Tiếp tục";
            this.btnContinueDMK.Click += new System.EventHandler(this.btnContinueDMK_Click);
            // 
            // lblPassnewagain
            // 
            this.lblPassnewagain.AutoSize = false;
            this.lblPassnewagain.BackColor = System.Drawing.Color.Transparent;
            this.lblPassnewagain.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassnewagain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPassnewagain.Location = new System.Drawing.Point(32, 195);
            this.lblPassnewagain.Name = "lblPassnewagain";
            this.lblPassnewagain.Size = new System.Drawing.Size(270, 55);
            this.lblPassnewagain.TabIndex = 95;
            this.lblPassnewagain.Text = "Nhập lại mật khẩu mới:";
            this.lblPassnewagain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassnew
            // 
            this.lblPassnew.AutoSize = false;
            this.lblPassnew.BackColor = System.Drawing.Color.Transparent;
            this.lblPassnew.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassnew.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPassnew.Location = new System.Drawing.Point(32, 130);
            this.lblPassnew.Name = "lblPassnew";
            this.lblPassnew.Size = new System.Drawing.Size(270, 55);
            this.lblPassnew.TabIndex = 94;
            this.lblPassnew.Text = "Mật khẩu mới:";
            this.lblPassnew.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelchange
            // 
            this.btnCancelchange.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelchange.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCancelchange.BorderRadius = 22;
            this.btnCancelchange.BorderThickness = 1;
            this.btnCancelchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelchange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelchange.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelchange.ForeColor = System.Drawing.Color.White;
            this.btnCancelchange.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btnCancelchange.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancelchange.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelchange.Location = new System.Drawing.Point(94, 270);
            this.btnCancelchange.Name = "btnCancelchange";
            this.btnCancelchange.Size = new System.Drawing.Size(175, 50);
            this.btnCancelchange.TabIndex = 89;
            this.btnCancelchange.Text = "Quay lại";
            // 
            // panReport
            // 
            this.panReport.BackColor = System.Drawing.Color.Transparent;
            this.panReport.Controls.Add(this.btnIn);
            this.panReport.Controls.Add(this.picClosePdf);
            this.panReport.Controls.Add(this.reportBaocao);
            this.panReport.Location = new System.Drawing.Point(147, 0);
            this.panReport.Margin = new System.Windows.Forms.Padding(2);
            this.panReport.Name = "panReport";
            this.panReport.Size = new System.Drawing.Size(906, 650);
            this.panReport.TabIndex = 73;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Transparent;
            this.btnIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIn.FillColor = System.Drawing.Color.White;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageSize = new System.Drawing.Size(33, 33);
            this.btnIn.Location = new System.Drawing.Point(2, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(33, 33);
            this.btnIn.TabIndex = 26;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // picClosePdf
            // 
            this.picClosePdf.BackColor = System.Drawing.Color.White;
            this.picClosePdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClosePdf.Image = ((System.Drawing.Image)(resources.GetObject("picClosePdf.Image")));
            this.picClosePdf.Location = new System.Drawing.Point(871, 0);
            this.picClosePdf.Name = "picClosePdf";
            this.picClosePdf.Size = new System.Drawing.Size(35, 35);
            this.picClosePdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClosePdf.TabIndex = 24;
            this.picClosePdf.TabStop = false;
            this.picClosePdf.Click += new System.EventHandler(this.picClosePdf_Click);
            // 
            // reportBaocao
            // 
            this.reportBaocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBaocao.Location = new System.Drawing.Point(0, 0);
            this.reportBaocao.Name = "reportBaocao";
            this.reportBaocao.ServerReport.BearerToken = null;
            this.reportBaocao.Size = new System.Drawing.Size(906, 650);
            this.reportBaocao.TabIndex = 25;
            // 
            // frmEcoOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 650);
            this.Controls.Add(this.panWork);
            this.Controls.Add(this.panReport);
            this.Controls.Add(this.panHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEcoOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEcoOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpLoidinhdang)).EndInit();
            this.panHome.ResumeLayout(false);
            this.panSignIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.panVeUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVechungtoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHuongdan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelEco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinisize)).EndInit();
            this.panForget.ResumeLayout(false);
            this.panForgetChange.ResumeLayout(false);
            this.panForgetOTP.ResumeLayout(false);
            this.panWork.ResumeLayout(false);
            this.panAdmin.ResumeLayout(false);
            this.TabcontrolAdmin.ResumeLayout(false);
            this.tabQLNV.ResumeLayout(false);
            this.panTTNVchitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox5)).EndInit();
            this.tabQLKH.ResumeLayout(false);
            this.panTTKHchitiet.ResumeLayout(false);
            this.tabQLHD.ResumeLayout(false);
            this.panTTHDchitiet.ResumeLayout(false);
            this.panTTHDchitiet.PerformLayout();
            this.panCSchitiet.ResumeLayout(false);
            this.grpDulieuTS.ResumeLayout(false);
            this.tabQLTS.ResumeLayout(false);
            this.tabQLTS.PerformLayout();
            this.panTTTSchitiet.ResumeLayout(false);
            this.tabQLTB.ResumeLayout(false);
            this.tabQLTB.PerformLayout();
            this.panDSTBchitiet.ResumeLayout(false);
            this.panTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panChuthich.ResumeLayout(false);
            this.panDSDH.ResumeLayout(false);
            this.panDSHDnvchitiet.ResumeLayout(false);
            this.splitDSHDnvchitiet.Panel1.ResumeLayout(false);
            this.splitDSHDnvchitiet.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDSHDnvchitiet)).EndInit();
            this.splitDSHDnvchitiet.ResumeLayout(false);
            this.grbThongtinDH.ResumeLayout(false);
            this.grbChucnang.ResumeLayout(false);
            this.grpDulieuDH.ResumeLayout(false);
            this.panTTNV.ResumeLayout(false);
            this.grbQuoctich.ResumeLayout(false);
            this.grbDiachithuongtru.ResumeLayout(false);
            this.grbQuequan.ResumeLayout(false);
            this.grbDantoc.ResumeLayout(false);
            this.grbNoioCurrent.ResumeLayout(false);
            this.grbNoisinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInformation)).EndInit();
            this.grbChucvu.ResumeLayout(false);
            this.grbPhongban.ResumeLayout(false);
            this.grbSex.ResumeLayout(false);
            this.grbEmail.ResumeLayout(false);
            this.grbName.ResumeLayout(false);
            this.grbNgaysinh.ResumeLayout(false);
            this.grbSdt.ResumeLayout(false);
            this.grbMa.ResumeLayout(false);
            this.panTB.ResumeLayout(false);
            this.panNoidungTB.ResumeLayout(false);
            this.panDSNV.ResumeLayout(false);
            this.panFindNV.ResumeLayout(false);
            this.grbTimthay.ResumeLayout(false);
            this.grbAllTTNV.ResumeLayout(false);
            this.panLogOut.ResumeLayout(false);
            this.grbLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.panDMK.ResumeLayout(false);
            this.grbChangepass.ResumeLayout(false);
            this.panReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClosePdf)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private ErrorProvider erpLoidinhdang;
        private SiticonePanel panHome;
        private PictureBox picCancelEco;
        private PictureBox picMinisize;
        private SiticonePanel panSignIn;
        private SiticoneButton btnSignIn;
        private SiticonePictureBox picEye;
        private SiticoneHtmlLabel lblForget;
        private SiticoneTextBox txtPass;
        private SiticoneTextBox txtName;
        private SiticoneHtmlLabel lblHello;
        private SiticoneButton btnFlag;
        private SiticoneHtmlLabel lblNote;
        private SiticoneHtmlLabel lblVechungtoi;
        private SiticoneHtmlLabel lblHuongdan;
        private SiticonePanel panForget;
        private SiticoneHtmlLabel lblTitleForget;
        private SiticoneHtmlLabel lblInstructionForget;
        private SiticoneTextBox txtInputEmail;
        private SiticoneButton btnContinueForget;
        private SiticoneButton btnCancelForget;
        private SiticonePanel panForgetOTP;
        private SiticoneHtmlLabel lblTitleOTP;
        private SiticoneHtmlLabel lblInstructionOTP;
        private SiticoneTextBox txtInputOTP;
        private SiticoneButton btnContinueOTP;
        private SiticoneButton btnCancelOTP;
        private SiticoneHtmlLabel lblSentAgainOTP;
        private SiticoneHtmlLabel lblNoteOTP;
        private SiticoneHtmlLabel lblNameEmail;
        private SiticonePanel panForgetChange;
        private SiticoneHtmlLabel lblTitleChange;
        private SiticoneHtmlLabel lblInstructionChange;
        private SiticoneButton btnContinueChange;
        private SiticoneHtmlLabel lblPasswordNew;
        private SiticoneHtmlLabel lblPasswordNewAgain;
        private SiticoneTextBox txtPasswordNewAgain;
        private SiticoneTextBox txtPasswordNew;
        private PictureBox picHuongdan;
        private PictureBox picVechungtoi;
        private SiticonePanel panVeUs;
        private PictureBox picClose;
        private SiticonePictureBox picAboutUs;
        private SiticonePanel panWork;
        private SiticonePanel panTB;
        private SiticoneButton btnSortTB;
        private SiticoneHtmlLabel lblDSTB;
        private DoubleBufferedPanel panDSTB;
        private SiticoneHtmlLabel lblGachngang;
        private SiticoneHtmlLabel siticoneHtmlLabel5;
        private SiticonePanel panNoidungTB;
        private RichTextBox ricNDungTB;
        private SiticoneHtmlLabel lblDateTB;
        private SiticoneHtmlLabel lblTitleTB;
        private SiticoneCircleButton btnFindTB;
        private SiticoneTextBox txtFindTB;
        private SiticonePanel panDSDH;
        private SiticoneButton btnSortDH;
        private SiticoneCustomGradientPanel panDSHDnvchitiet;
        private SplitContainer splitDSHDnvchitiet;
        private SiticoneCircleButton btnFindma;
        private SiticoneTextBox txtFindma;
        private GroupBox grbThongtinDH;
        private SiticoneTextBox txtMadonhang;
        private Label lblMadonhang;
        private Label lblGhichu;
        private SiticoneTextBox txtGhichu;
        private SiticoneTextBox txtTenthongso;
        private SiticoneTextBox txtKetqua;
        private Label lblTenthongso;
        private Label lblKetqua;
        private GroupBox grbChucnang;
        private SiticoneButton btnPrint;
        private SiticoneButton btnLuu;
        private SiticoneButton btnSua;
        private GroupBox grpDulieuDH;
        private ListView lvDulieudonhang;
        private DoubleBufferedPanel panDSHDnv;
        private SiticoneHtmlLabel lblDSDH;
        private SiticonePanel panDMK;
        private SiticoneGroupBox grbChangepass;
        private SiticoneTextBox txtPasscurrent;
        private SiticoneHtmlLabel lblPasscurrent;
        private SiticoneTextBox txtPassnewagain;
        private SiticoneTextBox txtPassnew;
        private SiticoneButton btnContinueDMK;
        private SiticoneHtmlLabel lblPassnewagain;
        private SiticoneHtmlLabel lblPassnew;
        private SiticoneButton btnCancelchange;
        private SiticoneHtmlLabel lblLogo;
        private PictureBox picLogo;
        private SiticoneHtmlLabel lblChucnangQL;
        private SiticoneHtmlLabel lblDoimatkhau;
        private SiticoneHtmlLabel lblThongke;
        private SiticoneHtmlLabel lblThongbao;
        private SiticoneHtmlLabel lblDanhsachNV;
        private SiticoneHtmlLabel lblThongtinNV;
        private SiticoneHtmlLabel lblDanhsachDH;
        private SiticoneHtmlLabel lblTrangchu;
        private SiticoneHtmlLabel lblNameNV;
        private PictureBox picStaff;
        private SiticoneHtmlLabel lblLogOut;
        private PictureBox picLogout;
        private SiticonePanel panTK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private SiticoneHtmlLabel lblYear;
        private SiticoneHtmlLabel siticoneHtmlLabel6;
        private SiticoneHtmlLabel lblTK;
        private SiticonePanel panChuthich;
        private SiticoneHtmlLabel lblDHQuahan;
        private SiticoneHtmlLabel lblDHInProgress;
        private SiticoneHtmlLabel lblDHFinish;
        private SiticoneTextBox txtQuahan;
        private SiticoneTextBox txtInProgress;
        private SiticoneHtmlLabel lblChuthich;
        private SiticoneTextBox txtFinish;
        private SiticonePanel panTTNV;
        private SiticoneGroupBox grbQuoctich;
        private SiticoneTextBox txtQuoctich;
        private SiticoneHtmlLabel lblQuoctich;
        private SiticoneGroupBox grbDiachithuongtru;
        private SiticoneTextBox txtDiachithuongtru;
        private SiticoneHtmlLabel lblDiachithuongtru;
        private SiticoneGroupBox grbQuequan;
        private SiticoneTextBox txtQuequan;
        private SiticoneHtmlLabel lblQuequan;
        private SiticoneGroupBox grbDantoc;
        private SiticoneTextBox txtDantoc;
        private SiticoneGroupBox grbNoioCurrent;
        private SiticoneTextBox txtNoioCurrent;
        private SiticoneHtmlLabel lblDantoc;
        private SiticoneHtmlLabel lblNoioCurrent;
        private SiticoneGroupBox grbNoisinh;
        private SiticoneTextBox txtNoisinh;
        private SiticoneHtmlLabel lblNoisinh;
        private SiticoneHtmlLabel lblThongtinCN;
        private SiticoneHtmlLabel lblHinhanhCN;
        private SiticoneCirclePictureBox picInformation;
        private SiticoneGroupBox grbChucvu;
        private SiticoneTextBox txtChucvu;
        private SiticoneHtmlLabel lblChucvu;
        private SiticoneGroupBox grbPhongban;
        private SiticoneTextBox txtPhongban;
        private SiticoneHtmlLabel lblPhongban;
        private SiticoneGroupBox grbSex;
        private SiticoneComboBox cboSexnv;
        private SiticoneGroupBox grbEmail;
        private SiticoneTextBox txtEmailnv;
        private SiticoneHtmlLabel lblEmail;
        private SiticoneGroupBox grbName;
        private SiticoneTextBox txtNamenv;
        private SiticoneHtmlLabel lblName;
        private SiticoneHtmlLabel lblSex;
        private SiticoneGroupBox grbNgaysinh;
        private SiticoneTextBox txtNgaysinhnv;
        private SiticoneGroupBox grbSdt;
        private SiticoneTextBox txtSdtnv;
        private SiticoneHtmlLabel lblNgaysinh;
        private SiticoneHtmlLabel lblSdt;
        private SiticoneGroupBox grbMa;
        private SiticoneTextBox txtManv;
        private SiticoneHtmlLabel lblMa;
        private SiticoneHtmlLabel lblThongtinNhanvien;
        private SiticonePanel panDSNV;
        private DoubleBufferedPanel panFindNV;
        private SiticoneGroupBox grbTimthay;
        private SiticoneHtmlLabel txtEmail;
        private SiticoneHtmlLabel txtSDT;
        private SiticoneHtmlLabel lblPhongbanFind;
        private SiticoneHtmlLabel txtTenNV;
        private SiticoneHtmlLabel lblManhanvien;
        private SiticoneGroupBox grbAllTTNV;
        private SiticoneHtmlLabel siticoneHtmlLabel3;
        private SiticoneHtmlLabel lblSodienthoai;
        private SiticoneHtmlLabel lblPhongbanNV;
        private SiticoneHtmlLabel siticoneHtmlLabel4;
        private SiticoneHtmlLabel lblMaNV;
        private SiticoneCircleButton btnFindNV;
        private SiticoneTextBox txtFindNV;
        private SiticonePanel panAdmin;
        private SiticoneCircleButton btnFindAdmin;
        private SiticoneTextBox txtFindAdmin;
        private SiticoneTabControl TabcontrolAdmin;
        private TabPage tabQLNV;
        private SiticoneGradientPanel panTTNVchitiet;
        private SiticoneCustomCheckBox checkTruongPhong;
        private Label lblTruongPhong;
        private SiticoneComboBox cboSexTTNV;
        private SiticoneDateTimePicker dtpNgaycap;
        private SiticoneTextBox txtGmail;
        private SiticoneTextBox txtSDTTTNV;
        private Label lblSodt;
        private Label lblGioitinh;
        private Label lblMatkhau;
        private SiticoneCirclePictureBox siticoneCirclePictureBox5;
        private SiticoneTextBox txtChucvuTTNV;
        private SiticoneTextBox txtChiso;
        private SiticoneTextBox txtMachiso;
        private Label lblDate;
        private Label lblChuc;
        private Label lblHoten;
        private Label lblMasonv;
        private SiticoneButton btnTaiDSNV;
        private SiticoneButton btnSuaDSNV;
        private SiticoneButton btnXoaDSNV;
        private SiticoneButton btnAddNV;
        private SiticoneButton btnSortNV;
        private SiticoneHtmlLabel siticoneHtmlLabel7;
        private SiticoneHtmlLabel lblTTNV;
        private SiticoneHtmlLabel lblThemNV;
        private DoubleBufferedPanel panDanhsachNV;
        private TabPage tabQLKH;
        private SiticoneGradientPanel panTTKHchitiet;
        private SiticoneTextBox txtMST;
        private Label lblMasothue;
        private SiticoneTextBox txtMaCty;
        private Label lblMasoct;
        private SiticoneTextBox txtGmailCty;
        private Label lblGmailct;
        private SiticoneTextBox txtSDTCty;
        private Label label1;
        private SiticoneTextBox txtDiachiCty;
        private SiticoneTextBox txtTenCty;
        private Label lblDiachi;
        private Label lblTenct;
        private SiticoneButton btnLuuDSKH;
        private SiticoneButton btnSuaDSKH;
        private SiticoneButton btnXoaDSKH;
        private SiticoneButton btnAddKH;
        private SiticoneButton btnSortKH;
        private DoubleBufferedPanel panDSKH;
        private SiticoneHtmlLabel lblDanhsachKH;
        private SiticoneHtmlLabel lblThongtinKH;
        private SiticoneHtmlLabel lblThemKH;
        private TabPage tabQLHD;
        private SiticoneGradientPanel panTTHDchitiet;
        private SiticoneGradientPanel panCSchitiet;
        private SiticoneButton btnSuaChiSoChiTiet;
        private GroupBox grpDulieuTS;
        private ListView lvDulieuTS;
        private SiticoneButton btnLuuCSchitiet;
        private SiticoneHtmlLabel siticoneHtmlLabel12;
        private SiticoneHtmlLabel lblTSchitiet;
        private SiticoneTextBox txtGhiChuQLHD;
        private Label label2;
        private SiticoneTextBox txtTenCS;
        private SiticoneTextBox txtMaNVnhap;
        private SiticoneTextBox txtMaCSQLHD;
        private Label lblDatenhap;
        private Label lblThongso;
        private Label label3;
        private Label lblMathongso;
        private SiticoneButton btnXoaChiSoChiTiet;
        private SiticoneTextBox txtSotien;
        private SiticoneTextBox txtMaHDQLHD;
        private SiticoneTextBox txtMaCtyQLHD;
        private Label lblSomoney;
        private Label lblDategiao;
        private Label lblDateky;
        private Label lblMasnv;
        private Label lblMact;
        private Label lblMahd;
        private SiticoneButton btnLuuHD;
        private SiticoneButton btnSuaHD;
        private SiticoneButton btnXoaHD;
        private SiticoneHtmlLabel lblTTHD;
        private SiticoneHtmlLabel lblThemHD;
        private SiticoneHtmlLabel lblDSHD;
        private DoubleBufferedPanel panDSHD;
        private SiticoneButton siticoneButton4;
        private SiticoneButton siticoneButton5;
        private TabPage tabQLTS;
        private SiticoneGradientPanel panTTTSchitiet;
        private Label lblNoiNhap;
        private SiticoneTextBox txtNoiNhap;
        private SiticoneTextBox txtTieuChuan;
        private SiticoneTextBox txtViTriCS;
        private Label lblTieuchuan;
        private SiticoneTextBox txtLoaiChiSo;
        private SiticoneTextBox txtTenChiSo;
        private SiticoneTextBox txtMaCS;
        private Label lblVitri;
        private Label lblLoaits;
        private Label label6;
        private Label lblMats;
        private SiticoneButton btnLuuTS;
        private SiticoneButton btnSuaTS;
        private SiticoneButton btnXoaTS;
        private SiticoneButton btnAddTS;
        private SiticoneButton btnSortTS;
        private DoubleBufferedPanel panDSTS;
        private SiticoneHtmlLabel lblDanhsachTS;
        private SiticoneHtmlLabel lblTTTS;
        private SiticoneHtmlLabel lblThemCS;
        private TabPage tabQLTB;
        private SiticoneGradientPanel panDSTBchitiet;
        private RichTextBox txtNoidung;
        private SiticoneTextBox txtTieuDe;
        private Label lblNdungTB;
        private Label lblDatephathanh;
        private Label lblTieude;
        private SiticoneTextBox txtVitriTB;
        private Label lblMaTB;
        private SiticoneButton btnLuuTB;
        private SiticoneButton btnSuaTB;
        private SiticoneButton btnXoaTB;
        private SiticoneHtmlLabel siticoneHtmlLabel10;
        private SiticoneHtmlLabel lblDanhsachTB;
        private DoubleBufferedPanel panDSTBAdmin;
        private SiticoneButton btnAddTB;
        private SiticoneButton btnSortThongbao;
        private SiticonePanel panLogOut;
        private SiticoneGroupBox grbLogout;
        private SiticoneButton btnContinueLogout;
        private SiticoneHtmlLabel siticoneHtmlLabel11;
        private SiticoneButton btnCancelLogout;
        private SiticonePanel panReport;
        private SiticoneButton btnIn;
        private PictureBox picClosePdf;
        private Microsoft.Reporting.WinForms.ReportViewer reportBaocao;
        private SiticoneButton btnAddHD;
        private SiticoneButton btnSortHD;
        private SiticoneDateTimePicker dtpNgaykyQLHD;
        private SiticoneDateTimePicker dtpNgaytraKQQLHD;
        private SiticoneTextBox txtMaNVQLHD;
        private SiticoneDateTimePicker dtpNgaynhapQLHD;
        private SiticoneTextBox txtMaThongSo;
        private Label label4;
        private SiticoneComboBox cboMoctgian;
        private SiticoneDateTimePicker dtpNgayphathanh;
    }
}
