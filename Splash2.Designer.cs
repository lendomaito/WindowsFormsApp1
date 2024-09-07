namespace WindowsFormsApp1
{
    partial class Splash2
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
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Location = new System.Drawing.Point(135, 41);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(35, 13);
            this.labelMessage2.TabIndex = 0;
            this.labelMessage2.Text = "label1";
            // 
            // Splash2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 294);
            this.Controls.Add(this.labelMessage2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash2";
            this.Text = "Splash2";
            this.Load += new System.EventHandler(this.Splash2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage2;
    }
}