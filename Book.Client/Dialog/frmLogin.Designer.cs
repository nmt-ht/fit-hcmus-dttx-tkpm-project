namespace BookManagement.Client.Dialog;
partial class frmLogin
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
        this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
        this.panel1 = new System.Windows.Forms.Panel();
        this.panel2 = new System.Windows.Forms.Panel();
        this.txtUserName = new System.Windows.Forms.TextBox();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.btnLogin = new FontAwesome.Sharp.IconButton();
        this.btnRegister = new FontAwesome.Sharp.IconButton();
        this.btnExit = new FontAwesome.Sharp.IconButton();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = global::BookManagement.Client.Properties.Resources.login;
        this.pictureBox1.Location = new System.Drawing.Point(108, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(127, 130);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // iconPictureBox1
        // 
        this.iconPictureBox1.BackColor = System.Drawing.Color.Lavender;
        this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
        this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
        this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveCaption;
        this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
        this.iconPictureBox1.Location = new System.Drawing.Point(29, 169);
        this.iconPictureBox1.Name = "iconPictureBox1";
        this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
        this.iconPictureBox1.TabIndex = 1;
        this.iconPictureBox1.TabStop = false;
        // 
        // iconPictureBox2
        // 
        this.iconPictureBox2.BackColor = System.Drawing.Color.Lavender;
        this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
        this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
        this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ActiveCaption;
        this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
        this.iconPictureBox2.Location = new System.Drawing.Point(29, 226);
        this.iconPictureBox2.Name = "iconPictureBox2";
        this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
        this.iconPictureBox2.TabIndex = 1;
        this.iconPictureBox2.TabStop = false;
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
        this.panel1.Location = new System.Drawing.Point(29, 205);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(283, 1);
        this.panel1.TabIndex = 2;
        // 
        // panel2
        // 
        this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
        this.panel2.Location = new System.Drawing.Point(29, 264);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(283, 1);
        this.panel2.TabIndex = 2;
        // 
        // txtUserName
        // 
        this.txtUserName.BackColor = System.Drawing.Color.Lavender;
        this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtUserName.ForeColor = System.Drawing.Color.SlateGray;
        this.txtUserName.Location = new System.Drawing.Point(67, 176);
        this.txtUserName.Name = "txtUserName";
        this.txtUserName.PlaceholderText = "Username";
        this.txtUserName.Size = new System.Drawing.Size(245, 22);
        this.txtUserName.TabIndex = 1;
        // 
        // txtPassword
        // 
        this.txtPassword.BackColor = System.Drawing.Color.Lavender;
        this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtPassword.ForeColor = System.Drawing.Color.SlateGray;
        this.txtPassword.Location = new System.Drawing.Point(67, 236);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.PlaceholderText = "Password";
        this.txtPassword.Size = new System.Drawing.Size(245, 22);
        this.txtPassword.TabIndex = 2;
        // 
        // btnLogin
        // 
        this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnLogin.FlatAppearance.BorderSize = 0;
        this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignIn;
        this.btnLogin.IconColor = System.Drawing.Color.DodgerBlue;
        this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
        this.btnLogin.IconSize = 30;
        this.btnLogin.Location = new System.Drawing.Point(29, 293);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(283, 41);
        this.btnLogin.TabIndex = 3;
        this.btnLogin.Text = "Sign in";
        this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnLogin.UseVisualStyleBackColor = false;
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        // 
        // btnRegister
        // 
        this.btnRegister.BackColor = System.Drawing.Color.LightGray;
        this.btnRegister.FlatAppearance.BorderSize = 0;
        this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.Registered;
        this.btnRegister.IconColor = System.Drawing.Color.Salmon;
        this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
        this.btnRegister.IconSize = 30;
        this.btnRegister.Location = new System.Drawing.Point(29, 359);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(283, 41);
        this.btnRegister.TabIndex = 4;
        this.btnRegister.Text = "Register";
        this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnRegister.UseVisualStyleBackColor = false;
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        // 
        // btnExit
        // 
        this.btnExit.FlatAppearance.BorderSize = 0;
        this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
        this.btnExit.IconColor = System.Drawing.Color.Crimson;
        this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
        this.btnExit.IconSize = 30;
        this.btnExit.Location = new System.Drawing.Point(313, 1);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(30, 27);
        this.btnExit.TabIndex = 5;
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // frmLogin
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Lavender;
        this.ClientSize = new System.Drawing.Size(346, 424);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnRegister);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.txtUserName);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.iconPictureBox2);
        this.Controls.Add(this.iconPictureBox1);
        this.Controls.Add(this.pictureBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "frmLogin";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Login";
        this.Load += new System.EventHandler(this.frmLogin_Load);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private PictureBox pictureBox1;
    private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    private Panel panel1;
    private Panel panel2;
    private TextBox txtUserName;
    private TextBox txtPassword;
    private FontAwesome.Sharp.IconButton btnLogin;
    private FontAwesome.Sharp.IconButton btnRegister;
    private FontAwesome.Sharp.IconButton btnExit;
}
