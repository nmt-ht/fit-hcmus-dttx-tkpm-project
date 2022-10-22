using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Client.Forms;
using BookManagement.Models;
using static BookManagement.Business.Helper.UserDelegateHandler;
using static BookManagement.Client.DataType;

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
            DisplayNotification(eMessageType.Info, "Register", "User name is existed.\nPlease use another one.");
            txtUserName.Focus();
        }
        else
        {
            var isSuccessed = _userBiz.AddUser(newUser);
            if (isSuccessed)
            {
                NotifyParent(newUser);
                DisplayNotification(eMessageType.Info, "Register", "You have registered new account successfully.");
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
    
    private void DisplayNotification(eMessageType messageType, string title, string message)
    {
        using (var messageBox = new FormMessageBox())
        {
            messageBox.SetParametters(title, message, messageType);
            messageBox.DataBind();
            messageBox.ShowDialog();
        }
    }
}
