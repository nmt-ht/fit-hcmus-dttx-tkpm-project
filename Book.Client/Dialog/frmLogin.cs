﻿using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Models;
using static BookManagement.Business.Helper.UserDelegateHandler;

namespace BookManagement.Client.Dialog;

public partial class frmLogin : Form
{
    IUserBiz _userBiz;
    public User NewUser { get; set; }
    public frmLogin(IUserBiz userBiz)
    {
        InitializeComponent();
        _userBiz = userBiz; 
    }
    public void DataBind()
    {
        if (this.NewUser is not null)
        {
            txtUserName.Text = this.NewUser.UserName;
            txtPassword.Text = this.NewUser.Password;
        }
    }

    public event UserDelegate OnUserDelegate;
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
                    NotifyParent(user);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Account does not exist.", "Login", MessageBoxButtons.OK);
            }
        }
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
            register.OnUserDelegate += new UserDelegate(SetNewUser);
            if (register.ShowDialog() == DialogResult.OK)
            {
                DataBind();
            }
        }
    }

    private void SetNewUser(CustomEventArgs customEventArgs) => this.NewUser = customEventArgs.User;

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
