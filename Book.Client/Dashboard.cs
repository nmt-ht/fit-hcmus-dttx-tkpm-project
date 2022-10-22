using Book.Business;
using Book.Business.Helper;
using Book.Client.Dialog;
using BookManagement.Models;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using static Book.Client.DataType;

namespace BookManagement
{
    public partial class Dashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildform;
        public User CurrentUser { get; set; }

        private readonly IUserBiz _userBiz;

        public Dashboard(IUserBiz userBiz)
        {
            InitializeComponent();
            InitDesignUI();
            _userBiz = userBiz;
        }

        private void InitDesignUI()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new System.Drawing.Size(10, 60);
            pnlLeftMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void DataBind()
        {
            if (CurrentUser is not null)
            {
                lblWelcomeUser.Text = lblWelcomeUser.Text.Replace("{userName}", this.CurrentUser.FullName);
            }
        }

        private struct RGBColors
        {
            public static Color clrBooks = Color.FromArgb(172, 126, 241);
            public static Color clrEmployee = Color.FromArgb(249, 118, 176);
            public static Color clrCustomer = Color.FromArgb(253, 138, 114);
            public static Color clrInvocie = Color.FromArgb(95, 77, 221);
            public static Color clrReport = Color.FromArgb(249, 88, 155);
            public static Color clrSetting = Color.FromArgb(24, 161, 251);

        }
        private void ActivateButton(object senderBtn, Color color, eDashboard eDashboard = eDashboard.Home)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new System.Drawing.Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                IconHome.IconChar = currentBtn.IconChar;
                IconHome.IconColor = color;
                GenerateTilte(eDashboard);
            }
        }

        private void GenerateTilte(eDashboard eDashboard)
        {
            var title = string.Empty;
            switch (eDashboard)
            {
                case eDashboard.Home:
                    title = "Home";
                    break;
                case eDashboard.Books:
                    title = "Danh Mục Sách";
                    break;
                case eDashboard.Employee:
                    title = "Nhân Viên";
                    break;
                case eDashboard.Customer:
                    title = "Khách Hàng";
                    break;
                case eDashboard.Invoice:
                    title = "Hóa Đơn";
                    break;
                case eDashboard.Report:
                    title = "Báo Cáo";
                    break;
                case eDashboard.Setting:
                    title = "Cài Đặt";
                    break;
            }

            lblTitle.Text = title;
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form chilForm)
        {
            if (IconHome != null)
                currentChildform.Close();
            currentChildform = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(chilForm);
            chilForm.BringToFront();
            chilForm.Show();
            lblTitle.Text = chilForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconHome.IconChar = IconChar.Home;
            IconHome.IconColor = Color.CornflowerBlue;
            lblTitle.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMiniminze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximinze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnDanhMucSach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrBooks, eDashboard.Books);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrEmployee, eDashboard.Employee);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrCustomer, eDashboard.Customer);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrInvocie, eDashboard.Invoice);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrReport, eDashboard.Report);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrSetting, eDashboard.Setting);
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            using(var dialog = new frmLogin(_userBiz))
            {
                dialog.OnUserDelegate += new UserDelegateHandler.UserDelegate(SetCurrentUser);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DataBind();
                }
            }
        }

        //Event Listener. This function will be called whenever child class raises event.
        private void SetCurrentUser(CustomEventArgs customEventArgs)
        {
            this.CurrentUser = customEventArgs.User;
        }
    }
}