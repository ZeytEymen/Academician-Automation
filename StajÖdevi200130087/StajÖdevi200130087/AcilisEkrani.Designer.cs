namespace StajÖdevi200130087
{
    partial class AcilisEkrani
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
            this.components = new System.ComponentModel.Container();
            this.acilisBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.acilisBox)).BeginInit();
            this.SuspendLayout();
            // 
            // acilisBox
            // 
            this.acilisBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acilisBox.Image = global::StajÖdevi200130087.Properties.Resources.acilis;
            this.acilisBox.Location = new System.Drawing.Point(0, 0);
            this.acilisBox.Name = "acilisBox";
            this.acilisBox.Size = new System.Drawing.Size(690, 458);
            this.acilisBox.TabIndex = 0;
            this.acilisBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.Location = new System.Drawing.Point(203, 415);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 19);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Bell Gothic Std Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(320, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // AcilisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.acilisBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcilisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcilisEkrani";
            this.Load += new System.EventHandler(this.AcilisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acilisBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox acilisBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}