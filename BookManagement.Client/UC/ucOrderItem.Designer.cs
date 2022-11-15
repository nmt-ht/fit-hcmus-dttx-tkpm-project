namespace BookManagement.Client.UC
{
    partial class ucOrderItem
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
            this.pnlTitleCustom = new BookManagement.Utility.PanelCustom();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlTitleCustom.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleCustom
            // 
            this.pnlTitleCustom.AutoSize = true;
            this.pnlTitleCustom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitleCustom.BackColor = System.Drawing.Color.White;
            this.pnlTitleCustom.BorderRadius = 28;
            this.pnlTitleCustom.Controls.Add(this.tlpTitle);
            this.pnlTitleCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitleCustom.ForeColor = System.Drawing.Color.Black;
            this.pnlTitleCustom.GradientAngle = 120F;
            this.pnlTitleCustom.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(114)))), ((int)(((byte)(225)))));
            this.pnlTitleCustom.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.pnlTitleCustom.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleCustom.Name = "pnlTitleCustom";
            this.pnlTitleCustom.Size = new System.Drawing.Size(618, 25);
            this.pnlTitleCustom.TabIndex = 2;
            this.pnlTitleCustom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTitleCustom_MouseClick);
            // 
            // tlpTitle
            // 
            this.tlpTitle.BackColor = System.Drawing.Color.Transparent;
            this.tlpTitle.ColumnCount = 5;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTitle.Controls.Add(this.lblPrice, 4, 0);
            this.tlpTitle.Controls.Add(this.lblAuthor, 2, 0);
            this.tlpTitle.Controls.Add(this.lblName, 1, 0);
            this.tlpTitle.Controls.Add(this.lblNo, 0, 0);
            this.tlpTitle.Controls.Add(this.numQuantity, 3, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Size = new System.Drawing.Size(618, 25);
            this.tlpTitle.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(472, 0);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(146, 25);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(213, 0);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(173, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(40, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(173, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(0, 0);
            this.lblNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(40, 25);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "#";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numQuantity
            // 
            this.numQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuantity.Location = new System.Drawing.Point(389, 3);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(80, 19);
            this.numQuantity.TabIndex = 5;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTitleCustom);
            this.Name = "ucOrderItem";
            this.Size = new System.Drawing.Size(618, 25);
            this.pnlTitleCustom.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utility.PanelCustom pnlTitleCustom;
        private TableLayoutPanel tlpTitle;
        private Label lblPrice;
        private Label lblAuthor;
        private Label lblName;
        private Label lblNo;
        private NumericUpDown numQuantity;
    }
}
