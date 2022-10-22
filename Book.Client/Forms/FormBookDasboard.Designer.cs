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
        this.SuspendLayout();
        // 
        // pnlBookDasboard
        // 
        this.pnlBookDasboard.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlBookDasboard.Location = new System.Drawing.Point(0, 0);
        this.pnlBookDasboard.Name = "pnlBookDasboard";
        this.pnlBookDasboard.Size = new System.Drawing.Size(800, 450);
        this.pnlBookDasboard.TabIndex = 0;
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
        this.ResumeLayout(false);

    }

    #endregion

    private Panel pnlBookDasboard;
}
