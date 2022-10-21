using BookManagement;
using Book.Business;

namespace Book.Client.Dialog
{
    public partial class frmLogin : Form
    {
        IUserBiz _userBiz;
        public frmLogin(IUserBiz userBiz)
        {
            InitializeComponent();
            _userBiz = userBiz; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("User name or password cannot be empty. Please try again.", "Login", MessageBoxButtons.OK);
                return;
            }
            else
            {
                var isChecked = _userBiz.CheckPassword4Login(userName, password);
                if (isChecked)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("User name or password does not match. Please try again.", "Login", MessageBoxButtons.OK);
                }
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
