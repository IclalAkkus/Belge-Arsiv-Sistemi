namespace OOP_Proje_Forms
{
    partial class MemurEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemurEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtMNo = new System.Windows.Forms.TextBox();
            this.txtMAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMemur = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mySqlDataAdapterMemurEkle = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.lblMid = new System.Windows.Forms.Label();
            this.lblTorF = new System.Windows.Forms.Label();
            this.rBmemur = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.rBmemur);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.txtMNo);
            this.groupBox1.Controls.Add(this.txtMAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(29, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(477, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memur Ekleme Paneli";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(259, 201);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 39);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Memuru Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(229, 126);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 30);
            this.txtSifre.TabIndex = 4;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(301, 246);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(114, 31);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtMNo
            // 
            this.txtMNo.Location = new System.Drawing.Point(229, 90);
            this.txtMNo.Name = "txtMNo";
            this.txtMNo.Size = new System.Drawing.Size(167, 30);
            this.txtMNo.TabIndex = 2;
            // 
            // txtMAdi
            // 
            this.txtMAdi.Location = new System.Drawing.Point(229, 54);
            this.txtMAdi.Name = "txtMAdi";
            this.txtMAdi.Size = new System.Drawing.Size(167, 30);
            this.txtMAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memur Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memur Adı:";
            // 
            // dataGridViewMemur
            // 
            this.dataGridViewMemur.AllowUserToAddRows = false;
            this.dataGridViewMemur.AllowUserToDeleteRows = false;
            this.dataGridViewMemur.AllowUserToOrderColumns = true;
            this.dataGridViewMemur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemur.Location = new System.Drawing.Point(548, 61);
            this.dataGridViewMemur.Name = "dataGridViewMemur";
            this.dataGridViewMemur.ReadOnly = true;
            this.dataGridViewMemur.RowHeadersWidth = 51;
            this.dataGridViewMemur.RowTemplate.Height = 24;
            this.dataGridViewMemur.Size = new System.Drawing.Size(478, 298);
            this.dataGridViewMemur.TabIndex = 1;
            this.dataGridViewMemur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMemur_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Düzenle:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(573, 385);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(137, 31);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(722, 385);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(137, 31);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(871, 385);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(137, 31);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(426, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mySqlDataAdapterMemurEkle
            // 
            this.mySqlDataAdapterMemurEkle.DeleteCommand = null;
            this.mySqlDataAdapterMemurEkle.InsertCommand = null;
            this.mySqlDataAdapterMemurEkle.SelectCommand = null;
            this.mySqlDataAdapterMemurEkle.UpdateCommand = null;
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMid.Location = new System.Drawing.Point(159, 33);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(64, 24);
            this.lblMid.TabIndex = 13;
            this.lblMid.Text = "label5";
            this.lblMid.Visible = false;
            // 
            // lblTorF
            // 
            this.lblTorF.AutoSize = true;
            this.lblTorF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTorF.Location = new System.Drawing.Point(25, 363);
            this.lblTorF.Name = "lblTorF";
            this.lblTorF.Size = new System.Drawing.Size(64, 24);
            this.lblTorF.TabIndex = 14;
            this.lblTorF.Text = "label5";
            this.lblTorF.Visible = false;
            // 
            // rBmemur
            // 
            this.rBmemur.AutoSize = true;
            this.rBmemur.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBmemur.Location = new System.Drawing.Point(131, 165);
            this.rBmemur.Name = "rBmemur";
            this.rBmemur.Size = new System.Drawing.Size(265, 24);
            this.rBmemur.TabIndex = 7;
            this.rBmemur.TabStop = true;
            this.rBmemur.Text = "Fakülte Sekreteri olarak kaydet";
            this.rBmemur.UseVisualStyleBackColor = true;
            // 
            // MemurEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 464);
            this.Controls.Add(this.lblTorF);
            this.Controls.Add(this.lblMid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewMemur);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemurEkle";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtMNo;
        private System.Windows.Forms.TextBox txtMAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMemur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapterMemurEkle;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Label lblTorF;
        private System.Windows.Forms.RadioButton rBmemur;
    }
}