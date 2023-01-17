namespace StajÖdevi200130087
{
    partial class Devamsizlik
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
            this.BtnListele = new System.Windows.Forms.Button();
            this.CboxSube = new System.Windows.Forms.ComboBox();
            this.dtList = new System.Windows.Forms.DataGridView();
            this.CboxBolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboxDers = new System.Windows.Forms.ComboBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFull = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFull)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.Transparent;
            this.BtnListele.FlatAppearance.BorderSize = 2;
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListele.ForeColor = System.Drawing.Color.Lime;
            this.BtnListele.Location = new System.Drawing.Point(581, 61);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(106, 26);
            this.BtnListele.TabIndex = 11;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // CboxSube
            // 
            this.CboxSube.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxSube.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxSube.FormattingEnabled = true;
            this.CboxSube.Location = new System.Drawing.Point(692, 20);
            this.CboxSube.Name = "CboxSube";
            this.CboxSube.Size = new System.Drawing.Size(121, 23);
            this.CboxSube.TabIndex = 8;
            // 
            // dtList
            // 
            this.dtList.AllowUserToAddRows = false;
            this.dtList.AllowUserToDeleteRows = false;
            this.dtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtList.Location = new System.Drawing.Point(409, 94);
            this.dtList.Name = "dtList";
            this.dtList.ReadOnly = true;
            this.dtList.Size = new System.Drawing.Size(445, 203);
            this.dtList.TabIndex = 9;
            this.dtList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtList_CellClick);
            // 
            // CboxBolum
            // 
            this.CboxBolum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxBolum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxBolum.FormattingEnabled = true;
            this.CboxBolum.Location = new System.Drawing.Point(500, 20);
            this.CboxBolum.Name = "CboxBolum";
            this.CboxBolum.Size = new System.Drawing.Size(121, 23);
            this.CboxBolum.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(636, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şube :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(433, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bölüm :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxDers);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBolum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCins);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 287);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEVAMSIZLIK";
            // 
            // CboxDers
            // 
            this.CboxDers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxDers.FormattingEnabled = true;
            this.CboxDers.Location = new System.Drawing.Point(91, 183);
            this.CboxDers.Name = "CboxDers";
            this.CboxDers.Size = new System.Drawing.Size(233, 27);
            this.CboxDers.TabIndex = 14;
            // 
            // BtnEkle
            // 
            this.BtnEkle.FlatAppearance.BorderSize = 0;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.Image = global::StajÖdevi200130087.Properties.Resources.ekleson;
            this.BtnEkle.Location = new System.Drawing.Point(250, 225);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(90, 50);
            this.BtnEkle.TabIndex = 13;
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ders :";
            // 
            // txtBolum
            // 
            this.txtBolum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBolum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBolum.Location = new System.Drawing.Point(91, 145);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.ReadOnly = true;
            this.txtBolum.Size = new System.Drawing.Size(233, 23);
            this.txtBolum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bölüm :";
            // 
            // txtCins
            // 
            this.txtCins.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCins.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCins.Location = new System.Drawing.Point(91, 106);
            this.txtCins.Name = "txtCins";
            this.txtCins.ReadOnly = true;
            this.txtCins.Size = new System.Drawing.Size(233, 23);
            this.txtCins.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cinsiyet :";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(91, 69);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(233, 23);
            this.txtAd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad :";
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(91, 35);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(233, 23);
            this.txtNo.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Numarası :";
            // 
            // dtFull
            // 
            this.dtFull.AllowUserToAddRows = false;
            this.dtFull.AllowUserToDeleteRows = false;
            this.dtFull.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFull.Location = new System.Drawing.Point(12, 314);
            this.dtFull.Name = "dtFull";
            this.dtFull.ReadOnly = true;
            this.dtFull.Size = new System.Drawing.Size(856, 256);
            this.dtFull.TabIndex = 13;
            // 
            // Devamsizlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(880, 582);
            this.Controls.Add(this.dtFull);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.CboxSube);
            this.Controls.Add(this.dtList);
            this.Controls.Add(this.CboxBolum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devamsizlik";
            this.Text = "Devamsizlik";
            this.Load += new System.EventHandler(this.Devamsizlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.ComboBox CboxSube;
        private System.Windows.Forms.DataGridView dtList;
        private System.Windows.Forms.ComboBox CboxBolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dtFull;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboxDers;
    }
}