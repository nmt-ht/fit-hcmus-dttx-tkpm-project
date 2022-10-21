using Book.Business;
using BookManagement.Models;

namespace Book.Client.Dialog
{
    public delegate void LoginCallbackHandler(User user);
    public partial class frmLogin : Form
    {
        IUserBiz _userBiz;
        public frmLogin(IUserBiz userBiz)
        {
            InitializeComponent();
            _userBiz = userBiz; 
        }

        
        public event LoginCallbackHandler OnLoginCallback;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("User name or password cannot be empty.\nPlease try again.", "Login", MessageBoxButtons.OK);
                return;
            }
            else
            {
                var user = _userBiz.GetUserByUserName(userName);
                if (user is not null)
                {
                    if(user.Password != password)
                    {
                        MessageBox.Show("User name or password does not match.\nPlease try again.", "Login", MessageBoxButtons.OK);
                    }
                    else {
                        //OnLoginCallback = new LoginCallbackHandler(user);
                        OnLoginCallback?.Invoke(user);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Account does not exist.", "Login", MessageBoxButtons.OK);
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

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var register = new frmRegister(_userBiz))
            {
                if (register.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
