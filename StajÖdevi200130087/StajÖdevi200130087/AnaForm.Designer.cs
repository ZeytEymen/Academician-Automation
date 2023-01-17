namespace StajÖdevi200130087
{
    partial class AnaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnKucult = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnOgrenci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnHakkinda = new System.Windows.Forms.Button();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.BtnYeni = new System.Windows.Forms.Button();
            this.BtnNotİslem = new System.Windows.Forms.Button();
            this.BtnGrafik = new System.Windows.Forms.Button();
            this.BtnDevamsizlik = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label1.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "AKADEMİSYEN NOT TAKİP OTOMASYONU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "200130087";
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.Transparent;
            this.BtnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKapat.FlatAppearance.BorderSize = 0;
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapat.Image = global::StajÖdevi200130087.Properties.Resources.kapat;
            this.BtnKapat.Location = new System.Drawing.Point(1005, 10);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(35, 35);
            this.BtnKapat.TabIndex = 2;
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnKucult
            // 
            this.BtnKucult.BackColor = System.Drawing.Color.Transparent;
            this.BtnKucult.BackgroundImage = global::StajÖdevi200130087.Properties.Resources.daralt;
            this.BtnKucult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKucult.FlatAppearance.BorderSize = 0;
            this.BtnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKucult.Location = new System.Drawing.Point(965, 13);
            this.BtnKucult.Name = "BtnKucult";
            this.BtnKucult.Size = new System.Drawing.Size(30, 30);
            this.BtnKucult.TabIndex = 3;
            this.BtnKucult.UseVisualStyleBackColor = false;
            this.BtnKucult.Click += new System.EventHandler(this.BtnKucult_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.BtnKucult);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.BtnKapat);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1050, 65);
            this.panelTop.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.BtnOgrenci);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.BtnHakkinda);
            this.panelMenu.Controls.Add(this.BtnDuyuru);
            this.panelMenu.Controls.Add(this.BtnYeni);
            this.panelMenu.Controls.Add(this.BtnNotİslem);
            this.panelMenu.Controls.Add(this.BtnGrafik);
            this.panelMenu.Controls.Add(this.BtnDevamsizlik);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 65);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(167, 585);
            this.panelMenu.TabIndex = 5;
            // 
            // BtnOgrenci
            // 
            this.BtnOgrenci.FlatAppearance.BorderSize = 0;
            this.BtnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOgrenci.Image = global::StajÖdevi200130087.Properties.Resources.ogrenciler;
            this.BtnOgrenci.Location = new System.Drawing.Point(3, 184);
            this.BtnOgrenci.Name = "BtnOgrenci";
            this.BtnOgrenci.Size = new System.Drawing.Size(162, 48);
            this.BtnOgrenci.TabIndex = 0;
            this.BtnOgrenci.UseVisualStyleBackColor = true;
            this.BtnOgrenci.Click += new System.EventHandler(this.BtnOgrenci_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "MENÜ";
            // 
            // BtnHakkinda
            // 
            this.BtnHakkinda.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnHakkinda.FlatAppearance.BorderSize = 0;
            this.BtnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHakkinda.Image = global::StajÖdevi200130087.Properties.Resources.hakkında;
            this.BtnHakkinda.Location = new System.Drawing.Point(3, 523);
            this.BtnHakkinda.Name = "BtnHakkinda";
            this.BtnHakkinda.Size = new System.Drawing.Size(162, 48);
            this.BtnHakkinda.TabIndex = 4;
            this.BtnHakkinda.UseVisualStyleBackColor = true;
            this.BtnHakkinda.Click += new System.EventHandler(this.BtnHakkinda_Click);
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDuyuru.FlatAppearance.BorderSize = 0;
            this.BtnDuyuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDuyuru.Image = global::StajÖdevi200130087.Properties.Resources.duyuru;
            this.BtnDuyuru.Location = new System.Drawing.Point(3, 116);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(162, 48);
            this.BtnDuyuru.TabIndex = 0;
            this.BtnDuyuru.UseVisualStyleBackColor = true;
            this.BtnDuyuru.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // BtnYeni
            // 
            this.BtnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYeni.FlatAppearance.BorderSize = 0;
            this.BtnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYeni.Image = global::StajÖdevi200130087.Properties.Resources.ayar1;
            this.BtnYeni.Location = new System.Drawing.Point(3, 455);
            this.BtnYeni.Name = "BtnYeni";
            this.BtnYeni.Size = new System.Drawing.Size(162, 48);
            this.BtnYeni.TabIndex = 3;
            this.BtnYeni.UseVisualStyleBackColor = true;
            this.BtnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // BtnNotİslem
            // 
            this.BtnNotİslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNotİslem.FlatAppearance.BorderSize = 0;
            this.BtnNotİslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotİslem.Image = global::StajÖdevi200130087.Properties.Resources.notislem;
            this.BtnNotİslem.Location = new System.Drawing.Point(3, 252);
            this.BtnNotİslem.Name = "BtnNotİslem";
            this.BtnNotİslem.Size = new System.Drawing.Size(162, 48);
            this.BtnNotİslem.TabIndex = 0;
            this.BtnNotİslem.UseVisualStyleBackColor = true;
            this.BtnNotİslem.Click += new System.EventHandler(this.BtnNotİslem_Click);
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrafik.FlatAppearance.BorderSize = 0;
            this.BtnGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrafik.Image = global::StajÖdevi200130087.Properties.Resources.GRAFİKLER;
            this.BtnGrafik.Location = new System.Drawing.Point(3, 387);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(162, 48);
            this.BtnGrafik.TabIndex = 2;
            this.BtnGrafik.UseVisualStyleBackColor = true;
            this.BtnGrafik.Click += new System.EventHandler(this.BtnGrafik_Click);
            // 
            // BtnDevamsizlik
            // 
            this.BtnDevamsizlik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDevamsizlik.FlatAppearance.BorderSize = 0;
            this.BtnDevamsizlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDevamsizlik.Image = global::StajÖdevi200130087.Properties.Resources.yoklama;
            this.BtnDevamsizlik.Location = new System.Drawing.Point(3, 319);
            this.BtnDevamsizlik.Name = "BtnDevamsizlik";
            this.BtnDevamsizlik.Size = new System.Drawing.Size(162, 48);
            this.BtnDevamsizlik.TabIndex = 1;
            this.BtnDevamsizlik.UseVisualStyleBackColor = true;
            this.BtnDevamsizlik.Click += new System.EventHandler(this.BtnDevamsizlik_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(167, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(883, 585);
            this.panelMain.TabIndex = 6;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::StajÖdevi200130087.Properties.Resources.ArkaPlan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnKucult;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button BtnHakkinda;
        private System.Windows.Forms.Button BtnDuyuru;
        private System.Windows.Forms.Button BtnYeni;
        private System.Windows.Forms.Button BtnNotİslem;
        private System.Windows.Forms.Button BtnGrafik;
        private System.Windows.Forms.Button BtnDevamsizlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOgrenci;
    }
}

