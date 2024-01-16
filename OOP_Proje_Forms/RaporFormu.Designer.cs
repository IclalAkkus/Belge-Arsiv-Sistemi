namespace OOP_Proje_Forms
{
    partial class RaporFormu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMemur = new System.Windows.Forms.Label();
            this.lblEvrak = new System.Windows.Forms.Label();
            this.lblEmanet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 51);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Evrak Turu";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(457, 352);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chartTurGrafigi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Evrak Türü Grafiği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(614, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "İstatistikler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Kayıtlı Emanet Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam Kayıtlı Evrak Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Toplam Kayıtlı Memur Sayısı:";
            // 
            // lblMemur
            // 
            this.lblMemur.AutoSize = true;
            this.lblMemur.Location = new System.Drawing.Point(852, 144);
            this.lblMemur.Name = "lblMemur";
            this.lblMemur.Size = new System.Drawing.Size(22, 24);
            this.lblMemur.TabIndex = 8;
            this.lblMemur.Text = "0";
            // 
            // lblEvrak
            // 
            this.lblEvrak.AutoSize = true;
            this.lblEvrak.Location = new System.Drawing.Point(852, 105);
            this.lblEvrak.Name = "lblEvrak";
            this.lblEvrak.Size = new System.Drawing.Size(22, 24);
            this.lblEvrak.TabIndex = 9;
            this.lblEvrak.Text = "0";
            // 
            // lblEmanet
            // 
            this.lblEmanet.AutoSize = true;
            this.lblEmanet.Location = new System.Drawing.Point(852, 66);
            this.lblEmanet.Name = "lblEmanet";
            this.lblEmanet.Size = new System.Drawing.Size(22, 24);
            this.lblEmanet.TabIndex = 10;
            this.lblEmanet.Text = "0";
            // 
            // RaporFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1026, 423);
            this.Controls.Add(this.lblEmanet);
            this.Controls.Add(this.lblEvrak);
            this.Controls.Add(this.lblMemur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaporFormu";
            this.Text = "RaporFormu";
            this.Load += new System.EventHandler(this.RaporFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMemur;
        private System.Windows.Forms.Label lblEvrak;
        private System.Windows.Forms.Label lblEmanet;
    }
}