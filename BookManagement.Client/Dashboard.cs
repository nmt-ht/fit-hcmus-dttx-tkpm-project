using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Client.Dialog;
using BookManagement.Client.Forms;
using BookManagement.Models;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace BookManagement
{
    public partial class Dashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildform;
        public User CurrentUser { get; set; }

        private readonly IUserBiz _userBiz;
        private readonly IBookBiz _bookBiz;
        private readonly ICustomerBiz _customerBiz;
        private readonly IParameterBiz _parameterBiz;

        public Dashboard(IUserBiz userBiz, IBookBiz bookBiz, ICustomerBiz customerBiz, IParameterBiz parameterBiz)
        {
            InitializeComponent();
            InitDesignUI();
            _userBiz = userBiz;
            _bookBiz = bookBiz;
            _customerBiz = customerBiz;
            _parameterBiz = parameterBiz;
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
                lblWelcomeUser.Text = this.CurrentUser.FullName;
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

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new System.Drawing.Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon current child form
                IconHome.IconChar = currentBtn.IconChar;
                IconHome.IconColor = color;
            }
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
            if (currentChildform is not null)
                currentChildform.Close();

            currentChildform = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            chilForm.Left = (this.ClientSize.Width - chilForm.Width) / 2;
            chilForm.Top = (this.ClientSize.Height - chilForm.Height) / 2;
            pnlDesktop.Controls.Add(chilForm);
            pnlDesktop.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
            lblTitle.Text = chilForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconHome.IconChar = IconChar.Home;
            IconHome.IconColor = Color.CornflowerBlue;
            lblTitle.Text = "Home";
            OpenChildForm(new FormHome());
        }

        //Drap form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //End drap form

        private void btnMaximinze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMiniminze_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnDanhMucSach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrBooks);
            var bookDasboard = new FormBookDasboard(_bookBiz, _parameterBiz);
            bookDasboard.CurrentUser = this.CurrentUser;
            OpenChildForm(bookDasboard);
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrEmployee);
            var formEmployee = new FormEmployee(_userBiz);
            OpenChildForm(formEmployee);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrCustomer);
            var formCustomer = new FormCustomer(_customerBiz);
            formCustomer.CurrentUser = this.CurrentUser;
            OpenChildForm(formCustomer);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrInvocie);
            var formInvoice = new FormInvoice(_customerBiz);
            OpenChildForm(formInvoice);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrReport);
            var formReport = new FormReport(_customerBiz);
            OpenChildForm(formReport);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.clrSetting);
            var formSetting = new FormSetting(_customerBiz);
            OpenChildForm(formSetting);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Hide();
            using (var dialog = new LoginDialog(_userBiz))
            {
                dialog.OnUserDelegate += new UserDelegateHandler.UserDelegate(SetCurrentUser);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    DataBind();
                    OpenChildForm(new FormHome());
                }
            }
        }

        //Event Listener. This function will be called whenever child class raises event.
        private void SetCurrentUser(UserCustomEventArgs customEventArgs)
        {
            this.CurrentUser = customEventArgs.User;
        }
    }
}