using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using System.Timers;
using System.Text.RegularExpressions;
using DuAnCNPM.Controlers;
using DuAnCNPM.Datas;
using System.IO;
using DuAnCNPM.Views;
using DuAnCNPM.Controller;
using AxWMPLib;
using WMPLib;
using static System.Net.WebRequestMethods;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DuAnCNPM.Models;
using Vosk;
using NAudio.Wave;

namespace DuAnCNPM
{
    public partial class frmEcoOrder : Form
    {
        private VoiceSearch voiceSearch;
        private bool isRecording = false;
        private static ResourceManager rm;
        public bool isVN = true;
        private string OldPanel="",idEm = "";
        public frmEcoOrder()
        {
            InitializeComponent();
            HieuUngChu(lblForget, lblHuongdan, lblVechungtoi, lblSentAgainOTP);
            this.reportBaocao.ShowToolBar = false;
            voiceSearch = new VoiceSearch();
            voiceSearch.OnRecognized += VoiceSearch_OnRecognized;
        }
        //check pan nào mở thì đóng
        private void CheckPanel(params Panel[] pans)
        {
            foreach (Panel panl in pans)
            {
                if (panl.Visible==true)
                {
                    panl.Visible = false;
                    OldPanel = panl.Name;
                }
            }
        }
        //đổi ngôn ngữ
        public void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            if (rm == null || rm.BaseName != "DuAnCNPM.Properties.Resources")
            {
                rm = new ResourceManager("DuAnCNPM.Properties.Resources", typeof(frmEcoOrder).Assembly);
            }
            UpdateControl(this, rm);
            foreach (Control ctrl in GetAllControls(this))
            {
                if (ctrl.ContextMenuStrip != null)
                {
                    foreach (ToolStripItem item in ctrl.ContextMenuStrip.Items)
                    {
                        UpdateMenuItem(item, rm);
                    }
                }
            }
            rm.ReleaseAllResources();
        }
        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                yield return ctrl;
                if (ctrl.HasChildren)
                {
                    foreach (Control child in GetAllControls(ctrl))
                    {
                        yield return child;
                    }
                }
            }
        }
        private void UpdateControl(Control parent, ResourceManager rm)
        {
            foreach (Control ctrl in parent.Controls)
            {
                string newText = rm.GetString(ctrl.Name, Thread.CurrentThread.CurrentUICulture);
                if (!string.IsNullOrEmpty(newText))
                {
                    if (ctrl is SiticoneTextBox textBox)
                    {
                        textBox.PlaceholderText = newText;
                    }
                    else if (!(ctrl is UserControl))
                    {
                        ctrl.Text = newText;
                    }
                }
                if (ctrl is UserControl || ctrl.HasChildren)
                {
                    UpdateControl(ctrl, rm);
                }
            }
        }
        private void UpdateMenuItem(ToolStripItem item, ResourceManager rm)
        {
            string newText = rm.GetString(item.Name, Thread.CurrentThread.CurrentUICulture);
            if (!string.IsNullOrEmpty(newText))
            {
                item.Text = newText;
            }

            if (item is ToolStripMenuItem parentItem)
            {
                foreach (ToolStripItem subItem in parentItem.DropDownItems)
                {
                    UpdateMenuItem(subItem, rm);
                }
            }
        }
        private async void LoadData()
        {
            await Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    DataSeeder.SeedData();
                }));
            });
        }
        //Hiệu ứng chữ
        private void HieuUngChu(params Control[] Fores)
        {
            foreach (Control Fore in Fores)
            {
                Fore.MouseEnter += (s, e) =>
                {
                    Fore.ForeColor = Color.LightGreen;
                    Fore.Font = new Font(lblForget.Font.FontFamily, 13, FontStyle.Bold | FontStyle.Underline);
                };
                Fore.MouseLeave += (s, e) =>
                {
                    Fore.ForeColor = Color.Black;
                    Fore.Font = new Font(lblForget.Font.FontFamily, 12, FontStyle.Bold | FontStyle.Underline);
                };
            }
        }
        private void ShowColor(params SiticoneHtmlLabel[] lbls)
        {
            foreach (SiticoneHtmlLabel lbl in lbls)
            {
                lbl.BackColor = Color.White;
                lbl.ForeColor = Color.DarkSlateGray;
            }
        }
        private void HideColor(params SiticoneHtmlLabel[] lbls)
        {
            foreach (SiticoneHtmlLabel lbl in lbls)
            {
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.White;
            }
        }
        //Mở panel
        private void ShowPanel(params Panel[] pan)
        {
            erpLoidinhdang.Clear();
            foreach (Panel panl in pan)
            {
                if (panl == panSignIn)
                {
                    txtPass.BorderColor = Color.SeaGreen;
                    txtPass.FillColor = Color.MintCream;
                    txtPass.Text = "";
                    txtName.BorderColor = Color.SeaGreen;
                    txtName.FillColor = Color.MintCream;
                    txtName.Text = "";
                }
                if (panl == panForget)
                {
                    txtInputEmail.BorderColor = Color.SeaGreen;
                    txtInputEmail.FillColor = Color.White;
                    txtInputEmail.Text = "";
                }
                if (panl == panForgetOTP)
                {
                    txtInputOTP.BorderColor = Color.SeaGreen;
                    txtInputOTP.FillColor = Color.White;
                    txtInputOTP.Text = "";
                    txtPassnew.BorderColor = Color.SeaGreen;
                    txtPassnew.FillColor = Color.White;
                    txtPassnew.Text = "";
                    txtPassnewagain.BorderColor = Color.SeaGreen;
                    txtPassnewagain.FillColor = Color.White;
                    txtPassnewagain.Text = "";
                }
                if (panl==panDSDH)
                {
                    HideColor(lblThongtinNV,lblDanhsachNV,lblThongbao,lblThongke,lblDoimatkhau,lblChucnangQL,lblTrangchu);
                    ShowColor(lblDanhsachDH);
                }
                if (panl==panTTNV)
                {
                    HideColor(lblDanhsachDH, lblDanhsachNV, lblThongbao, lblThongke, lblDoimatkhau, lblChucnangQL, lblTrangchu);
                    ShowColor(lblThongtinNV);
                }
                if (panl==panDSNV)
                {
                    HideColor(lblThongtinNV, lblDanhsachDH, lblThongbao, lblThongke, lblDoimatkhau, lblChucnangQL, lblTrangchu);
                    ShowColor(lblDanhsachNV);
                }
                if (panl==panTB)
                {
                    HideColor(lblThongtinNV, lblDanhsachNV, lblDanhsachDH, lblThongke, lblDoimatkhau, lblChucnangQL, lblTrangchu);
                    ShowColor(lblThongbao);
                }
                if (panl==panTK)
                {
                    HideColor(lblThongtinNV, lblDanhsachNV, lblThongbao, lblDanhsachDH, lblDoimatkhau, lblChucnangQL, lblTrangchu);
                    ShowColor(lblThongke);
                }
                if (panl==panDMK)
                {
                    HideColor(lblThongtinNV, lblDanhsachNV, lblThongbao, lblThongke, lblDanhsachDH, lblChucnangQL, lblTrangchu);
                    ShowColor(lblDoimatkhau);
                }
                if (panl == panTrangchu)
                {
                    HideColor(lblThongtinNV, lblDanhsachNV, lblThongbao, lblThongke, lblDoimatkhau, lblDanhsachDH, lblChucnangQL);
                    ShowColor(lblTrangchu);
                }
                if (panl == panLogOut)
                {
                    HideColor(lblThongtinNV, lblDanhsachNV, lblThongbao, lblThongke, lblDoimatkhau, lblDanhsachDH, lblChucnangQL, lblTrangchu);
                }
                panl.Visible = true;
                if (panl==panAdmin)
                {
                    HideColor(lblThongtinNV, lblDanhsachNV, lblThongbao, lblThongke, lblDoimatkhau, lblDanhsachDH, lblTrangchu);
                    ShowColor(lblChucnangQL);
                    CheckPanel(panTTNVchitiet, panTTKHchitiet, panTTHDchitiet, panTTTSchitiet,panDSTBchitiet);
                }
                if (panl ==panWork)
                {
                    ShowColor(lblTrangchu);
                    CheckPanel(panDSDH, panTTNV, panDSNV, panTB, panTK, panDMK, panAdmin, panLogOut,panTrangchu);
                }
            }
        }
        // forget quay lại
        private void btnCancelForget_Click(object sender, EventArgs e)
        {
            CheckPanel(panForget);
            ShowPanel(panSignIn);
            this.AcceptButton = btnSignIn;
        }
        // click lá cờ đổi ngôn ngữ
        private void btnFlag_Click(object sender, EventArgs e)
        {
            string lang = (Thread.CurrentThread.CurrentUICulture.Name == "vi") ? "en" : "vi";
            ChangeLanguage(lang);
            btnFlag.Image = (isVN) ? DuAnCNPM.Properties.Resources.FlagUS : DuAnCNPM.Properties.Resources.FlagVN;
            isVN = !isVN;
        }
        //nút out phần mềm
        private void picCancelEco_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(isVN ? "Bạn có muốn thoát không?" : "Do you want to escape?", isVN ? "Xác nhận" : "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            CheckPanel(panVeUs);
        }
        // đăng nhập
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                Validating Vali = new Validating();
                erpLoidinhdang.Clear();
                if (Vali.valSignin(txtName.Text, txtPass.Text)[0])
                {
                    erpLoidinhdang.SetError(txtName,
                    string.IsNullOrWhiteSpace(txtName.Text)
                    ? (isVN ? "Không để trống" : "Do not leave blank")
                    : (isVN ? "Sai định dạng!" : "Incorrect format"));
                    txtName.BorderColor = Color.Red;
                    txtName.FillColor = Color.LightPink;
                    return;
                }
                else
                {
                    txtName.BorderColor = Color.DarkGreen;
                    txtName.FillColor = Color.Honeydew;
                    if (Vali.valSignin(txtName.Text, txtPass.Text)[1])
                    {
                        erpLoidinhdang.SetError(txtPass, isVN ? "Không để trống" : "Do not leave blank");
                        txtPass.BorderColor = Color.Red;
                        txtPass.FillColor = Color.LightPink;
                        return;
                    }
                    else
                    {
                        SignInService Signin = new SignInService();
                        txtPass.BorderColor = Color.DarkGreen;
                        txtPass.FillColor = Color.Honeydew;
                        if (Signin.signInService(txtName.Text, txtPass.Text))
                        {
                            string Name = UserInform.name;
                            lblNameNV.Text = Name;
                            lblChucnangQL.Visible = false;
                            idEm = Signin.getID(txtName.Text, txtPass.Text);
                            if (Signin.getRole(txtName.Text, txtPass.Text) == "ADMIN")
                            {
                                lblChucnangQL.Visible = true;
                            }
                            CheckPanel(panHome,panSignIn);
                            ShowPanel(panWork);
                        }
                        else
                        {
                            MessageBox.Show(isVN ? "Tên đăng nhập hoặc mật khẩu không đúng!" : "Incorrect username or password!", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        // form Load
        private void frmEcoOrder_Load(object sender, EventArgs e)
        {
            LoadData();
            ChangeLanguage("vi");
            CheckPanel(panWork, panReport, panVeUs, panForget, panForgetChange, panForgetOTP);
            ShowPanel(panSignIn,panHome);
            this.AcceptButton = btnSignIn;
        }
        //thu nhỏ
        private void picMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void picClosePdf_Click(object sender, EventArgs e)
        {
            CheckPanel(panReport);
        }
        //Ẩn pass
        private void picEye_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar = '\0';
                picEye.Image = Properties.Resources.eyeOpen;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                picEye.Image = Properties.Resources.eyeClose;
            }
        }
        //về chúng tôi
        private void lblVechungtoi_Click(object sender, EventArgs e)
        {
            ShowPanel(panVeUs);
        }
        private void picVechungtoi_Click(object sender, EventArgs e)
        {
            ShowPanel(panVeUs);
        }
        //Quên mật khẩu
        private void lblForget_Click(object sender, EventArgs e)
        {
            CheckPanel(panSignIn);
            ShowPanel(panForget);
            this.AcceptButton = btnContinueForget;
        }
        // Đăng xuất
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            CheckPanel(panDSDH, panTTNV, panDSNV, panTB, panTK, panDMK, panAdmin,panTrangchu);
            ShowPanel(panLogOut);
            this.AcceptButton = btnContinueLogout;
        }
        private void picLogout_Click(object sender, EventArgs e)
        {
            lblLogOut_Click(sender, e);
        }
        // Yes khi đăng xuất
        private void btnContinueLogout_Click(object sender, EventArgs e)
        {
            CheckPanel(panVeUs, panLogOut, panWork);
            ShowPanel(panSignIn,panHome);
            this.AcceptButton = btnSignIn;
        }
        //No khi đăng xuất
        private void btnCancelLogout_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> pans = new Dictionary<string, string>()
            {
                { "panDSDH", "lblDanhsachDH" },
                { "panTTNV", "lblThongtinNV" },
                { "panDSNV", "lblDanhsachNV" },
                { "panTB", "lblThongbao" },
                { "panTK", "lblThongke" },
                { "panDMK", "lblDoimatkhau" }, 
                { "panAdmin", "lblChucnangQL" },
                { "panTrangchu", "lblTrangchu" },
            };
            if (pans.ContainsKey(OldPanel))
            {
                (panWork.Controls[OldPanel] as Panel).Visible = true;
                ShowColor(panWork.Controls[pans[OldPanel]] as SiticoneHtmlLabel);
            }
            CheckPanel(panLogOut);
        }
        // trang chủ
        private void lblTrangchu_Click(object sender, EventArgs e)
        {
            CheckPanel(panDSDH, panTTNV, panDSNV, panTB, panTK, panDMK, panAdmin,panLogOut);
            ShowPanel(panTrangchu);
        }
        // Mở DSDH
        private void lblDanhsachDH_Click(object sender, EventArgs e)
        {
            CheckPanel(panTTNV, panDSNV, panTB, panTK, panDMK, panAdmin, panLogOut,panTrangchu);
            ContractService contractViewing = new ContractService();
            contractViewing.ShowContracts(panDSHDnv, splitDSHDnvchitiet);
            //panCSchitiet.Visible = true ;
            ShowPanel(panDSDH);

        }
        // Mở TTNV
        private void lblThongtinNV_Click(object sender, EventArgs e)
        {
            CheckPanel(panDSDH, panDSNV, panTB, panTK, panDMK, panAdmin, panLogOut, panTrangchu);
            ShowPanel(panTTNV);
            EmployeeService em = new EmployeeService();
            em.ShowEmployeeInformation(idEm, panTTNV);
        }
        //Mở DSNV
        private void lblDanhsachNV_Click(object sender, EventArgs e)
        {
            CheckPanel(panDSDH, panTTNV, panTB, panTK, panDMK, panAdmin, panLogOut, panTrangchu);
            ShowPanel(panDSNV);
        }
        //Mở TB
        private void lblThongbao_Click(object sender, EventArgs e)
        {
            CheckPanel(panDSDH, panTTNV, panDSNV, panTK, panDMK, panAdmin, panLogOut, panTrangchu);
            ShowPanel(panTB);
        }
        //Mở Thống kê
        private void lblThongke_Click(object sender, EventArgs e)
        {
            CheckPanel(panDSDH, panTTNV, panDSNV, panTB, panDMK, panAdmin, panLogOut, panTrangchu);
            ContractService cs = new ContractService();
            cboMoctgian.DataSource = cs.timeData().ToList();
            if (checkTime(cboMoctgian.Items[0].ToString()) == 1)
            {
                chart2.Visible = true;
                loadPieChart(cs.dataForPieChart(cboMoctgian.Items[0].ToString()));
                loadChart(cs.dataForQuarter(cboMoctgian.Items[0].ToString()));
            }
            else
            {
                loadChart(cs.dataForYearChart(cboMoctgian.Items[0].ToString()));
                loadPieChart(cs.dataForPieChart(cboMoctgian.Items[0].ToString()));
            }
            ShowPanel(panTK);
        }
        //Mở Đổi MK
        private void lblDoimatkhau_Click(object sender, EventArgs e)
        {
            CheckPanel(panDSDH, panTTNV, panDSNV, panTB, panTK, panAdmin, panLogOut, panTrangchu);
            ShowPanel(panDMK);
        }
        // Mở Quản lý(Admin)
        private void lblChucnangQL_Click(object sender, EventArgs e)
        {
            CheckPanel(panDSDH, panTTNV, panDSNV, panTB, panTK, panDMK, panLogOut, panTrangchu);
            ShowPanel(panAdmin);
            EmployeeService employeeService = new EmployeeService();
            employeeService.ShowEmployeeAdmin(panDanhsachNV,panTTNVchitiet);
            btnSuaDSNV.Enabled = true;
            btnTaiDSNV.Enabled = false;
            btnXoaDSNV.Enabled = false;
        }
        
        // In PDF
        //nút In trong report
        private void btnIn_Click(object sender, EventArgs e)
        {
            this.reportBaocao.PrintDialog();
            CheckPanel(panReport);
        }
        // Hàm thêm data vào Report
        public void LoadData(List<ChiSoMoiTruongDTOR> data)
        {
            if (DesignMode) return;
            try
            {
                using (var db = new CTQLMTContext())
                {
                    ReportDataSource rds = new ReportDataSource("DataSet", data);
                    this.reportBaocao.LocalReport.DataSources.Clear();
                    this.reportBaocao.LocalReport.ReportEmbeddedResource = "DuAnCNPM.Views.Report.rdlc";
                    this.reportBaocao.LocalReport.DataSources.Add(rds);
                    this.reportBaocao.Width = this.Width - 20;
                    this.reportBaocao.Height = this.Height - 100;
                    this.reportBaocao.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            this.reportBaocao.RefreshReport();
        }
        // Click nút in đơn hàng
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ContractService contract = new ContractService();
            String maDonHang = txtMadonhang.Text;
            if (!contract.checkPrintCondition(maDonHang))
            {
                MessageBox.Show("Hãy nhập tất cả các chỉ số trong đơn hàng");
                return;
            }
            LoadData(contract.GetDanhSachChiSoReport(txtMadonhang.Text));
            ShowPanel(panReport);
        }
        // Click tiếp tục panForgetChange
        private void btnContinueChange_Click(object sender, EventArgs e)
        {
            try
            {
                Validating Vali = new Validating();
                erpLoidinhdang.Clear();
                if (!Vali.valResetPassword(txtPasswordNew.Text, txtPasswordNewAgain.Text)[0])
                {
                    erpLoidinhdang.SetError(txtPasswordNew, isVN ? "Không để trống" : "Do not leave blank");
                    txtPasswordNew.BorderColor = Color.Red;
                    txtPasswordNew.FillColor = Color.LightPink;
                    return;
                }
                else
                {
                    txtPasswordNew.BorderColor = Color.DarkGreen;
                    txtPasswordNew.FillColor = Color.Honeydew;
                    if (!Vali.valResetPassword(txtPasswordNew.Text, txtPasswordNewAgain.Text)[1])
                    {
                        erpLoidinhdang.SetError(txtPasswordNewAgain, isVN ? "Sai định dạng" : "Do not leave blank");
                        txtPasswordNewAgain.BorderColor = Color.Red;
                        txtPasswordNewAgain.FillColor = Color.LightPink;
                        return;
                    }
                    else
                    {
                        txtPasswordNewAgain.BorderColor = Color.DarkGreen;
                        txtPasswordNewAgain.FillColor = Color.Honeydew;
                        if (!Vali.valResetPassword(txtPasswordNew.Text, txtPasswordNewAgain.Text)[2])
                        {
                            MessageBox.Show(isVN ? "Mật khẩu không trùng lặp!" : "Password not duplicate!", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            OTPService OTP = new OTPService();
                            ResetPasswordService re = new ResetPasswordService();
                            if (re.ResetPasswordServices(OTP.email, txtPasswordNewAgain.Text))
                            {
                                MessageBox.Show(isVN ? "Đổi mật khẩu thành công!" : "Password changed successfully!", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CheckPanel(panForgetChange);
                                ShowPanel(panSignIn);
                                this.AcceptButton = btnSignIn;
                            }
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        // gửi lại otp
        private void lblSentAgainOTP_Click(object sender, EventArgs e)
        {
            OTPService OTP = new OTPService();
            if (OTP.sentOTP(txtInputEmail.Text))
            {
                MessageBox.Show(isVN ? "OTP đã gửi đến Email của bạn vui lòng nhập OTP để đổi mật khẩu" : "OTP has been sent to your Email, please enter OTP to change password", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(isVN ? "Không thể gửi OTP" : "Unable to send OTP", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // panForgetOTP  nút quay lại
        private void btnCancelOTP_Click(object sender, EventArgs e)
        {
            CheckPanel(panForgetOTP);
            ShowPanel(panSignIn);
            this.AcceptButton = btnSignIn;
        }
        //panForgetOTP nút tiếp tục
        private void btnContinueOTP_Click(object sender, EventArgs e)
        {
            OTPService OTP = new OTPService();
            if (OTP.OTPChecking(txtInputOTP.Text))
            {
                CheckPanel(panForgetOTP);
                ShowPanel(panForgetChange);
                this.AcceptButton = btnContinueChange;
            }
            else
            {
                MessageBox.Show(isVN ? "Sai mã OTP!" : "Wrong OTP code!", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //panForget nút tiếp tục
        private void btnContinueForget_Click(object sender, EventArgs e)
        {
            try
            {
                OTPService OTP = new OTPService();
                Validating Vali = new Validating();
                erpLoidinhdang.Clear();

                txtInputEmail.BorderColor = Color.DarkGreen;
                txtInputEmail.FillColor = Color.Honeydew;
                if (Vali.EmailService(txtInputEmail.Text))
                {
                    if (OTP.sentOTP(txtInputEmail.Text))
                    {
                        CheckPanel(panForget);
                        ShowPanel(panForgetOTP);
                        this.AcceptButton = btnContinueOTP;
                        MessageBox.Show(isVN ? "OTP đã gửi đến Email của bạn vui lòng nhập OTP để đổi mật khẩu" : "OTP has been sent to your Email, please enter OTP to change password", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblNameEmail.Text = OTP.email;
                    }
                    else
                    {
                        MessageBox.Show(isVN ? "Không thể gửi OTP" : "Unable to send OTP", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(isVN ? "Tài khoản email không tồn tại!" : "Email account does not exist!", isVN ? "Thông báo" : "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }






        //TÌM kiếm trong chức năng quản lý (phần trang nào nằm top trong này k hợp lý nữa nha t thay bằng Visible hết rồi)
        private void btnFindAdmin_Click(object sender, EventArgs e)
        {
            if (TabcontrolAdmin.SelectedIndex == 0 && txtFindAdmin.Text != "")
            {
                EmployeeService employeeService = new EmployeeService();
                employeeService.ShowEmployeeAdminSearch(employeeService.searchEmployee(txtFindAdmin.Text), panDanhsachNV, panTTNVchitiet);
            }
            else if (TabcontrolAdmin.SelectedIndex == 1 && txtFindAdmin.Text != "")
            {
                CustomerService customerService = new CustomerService();
                customerService.ShowCustomersSearch(customerService.searchCustomer(txtFindAdmin.Text), panDSKH, panTTKHchitiet);
            }
            else if (TabcontrolAdmin.SelectedIndex == 2 && txtFindAdmin.Text != "")
            {
                ContractService contractService = new ContractService();
                contractService.ShowContractsAdminSearch(contractService.searchContract(txtFindAdmin.Text), panDSHD, panTTHDchitiet);
            }
            else if (TabcontrolAdmin.SelectedIndex == 3 && txtFindAdmin.Text != "")
            {
                EnviromentIndexService enviromentIndexService = new EnviromentIndexService();
                enviromentIndexService.ShowStatsSearch(enviromentIndexService.searchEnviromentIndex(txtFindAdmin.Text), panDSTS, panTTTSchitiet);
            }
            else
            {
                AnnouncementService announcementService = new AnnouncementService();
                announcementService.ShowAnnouncementAdminSearch(null,panDSTBAdmin,panDSTBchitiet);
            }
        }
        //public void Workbtn_OnFindClicked()
        //{
        //    if (IsPanelReallyOnTop(panDSHDnv) && txtFind.Text != "")
        //    {
        //        ContractService contractService = new ContractService();
        //        contractService.ShowContract(this, contractService.searchContractForEmployee(txtFind.Text));
        //    }
        //    else if (((this.panAdmin.Controls["formAdmin"] as formAdmin).getTabAdmin().SelectedIndex == 0) && txtFind.Text != "")
        //    {
        //        EmployeeService employeeService = new EmployeeService();
        //        employeeService.ShowEmployeeSearch(employeeService.searchEmployee(txtFind.Text), (this.panAdmin.Controls["formAdmin"] as formAdmin).getPanDSNV(),
        //            (this.panAdmin.Controls["formAdmin"] as formAdmin).getPanTTNVchitiet());
        //    }
        //    else if (((this.panAdmin.Controls["formAdmin"] as formAdmin).getTabAdmin().SelectedIndex == 1) && txtFind.Text != "")
        //    {
        //        CustomerService customerService = new CustomerService();
        //        customerService.ShowCustomersSearch(customerService.searchCustomer(txtFind.Text), (this.panAdmin.Controls["formAdmin"] as formAdmin).getPanDSKH(),
        //            (this.panAdmin.Controls["formAdmin"] as formAdmin).getPanTTKHchitiet());
        //    }
        //    else if (((this.panAdmin.Controls["formAdmin"] as formAdmin).getTabAdmin().SelectedIndex == 2) && txtFind.Text != "")
        //    {
        //        ContractService contractService = new ContractService();
        //        contractService.ShowContractsSearchAdmin(contractService.searchContract(txtFind.Text), (this.panAdmin.Controls["formAdmin"] as formAdmin).getPanDSHD(),
        //            (this.panAdmin.Controls["formAdmin"] as formAdmin).getPanTTHDchitiet());
        //    }
        //    else if (((this.panAdmin.Controls["formAdmin"] as formAdmin).getTabAdmin().SelectedIndex == 3) && txtFind.Text != "")
        //    {
        //        EnviromentIndexService enviromentIndexService = new EnviromentIndexService();
        //        enviromentIndexService.ShowStatsSearch(enviromentIndexService.searchEnviromentIndex(txtFind.Text), (this.panAdmin.Controls["formAdmin"] as formAdmin).getPanDSCS(),
        //            (this.panAdmin.Controls["formAdmin"] as formAdmin).getPanTTCSchitiet());
        //    }
        //    else
        //    {

        //    }
        //}



        /// //////////////////////////////////////////////// /////////////////////////////////////////////

        //các nút chọn t note ở dưới gắn vào hàm phát sinh các danh sách 

        /// //////////////////////////////////////////////// /////////////////////////////////////////////



        //        //chọn NV
        //        public void Work_OnselectDSNVClicked()
        //        {
        //            lblThongtinNV.Visible = true;
        //            ShowPanel(panTTNVchitiet);
        //        }


        //Add NV trong admin
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            lblTTNV.Visible = false;
            ShowPanel(panTTNVchitiet);
            lblTTNV.Visible = false;
            ShowPanel(panTTNVchitiet);
            panTTNVchitiet.Enabled = true;
            foreach (Control ctrl in panTTNVchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Clear();
                }
            }
            foreach (Control ctrl in panTTNVchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Enabled = true;
                }
            }
            txtMachiso.Enabled = false;

            btnXoaDSNV.Enabled = false;
            btnSuaDSNV.Enabled = false;
            btnTaiDSNV.Enabled = true;

            cboSexTTNV.Enabled = true;
            dtpNgaycap.Enabled = true;
            checkTruongPhong.Enabled = true;
        }


        // Tải ds Nhân viên panAdmin
        private void btnTaiDSNV_Click(object sender, EventArgs e)
        {
            String manhanvien = txtMachiso.Text;
            String hoten = txtChiso.Text;               // Khác null, không có số
            String chucvu = txtChucvuTTNV.Text;              // nằm trong danh sách cho trước
            String ngaysinh = dtpNgaycap.Text;   // theo format dd-mm-yyyy
            String gioitinh = cboSexTTNV.Text;    // nam or nu
            String sodienthoai = txtSDTTTNV.Text; // 10 chữ số, chỉ là số
            String gmail = txtGmail.Text;      // có đuôi là @gmail.com
            Boolean truongphong = checkTruongPhong.Checked;

            Validating validate = new Validating();
            if (!validate.nameValidate(hoten))
            {
                MessageBox.Show("Tên vừa nhập chưa phù hợp");
                return;
            }
            else if (!validate.position().Contains(chucvu))
            {
                MessageBox.Show("Chức vụ chưa đúng. Chức vụ phải là 1 trong các chức vụ sau (\"PTN\", \"PKH\", \"PQT\", \"PKQ\", \"PKD, ADMIN\")");
                return;
            }
            else if (!validate.ageValidate(DateTime.Parse(ngaysinh)))
            {
                MessageBox.Show("Phải lớn hơn 18 tuổi");
                return;
            }
            else if (!validate.genderValidate(gioitinh))
            {
                MessageBox.Show("Giới tính phải là nam hoặc nữ");
                return;
            }
            else if (!validate.validatePhoneNumber(sodienthoai))
            {
                MessageBox.Show("Số điện thoại chưa hợp lệ");
                return;
            }
            else if (!validate.validateGmail(gmail))
            {
                MessageBox.Show("Gmail không hợp lệ");
                return;
            }



            EmployeeService edit = new EmployeeService();
            if (!btnSuaDSNV.Enabled)
            {
                if (edit.AddEmployee(hoten, chucvu, DateTime.Parse(ngaysinh /*, new CultureInfo("vi-VN")*/), "123456", gioitinh, sodienthoai, gmail, truongphong))
                {
                    MessageBox.Show("Thêm thành công");
                    foreach (Control ctrl in panTTNVchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Clear();
                        }
                    }
                    edit.ShowEmployeeAdmin(panDSNV, panTTNVchitiet);
                    panTTNVchitiet.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                bool[] flag = new bool[6] {
                edit.editEmployeeName(manhanvien, hoten),
                edit.editEmployeePosition(manhanvien, chucvu),
                edit.editDateOfBirth(manhanvien, DateTime.Parse(ngaysinh /*, new CultureInfo("vi-VN")*/ )),
                edit.editEmployeeGender(manhanvien, gioitinh),
                edit.editPhoneNumber(manhanvien, sodienthoai),
                edit.editGmail(manhanvien, gmail) };
                edit.editHeadOfRoom(manhanvien, truongphong);
                for (int i = 0; i < 6; i++)
                {
                    if (!flag[i])
                    {
                        MessageBox.Show("Chỉnh sửa không thành công, hãy nhập lại");
                        return;
                    }
                }
                MessageBox.Show("Chỉnh sửa thành công");
                foreach (Control ctrl in panTTNVchitiet.Controls)
                {
                    if (ctrl is SiticoneTextBox)
                    {
                        ((SiticoneTextBox)ctrl).Clear();
                    }
                }
                edit.ShowEmployeeAdmin(panDSNV, panTTNVchitiet);
                panTTNVchitiet.Enabled = false;
                btnXoaDSNV.Enabled = false;
                btnTaiDSNV.Enabled = false;
            }
        }

        // xoa ds nhân viên panAdmin
        private void btnXoaDSNV_Click(object sender, EventArgs e)
        {
            String manhanvien = txtMachiso.Text;


            EmployeeService remove = new EmployeeService();
            if (remove.deleteEmployee(manhanvien))
            {
                MessageBox.Show("Xóa thành công");
                foreach (Control ctrl in panTTNVchitiet.Controls)
                {
                    if (ctrl is SiticoneTextBox)
                    {
                        ((SiticoneTextBox)ctrl).Clear();
                    }
                }
                remove.ShowEmployeeAdmin(panDSNV, panTTNVchitiet);
                panTTNVchitiet.Enabled = false;
                btnXoaDSNV.Enabled = false;
                btnTaiDSNV.Enabled = false;
            }
            else MessageBox.Show("Xóa không thành công");
        }
        
        // Sửa ds NV panAdmin
        private void btnSuaDSNV_Click(object sender, EventArgs e)
        {
            btnXoaDSNV.Enabled = true;
            btnTaiDSNV.Enabled = true;
            panTTNVchitiet.Enabled = true;
            //txtMachiso.Enabled = false;
            foreach (Control ctrl in panTTNVchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Enabled = true;
                }
            }
            txtMachiso.Enabled = false;
            cboSexTTNV.Enabled = true;
            dtpNgaycap.Enabled = true;
            checkTruongPhong.Enabled = true;
        }

        //Sort NV
        private void btnSortNV_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            employeeService.ShowEmployeeAdmin(panDanhsachNV, panTTNVchitiet);
        }


        // các phần tabcontrol khác lấy ở dưới nha




        //        //chọn KH
        //        public void Work_OnselectDSKHClicked()
        //        {
        //            lblThongtinKH.Visible = true;
        //            ShowPanel(panTTKHchitiet);
        //        }
        //Add KH trong admin
        private void btnAddKH_Click(object sender, EventArgs e)
        {
            panTTKHchitiet.Enabled = true;
            btnLuuDSKH.Enabled = true;
            btnSuaDSKH.Enabled = false;
            foreach (Control ctrl in panTTKHchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Clear();
                }
            }
            foreach (Control ctrl in panTTKHchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Enabled = true;
                }
            }
            txtMaCty.Enabled = false;

        }
        //Luu KH
        private void btnLuuDSKH_Click(object sender, EventArgs e)
        {
            String makhachhang = txtMaCty.Text;
            String tenkhachhang = txtTenCty.Text;
            String diachi = txtDiachiCty.Text;
            String sodienthoai = txtSDTCty.Text;
            String gmail = txtGmailCty.Text;
            String masothue = txtMST.Text;


            Validating validate = new Validating();
            if (!validate.nameValidate(tenkhachhang))
            {
                MessageBox.Show("Tên khách hàng chưa hợp lí");
                return;
            }
            else if (string.IsNullOrWhiteSpace(diachi))
            {
                MessageBox.Show("Địa chỉ không được trống");
                return;
            }
            if (!validate.validatePhoneNumber(sodienthoai))
            {
                MessageBox.Show("Số điện thoai chưa hợp lệ");
                return;
            }
            else if (!validate.validateGmail(gmail))
            {
                MessageBox.Show("Gmail chưa hợp lệ");
                return;
            }

            CustomerService edit = new CustomerService();
            if (!btnSuaDSKH.Enabled)
            {
                if (validate.listMST().ContainsKey(masothue))
                {
                    MessageBox.Show("Khách hàng đã tồn tại, hay tìm kiếm");
                    return;
                }

                if (edit.addCustomer(tenkhachhang, sodienthoai, gmail, diachi, masothue))
                {
                    MessageBox.Show("Thêm thành công");
                    foreach (Control ctrl in panTTKHchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Clear();
                        }
                    }
                    edit.ShowCustomers(panDSKH, panTTKHchitiet);
                    panTTNVchitiet.Enabled = false;
                    foreach (Control ctrl in panTTKHchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Enabled = false;
                        }
                    }
                    btnLuuDSKH.Enabled = false;

                }
                else MessageBox.Show("Thêm không thành công");
            }
            else
            {
                bool[] flag = new bool[4]
                {
                    edit.editCustomerName(makhachhang, tenkhachhang),
                    edit.editCustomerPhoneNumber(makhachhang, sodienthoai),
                    edit.editCustomerGmail(makhachhang, gmail),
                    edit.editCustomerAddress(makhachhang, diachi)
                };
                for (int i = 0; i < 4; i++)
                {
                    if (!flag[i])
                    {
                        MessageBox.Show("Chỉnh sửa không thành công, hãy làm lại");
                        return;
                    }
                }
                MessageBox.Show("Chỉnh sửa thành công");
                foreach (Control ctrl in panTTKHchitiet.Controls)
                {
                    if (ctrl is SiticoneTextBox)
                    {
                        ((SiticoneTextBox)ctrl).Clear();
                    }
                }
                edit.ShowCustomers(panDSKH, panTTKHchitiet);
                panTTNVchitiet.Enabled = false;
                foreach (Control ctrl in panTTKHchitiet.Controls)
                {
                    if (ctrl is SiticoneTextBox)
                    {
                        ((SiticoneTextBox)ctrl).Enabled = false;
                    }
                }
                btnXoaDSKH.Enabled = false;
                btnLuuDSKH.Enabled = false;
            }

        }
        //Xoa KH
        private void btnXoaDSKH_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
);


            if (result == DialogResult.Yes)
            {
                String makhachhang = txtMaCty.Text;
                CustomerService remove = new CustomerService();
                if (remove.deleteCustomer(makhachhang))
                {
                    MessageBox.Show("Xóa thành công");
                    foreach (Control ctrl in panTTKHchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Clear();
                        }
                    }
                    remove.ShowCustomers(panDSKH, panTTKHchitiet);
                    panTTNVchitiet.Enabled = false;
                    foreach (Control ctrl in panTTKHchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Enabled = false;
                        }
                    }
                    btnXoaDSKH.Enabled = false;
                    btnLuuDSKH.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                    return;
                }


            }
            else
            {
                return;
            }

        }
        //Sua KH
        private void btnSuaDSKH_Click(object sender, EventArgs e)
        {
            btnXoaDSKH.Enabled = true;
            btnLuuDSKH.Enabled = true;
            panTTKHchitiet.Enabled = true;
            foreach (Control ctrl in panTTKHchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Enabled = true;
                }
            }
            txtMaCty.Enabled = false;

        }
        //Sort KH
        private void btnSortKH_Click(object sender, EventArgs e)
        {

        }
        //        //chọn HD
        //        public void Work_OnselectDSHDClicked()
        //        {
        //            lblTTHD.Visible = true;
        //            ShowPanel(panTTHDchitiet, panCSchitiet);
        //        }
        //        

        //Add HD trong admin
        private void btnAddHD_Click(object sender, EventArgs e)
        {
            lblTTHD.Visible = false;
            ShowPanel(panTTHDchitiet);

            //.Enabled = false;
            foreach (Control ctrl in panTTHDchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Clear();
                    ((SiticoneTextBox)ctrl).Enabled = true; ;

                }
            }
            panTTHDchitiet.Enabled = true;
            panCSchitiet.Visible = false;
            txtMaHDQLHD.Enabled = false;
            btnSuaHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnLuuHD.Enabled = true;
            dtpNgaykyQLHD.Enabled = true;
            dtpNgaytraKQQLHD.Enabled = true;
        }
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string mahopdong = txtMaHDQLHD.Text;
            ContractService remove = new ContractService();
            if (remove.deleteContract(mahopdong))
            {
                MessageBox.Show("Xóa hợp đồng thành công");
                foreach (Control ctrl in panTTHDchitiet.Controls)
                {
                    if (ctrl is SiticoneTextBox)
                    {
                        ((SiticoneTextBox)ctrl).Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Xoá không thành công");
                return;
            }

        }

        private void btnSortHD_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            String mahopdong = txtMaHDQLHD.Text;
            String macongty = txtMaCtyQLHD.Text;
            String manhanvien = UserInform.manhanvien;
            String ngayky = dtpNgaykyQLHD.Text;
            String ngaygiao = dtpNgaytraKQQLHD.Text;
            String sotien = txtSotien.Text;
            //String masothue = "..."; // tạo text để nhập mã số thuế của khách hàng


            Validating validate = new Validating();
            if (!validate.IdCustomerValidate(macongty))
            {
                MessageBox.Show("Khách hàng không tồn tại, hãy kiếm tra lại hoặc thêm khách hàng mới ");
                return;
            }
            else if (!validate.timeValid(ngayky, ngaygiao))
            {
                MessageBox.Show("Ngày giao và ngày kí chưa hợp lí");
                return;
            }
            else if (!validate.moneyValidate(sotien))
            {
                MessageBox.Show("Số tiền chưa hợp lí");
                return;
            }
            //else if (validate.listMST().ContainsKey(masothue))
            //{
            //    MessageBox.Show("Khách hàng đã tồn tại hãy tìm khách hàng dựa vào mã số thuế");
            //    return;
            //}


            ContractService edit = new ContractService();
            if (!btnSuaHD.Enabled)
            {
                if (edit.addContract(manhanvien, macongty, DateTime.Parse(ngayky), DateTime.Parse(ngaygiao), long.Parse(sotien)))
                {
                    MessageBox.Show("Thêm hợp đồng mới thành công");
                    foreach (Control ctrl in panTTHDchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thêm hợp đồng không thành công");
                    return;
                }
            }
            else
            {
                bool[] flag = new bool[4]
                {
                    edit.editNgayKy(mahopdong, DateTime.Parse(ngayky)),
                    edit.editNgayTra(mahopdong, DateTime.Parse(ngaygiao)),
                    edit.editSoTien(mahopdong, long.Parse(sotien)),
                    edit.editMacongty(mahopdong, macongty)
                };
                for (int i = 0; i < 4; i++)
                {
                    if (!flag[i])
                    {
                        MessageBox.Show("Chỉnh sửa không thanh công");
                        return;
                    }
                }
                MessageBox.Show("Chỉnh sửa thành công");
                foreach (Control ctrl in panTTHDchitiet.Controls)
                {
                    if (ctrl is SiticoneTextBox)
                    {
                        ((SiticoneTextBox)ctrl).Clear();
                    }
                }
            }

        }

        private void TabcontrolAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabcontrolAdmin.SelectedTab == tabQLNV)
            {
                EmployeeService employeeService = new EmployeeService();
                employeeService.ShowEmployeeAdmin(panDanhsachNV, panTTNVchitiet);
            }
            else if (TabcontrolAdmin.SelectedTab == tabQLKH)
            {
                CustomerService customerService = new CustomerService();
                customerService.ShowCustomers(panDSKH, panTTKHchitiet);
            }
            else if (TabcontrolAdmin.SelectedTab == tabQLTB)
            {
                AnnouncementService announcementService = new AnnouncementService();
                announcementService.ShowAnnouncementAdmin(panDSTBAdmin, panDSTBchitiet);
            }
            else if (TabcontrolAdmin.SelectedTab == tabQLHD)
            {
                ContractService contractService = new ContractService();
                contractService.ShowContractsAdmin(panDSHD, panTTHDchitiet);
            }
            else if (TabcontrolAdmin.SelectedTab == tabQLTS)
            {
                EnviromentIndexService enviromentIndexService = new EnviromentIndexService();
                enviromentIndexService.ShowStats(panDSTS, panTTTSchitiet);
            }
            else
            {

            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            panTTHDchitiet.Enabled = true;
            txtMaHDQLHD.Enabled = false;
            txtMaNVQLHD.Enabled = false;
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;

        }


        //        //chọn CS
        //public void Work_OnselectDSCSClicked()
        //{
        //    lblTTCS.Visible = true;
        //    ShowPanel(panTTCSchitiet);
        //}
        //        

        //Add Thông Số trong admin
        private void btnAddTS_Click(object sender, EventArgs e)
        {
            lblTTTS.Visible = false;
            ShowPanel(panTTTSchitiet);
            panTTTSchitiet.Enabled = true;
            foreach (Control ctrl in panTTTSchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Clear();
                }
            }
            foreach (Control ctrl in panTTTSchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Enabled = true;
                }
            }
            txtMaCS.Enabled = false;
            txtViTriCS.Enabled = false;
            btnXoaTS.Enabled = false;
            btnSuaTS.Enabled = false;
            btnLuuTS.Enabled = true;

        }
        private void btnSortTS_Click(object sender, EventArgs e)
        {
            EnviromentIndexService enviromentIndexService = new EnviromentIndexService();
            enviromentIndexService.ShowStats(panDSTS, panTTTSchitiet);
        }

        private void btnLuuTS_Click(object sender, EventArgs e)
        {
            String machiso = txtMaCS.Text;
            String tenchiso = txtTenChiSo.Text;
            String loaichiso = txtLoaiChiSo.Text.ToUpper();
            String tieuchuan = txtTieuChuan.Text;
            String noinhap = txtNoiNhap.Text;


            Validating validate = new Validating();


            if (string.IsNullOrWhiteSpace(tenchiso))
            {
                MessageBox.Show("Tên không được rỗng");
                return;
            }
            else if (!validate.enviromentTypeValidate(loaichiso))
            {
                MessageBox.Show("Loại chỉ số chưa phù hợp");
                return;
            }
            else if (!validate.standardValidate(tieuchuan))
            {
                MessageBox.Show("Tiêu chuẩn chưa phù hợp");
                return;
            }
            else if (!validate.enterPlacevalidate().Contains(noinhap))
            {
                MessageBox.Show("Nơi nhập chưa phù hợp");
                return;
            }

            EnviromentIndexService edit = new EnviromentIndexService();
            if (!btnSuaTS.Enabled)
            {
                if (edit.addEnviromentIndex(tenchiso, loaichiso, tieuchuan, noinhap))
                {
                    MessageBox.Show("Thêm chỉ số mới thành công");
                    foreach (Control ctrl in panTTTSchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Clear();
                        }
                    }
                    edit.ShowStats(panDSTS, panTTTSchitiet);
                    panCSchitiet.Enabled = false;
                    foreach (Control ctrl in panTTTSchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Enabled = false;
                        }
                    }
                    btnLuuTS.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm chỉ số không thành công");
                    return;
                }
            }
            else
            {
                bool[] flag = new bool[3]
                {
                    edit.editName(machiso, tenchiso),
                    edit.editEnviromentType(machiso, loaichiso),
                    edit.editStandardIndex(machiso, tieuchuan)
                };
                for (int i = 0; i < 3; i++)
                {
                    if (!flag[i])
                    {
                        MessageBox.Show("Chỉnh sửa không thành công, hãy nhập lại");
                        return;
                    }
                }
                MessageBox.Show("Chỉnh sửa thành công");
                foreach (Control ctrl in panTTTSchitiet.Controls)
                {
                    if (ctrl is SiticoneTextBox)
                    {
                        ((SiticoneTextBox)ctrl).Clear();
                    }
                }
                foreach (Control ctrl in panTTTSchitiet.Controls)
                {
                    if (ctrl is SiticoneTextBox)
                    {
                        ((SiticoneTextBox)ctrl).Enabled = false;
                    }
                }
                btnLuuTS.Enabled = false;
                btnSuaTS.Enabled = false;
                btnXoaTS.Enabled = false;
            }

        }

        private void btnXoaTS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );


            if (result == DialogResult.Yes)
            {
                String machiso = txtMaCS.Text;
                EnviromentIndexService remove = new EnviromentIndexService();
                if (remove.deleteEnviromentIndex(machiso))
                {
                    MessageBox.Show("Xóa thành công");
                    foreach (Control ctrl in panTTTSchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Clear();
                        }
                    }
                    remove.ShowStats(panDSTS, panTTTSchitiet);
                    foreach (Control ctrl in panTTTSchitiet.Controls)
                    {
                        if (ctrl is SiticoneTextBox)
                        {
                            ((SiticoneTextBox)ctrl).Enabled = false;
                        }
                    }
                    btnLuuTS.Enabled = false;
                    btnSuaTS.Enabled = false;
                    btnXoaTS.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                    return;
                }
            }
            else
            {
                return;
            }

        }

        private void btnSuaTS_Click(object sender, EventArgs e)
        {
            btnLuuTS.Enabled = true;
            btnXoaTS.Enabled = true;
            panTTTSchitiet.Enabled = true;
            foreach (Control ctrl in panTTTSchitiet.Controls)
            {
                if (ctrl is SiticoneTextBox)
                {
                    ((SiticoneTextBox)ctrl).Enabled = true;
                }
            }
            txtMaCS.Enabled = false;
            txtViTriCS.Enabled = false;

        }


        //Luu thông báo panAdmin
        private void btnLuuTB_Click(object sender, EventArgs e)
        {
            String maThongBao = txtMaThongBao.Text;
            String tieuDe = txtTieuDe.Text;
            String ngayPhatHanh = dtpNgayphathanh.Text;
            String noiDung = txtNoidung.Text;



            NotificationService noti = new NotificationService();

            if (btnSuaTB.Enabled == false)
            {
                if (noti.addNoti(tieuDe, DateTime.Parse(ngayPhatHanh), noiDung))
                {
                    MessageBox.Show("Thêm thành công");

                    txtMaThongBao.Clear();
                    txtTieuDe.Clear();
                    txtNoidung.Clear();

                    txtTieuDe.Enabled = false;
                    txtNoidung.Enabled = false;

                    btnXoaTB.Enabled = false;
                    btnLuuTB.Enabled = false;
                }
                else MessageBox.Show("Thêm không thành công");
            }
            else
            {
                bool flag = noti.editNoti(maThongBao, tieuDe, DateTime.Today, noiDung);
                if (flag)
                {
                    MessageBox.Show("Sửa thành công");

                    txtMaThongBao.Clear();
                    txtTieuDe.Clear();
                    txtNoidung.Clear();

                    txtTieuDe.Enabled = false;
                    txtNoidung.Enabled = false;

                    btnXoaTB.Enabled = false;
                    btnLuuTB.Enabled = false;

                }
                else MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            String maThongBao = txtMaThongBao.Text;

            NotificationService noti = new NotificationService();
            if (noti.removeNoti(maThongBao))
            {
                MessageBox.Show("Xóa thành công");
                txtMaThongBao.Clear();
                txtTieuDe.Clear();
                txtNoidung.Clear();

                btnXoaTB.Enabled = false;
                btnLuuTB.Enabled = false;

                txtTieuDe.Enabled = false;
                txtNoidung.Enabled = false;
            }
            else MessageBox.Show("Xóa không thành công");
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            btnSuaTB.Enabled = true;
            btnXoaTB.Enabled = true;
            btnLuuTB.Enabled = true;

            txtTieuDe.Enabled = true;
            dtpNgayphathanh.Enabled = true;
            txtNoidung.Enabled = true;
        }

        private void btnSortThongbao_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTB_Click(object sender, EventArgs e)
        {
            txtMaThongBao.Enabled = false;
            txtTieuDe.Enabled = true;
            dtpNgayphathanh.Enabled = true;
            txtNoidung.Enabled = true;

            txtMaThongBao.Clear();
            txtTieuDe.Clear();
            txtNoidung.Clear();

            btnSuaTB.Enabled = false;
            btnXoaTB.Enabled = false;
            btnLuuTB.Enabled = true;
        }


        //Sort đơn hàng
        private void btnSortDH_Click(object sender, EventArgs e)
        {
            ContractService contractService = new ContractService();
            contractService.ShowContracts(panDSHDnv, splitDSHDnvchitiet);
        }
        //Sửa đơn hàng 
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtKetqua.Enabled = true;
            txtGhichu.Enabled = true;
            txtMaThongSo.Enabled = false;
            txtMadonhang.Enabled = false;
            txtTenthongso.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }

        //Lưu đơn hàng
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ContractService contractService = new ContractService();
            String mahopdong = txtMadonhang.Text;
            String machiso = txtMaThongSo.Text;
            String manhanvien = UserInform.manhanvien;
            String chiso = txtKetqua.Text;
            String ghichu = txtGhichu.Text;
            if (!float.TryParse(chiso, out float result))
            {
                MessageBox.Show("Hãy nhập chỉ số");
                return;
            }
            DetailedIndexService edit = new DetailedIndexService();
            bool flagCS = edit.editChiSo(mahopdong, machiso, float.Parse(chiso), manhanvien);
            bool flagGC = edit.editGhiChu(mahopdong, machiso, manhanvien, ghichu);
            if (flagCS && flagGC)
            {
                txtMaThongSo.Clear();
                txtKetqua.Clear();
                txtTenthongso.Clear();
                txtGhichu.Clear();
                txtKetqua.Enabled = false;
                txtGhichu.Enabled = false;
                btnLuu.Enabled = false;

            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
          

        }
        //private void btnLuu_Click_1(object sender, EventArgs e)
        //{
        //    ContractService contractService = new ContractService();
        //    String mahopdong = txtMahopdong.Text;
        //    String machiso = txtMachiso.Text;
        //    String manhanvien = UserInform.manhanvien;
        //    String chiso = txtChiso.Text;
        //    String ghichu = txtGhichu.Text;
        //    if (!float.TryParse(chiso, out float result))
        //    {
        //        MessageBox.Show("Hãy nhập chỉ số");
        //        return;
        //    }
        //    DetailedIndexService edit = new DetailedIndexService();
        //    bool flagCS = edit.editChiSo(mahopdong, machiso, float.Parse(chiso), manhanvien);
        //    bool flagGC = edit.editGhiChu(mahopdong, machiso, manhanvien, ghichu);
        //    if (flagCS && flagGC)
        //    {
        //        //txtMahopdong.Clear();
        //        txtMachiso.Clear();
        //        txtChiso.Clear();
        //        txtVitri.Clear();
        //        txtTenchiso.Clear();
        //        txtGhichu.Clear();
        //        dtpNgaynhap.Value = DateTime.Today;
        //        //txtMahopdong.Enabled = false;
        //        //txtMachiso.Enabled = false;
        //        txtChiso.Enabled = false;
        //        txtGhichu.Enabled = false;
        //        btnLuu.Enabled = false;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Sửa không thành công");
        //    }
        //    LoadProductData(mahopdong);
        //}


        //Load dữ liệu đơn hàng 

        //private void lvDulieuhopdong_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lvDulieuhopdong.SelectedItems.Count > 0)
        //    {
        //        btnSua.Enabled = true;
        //        var selectedItem = lvDulieuhopdong.SelectedItems[0];

        //        string mcs = selectedItem.SubItems[0].Text;
        //        string tcs = selectedItem.SubItems[1].Text;
        //        string cs = selectedItem.SubItems[4].Text;
        //        string vt = selectedItem.SubItems[6].Text;
        //        string gc = selectedItem.SubItems[8].Text;
        //        DateTime ngaynhap = DateTime.Parse(selectedItem.SubItems[7].Text);

        //        dtpNgaynhap.Value = ngaynhap;
        //        txtChiso.Text = cs;
        //        txtMachiso.Text = mcs;
        //        txtTenchiso.Text = tcs;
        //        txtVitri.Text = vt;
        //        txtGhichu.Text = gc;
        //    }
        //}

        //Tự động sinh danh sách Đơn hàng (sửa lại các text box nha)
        private void SetGroupBoxColor(SiticoneGroupBox grBox, Color color1, Color color2)
        {
            grBox.FillColor = color1;
            foreach (Control ctrl in grBox.Controls)
                if (ctrl is SiticoneTextBox txt)
                {
                    txt.FillColor = color1;

                    txt.ForeColor = color2;
                }
        }

        private void lvDulieudonhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDulieudonhang.SelectedItems.Count > 0)
            {
                btnSua.Enabled = true;
                var selectedItem = lvDulieudonhang.SelectedItems[0];
                string mts = selectedItem.SubItems[9].Text;
                string tcs = selectedItem.SubItems[0].Text;
                string cs = selectedItem.SubItems[2].Text;
                string gc = selectedItem.SubItems[6].Text;

                txtMaThongSo.Text = mts;
                txtTenthongso.Text = tcs;
                txtGhichu.Text = gc;
                txtKetqua.Text = cs;
            }
        }


        private void btnFindma_Click(object sender, EventArgs e)
        {
            ContractService contractService = new ContractService();
            List<HopDong> hd = contractService.searchContractForEmployee(txtFindma.Text);
            contractService.ShowContractsSearch(hd, panDSHDnv, splitDSHDnvchitiet);
        }

        private void btnFindNV_Click(object sender, EventArgs e)
        {
            EmployeeService em = new EmployeeService();
            List<NhanVien> nv = em.searchEmployeeForEmployee(txtFindNV.Text);
            em.ShowEmployeeSearch(nv, panFindNV);
        }

        private void lvDulieuTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDulieuTS.SelectedItems.Count > 0)
            {
                btnSuaChiSoChiTiet.Enabled = true;
                var selectedItem = lvDulieuTS.SelectedItems[0];

                string mcs = selectedItem.SubItems[0].Text;
                string mnv = selectedItem.SubItems[1].Text;
                string ts = selectedItem.SubItems[2].Text;
                DateTime ng = DateTime.ParseExact(selectedItem.SubItems[3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string gc = selectedItem.SubItems[4].Text;

                txtMaCSQLHD.Text = mcs;
                txtMaNVnhap.Text = mnv;
                txtTenCS.Text = ts;
                dtpNgaynhapQLHD.Value = ng;
                txtGhiChuQLHD.Text = gc;

            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            ContractService contractService = new ContractService();
            contractService.ShowContractsAdmin(panDSHD, panTTHDchitiet);
        }

        private void btnContinueDMK_Click(object sender, EventArgs e)
        {
            erpLoidinhdang = new ErrorProvider();
            Validating vali = new Validating();
            bool[] checking = vali.valResetPasswordInner(txtPasscurrent.Text, txtPassnew.Text, txtPassnewagain.Text);
            if (!checking[0])
            {
                erpLoidinhdang.SetError(txtPasscurrent, "Sai PassWord");
                txtPasscurrent.BorderColor = Color.Red;
                txtPasscurrent.FillColor = Color.LightPink;
                return;
            }
            else if (!checking[1])
            {
                erpLoidinhdang.SetError(txtPassnew, "Sai cú pháp (Bao gồm in hoa, in thường, số và trên 6 ký tự)");
                txtPassnew.BorderColor = Color.Red;
                txtPassnew.FillColor = Color.LightPink;
                return;
            }
            else if (!checking[3])
            {
                erpLoidinhdang.SetError(txtPassnewagain, "Nhập lại phải giống ở trên");
                txtPassnewagain.BorderColor = Color.Red;
                txtPassnewagain.FillColor = Color.LightPink;
                return;
            }
            else
            {
                ResetPasswordService resetPasswordService = new ResetPasswordService();
                if (resetPasswordService.ResetPasswordServicesInner(UserInform.manhanvien, txtPassnewagain.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    txtPasscurrent.Clear();
                    txtPassnew.Clear();
                    txtPassnewagain.Clear();
                    erpLoidinhdang.Clear();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại");
                    txtPasscurrent.Clear();
                    txtPassnew.Clear();
                    txtPassnewagain.Clear();
                    erpLoidinhdang.Clear();
                }
            }
        }

        //form admin




        //        //Load dataa
        //        private void TabcontrolAdmin_SelectedIndexChanged(object sender, EventArgs e)
        //        {
        //            if (TabcontrolAdmin.SelectedTab == tabQLNV)
        //            {
        //                EmployeeService employeeService = new EmployeeService();
        //                employeeService.ShowEmployee(getPanDSNV(), getPanTTNVchitiet());
        //            }
        //            else if (TabcontrolAdmin.SelectedTab == tabQLKH)
        //            {
        //                CustomerService customerService = new CustomerService();
        //                customerService.ShowCustomers(panDSKH, panTTKHchitiet);
        //            }
        //            else if (TabcontrolAdmin.SelectedTab == tabQLTB)
        //            {
        //            }
        //            else if (TabcontrolAdmin.SelectedTab == tabQLHD)
        //            {
        //                ContractService contractService = new ContractService();
        //                contractService.ShowContracts(panDSHD, panTTHDchitiet);
        //            }
        //            else if (TabcontrolAdmin.SelectedTab == tabQLCS)
        //            {
        //                EnviromentIndexService enviromentIndexService = new EnviromentIndexService();
        //                enviromentIndexService.ShowStats(panDSCS, panTTCSchitiet);
        //            }
        //            else
        //            {

        //            }
        //        }







        //        private void btnAddKH_Click(object sender, EventArgs e)
        //        {
        //            panTTKHchitiet.Enabled = true;
        //            btnLuuDSKH.Enabled = true;
        //            btnSuaDSKH.Enabled = false;
        //            foreach (Control ctrl in panTTKHchitiet.Controls)
        //            {
        //                if (ctrl is SiticoneTextBox)
        //                {
        //                    ((SiticoneTextBox)ctrl).Clear();
        //                }
        //            }
        //            foreach (Control ctrl in panTTKHchitiet.Controls)
        //            {
        //                if (ctrl is SiticoneTextBox)
        //                {
        //                    ((SiticoneTextBox)ctrl).Enabled = true;
        //                }
        //            }
        //            txtMaCty.Enabled = false;

        //        }

        //        private void btnLuuDSKH_Click(object sender, EventArgs e)
        //        {
        //            String makhachhang = txtMaCty.Text;
        //            String tenkhachhang = txtTenCty.Text;
        //            String diachi = txtDiachiCty.Text;
        //            String sodienthoai = txtSDTCty.Text;
        //            String gmail = txtGmailCty.Text;
        //            String masothue = txtMST.Text;


        //            Validating validate = new Validating();
        //            if (!validate.nameValidate(tenkhachhang))
        //            {
        //                MessageBox.Show("Tên khách hàng chưa hợp lí");
        //                return;
        //            }
        //            else if (string.IsNullOrWhiteSpace(diachi))
        //            {
        //                MessageBox.Show("Địa chỉ không được trống");
        //                return;
        //            }
        //            if (!validate.validatePhoneNumber(sodienthoai))
        //            {
        //                MessageBox.Show("Số điện thoai chưa hợp lệ");
        //                return;
        //            }
        //            else if (!validate.validateGmail(gmail))
        //            {
        //                MessageBox.Show("Gmail chưa hợp lệ");
        //                return;
        //            }

        //            CustomerService edit = new CustomerService();
        //            if (!btnSuaDSKH.Enabled)
        //            {
        //                if (validate.listMST().ContainsKey(masothue))
        //                {
        //                    MessageBox.Show("Khách hàng đã tồn tại, hay tìm kiếm");
        //                    return;
        //                }

        //                if (edit.addCustomer(tenkhachhang, sodienthoai, gmail, diachi, masothue))
        //                {
        //                    MessageBox.Show("Thêm thành công");
        //                    foreach (Control ctrl in panTTKHchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Clear();
        //                        }
        //                    }
        //                    edit.ShowCustomers(panDSKH, panTTKHchitiet);
        //                    panTTNVchitiet.Enabled = false;
        //                    foreach (Control ctrl in panTTKHchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Enabled = false;
        //                        }
        //                    }
        //                    btnLuuDSKH.Enabled = false;

        //                }
        //                else MessageBox.Show("Thêm không thành công");
        //            }
        //            else
        //            {
        //                bool[] flag = new bool[4]
        //                {
        //                    edit.editCustomerName(makhachhang, tenkhachhang),
        //                    edit.editCustomerPhoneNumber(makhachhang, sodienthoai),
        //                    edit.editCustomerGmail(makhachhang, gmail),
        //                    edit.editCustomerAddress(makhachhang, diachi)
        //                };
        //                for (int i = 0; i < 4; i++)
        //                {
        //                    if (!flag[i])
        //                    {
        //                        MessageBox.Show("Chỉnh sửa không thành công, hãy làm lại");
        //                        return;
        //                    }
        //                }
        //                MessageBox.Show("Chỉnh sửa thành công");
        //                foreach (Control ctrl in panTTKHchitiet.Controls)
        //                {
        //                    if (ctrl is SiticoneTextBox)
        //                    {
        //                        ((SiticoneTextBox)ctrl).Clear();
        //                    }
        //                }
        //                edit.ShowCustomers(panDSKH, panTTKHchitiet);
        //                panTTNVchitiet.Enabled = false;
        //                foreach (Control ctrl in panTTKHchitiet.Controls)
        //                {
        //                    if (ctrl is SiticoneTextBox)
        //                    {
        //                        ((SiticoneTextBox)ctrl).Enabled = false;
        //                    }
        //                }
        //                btnXoaDSKH.Enabled = false;
        //                btnLuuDSKH.Enabled = false;
        //            }
        //        }

        //        private void btnSuaDSKH_Click(object sender, EventArgs e)
        //        {
        //            btnXoaDSKH.Enabled = true;
        //            btnLuuDSKH.Enabled = true;
        //            panTTKHchitiet.Enabled = true;
        //            foreach (Control ctrl in panTTKHchitiet.Controls)
        //            {
        //                if (ctrl is SiticoneTextBox)
        //                {
        //                    ((SiticoneTextBox)ctrl).Enabled = true;
        //                }
        //            }
        //            txtMaCty.Enabled = false;
        //        }

        //        private void btnXoaDSKH_Click(object sender, EventArgs e)
        //        {
        //            DialogResult result = MessageBox.Show(
        //            "Bạn có chắc chắn muốn xóa không?",
        //            "Xác nhận xóa",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Question
        //);


        //            if (result == DialogResult.Yes)
        //            {
        //                String makhachhang = txtMaCty.Text;
        //                CustomerService remove = new CustomerService();
        //                if (remove.deleteCustomer(makhachhang))
        //                {
        //                    MessageBox.Show("Xóa thành công");
        //                    foreach (Control ctrl in panTTKHchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Clear();
        //                        }
        //                    }
        //                    remove.ShowCustomers(panDSKH, panTTKHchitiet);
        //                    panTTNVchitiet.Enabled = false;
        //                    foreach (Control ctrl in panTTKHchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Enabled = false;
        //                        }
        //                    }
        //                    btnXoaDSKH.Enabled = false;
        //                    btnLuuDSKH.Enabled = false;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Xóa không thành công");
        //                    return;
        //                }


        //            }
        //            else
        //            {
        //                return;
        //            }

        //        }


        //        private void btnAddCS_Click(object sender, EventArgs e)
        //        {
        //            panTTCSchitiet.Enabled = true;
        //            foreach (Control ctrl in panTTCSchitiet.Controls)
        //            {
        //                if (ctrl is SiticoneTextBox)
        //                {
        //                    ((SiticoneTextBox)ctrl).Clear();
        //                }
        //            }
        //            foreach (Control ctrl in panTTCSchitiet.Controls)
        //            {
        //                if (ctrl is SiticoneTextBox)
        //                {
        //                    ((SiticoneTextBox)ctrl).Enabled = true;
        //                }
        //            }
        //            txtMaCS.Enabled = false;
        //            txtViTriCS.Enabled = false;
        //            btnXoaCS.Enabled = false;
        //            btnSuaCS.Enabled = false;
        //            btnLuuCS.Enabled = true;
        //        }

        //        private void siticoneButton8_Click(object sender, EventArgs e)
        //        {
        //            String machiso = txtMaCS.Text;
        //            String tenchiso = txtTenChiSo.Text;
        //            String loaichiso = txtLoaiChiSo.Text.ToUpper();
        //            String tieuchuan = txtTieuChuan.Text;
        //            String noinhap = txtNoiNhap.Text;


        //            Validating validate = new Validating();


        //            if (string.IsNullOrWhiteSpace(tenchiso))
        //            {
        //                MessageBox.Show("Tên không được rỗng");
        //                return;
        //            }
        //            else if (!validate.enviromentTypeValidate(loaichiso))
        //            {
        //                MessageBox.Show("Loại chỉ số chưa phù hợp");
        //                return;
        //            }
        //            else if (!validate.standardValidate(tieuchuan))
        //            {
        //                MessageBox.Show("Tiêu chuẩn chưa phù hợp");
        //                return;
        //            }
        //            else if (!validate.enterPlacevalidate().Contains(noinhap))
        //            {
        //                MessageBox.Show("Nơi nhập chưa phù hợp");
        //                return;
        //            }

        //            EnviromentIndexService edit = new EnviromentIndexService();
        //            if (!btnSuaCS.Enabled)
        //            {
        //                if (edit.addEnviromentIndex(tenchiso, loaichiso, tieuchuan, noinhap))
        //                {
        //                    MessageBox.Show("Thêm chỉ số mới thành công");
        //                    foreach (Control ctrl in panTTCSchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Clear();
        //                        }
        //                    }
        //                    edit.ShowStats(panDSCS, panTTCSchitiet);
        //                    panCSchitiet.Enabled = false;
        //                    foreach (Control ctrl in panTTCSchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Enabled = false;
        //                        }
        //                    }
        //                    btnLuuCS.Enabled = false;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Thêm chỉ số không thành công");
        //                    return;
        //                }
        //            }
        //            else
        //            {
        //                bool[] flag = new bool[3]
        //                {
        //                    edit.editName(machiso, tenchiso),
        //                    edit.editEnviromentType(machiso, loaichiso),
        //                    edit.editStandardIndex(machiso, tieuchuan)
        //                };
        //                for (int i = 0; i < 3; i++)
        //                {
        //                    if (!flag[i])
        //                    {
        //                        MessageBox.Show("Chỉnh sửa không thành công, hãy nhập lại");
        //                        return;
        //                    }
        //                }
        //                MessageBox.Show("Chỉnh sửa thành công");
        //                foreach (Control ctrl in panTTCSchitiet.Controls)
        //                {
        //                    if (ctrl is SiticoneTextBox)
        //                    {
        //                        ((SiticoneTextBox)ctrl).Clear();
        //                    }
        //                }
        //                foreach (Control ctrl in panTTCSchitiet.Controls)
        //                {
        //                    if (ctrl is SiticoneTextBox)
        //                    {
        //                        ((SiticoneTextBox)ctrl).Enabled = false;
        //                    }
        //                }
        //                btnLuuCS.Enabled = false;
        //                btnSuaCS.Enabled = false;
        //                btnXoaCS.Enabled = false;
        //            }
        //        }

        //        private void siticoneButton9_Click(object sender, EventArgs e)
        //        {
        //            btnLuuCS.Enabled = true;
        //            btnXoaCS.Enabled = true;
        //            panTTCSchitiet.Enabled = true;
        //            foreach (Control ctrl in panTTCSchitiet.Controls)
        //            {
        //                if (ctrl is SiticoneTextBox)
        //                {
        //                    ((SiticoneTextBox)ctrl).Enabled = true;
        //                }
        //            }
        //            txtMaCS.Enabled = false;
        //            txtViTriCS.Enabled = false;
        //        }

        //        private void siticoneButton10_Click(object sender, EventArgs e)
        //        {
        //            DialogResult result = MessageBox.Show(
        //            "Bạn có chắc chắn muốn xóa không?",
        //            "Xác nhận xóa",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Question
        //        );


        //            if (result == DialogResult.Yes)
        //            {
        //                String machiso = txtMaCS.Text;
        //                EnviromentIndexService remove = new EnviromentIndexService();
        //                if (remove.deleteEnviromentIndex(machiso))
        //                {
        //                    MessageBox.Show("Xóa thành công");
        //                    foreach (Control ctrl in panTTCSchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Clear();
        //                        }
        //                    }
        //                    remove.ShowStats(panDSCS, panTTCSchitiet);
        //                    foreach (Control ctrl in panTTCSchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Enabled = false;
        //                        }
        //                    }
        //                    btnLuuCS.Enabled = false;
        //                    btnSuaCS.Enabled = false;
        //                    btnXoaCS.Enabled = false;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Xóa không thành công");
        //                    return;
        //                }
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }

        //        private void btnAddHD_Click(object sender, EventArgs e)
        //        {
        //            panTTHDchitiet.Enabled = true;
        //            siticoneTextBox51.Enabled = false;
        //            siticoneTextBox23.Enabled = false;
        //            foreach (Control ctrl in panTTHDchitiet.Controls)
        //            {
        //                if (ctrl is SiticoneTextBox)
        //                {
        //                    ((SiticoneTextBox)ctrl).Clear();
        //                }
        //            }
        //            siticoneButton3.Enabled = false;
        //            siticoneButton2.Enabled = false;
        //        }

        //        private void siticoneButton1_Click(object sender, EventArgs e)
        //        {
        //            String mahopdong = siticoneTextBox51.Text;
        //            String macongty = siticoneTextBox50.Text;
        //            String manhanvien = UserInform.manhanvien;
        //            String ngayky = siticoneTextBox18.Text;
        //            String ngaygiao = siticoneTextBox17.Text;
        //            String sotien = siticoneTextBox16.Text;
        //            //String masothue = "..."; // tạo text để nhập mã số thuế của khách hàng


        //            Validating validate = new Validating();
        //            if (!validate.IdCustomerValidate(macongty))
        //            {
        //                MessageBox.Show("Khách hàng không tồn tại, hãy kiếm tra lại hoặc thêm khách hàng mới ");
        //                return;
        //            }
        //            else if (!validate.timeValid(ngayky, ngaygiao))
        //            {
        //                MessageBox.Show("Ngày giao và ngày kí chưa hợp lí");
        //                return;
        //            }
        //            else if (!validate.moneyValidate(sotien))
        //            {
        //                MessageBox.Show("Số tiền chưa hợp lí");
        //                return;
        //            }
        //            //else if (validate.listMST().ContainsKey(masothue))
        //            //{
        //            //    MessageBox.Show("Khách hàng đã tồn tại hãy tìm khách hàng dựa vào mã số thuế");
        //            //    return;
        //            //}


        //            ContractService edit = new ContractService();
        //            if (!siticoneButton2.Enabled)
        //            {
        //                if (edit.addContract(manhanvien, macongty, DateTime.Parse(ngayky), DateTime.Parse(ngaygiao), long.Parse(sotien)))
        //                {
        //                    MessageBox.Show("Thêm hợp đồng mới thành công");
        //                    foreach (Control ctrl in panTTHDchitiet.Controls)
        //                    {
        //                        if (ctrl is SiticoneTextBox)
        //                        {
        //                            ((SiticoneTextBox)ctrl).Clear();
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Thêm hợp đồng không thành công");
        //                    return;
        //                }
        //            }
        //            else
        //            {
        //                bool[] flag = new bool[4]
        //                {
        //                    edit.editNgayKy(mahopdong, DateTime.Parse(ngayky)),
        //                    edit.editNgayTra(mahopdong, DateTime.Parse(ngaygiao)),
        //                    edit.editSoTien(mahopdong, long.Parse(sotien)),
        //                    edit.editMacongty(mahopdong, macongty)
        //                };
        //                for (int i = 0; i < 4; i++)
        //                {
        //                    if (!flag[i])
        //                    {
        //                        MessageBox.Show("Chỉnh sửa không thanh công");
        //                        return;
        //                    }
        //                }
        //                MessageBox.Show("Chỉnh sửa thành công");
        //                foreach (Control ctrl in panTTHDchitiet.Controls)
        //                {
        //                    if (ctrl is SiticoneTextBox)
        //                    {
        //                        ((SiticoneTextBox)ctrl).Clear();
        //                    }
        //                }
        //            }


        //        }

        //        private void siticoneButton2_Click(object sender, EventArgs e)
        //        {
        //            panTTHDchitiet.Enabled = true;
        //            siticoneTextBox51.Enabled = false;
        //            siticoneTextBox23.Enabled = false;
        //            siticoneButton1.Enabled = true;
        //            siticoneButton3.Enabled = true;
        //        }

        //        private void siticoneButton3_Click(object sender, EventArgs e)
        //        {
        //            string mahopdong = siticoneTextBox51.Text;
        //            ContractService remove = new ContractService();
        //            if (remove.deleteContract(mahopdong))
        //            {
        //                MessageBox.Show("Xóa hợp đồng thành công");
        //                foreach (Control ctrl in panTTHDchitiet.Controls)
        //                {
        //                    if (ctrl is SiticoneTextBox)
        //                    {
        //                        ((SiticoneTextBox)ctrl).Clear();
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Xoá không thành công");
        //                return;
        //            }
        //        }

        //        private void siticoneButton21_Click(object sender, EventArgs e)
        //        {
        //            siticoneTextBox69.Enabled = true;
        //            siticoneTextBox67.Enabled = true;
        //            siticoneButton23.Enabled = true;
        //            siticoneButton20.Enabled = true;

        //        }

        //        private void siticoneButton23_Click(object sender, EventArgs e)
        //        {
        //            String mahopdong = siticoneTextBox66.Text;
        //            String machiso = siticoneTextBox71.Text;
        //            String manhanvien = UserInform.manhanvien;
        //            String chiso = siticoneTextBox69.Text;
        //            String ngaynhap = siticoneTextBox68.Text;
        //            String ghichu = siticoneTextBox67.Text;


        //            Validating validate = new Validating();
        //            if (!validate.indexValidate(chiso))
        //            {
        //                MessageBox.Show("Chỉ số vừa nhập chưa đúng");
        //                return;
        //            }


        //            DetailedIndexService edit = new DetailedIndexService();
        //            bool[] flag = new bool[2]
        //            {
        //                edit.editChiSo(mahopdong, machiso, float.Parse(chiso), manhanvien),
        //                edit.editGhiChu(mahopdong, machiso, manhanvien,ghichu)
        //            };
        //            for (int i = 0; i < 2; i++)
        //            {
        //                if (!flag[i])
        //                {
        //                    MessageBox.Show("Chỉnh sửa không thành công");
        //                    return;
        //                }
        //            }
        //            MessageBox.Show("Chỉnh sửa hợp đồng thành công");
        //            foreach (Control ctrl in panVitriCS.Controls)
        //            {
        //                if (ctrl is SiticoneTextBox)
        //                {
        //                    ((SiticoneTextBox)ctrl).Clear();
        //                }
        //            }
        //        }

        //        private void siticoneButton20_Click(object sender, EventArgs e)
        //        {
        //            String mahopdong = siticoneTextBox66.Text;
        //            String machiso = siticoneTextBox71.Text;
        //            DetailedIndexService remove = new DetailedIndexService();
        //            if (remove.deleteDetailedIndex(mahopdong, machiso))
        //            {
        //                MessageBox.Show("Xóa chỉ số thành công");
        //                foreach (Control ctrl in panVitriCS.Controls)
        //                {
        //                    if (ctrl is SiticoneTextBox)
        //                    {
        //                        ((SiticoneTextBox)ctrl).Clear();
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Xóa không thành công");
        //            }
        //        }


        //        private void btnSortNV_Click(object sender, EventArgs e)
        //        {
        //            EmployeeService employeeService = new EmployeeService();
        //            employeeService.ShowEmployee(getPanDSNV(), getPanTTNVchitiet());
        //        }

        //        private void btnBackCS_Click(object sender, EventArgs e)
        //        {
        //            btnBackCS.Visible = false;
        //            btnLuuCS.Enabled = false;
        //            btnXoaCS.Enabled = false;
        //            btnSuaCS.Enabled = false;
        //            panTTCSchitiet.Visible = false;
        //        }

        //        private void btnSortKH_Click(object sender, EventArgs e)
        //        {
        //            CustomerService customerService = new CustomerService();
        //            customerService.ShowCustomers(panDSKH, panTTKHchitiet);
        //        }

        //        private void siticoneButton17_Click(object sender, EventArgs e)
        //        {
        //            ContractService contractService = new ContractService();
        //            contractService.ShowContracts(panDSHD, panTTHDchitiet);
        //        }

        //        private void siticoneButton7_Click(object sender, EventArgs e)
        //        {
        //            EnviromentIndexService enviromentIndexService = new EnviromentIndexService();
        //            enviromentIndexService.ShowStats(panDSCS, panTTCSchitiet);
        //        }

        private int checkTime(String time)
        {
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] == '/')
                {
                    return 1;    // quy
                }
            }
            return 0;            // nam
        }

        private void loadChart(Dictionary<String, int> data)
        {
            chart1.Series.Clear();
            Series columnSeries = new Series
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            foreach (var s in data)
            {
                columnSeries.Points.AddXY(s.Key, s.Value);
            }

            chart1.Series.Add(columnSeries);

            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Số lượng";

        }

        private void loadPieChart(Dictionary<String, int> data)
        {
            chart2.Series.Clear();
            Series series = new Series()
            {
                ChartType = SeriesChartType.Pie
            };

            foreach (var s in data)
            {
                series.Points.AddXY(s.Key, s.Value);
            }

            chart2.Series.Add(series);

        }

        private void btnSuaChiSoChiTiet_Click(object sender, EventArgs e)
        {
            btnXoaChiSoChiTiet.Enabled = true;
            btnLuuCSchitiet.Enabled = true;
            panCSchitiet.Visible = false;
            txtGhiChuQLHD.Enabled = true;
            dtpNgaynhapQLHD.Enabled = true;
            txtTenCS.Enabled = false;
            txtMaNVnhap.Enabled = false;
            txtMaCSQLHD.Enabled = false;
        }

        private void btnXoaChiSoChiTiet_Click(object sender, EventArgs e)
        {
            String maChiSo = txtMaCSQLHD.Text;
            String maHopDong = txtMaHDQLHD.Text;
            DetailedIndexService del = new DetailedIndexService();
            if (del.deleteDetailedIndex(maHopDong, maChiSo))
            {
                MessageBox.Show("Xóa thành công");
            }
            else MessageBox.Show("Xóa không thành công");

        }

        private void btnLuuCSchitiet_Click(object sender, EventArgs e)
        {
            String maChiSo = txtMaCSQLHD.Text;
            String maHopDong = txtMaHDQLHD.Text;
            String ghiChu = txtGhiChuQLHD.Text;
            String ngayNhap = dtpNgaynhapQLHD.Text;
            String thongSo = txtTenCS.Text;
            String maNhanVien = UserInform.manhanvien;

            Validating validate = new Validating();
            if (!validate.indexValidate(thongSo))
            {
                MessageBox.Show("Thông số chưa chính xác");
                return;
            }

            DetailedIndexService del = new DetailedIndexService();
            bool flag1 = del.editChiSo(maHopDong, maChiSo, float.Parse(thongSo), maNhanVien);
            bool flag2 = del.editGhiChu(maHopDong, maChiSo, maNhanVien, ghiChu);
            if (flag1 && flag2)
            {
                MessageBox.Show("Chỉnh sửa thành công");
                return;
            }
            MessageBox.Show("Chỉnh sửa không thành công");
        }

        private void lblTitleChange_Click(object sender, EventArgs e)
        {

        }

        private void btnMic_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void VoiceSearch_OnRecognized(string recognizedText)
        {
            if (!string.IsNullOrWhiteSpace(recognizedText))
            {
                Action updateAction = () =>
                {
                    // In để xác nhận xem recognizedText có giá trị hợp lệ
                    MessageBox.Show("Recognized Text: " + recognizedText);

                    // Cập nhật trực tiếp vào TextBox
                    txtFindma.Text = recognizedText;
                    txtFindma.Refresh(); // Refresh lại TextBox để cập nhật UI


                    btnMic.FillColor = Color.MintCream;
                    voiceSearch.StopVoiceSearch();
                    isRecording = false; // Cập nhật trạng thái
                };

                if (this.InvokeRequired)
                {
                    this.BeginInvoke(updateAction);  // Sử dụng BeginInvoke thay vì Invoke
                }
                else
                {
                    updateAction();  // Trực tiếp nếu đang ở UI thread
                }
            }
        }


        private void btnMic_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                btnMic.FillColor = Color.MintCream;
                // Nếu đang thu âm, dừng thu âm
                voiceSearch.StopVoiceSearch();
                isRecording = false; // Cập nhật trạng thái
            }
            else
            {
                btnMic.FillColor = Color.Tomato;
                // Nếu chưa thu âm, bắt đầu thu âm
                voiceSearch.StartVoiceSearch();
                isRecording = true; // Cập nhật trạng thái
            }
        }

        private void frmEcoOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            voiceSearch?.StopVoiceSearch();
        }

        private void cboMoctgian_SelectedIndexChanged(object sender, EventArgs e)
        {
            String time = cboMoctgian.Text;
            ContractService cv = new ContractService();
            Dictionary<String, int> dic = new Dictionary<string, int>();
            Dictionary<String, int> dic2 = new Dictionary<string, int>();
            dic2 = cv.dataForPieChart(time);


            if (checkTime(time) == 1)
            {
                dic = cv.dataForQuarter(time);
                //txtSumDH.Text = cv.sumHDQuarter(time).ToString();
            }
            else
            {
                dic = cv.dataForYearChart(time);
                //txtSumDH.Text = cv.sumHDYear(time).ToString();

            }
            loadPieChart(dic2);
            loadChart(dic);
            txtFinish.Text = cv.getPerfectContract(time).ToString();
            txtInProgress.Text = cv.getProgressingContract(time).ToString();
            txtQuahan.Text = cv.getDelayContract(time).ToString();
        }



        ///AI VOICE RECOGNIZER
        ///

    }
}


