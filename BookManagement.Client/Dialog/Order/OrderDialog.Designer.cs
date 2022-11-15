namespace BookManagement.Client.Dialog.Order
{
    partial class OrderDialog
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
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCustom1 = new BookManagement.Utility.PanelCustom();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pntCustomerInfo = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.pnlTitleCustom = new BookManagement.Utility.PanelCustom();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlItems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pntCustomerInfo.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(239)))), ((int)(((byte)(207)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.Lime;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.Location = new System.Drawing.Point(1059, 740);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Place Order";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnExit.IconColor = System.Drawing.Color.Crimson;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1175, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 27);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookManagement.Client.Properties.Resources.order;
            this.pictureBox1.Location = new System.Drawing.Point(555, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 131);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlAuthor.Location = new System.Drawing.Point(461, 149);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(338, 1);
            this.pnlAuthor.TabIndex = 23;
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.panel1);
            this.pnlItems.Location = new System.Drawing.Point(12, 194);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(619, 531);
            this.pnlItems.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCustom1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 45);
            this.panel1.TabIndex = 0;
            // 
            // panelCustom1
            // 
            this.panelCustom1.BackColor = System.Drawing.Color.White;
            this.panelCustom1.BorderRadius = 40;
            this.panelCustom1.Controls.Add(this.tableLayoutPanel1);
            this.panelCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustom1.ForeColor = System.Drawing.Color.Black;
            this.panelCustom1.GradientAngle = 120F;
            this.panelCustom1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.panelCustom1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.panelCustom1.Location = new System.Drawing.Point(0, 0);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(619, 45);
            this.panelCustom1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(472, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(328, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Item Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "#";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pntCustomerInfo
            // 
            this.pntCustomerInfo.Controls.Add(this.label18);
            this.pntCustomerInfo.Controls.Add(this.richTextBox1);
            this.pntCustomerInfo.Controls.Add(this.label13);
            this.pntCustomerInfo.Controls.Add(this.label14);
            this.pntCustomerInfo.Controls.Add(this.label15);
            this.pntCustomerInfo.Controls.Add(this.label16);
            this.pntCustomerInfo.Controls.Add(this.label17);
            this.pntCustomerInfo.Controls.Add(this.txtEmail);
            this.pntCustomerInfo.Controls.Add(this.txtCountry);
            this.pntCustomerInfo.Controls.Add(this.txtCity);
            this.pntCustomerInfo.Controls.Add(this.txtPhone);
            this.pntCustomerInfo.Controls.Add(this.txtAddress);
            this.pntCustomerInfo.Controls.Add(this.panel11);
            this.pntCustomerInfo.Controls.Add(this.panel10);
            this.pntCustomerInfo.Controls.Add(this.panel9);
            this.pntCustomerInfo.Controls.Add(this.panel8);
            this.pntCustomerInfo.Controls.Add(this.panel6);
            this.pntCustomerInfo.Controls.Add(this.label11);
            this.pntCustomerInfo.Controls.Add(this.label12);
            this.pntCustomerInfo.Controls.Add(this.txtLastName);
            this.pntCustomerInfo.Controls.Add(this.txtFirstName);
            this.pntCustomerInfo.Controls.Add(this.panel4);
            this.pntCustomerInfo.Controls.Add(this.panel5);
            this.pntCustomerInfo.Controls.Add(this.label10);
            this.pntCustomerInfo.Controls.Add(this.label9);
            this.pntCustomerInfo.Controls.Add(this.cboCustomers);
            this.pntCustomerInfo.Controls.Add(this.label8);
            this.pntCustomerInfo.Location = new System.Drawing.Point(651, 251);
            this.pntCustomerInfo.Name = "pntCustomerInfo";
            this.pntCustomerInfo.Size = new System.Drawing.Size(544, 474);
            this.pntCustomerInfo.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.label18.Location = new System.Drawing.Point(19, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 21);
            this.label18.TabIndex = 30;
            this.label18.Text = "Note:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(19, 303);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(518, 110);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.label13.Location = new System.Drawing.Point(18, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.label14.Location = new System.Drawing.Point(285, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "Country:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.label15.Location = new System.Drawing.Point(18, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 21);
            this.label15.TabIndex = 21;
            this.label15.Text = "City:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.label16.Location = new System.Drawing.Point(285, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "Phone:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.label17.Location = new System.Drawing.Point(18, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 21);
            this.label17.TabIndex = 23;
            this.label17.Text = "Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(133)))), ((int)(((byte)(54)))));
            this.txtEmail.Location = new System.Drawing.Point(67, 225);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 29);
            this.txtEmail.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(133)))), ((int)(((byte)(54)))));
            this.txtCountry.Location = new System.Drawing.Point(355, 169);
            this.txtCountry.Multiline = true;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(146, 29);
            this.txtCountry.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(133)))), ((int)(((byte)(54)))));
            this.txtCity.Location = new System.Drawing.Point(67, 170);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(206, 29);
            this.txtCity.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(133)))), ((int)(((byte)(54)))));
            this.txtPhone.Location = new System.Drawing.Point(348, 225);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Phone ";
            this.txtPhone.Size = new System.Drawing.Size(189, 29);
            this.txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(133)))), ((int)(((byte)(54)))));
            this.txtAddress.Location = new System.Drawing.Point(93, 115);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.Size = new System.Drawing.Size(346, 29);
            this.txtAddress.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.panel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.panel11.Location = new System.Drawing.Point(16, 257);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(252, 1);
            this.panel11.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.panel10.Location = new System.Drawing.Point(285, 201);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(219, 1);
            this.panel10.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.panel9.Location = new System.Drawing.Point(19, 201);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(252, 1);
            this.panel9.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.panel8.Location = new System.Drawing.Point(285, 257);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(252, 1);
            this.panel8.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.panel6.Location = new System.Drawing.Point(16, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(423, 1);
            this.panel6.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.label11.Location = new System.Drawing.Point(278, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "LastName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.label12.Location = new System.Drawing.Point(15, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "FirstName:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(133)))), ((int)(((byte)(54)))));
            this.txtLastName.Location = new System.Drawing.Point(365, 58);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(161, 29);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(133)))), ((int)(((byte)(54)))));
            this.txtFirstName.Location = new System.Drawing.Point(102, 57);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(160, 29);
            this.txtFirstName.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.panel4.Location = new System.Drawing.Point(278, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 1);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.panel5.Location = new System.Drawing.Point(15, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 1);
            this.panel5.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(118, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 30);
            this.label10.TabIndex = 3;
            this.label10.Text = "100.000.000 VND";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Order Total:";
            // 
            // cboCustomers
            // 
            this.cboCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(102, 12);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(290, 23);
            this.cboCustomers.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(120, 0);
            this.lblType.Margin = new System.Windows.Forms.Padding(0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 100);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(80, 0);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(40, 100);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(40, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 100);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(0, 0);
            this.lblNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(40, 100);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "#";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitleCustom
            // 
            this.pnlTitleCustom.BackColor = System.Drawing.Color.White;
            this.pnlTitleCustom.BorderRadius = 40;
            this.pnlTitleCustom.ForeColor = System.Drawing.Color.Black;
            this.pnlTitleCustom.GradientAngle = 90F;
            this.pnlTitleCustom.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.pnlTitleCustom.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.pnlTitleCustom.Location = new System.Drawing.Point(8, 8);
            this.pnlTitleCustom.Name = "pnlTitleCustom";
            this.pnlTitleCustom.Size = new System.Drawing.Size(350, 200);
            this.pnlTitleCustom.TabIndex = 0;
            // 
            // tlpTitle
            // 
            this.tlpTitle.BackColor = System.Drawing.Color.Transparent;
            this.tlpTitle.ColumnCount = 5;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitle.Controls.Add(this.lblActive, 4, 0);
            this.tlpTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.Size = new System.Drawing.Size(200, 100);
            this.tlpTitle.TabIndex = 0;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActive.ForeColor = System.Drawing.Color.White;
            this.lblActive.Location = new System.Drawing.Point(160, 0);
            this.lblActive.Margin = new System.Windows.Forms.Padding(0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(40, 100);
            this.lblActive.TabIndex = 4;
            this.lblActive.Text = "Actice";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "1. Order Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.panel2.Location = new System.Drawing.Point(12, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 1);
            this.panel2.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(651, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "2. Customer Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.panel3.Location = new System.Drawing.Point(651, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 1);
            this.panel3.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.panel7.Location = new System.Drawing.Point(639, 195);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 545);
            this.panel7.TabIndex = 28;
            // 
            // OrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(239)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1207, 788);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pntCustomerInfo);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.pnlAuthor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlItems.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCustom1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pntCustomerInfo.ResumeLayout(false);
            this.pntCustomerInfo.PerformLayout();
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureBox1;
        private Panel pnlAuthor;
        private Panel pnlItems;
        private Panel pntCustomerInfo;
        private Panel panel1;
        private Utility.PanelCustom panelCustom1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblType;
        private Label lblValue;
        private Label lblName;
        private Label lblNo;
        private Utility.PanelCustom pnlTitleCustom;
        private TableLayoutPanel tlpTitle;
        private Label lblActive;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private ComboBox cboCustomers;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Panel panel4;
        private Panel panel5;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtEmail;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel6;
        private RichTextBox richTextBox1;
        private Label label18;
        private Panel panel7;
    }
}