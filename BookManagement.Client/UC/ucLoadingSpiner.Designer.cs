namespace BookManagement.Client.UC
{
    partial class ucLoadingSpiner
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
            this.picLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.picLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLoader.Image = global::BookManagement.Client.Properties.Resources.loading;
            this.picLoader.Location = new System.Drawing.Point(0, 0);
            this.picLoader.Name = "pictureBox1";
            this.picLoader.Size = new System.Drawing.Size(152, 152);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 0;
            this.picLoader.TabStop = false;
            // 
            // ucLoadingSpiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(152, 152);
            this.Controls.Add(this.picLoader);
            this.Name = "ucLoadingSpiner";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private PictureBox picLoader;
    }
}
