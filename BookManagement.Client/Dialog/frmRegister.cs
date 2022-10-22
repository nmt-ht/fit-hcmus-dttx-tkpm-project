using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Models;
using static BookManagement.Business.Helper.UserDelegateHandler;

namespace BookManagement.Client.Dialog;
public partial class frmRegister : Form
{
    IUserBiz _userBiz;
    public frmRegister(IUserBiz userBiz)
    {
        InitializeComponent();
        _userBiz = userBiz;
    }
    public event UserDelegate OnUserDelegate;
    private void frmRegister_Load(object sender, EventArgs e)
    {
        this.KeyPreview = true;
    }

    private void txtFirstName_Click(object sender, EventArgs e)
    {
        txtFirstName.Text = string.Empty;
    }

    private void txtLastName_Click(object sender, EventArgs e)
    {
        txtLastName.Text = string.Empty;
    }

    private void txtUserName_Click(object sender, EventArgs e)
    {
        txtUserName.Text = string.Empty;
    }

    private void txtPassword_Click(object sender, EventArgs e)
    {
        txtPassword.Text = string.Empty;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        var newUser = new User
        {
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            UserName = txtUserName.Text,
            Password = txtPassword.Text
        };

        var isExistedUser = _userBiz.CheckExistingUser(newUser.UserName);
        if (isExistedUser)
        {
            MessageBox.Show("User name is existed. Please use another one.", "Warning");
            txtUserName.Focus();
        }
        else
        {
            var isSuccessed = _userBiz.AddUser(newUser);
            if (isSuccessed)
            {
                NotifyParent(newUser);
                MessageBox.Show("You have registered new account successfully.", "Information");
                this.DialogResult = DialogResult.OK;
            }
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    public void NotifyParent(User user)
    {
        if (OnUserDelegate != null)
        {
            CustomEventArgs loginHandler = new CustomEventArgs(user);
            //Raise Event. All the listeners of this event will get a call.
            OnUserDelegate(loginHandler);
        }
    }
}
