namespace OOP_Proje_Forms
{
    partial class EvrakEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvrakEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.cmBoxETuru = new System.Windows.Forms.ComboBox();
            this.mskBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.btnEKaydet = new System.Windows.Forms.Button();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.txtBoxAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnTurEkle);
            this.groupBox1.Controls.Add(this.cmBoxETuru);
            this.groupBox1.Controls.Add(this.mskBoxTarih);
            this.groupBox1.Controls.Add(this.btnEKaydet);
            this.groupBox1.Controls.Add(this.txtBoxLocation);
            this.groupBox1.Controls.Add(this.txtBoxAciklama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(34, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(588, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evrak Ekleme Paneli";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(530, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(425, 401);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(99, 31);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurEkle.Location = new System.Drawing.Point(412, 62);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(112, 66);
            this.btnTurEkle.TabIndex = 7;
            this.btnTurEkle.Text = "Evrak Türü Ekle";
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // cmBoxETuru
            // 
            this.cmBoxETuru.FormattingEnabled = true;
            this.cmBoxETuru.Location = new System.Drawing.Point(178, 79);
            this.cmBoxETuru.Name = "cmBoxETuru";
            this.cmBoxETuru.Size = new System.Drawing.Size(177, 32);
            this.cmBoxETuru.TabIndex = 1;
            // 
            // mskBoxTarih
            // 
            this.mskBoxTarih.Location = new System.Drawing.Point(178, 129);
            this.mskBoxTarih.Mask = "00/00/0000";
            this.mskBoxTarih.Name = "mskBoxTarih";
            this.mskBoxTarih.Size = new System.Drawing.Size(177, 30);
            this.mskBoxTarih.TabIndex = 2;
            this.mskBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // btnEKaydet
            // 
            this.btnEKaydet.Location = new System.Drawing.Point(345, 351);
            this.btnEKaydet.Name = "btnEKaydet";
            this.btnEKaydet.Size = new System.Drawing.Size(179, 44);
            this.btnEKaydet.TabIndex = 5;
            this.btnEKaydet.Text = "Evrağı Kaydet";
            this.btnEKaydet.UseVisualStyleBackColor = true;
            this.btnEKaydet.Click += new System.EventHandler(this.btnEKaydet_Click_1);
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(178, 177);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(177, 30);
            this.txtBoxLocation.TabIndex = 3;
            // 
            // txtBoxAciklama
            // 
            this.txtBoxAciklama.Location = new System.Drawing.Point(178, 225);
            this.txtBoxAciklama.Multiline = true;
            this.txtBoxAciklama.Name = "txtBoxAciklama";
            this.txtBoxAciklama.Size = new System.Drawing.Size(286, 105);
            this.txtBoxAciklama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Açıklaması:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arşivdeki Yeri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evrak Türü:";
            // 
            // EvrakEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 520);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EvrakEkle";
            this.Text = "EvrakEkle";
            this.Load += new System.EventHandler(this.EvrakEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTurEkle;
        private System.Windows.Forms.ComboBox cmBoxETuru;
        private System.Windows.Forms.MaskedTextBox mskBoxTarih;
        private System.Windows.Forms.Button btnEKaydet;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.TextBox txtBoxAciklama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button1;
    }
}