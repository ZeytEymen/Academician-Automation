namespace StajÖdevi200130087
{
    partial class Notlar
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
            this.CboxBolum = new System.Windows.Forms.ComboBox();
            this.CboxSube = new System.Windows.Forms.ComboBox();
            this.dtList = new System.Windows.Forms.DataGridView();
            this.BtnListele = new System.Windows.Forms.Button();
            this.dtNot = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboxDers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCins = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(617, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şube :";
            // 
            // CboxBolum
            // 
            this.CboxBolum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxBolum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxBolum.FormattingEnabled = true;
            this.CboxBolum.Location = new System.Drawing.Point(490, 5);
            this.CboxBolum.Name = "CboxBolum";
            this.CboxBolum.Size = new System.Drawing.Size(121, 23);
            this.CboxBolum.TabIndex = 1;
            // 
            // CboxSube
            // 
            this.CboxSube.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxSube.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxSube.FormattingEnabled = true;
            this.CboxSube.Location = new System.Drawing.Point(673, 6);
            this.CboxSube.Name = "CboxSube";
            this.CboxSube.Size = new System.Drawing.Size(121, 23);
            this.CboxSube.TabIndex = 1;
            // 
            // dtList
            // 
            this.dtList.AllowUserToAddRows = false;
            this.dtList.AllowUserToDeleteRows = false;
            this.dtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtList.Location = new System.Drawing.Point(427, 39);
            this.dtList.Name = "dtList";
            this.dtList.ReadOnly = true;
            this.dtList.Size = new System.Drawing.Size(445, 219);
            this.dtList.TabIndex = 1;
            this.dtList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtList_CellClick);
            // 
            // BtnListele
            // 
            this.BtnListele.FlatAppearance.BorderSize = 2;
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListele.ForeColor = System.Drawing.Color.Lime;
            this.BtnListele.Location = new System.Drawing.Point(800, 5);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(74, 26);
            this.BtnListele.TabIndex = 5;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // dtNot
            // 
            this.dtNot.AllowUserToAddRows = false;
            this.dtNot.AllowUserToDeleteRows = false;
            this.dtNot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNot.Location = new System.Drawing.Point(13, 305);
            this.dtNot.Name = "dtNot";
            this.dtNot.Size = new System.Drawing.Size(855, 265);
            this.dtNot.TabIndex = 6;
            this.dtNot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNot_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCins);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.txtNot);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CboxDers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 294);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOT EKLE - GÜNCELLE - SİL";
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Image = global::StajÖdevi200130087.Properties.Resources.sil;
            this.BtnDelete.Location = new System.Drawing.Point(283, 199);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(90, 50);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Image = global::StajÖdevi200130087.Properties.Resources.guncelle;
            this.BtnUpdate.Location = new System.Drawing.Point(283, 123);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(90, 50);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.FlatAppearance.BorderSize = 0;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.Image = global::StajÖdevi200130087.Properties.Resources.ekleson;
            this.BtnEkle.Location = new System.Drawing.Point(283, 50);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(90, 50);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtNot
            // 
            this.txtNot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNot.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNot.Location = new System.Drawing.Point(92, 238);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(150, 23);
            this.txtNot.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Not :";
            // 
            // CboxDers
            // 
            this.CboxDers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxDers.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxDers.FormattingEnabled = true;
            this.CboxDers.Location = new System.Drawing.Point(92, 196);
            this.CboxDers.Name = "CboxDers";
            this.CboxDers.Size = new System.Drawing.Size(150, 23);
            this.CboxDers.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ders :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSoyad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(92, 121);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(150, 23);
            this.txtSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(92, 80);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(150, 23);
            this.txtAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad :";
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(92, 39);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(150, 23);
            this.txtNo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Numarası :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cinsiyet :";
            // 
            // txtCins
            // 
            this.txtCins.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCins.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txtCins.Location = new System.Drawing.Point(92, 158);
            this.txtCins.Name = "txtCins";
            this.txtCins.ReadOnly = true;
            this.txtCins.Size = new System.Drawing.Size(150, 23);
            this.txtCins.TabIndex = 5;
            // 
            // Notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(880, 582);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtNot);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.CboxSube);
            this.Controls.Add(this.dtList);
            this.Controls.Add(this.CboxBolum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.Notlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxBolum;
        private System.Windows.Forms.ComboBox CboxSube;
        private System.Windows.Forms.DataGridView dtList;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.DataGridView dtNot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ComboBox CboxDers;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.Label label7;
    }
}