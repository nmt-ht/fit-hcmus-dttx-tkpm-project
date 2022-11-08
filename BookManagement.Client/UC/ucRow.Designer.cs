namespace BookManagement.Client.UC
{
    partial class ucRow
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
            this.lblActive = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.pnlTitleCustom.SuspendLayout();
            this.tlpTitle.SuspendLayout();
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
            this.pnlTitleCustom.Location = new System.Drawing.Point(1, 1);
            this.pnlTitleCustom.Name = "pnlTitleCustom";
            this.pnlTitleCustom.Size = new System.Drawing.Size(778, 28);
            this.pnlTitleCustom.TabIndex = 1;
            this.pnlTitleCustom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTitleCustom_MouseClick);
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
            this.tlpTitle.Controls.Add(this.lblType, 3, 0);
            this.tlpTitle.Controls.Add(this.lblValue, 2, 0);
            this.tlpTitle.Controls.Add(this.lblName, 1, 0);
            this.tlpTitle.Controls.Add(this.lblNo, 0, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Size = new System.Drawing.Size(778, 28);
            this.tlpTitle.TabIndex = 0;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblActive.ForeColor = System.Drawing.Color.White;
            this.lblActive.Location = new System.Drawing.Point(592, 0);
            this.lblActive.Margin = new System.Windows.Forms.Padding(0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(186, 28);
            this.lblActive.TabIndex = 4;
            this.lblActive.Text = "Actice";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblActive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTitleCustom_MouseClick);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(408, 0);
            this.lblType.Margin = new System.Windows.Forms.Padding(0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(184, 28);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTitleCustom_MouseClick);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(224, 0);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(184, 28);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTitleCustom_MouseClick);
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
            this.lblName.Size = new System.Drawing.Size(184, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTitleCustom_MouseClick);
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
            this.lblNo.Size = new System.Drawing.Size(40, 28);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "#";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTitleCustom_MouseClick);
            // 
            // ucSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.pnlTitleCustom);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucSetting";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(780, 30);
            this.pnlTitleCustom.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utility.PanelCustom pnlTitleCustom;
        private TableLayoutPanel tlpTitle;
        private Label lblActive;
        private Label lblType;
        private Label lblValue;
        private Label lblName;
        private Label lblNo;
    }
}
