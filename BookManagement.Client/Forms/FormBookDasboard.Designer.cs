namespace BookManagement.Client.Forms;
partial class FormBookDasboard
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
            this.pnlBookDasboard = new System.Windows.Forms.Panel();
            this.ucLoadingSpiner = new BookManagement.Client.UC.ucLoadingSpiner();
            this.pnlBookDasboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBookDasboard
            // 
            this.pnlBookDasboard.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlBookDasboard.Controls.Add(this.ucLoadingSpiner);
            this.pnlBookDasboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookDasboard.Location = new System.Drawing.Point(0, 0);
            this.pnlBookDasboard.Name = "pnlBookDasboard";
            this.pnlBookDasboard.Size = new System.Drawing.Size(800, 450);
            this.pnlBookDasboard.TabIndex = 0;
            // 
            // ucLoadingSpiner
            // 
            this.ucLoadingSpiner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLoadingSpiner.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ucLoadingSpiner.Location = new System.Drawing.Point(314, 123);
            this.ucLoadingSpiner.Name = "ucLoadingSpiner";
            this.ucLoadingSpiner.Size = new System.Drawing.Size(152, 152);
            this.ucLoadingSpiner.TabIndex = 0;
            this.ucLoadingSpiner.UseWaitCursor = true;
            // 
            // FormBookDasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBookDasboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookDasboard";
            this.Text = "Book\'s Dasboard";
            this.Load += new System.EventHandler(this.FormBookDasboard_Load);
            this.pnlBookDasboard.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel pnlBookDasboard;
    private UC.ucLoadingSpiner ucLoadingSpiner;
}
