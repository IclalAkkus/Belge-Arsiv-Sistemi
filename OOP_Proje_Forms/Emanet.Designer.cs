namespace OOP_Proje_Forms
{
    partial class Emanet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVBilgi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEAl = new System.Windows.Forms.Button();
            this.lblETarih = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAlanGorevli = new System.Windows.Forms.TextBox();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridViewEmanet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblidTutucu = new System.Windows.Forms.Label();
            this.lblBosTutucu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(610, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emaneti Veren Görevli:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emanet Alan Görevli:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verilen Evrağın Bilgisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih / Saat:";
            // 
            // txtVBilgi
            // 
            this.txtVBilgi.Location = new System.Drawing.Point(277, 216);
            this.txtVBilgi.Multiline = true;
            this.txtVBilgi.Name = "txtVBilgi";
            this.txtVBilgi.Size = new System.Drawing.Size(236, 94);
            this.txtVBilgi.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnEAl);
            this.groupBox1.Controls.Add(this.lblETarih);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.txtAlanGorevli);
            this.groupBox1.Controls.Add(this.txtVBilgi);
            this.groupBox1.Controls.Add(this.btnEmanetVer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 423);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evrak Emanet Verme";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(440, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 37);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEAl
            // 
            this.btnEAl.Location = new System.Drawing.Point(270, 332);
            this.btnEAl.Name = "btnEAl";
            this.btnEAl.Size = new System.Drawing.Size(141, 57);
            this.btnEAl.TabIndex = 20;
            this.btnEAl.Text = "Evrağı Emanetten Al";
            this.btnEAl.UseVisualStyleBackColor = true;
            this.btnEAl.Click += new System.EventHandler(this.btnEAl_Click);
            // 
            // lblETarih
            // 
            this.lblETarih.AutoSize = true;
            this.lblETarih.Location = new System.Drawing.Point(277, 170);
            this.lblETarih.Name = "lblETarih";
            this.lblETarih.Size = new System.Drawing.Size(124, 24);
            this.lblETarih.TabIndex = 19;
            this.lblETarih.Text = "__.__.____";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(277, 72);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(120, 24);
            this.lblAd.TabIndex = 18;
            this.lblAd.Text = "kullanıcı adı";
            // 
            // txtAlanGorevli
            // 
            this.txtAlanGorevli.Location = new System.Drawing.Point(277, 118);
            this.txtAlanGorevli.Name = "txtAlanGorevli";
            this.txtAlanGorevli.Size = new System.Drawing.Size(186, 30);
            this.txtAlanGorevli.TabIndex = 17;
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Location = new System.Drawing.Point(101, 332);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(135, 57);
            this.btnEmanetVer.TabIndex = 15;
            this.btnEmanetVer.Text = "Evrağı Emanet Ver";
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridViewEmanet
            // 
            this.dataGridViewEmanet.AllowUserToAddRows = false;
            this.dataGridViewEmanet.AllowUserToDeleteRows = false;
            this.dataGridViewEmanet.AllowUserToOrderColumns = true;
            this.dataGridViewEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmanet.Location = new System.Drawing.Point(616, 69);
            this.dataGridViewEmanet.Name = "dataGridViewEmanet";
            this.dataGridViewEmanet.ReadOnly = true;
            this.dataGridViewEmanet.RowHeadersWidth = 51;
            this.dataGridViewEmanet.RowTemplate.Height = 24;
            this.dataGridViewEmanet.Size = new System.Drawing.Size(578, 381);
            this.dataGridViewEmanet.TabIndex = 15;
            this.dataGridViewEmanet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmanet_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Evraklar:";
            // 
            // lblidTutucu
            // 
            this.lblidTutucu.AutoSize = true;
            this.lblidTutucu.Location = new System.Drawing.Point(699, 488);
            this.lblidTutucu.Name = "lblidTutucu";
            this.lblidTutucu.Size = new System.Drawing.Size(82, 24);
            this.lblidTutucu.TabIndex = 17;
            this.lblidTutucu.Text = "000000";
            this.lblidTutucu.Visible = false;
            // 
            // lblBosTutucu
            // 
            this.lblBosTutucu.AutoSize = true;
            this.lblBosTutucu.Location = new System.Drawing.Point(836, 488);
            this.lblBosTutucu.Name = "lblBosTutucu";
            this.lblBosTutucu.Size = new System.Drawing.Size(17, 24);
            this.lblBosTutucu.TabIndex = 19;
            this.lblBosTutucu.Text = "-";
            this.lblBosTutucu.Visible = false;
            // 
            // Emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 476);
            this.Controls.Add(this.lblBosTutucu);
            this.Controls.Add(this.lblidTutucu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmanet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Emanet";
            this.Text = "Emanet";
            this.Load += new System.EventHandler(this.Emanet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVBilgi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.TextBox txtAlanGorevli;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblETarih;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewEmanet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEAl;
        private System.Windows.Forms.Label lblidTutucu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBosTutucu;
    }
}