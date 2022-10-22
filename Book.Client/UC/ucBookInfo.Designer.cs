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
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = global::BookManagement.Client.Properties.Resources.book_default;
        this.pictureBox1.Location = new System.Drawing.Point(80, 16);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(96, 95);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // lblBookName
        // 
        this.lblBookName.AutoSize = true;
        this.lblBookName.Location = new System.Drawing.Point(92, 128);
        this.lblBookName.Name = "lblBookName";
        this.lblBookName.Size = new System.Drawing.Size(66, 15);
        this.lblBookName.TabIndex = 1;
        this.lblBookName.Text = "BookName";
        // 
        // lblAuthor
        // 
        this.lblAuthor.AutoSize = true;
        this.lblAuthor.Location = new System.Drawing.Point(103, 153);
        this.lblAuthor.Name = "lblAuthor";
        this.lblAuthor.Size = new System.Drawing.Size(44, 15);
        this.lblAuthor.TabIndex = 1;
        this.lblAuthor.Text = "Author";
        // 
        // lblPrice
        // 
        this.lblPrice.AutoSize = true;
        this.lblPrice.Location = new System.Drawing.Point(109, 178);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Size = new System.Drawing.Size(33, 15);
        this.lblPrice.TabIndex = 1;
        this.lblPrice.Text = "Price";
        // 
        // lblDescription
        // 
        this.lblDescription.AutoSize = true;
        this.lblDescription.Location = new System.Drawing.Point(92, 203);
        this.lblDescription.Name = "lblDescription";
        this.lblDescription.Size = new System.Drawing.Size(67, 15);
        this.lblDescription.TabIndex = 1;
        this.lblDescription.Text = "Description";
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
        this.btnViewDetail.Location = new System.Drawing.Point(80, 247);
        this.btnViewDetail.Name = "btnViewDetail";
        this.btnViewDetail.Size = new System.Drawing.Size(96, 26);
        this.btnViewDetail.TabIndex = 2;
        this.btnViewDetail.Text = "View Detail";
        this.btnViewDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnViewDetail.UseVisualStyleBackColor = false;
        // 
        // btnBuy
        // 
        this.btnBuy.BackColor = System.Drawing.Color.DarkTurquoise;
        this.btnBuy.FlatAppearance.BorderSize = 0;
        this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnBuy.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
        this.btnBuy.IconColor = System.Drawing.Color.Black;
        this.btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
        this.btnBuy.IconSize = 16;
        this.btnBuy.Location = new System.Drawing.Point(80, 279);
        this.btnBuy.Name = "btnBuy";
        this.btnBuy.Size = new System.Drawing.Size(96, 26);
        this.btnBuy.TabIndex = 2;
        this.btnBuy.Text = "Buy";
        this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.btnBuy.UseVisualStyleBackColor = false;
        // 
        // ucBookInfo
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Lavender;
        this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Controls.Add(this.btnBuy);
        this.Controls.Add(this.btnViewDetail);
        this.Controls.Add(this.lblDescription);
        this.Controls.Add(this.lblPrice);
        this.Controls.Add(this.lblAuthor);
        this.Controls.Add(this.lblBookName);
        this.Controls.Add(this.pictureBox1);
        this.Name = "ucBookInfo";
        this.Size = new System.Drawing.Size(256, 320);
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
}
