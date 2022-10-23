namespace BookManagement.Client.UC;
partial class ucBookInfo
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnViewDetail = new FontAwesome.Sharp.IconButton();
            this.btnBuy = new FontAwesome.Sharp.IconButton();
            this.txtAuthor = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookManagement.Client.Properties.Resources.book_default;
            this.pictureBox1.Location = new System.Drawing.Point(108, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.ForeColor = System.Drawing.Color.Chocolate;
            this.lblBookName.Location = new System.Drawing.Point(16, 122);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(87, 20);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "BookName";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Lavender;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.ForeColor = System.Drawing.Color.Maroon;
            this.lblAuthor.Location = new System.Drawing.Point(16, 153);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 20);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Lavender;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblPrice.Location = new System.Drawing.Point(16, 178);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Lavender;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescription.Location = new System.Drawing.Point(16, 202);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description :";
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewDetail.FlatAppearance.BorderSize = 0;
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnViewDetail.IconColor = System.Drawing.Color.White;
            this.btnViewDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewDetail.IconSize = 15;
            this.btnViewDetail.Location = new System.Drawing.Point(16, 376);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(96, 26);
            this.btnViewDetail.TabIndex = 2;
            this.btnViewDetail.Text = "View Detail";
            this.btnViewDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnBuy.IconColor = System.Drawing.Color.White;
            this.btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuy.IconSize = 16;
            this.btnBuy.Location = new System.Drawing.Point(195, 376);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(96, 26);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Add to Cart";
            this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.BackColor = System.Drawing.Color.Lavender;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAuthor.ForeColor = System.Drawing.Color.Maroon;
            this.txtAuthor.Location = new System.Drawing.Point(83, 153);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(59, 20);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.Text = "Author";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.BackColor = System.Drawing.Color.Lavender;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.Color.Maroon;
            this.txtPrice.Location = new System.Drawing.Point(71, 178);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(43, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Lavender;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.ForeColor = System.Drawing.Color.Maroon;
            this.txtDescription.Location = new System.Drawing.Point(112, 204);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(179, 117);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(16, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Qty:";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.AutoSize = true;
            this.txtAvailableQty.BackColor = System.Drawing.Color.Lavender;
            this.txtAvailableQty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAvailableQty.ForeColor = System.Drawing.Color.Maroon;
            this.txtAvailableQty.Location = new System.Drawing.Point(123, 332);
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.Size = new System.Drawing.Size(102, 20);
            this.txtAvailableQty.TabIndex = 3;
            this.txtAvailableQty.Text = "Available Qty";
            // 
            // ucBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAvailableQty);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucBookInfo";
            this.Size = new System.Drawing.Size(314, 420);
            this.Click += new System.EventHandler(this.ucBookInfo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private PictureBox pictureBox1;
    private Label lblBookName;
    private Label lblAuthor;
    private Label lblPrice;
    private Label lblDescription;
    private FontAwesome.Sharp.IconButton btnViewDetail;
    private FontAwesome.Sharp.IconButton btnBuy;
    private Label txtAuthor;
    private Label txtPrice;
    private RichTextBox txtDescription;
    private Label label1;
    private Label txtAvailableQty;
}
