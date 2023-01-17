namespace StajÖdevi200130087
{
    partial class Ekle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBolum = new System.Windows.Forms.Button();
            this.ListBolum = new System.Windows.Forms.ListBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDers = new System.Windows.Forms.Button();
            this.CboxBolum = new System.Windows.Forms.ComboBox();
            this.ListDers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDers = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBolum);
            this.groupBox1.Controls.Add(this.ListBolum);
            this.groupBox1.Controls.Add(this.txtBolum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(122, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BÖLÜM EKLE";
            // 
            // BtnBolum
            // 
            this.BtnBolum.FlatAppearance.BorderSize = 0;
            this.BtnBolum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBolum.Image = global::StajÖdevi200130087.Properties.Resources.ekleson;
            this.BtnBolum.Location = new System.Drawing.Point(416, 149);
            this.BtnBolum.Name = "BtnBolum";
            this.BtnBolum.Size = new System.Drawing.Size(90, 50);
            this.BtnBolum.TabIndex = 5;
            this.BtnBolum.UseVisualStyleBackColor = true;
            this.BtnBolum.Click += new System.EventHandler(this.BtnBolum_Click);
            // 
            // ListBolum
            // 
            this.ListBolum.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ListBolum.FormattingEnabled = true;
            this.ListBolum.ItemHeight = 19;
            this.ListBolum.Location = new System.Drawing.Point(33, 36);
            this.ListBolum.Name = "ListBolum";
            this.ListBolum.Size = new System.Drawing.Size(265, 194);
            this.ListBolum.TabIndex = 2;
            // 
            // txtBolum
            // 
            this.txtBolum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBolum.Location = new System.Drawing.Point(441, 92);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(166, 26);
            this.txtBolum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "YENİ BÖLÜM :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDers);
            this.groupBox2.Controls.Add(this.CboxBolum);
            this.groupBox2.Controls.Add(this.ListDers);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDers);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(122, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 255);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BÖLÜME DERS EKLE";
            // 
            // BtnDers
            // 
            this.BtnDers.FlatAppearance.BorderSize = 0;
            this.BtnDers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDers.Image = global::StajÖdevi200130087.Properties.Resources.ekleson;
            this.BtnDers.Location = new System.Drawing.Point(416, 169);
            this.BtnDers.Name = "BtnDers";
            this.BtnDers.Size = new System.Drawing.Size(90, 50);
            this.BtnDers.TabIndex = 5;
            this.BtnDers.UseVisualStyleBackColor = true;
            this.BtnDers.Click += new System.EventHandler(this.BtnDers_Click);
            // 
            // CboxBolum
            // 
            this.CboxBolum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CboxBolum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxBolum.FormattingEnabled = true;
            this.CboxBolum.Location = new System.Drawing.Point(117, 41);
            this.CboxBolum.Name = "CboxBolum";
            this.CboxBolum.Size = new System.Drawing.Size(146, 23);
            this.CboxBolum.TabIndex = 6;
            this.CboxBolum.SelectedIndexChanged += new System.EventHandler(this.CboxBolum_SelectedIndexChanged);
            // 
            // ListDers
            // 
            this.ListDers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ListDers.FormattingEnabled = true;
            this.ListDers.ItemHeight = 19;
            this.ListDers.Location = new System.Drawing.Point(33, 81);
            this.ListDers.Name = "ListDers";
            this.ListDers.Size = new System.Drawing.Size(265, 156);
            this.ListDers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "YENİ DERS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "BÖLÜM :";
            // 
            // txtDers
            // 
            this.txtDers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDers.Location = new System.Drawing.Point(441, 99);
            this.txtDers.Name = "txtDers";
            this.txtDers.Size = new System.Drawing.Size(166, 26);
            this.txtDers.TabIndex = 1;
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(880, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ekle";
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.Ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListBolum;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBolum;
        private System.Windows.Forms.ComboBox CboxBolum;
        private System.Windows.Forms.ListBox ListDers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDers;
        private System.Windows.Forms.Button BtnDers;
    }
}