namespace OOP_Proje_Forms
{
    partial class EvrakArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvrakArama));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGWListele = new System.Windows.Forms.DataGridView();
            this.cmEvrakTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msTxtevrakTarihi = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWListele)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(738, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 37);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGWListele
            // 
            this.dataGWListele.AllowUserToAddRows = false;
            this.dataGWListele.AllowUserToDeleteRows = false;
            this.dataGWListele.AllowUserToOrderColumns = true;
            this.dataGWListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGWListele.Location = new System.Drawing.Point(32, 58);
            this.dataGWListele.Name = "dataGWListele";
            this.dataGWListele.ReadOnly = true;
            this.dataGWListele.RowHeadersWidth = 51;
            this.dataGWListele.RowTemplate.Height = 24;
            this.dataGWListele.Size = new System.Drawing.Size(847, 524);
            this.dataGWListele.TabIndex = 2;
            this.dataGWListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGWListele_CellContentClick);
            // 
            // cmEvrakTuru
            // 
            this.cmEvrakTuru.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmEvrakTuru.FormattingEnabled = true;
            this.cmEvrakTuru.Location = new System.Drawing.Point(555, 13);
            this.cmEvrakTuru.Name = "cmEvrakTuru";
            this.cmEvrakTuru.Size = new System.Drawing.Size(147, 32);
            this.cmEvrakTuru.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(423, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Evrak Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(142, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Evrak Tarihi:";
            // 
            // msTxtevrakTarihi
            // 
            this.msTxtevrakTarihi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msTxtevrakTarihi.Location = new System.Drawing.Point(284, 14);
            this.msTxtevrakTarihi.Mask = "00/00/0000";
            this.msTxtevrakTarihi.Name = "msTxtevrakTarihi";
            this.msTxtevrakTarihi.Size = new System.Drawing.Size(124, 30);
            this.msTxtevrakTarihi.TabIndex = 11;
            this.msTxtevrakTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(833, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 31);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(256, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(575, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bu sayfayı nasıl kullanacağınızı bilgi kutucuğuna basarak öğrenebilirsiniz !";
            // 
            // EvrakArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(912, 620);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.msTxtevrakTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmEvrakTuru);
            this.Controls.Add(this.dataGWListele);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "EvrakArama";
            this.Text = "EvrakArama";
            this.Load += new System.EventHandler(this.EvrakArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGWListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGWListele;
        private System.Windows.Forms.ComboBox cmEvrakTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msTxtevrakTarihi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}