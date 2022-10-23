﻿namespace BookManagement.Client.Dialog
{
    partial class AddEditBookDialog
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.pnlQty = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBookTypes = new System.Windows.Forms.ComboBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlType = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTypeOfAddBook = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboListOfBooks = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Image = global::BookManagement.Client.Properties.Resources.book_add;
            this.picBox.Location = new System.Drawing.Point(355, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(127, 132);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.Color.Crimson;
            this.txtPrice.Location = new System.Drawing.Point(245, 284);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Price";
            this.txtPrice.Size = new System.Drawing.Size(142, 19);
            this.txtPrice.TabIndex = 6;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBookName.ForeColor = System.Drawing.Color.Crimson;
            this.txtBookName.Location = new System.Drawing.Point(96, 238);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PlaceholderText = "Book name";
            this.txtBookName.Size = new System.Drawing.Size(245, 19);
            this.txtBookName.TabIndex = 3;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlName.Location = new System.Drawing.Point(29, 259);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(338, 1);
            this.pnlName.TabIndex = 22;
            // 
            // pnlQty
            // 
            this.pnlQty.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlQty.Location = new System.Drawing.Point(31, 302);
            this.pnlQty.Name = "pnlQty";
            this.pnlQty.Size = new System.Drawing.Size(143, 1);
            this.pnlQty.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnExit.IconColor = System.Drawing.Color.Crimson;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(768, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 27);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.ForeColor = System.Drawing.Color.Crimson;
            this.txtQuantity.Location = new System.Drawing.Point(78, 284);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.Size = new System.Drawing.Size(67, 19);
            this.txtQuantity.TabIndex = 5;
            // 
            // pnlPrice
            // 
            this.pnlPrice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlPrice.Location = new System.Drawing.Point(193, 302);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(174, 1);
            this.pnlPrice.TabIndex = 23;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.ForeColor = System.Drawing.Color.Crimson;
            this.txtDescription.Location = new System.Drawing.Point(29, 355);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(738, 173);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Description:";
            // 
            // cboBookTypes
            // 
            this.cboBookTypes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cboBookTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBookTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboBookTypes.ForeColor = System.Drawing.Color.Crimson;
            this.cboBookTypes.FormattingEnabled = true;
            this.cboBookTypes.Location = new System.Drawing.Point(496, 275);
            this.cboBookTypes.Name = "cboBookTypes";
            this.cboBookTypes.Size = new System.Drawing.Size(271, 28);
            this.cboBookTypes.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.Lime;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.Location = new System.Drawing.Point(670, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlDescription.Location = new System.Drawing.Point(31, 371);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(733, 1);
            this.pnlDescription.TabIndex = 23;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHome.Location = new System.Drawing.Point(272, 150);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(283, 1);
            this.pnlHome.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name:";
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlAuthor.Location = new System.Drawing.Point(423, 262);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(338, 1);
            this.pnlAuthor.TabIndex = 22;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthor.ForeColor = System.Drawing.Color.Crimson;
            this.txtAuthor.Location = new System.Drawing.Point(496, 236);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderText = "Author";
            this.txtAuthor.Size = new System.Drawing.Size(245, 19);
            this.txtAuthor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(409, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(423, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Type:";
            // 
            // pnlType
            // 
            this.pnlType.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlType.Location = new System.Drawing.Point(423, 302);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(338, 1);
            this.pnlType.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(193, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Qty:";
            // 
            // cboTypeOfAddBook
            // 
            this.cboTypeOfAddBook.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cboTypeOfAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTypeOfAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTypeOfAddBook.ForeColor = System.Drawing.Color.Crimson;
            this.cboTypeOfAddBook.FormattingEnabled = true;
            this.cboTypeOfAddBook.Location = new System.Drawing.Point(126, 183);
            this.cboTypeOfAddBook.Name = "cboTypeOfAddBook";
            this.cboTypeOfAddBook.Size = new System.Drawing.Size(147, 28);
            this.cboTypeOfAddBook.TabIndex = 1;
            this.cboTypeOfAddBook.SelectedValueChanged += new System.EventHandler(this.cboTypeOfAddBook_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Add Type?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(365, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "List of Books:";
            // 
            // cboListOfBooks
            // 
            this.cboListOfBooks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cboListOfBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboListOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboListOfBooks.ForeColor = System.Drawing.Color.Crimson;
            this.cboListOfBooks.FormattingEnabled = true;
            this.cboListOfBooks.Location = new System.Drawing.Point(496, 179);
            this.cboListOfBooks.Name = "cboListOfBooks";
            this.cboListOfBooks.Size = new System.Drawing.Size(271, 28);
            this.cboListOfBooks.TabIndex = 2;
            this.cboListOfBooks.SelectedValueChanged += new System.EventHandler(this.cboListOfBooks_SelectedValueChanged);
            // 
            // AddEditBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(799, 609);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboListOfBooks);
            this.Controls.Add(this.cboTypeOfAddBook);
            this.Controls.Add(this.cboBookTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.pnlType);
            this.Controls.Add(this.pnlAuthor);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlPrice);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pnlQty);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditBookDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new book";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBox;
        private TextBox txtPrice;
        private TextBox txtBookName;
        private Panel pnlName;
        private Panel pnlQty;
        private FontAwesome.Sharp.IconButton btnExit;
        private TextBox txtQuantity;
        private Panel pnlPrice;
        private RichTextBox txtDescription;
        private Label label1;
        private ComboBox cboBookTypes;
        private FontAwesome.Sharp.IconButton btnSave;
        private Panel pnlDescription;
        private Panel pnlHome;
        private Label label2;
        private Panel pnlAuthor;
        private TextBox txtAuthor;
        private Label label3;
        private Label label4;
        private Panel pnlType;
        private Label label5;
        private Label label6;
        private ComboBox cboTypeOfAddBook;
        private Label label7;
        private Label label8;
        private ComboBox cboListOfBooks;
    }
}