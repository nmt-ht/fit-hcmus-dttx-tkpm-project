namespace BookManagement.Client.Dialog
{
    partial class MessageBoxDialog
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.txtOK = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(180, 61);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(127, 132);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Lavender;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnExit.IconColor = System.Drawing.Color.Crimson;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(476, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 27);
            this.btnExit.TabIndex = 24;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOK
            // 
            this.txtOK.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtOK.FlatAppearance.BorderSize = 0;
            this.txtOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOK.ForeColor = System.Drawing.Color.White;
            this.txtOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.txtOK.IconColor = System.Drawing.Color.Lime;
            this.txtOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtOK.IconSize = 30;
            this.txtOK.Location = new System.Drawing.Point(193, 267);
            this.txtOK.Name = "txtOK";
            this.txtOK.Size = new System.Drawing.Size(97, 36);
            this.txtOK.TabIndex = 28;
            this.txtOK.Text = "OK";
            this.txtOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtOK.UseVisualStyleBackColor = false;
            this.txtOK.Click += new System.EventHandler(this.txtOK_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Location = new System.Drawing.Point(97, 199);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 1);
            this.panel7.TabIndex = 22;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(12, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 28);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 1);
            this.panel1.TabIndex = 22;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.Lavender;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(28, 206);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(431, 55);
            this.txtMessage.TabIndex = 31;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageBoxDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(509, 349);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtOK);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new book";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBox;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton txtOK;
        private Panel panel7;
        private Label lblTitle;
        private Panel panel1;
        private TextBox txtMessage;
    }
}