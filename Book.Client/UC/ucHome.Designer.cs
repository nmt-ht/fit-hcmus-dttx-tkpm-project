namespace BookManagement.Client.UC;
partial class ucHome
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
        this.label1 = new System.Windows.Forms.Label();
        this.lblTime = new System.Windows.Forms.Label();
        this.lblDate = new System.Windows.Forms.Label();
        this.panel1 = new System.Windows.Forms.Panel();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = global::BookManagement.Client.Properties.Resources.book_dasboard;
        this.pictureBox1.Location = new System.Drawing.Point(73, 19);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(263, 256);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
        this.label1.Location = new System.Drawing.Point(6, 287);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(397, 47);
        this.label1.TabIndex = 1;
        this.label1.Text = "Book Management";
        // 
        // lblTime
        // 
        this.lblTime.AutoSize = true;
        this.lblTime.Font = new System.Drawing.Font("Niagara Engraved", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblTime.ForeColor = System.Drawing.Color.White;
        this.lblTime.Location = new System.Drawing.Point(148, 396);
        this.lblTime.Name = "lblTime";
        this.lblTime.Size = new System.Drawing.Size(113, 57);
        this.lblTime.TabIndex = 2;
        this.lblTime.Text = "Timing";
        // 
        // lblDate
        // 
        this.lblDate.AutoSize = true;
        this.lblDate.Font = new System.Drawing.Font("Niagara Engraved", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblDate.ForeColor = System.Drawing.Color.White;
        this.lblDate.Location = new System.Drawing.Point(73, 357);
        this.lblDate.Name = "lblDate";
        this.lblDate.Size = new System.Drawing.Size(59, 43);
        this.lblDate.TabIndex = 3;
        this.lblDate.Text = "Date";
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.pictureBox1);
        this.panel1.Controls.Add(this.lblDate);
        this.panel1.Controls.Add(this.lblTime);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(410, 482);
        this.panel1.TabIndex = 4;
        // 
        // ucHome
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.panel1);
        this.Name = "ucHome";
        this.Size = new System.Drawing.Size(410, 482);
        this.Load += new System.EventHandler(this.ucDasboard_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Label lblTime;
    private Label lblDate;
    private Panel panel1;
}
