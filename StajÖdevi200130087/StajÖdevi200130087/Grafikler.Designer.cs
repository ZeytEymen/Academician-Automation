namespace StajÖdevi200130087
{
    partial class Grafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartKizErkek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboxKizErkek = new System.Windows.Forms.ComboBox();
            this.chartOrtlama = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cBoxOrt = new System.Windows.Forms.ComboBox();
            this.BtnKizErkek = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnOrtlama = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CboxDers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartKizErkek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrtlama)).BeginInit();
            this.SuspendLayout();
            // 
            // chartKizErkek
            // 
            chartArea5.Name = "ChartArea1";
            this.chartKizErkek.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartKizErkek.Legends.Add(legend5);
            this.chartKizErkek.Location = new System.Drawing.Point(12, 231);
            this.chartKizErkek.Name = "chartKizErkek";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Seri1";
            this.chartKizErkek.Series.Add(series7);
            this.chartKizErkek.Size = new System.Drawing.Size(351, 273);
            this.chartKizErkek.TabIndex = 0;
            this.chartKizErkek.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "X Bölümündeki Kız - Erkek Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm ;";
            // 
            // CboxKizErkek
            // 
            this.CboxKizErkek.BackColor = System.Drawing.Color.Silver;
            this.CboxKizErkek.FormattingEnabled = true;
            this.CboxKizErkek.Location = new System.Drawing.Point(59, 129);
            this.CboxKizErkek.Name = "CboxKizErkek";
            this.CboxKizErkek.Size = new System.Drawing.Size(176, 21);
            this.CboxKizErkek.TabIndex = 2;
            // 
            // chartOrtlama
            // 
            chartArea6.Name = "ChartArea1";
            this.chartOrtlama.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartOrtlama.Legends.Add(legend6);
            this.chartOrtlama.Location = new System.Drawing.Point(468, 232);
            this.chartOrtlama.Name = "chartOrtlama";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Seri1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Seri2";
            this.chartOrtlama.Series.Add(series8);
            this.chartOrtlama.Series.Add(series9);
            this.chartOrtlama.Size = new System.Drawing.Size(366, 273);
            this.chartOrtlama.TabIndex = 0;
            this.chartOrtlama.Text = "chart1";
            // 
            // cBoxOrt
            // 
            this.cBoxOrt.BackColor = System.Drawing.Color.Silver;
            this.cBoxOrt.FormattingEnabled = true;
            this.cBoxOrt.Location = new System.Drawing.Point(513, 114);
            this.cBoxOrt.Name = "cBoxOrt";
            this.cBoxOrt.Size = new System.Drawing.Size(178, 21);
            this.cBoxOrt.TabIndex = 2;
            this.cBoxOrt.SelectedIndexChanged += new System.EventHandler(this.cBoxOrt_SelectedIndexChanged);
            // 
            // BtnKizErkek
            // 
            this.BtnKizErkek.FlatAppearance.BorderSize = 2;
            this.BtnKizErkek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKizErkek.ForeColor = System.Drawing.Color.Yellow;
            this.BtnKizErkek.Location = new System.Drawing.Point(251, 186);
            this.BtnKizErkek.Name = "BtnKizErkek";
            this.BtnKizErkek.Size = new System.Drawing.Size(100, 31);
            this.BtnKizErkek.TabIndex = 3;
            this.BtnKizErkek.Text = "GETİR";
            this.BtnKizErkek.UseVisualStyleBackColor = true;
            this.BtnKizErkek.Click += new System.EventHandler(this.BtnKizErkek_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(485, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "X Bölümündeki Not Ortalamaları";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(486, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bölüm ;";
            // 
            // BtnOrtlama
            // 
            this.BtnOrtlama.FlatAppearance.BorderSize = 2;
            this.BtnOrtlama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrtlama.ForeColor = System.Drawing.Color.Yellow;
            this.BtnOrtlama.Location = new System.Drawing.Point(709, 186);
            this.BtnOrtlama.Name = "BtnOrtlama";
            this.BtnOrtlama.Size = new System.Drawing.Size(100, 31);
            this.BtnOrtlama.TabIndex = 5;
            this.BtnOrtlama.Text = "GETİR";
            this.BtnOrtlama.UseVisualStyleBackColor = true;
            this.BtnOrtlama.Click += new System.EventHandler(this.BtnOrtlama_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(485, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ders ;";
            // 
            // CboxDers
            // 
            this.CboxDers.BackColor = System.Drawing.Color.Silver;
            this.CboxDers.FormattingEnabled = true;
            this.CboxDers.Location = new System.Drawing.Point(513, 165);
            this.CboxDers.Name = "CboxDers";
            this.CboxDers.Size = new System.Drawing.Size(178, 21);
            this.CboxDers.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(687, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(880, 582);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnOrtlama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnKizErkek);
            this.Controls.Add(this.CboxDers);
            this.Controls.Add(this.cBoxOrt);
            this.Controls.Add(this.CboxKizErkek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartOrtlama);
            this.Controls.Add(this.chartKizErkek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grafikler";
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartKizErkek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrtlama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartKizErkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxKizErkek;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrtlama;
        private System.Windows.Forms.ComboBox cBoxOrt;
        private System.Windows.Forms.Button BtnKizErkek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnOrtlama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboxDers;
        private System.Windows.Forms.Label label6;
    }
}