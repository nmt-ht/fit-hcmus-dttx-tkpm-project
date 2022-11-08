namespace BookManagement.Client.Forms;
partial class FormInvoice
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
            this.pnlInvocie = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlInvocie
            // 
            this.pnlInvocie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.pnlInvocie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvocie.Location = new System.Drawing.Point(0, 0);
            this.pnlInvocie.Name = "pnlInvocie";
            this.pnlInvocie.Size = new System.Drawing.Size(800, 450);
            this.pnlInvocie.TabIndex = 0;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlInvocie);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInvoice";
            this.Text = "Invocie";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel pnlInvocie;
}
