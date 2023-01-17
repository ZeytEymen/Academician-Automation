namespace StajÖdevi200130087
{
    partial class Duyurular
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.ListOfMail = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnMailGonder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CboxCinsSec = new System.Windows.Forms.ComboBox();
            this.CboxSubeSec = new System.Windows.Forms.ComboBox();
            this.CboxBolumSec = new System.Windows.Forms.ComboBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.txtMailler = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONU : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "İÇERİK : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "GÖNDERİLECEK ADRESLER";
            // 
            // TxtSubject
            // 
            this.TxtSubject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubject.ForeColor = System.Drawing.Color.Black;
            this.TxtSubject.Location = new System.Drawing.Point(495, 12);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(359, 26);
            this.TxtSubject.TabIndex = 1;
            // 
            // TxtContent
            // 
            this.TxtContent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContent.Location = new System.Drawing.Point(495, 62);
            this.TxtContent.Multiline = true;
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(359, 197);
            this.TxtContent.TabIndex = 1;
            // 
            // ListOfMail
            // 
            this.ListOfMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.ListOfMail.FormattingEnabled = true;
            this.ListOfMail.Location = new System.Drawing.Point(25, 139);
            this.ListOfMail.Name = "ListOfMail";
            this.ListOfMail.Size = new System.Drawing.Size(366, 173);
            this.ListOfMail.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(829, 211);
            this.dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "ESKİ DUYURULAR";
            // 
            // BtnMailGonder
            // 
            this.BtnMailGonder.FlatAppearance.BorderSize = 0;
            this.BtnMailGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailGonder.Image = global::StajÖdevi200130087.Properties.Resources.gonder;
            this.BtnMailGonder.Location = new System.Drawing.Point(621, 280);
            this.BtnMailGonder.Name = "BtnMailGonder";
            this.BtnMailGonder.Size = new System.Drawing.Size(127, 57);
            this.BtnMailGonder.TabIndex = 2;
            this.BtnMailGonder.UseVisualStyleBackColor = true;
            this.BtnMailGonder.Click += new System.EventHandler(this.BtnMailGonder_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şube :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Bölüm :";
            // 
            // CboxCinsSec
            // 
            this.CboxCinsSec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxCinsSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxCinsSec.FormattingEnabled = true;
            this.CboxCinsSec.Location = new System.Drawing.Point(118, 84);
            this.CboxCinsSec.Name = "CboxCinsSec";
            this.CboxCinsSec.Size = new System.Drawing.Size(124, 23);
            this.CboxCinsSec.TabIndex = 7;
            // 
            // CboxSubeSec
            // 
            this.CboxSubeSec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxSubeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxSubeSec.FormattingEnabled = true;
            this.CboxSubeSec.Location = new System.Drawing.Point(258, 46);
            this.CboxSubeSec.Name = "CboxSubeSec";
            this.CboxSubeSec.Size = new System.Drawing.Size(130, 23);
            this.CboxSubeSec.TabIndex = 8;
            // 
            // CboxBolumSec
            // 
            this.CboxBolumSec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxBolumSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxBolumSec.FormattingEnabled = true;
            this.CboxBolumSec.Location = new System.Drawing.Point(65, 46);
            this.CboxBolumSec.Name = "CboxBolumSec";
            this.CboxBolumSec.Size = new System.Drawing.Size(143, 23);
            this.CboxBolumSec.TabIndex = 9;
            // 
            // BtnListele
            // 
            this.BtnListele.FlatAppearance.BorderSize = 2;
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListele.ForeColor = System.Drawing.Color.Lime;
            this.BtnListele.Location = new System.Drawing.Point(282, 84);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(106, 26);
            this.BtnListele.TabIndex = 13;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // txtMailler
            // 
            this.txtMailler.Location = new System.Drawing.Point(312, 318);
            this.txtMailler.Name = "txtMailler";
            this.txtMailler.Size = new System.Drawing.Size(162, 20);
            this.txtMailler.TabIndex = 14;
            this.txtMailler.Visible = false;
            // 
            // Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(880, 582);
            this.Controls.Add(this.txtMailler);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CboxCinsSec);
            this.Controls.Add(this.CboxSubeSec);
            this.Controls.Add(this.CboxBolumSec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListOfMail);
            this.Controls.Add(this.BtnMailGonder);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Duyurular";
            this.Text = "Duyurular";
            this.Load += new System.EventHandler(this.Duyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.TextBox TxtContent;
        private System.Windows.Forms.Button BtnMailGonder;
        private System.Windows.Forms.ListBox ListOfMail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboxCinsSec;
        private System.Windows.Forms.ComboBox CboxSubeSec;
        private System.Windows.Forms.ComboBox CboxBolumSec;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox txtMailler;
    }
}