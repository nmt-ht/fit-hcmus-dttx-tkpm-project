﻿namespace BookManagement.Client.Forms;
partial class FormHome
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
            this.pnlDasboard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDasboard
            // 
            this.pnlDasboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDasboard.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlDasboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDasboard.Name = "pnlDasboard";
            this.pnlDasboard.Size = new System.Drawing.Size(738, 509);
            this.pnlDasboard.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 509);
            this.Controls.Add(this.pnlDasboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormBookDasboard_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel pnlDasboard;
}
