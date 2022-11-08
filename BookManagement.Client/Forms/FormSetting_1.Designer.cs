namespace BookManagement.Client.Forms
{
    partial class FormSetting_1
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlTitleCustom = new BookManagement.Utility.PanelCustom();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.pnlRow = new System.Windows.Forms.Panel();
            this.flpRow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle.SuspendLayout();
            this.pnlTitleCustom.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.pnlRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.pnlTitleCustom);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(10, 10);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(780, 40);
            this.pnlTitle.TabIndex = 0;
            // 
            // pnlTitleCustom
            // 
            this.pnlTitleCustom.BackColor = System.Drawing.Color.White;
            this.pnlTitleCustom.BorderRadius = 40;
            this.pnlTitleCustom.Controls.Add(this.tlpTitle);
            this.pnlTitleCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitleCustom.ForeColor = System.Drawing.Color.Black;
            this.pnlTitleCustom.GradientAngle = 120F;
            this.pnlTitleCustom.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.pnlTitleCustom.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.pnlTitleCustom.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleCustom.Name = "pnlTitleCustom";
            this.pnlTitleCustom.Size = new System.Drawing.Size(780, 40);
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
            this.tlpTitle.Size = new System.Drawing.Size(780, 40);
            this.tlpTitle.TabIndex = 0;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActive.ForeColor = System.Drawing.Color.White;
            this.lblActive.Location = new System.Drawing.Point(595, 0);
            this.lblActive.Margin = new System.Windows.Forms.Padding(0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(185, 40);
            this.lblActive.TabIndex = 4;
            this.lblActive.Text = "Actice";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(410, 0);
            this.lblType.Margin = new System.Windows.Forms.Padding(0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(185, 40);
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
            this.lblValue.Location = new System.Drawing.Point(225, 0);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(185, 40);
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
            this.lblName.Size = new System.Drawing.Size(185, 40);
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
            this.lblNo.Size = new System.Drawing.Size(40, 40);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "#";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRow
            // 
            this.pnlRow.AutoSize = true;
            this.pnlRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.pnlRow.Controls.Add(this.flpRow);
            this.pnlRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRow.Location = new System.Drawing.Point(10, 50);
            this.pnlRow.Name = "pnlRow";
            this.pnlRow.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlRow.Size = new System.Drawing.Size(780, 390);
            this.pnlRow.TabIndex = 1;
            // 
            // flpRow
            // 
            this.flpRow.AutoSize = true;
            this.flpRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRow.Location = new System.Drawing.Point(3, 0);
            this.flpRow.Margin = new System.Windows.Forms.Padding(0);
            this.flpRow.Name = "flpRow";
            this.flpRow.Size = new System.Drawing.Size(774, 390);
            this.flpRow.TabIndex = 0;
            // 
            // FormSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRow);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitleCustom.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.pnlRow.ResumeLayout(false);
            this.pnlRow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTitle;
        private Panel pnlRow;
        private Utility.PanelCustom pnlTitleCustom;
        private TableLayoutPanel tlpTitle;
        private Label lblNo;
        private Label lblActive;
        private Label lblType;
        private Label lblValue;
        private Label lblName;
        private FlowLayoutPanel flpRow;
    }
}