namespace OOP_Proje_Forms
{
    partial class ArayuzFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArayuzFormu));
            this.ArayuzPaneli = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkindaMesaji = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiEdinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEvrakArama = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmanetAlVer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTeslimAlVer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmanetList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEvrakEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMemurEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArayuzPaneli
            // 
            this.ArayuzPaneli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ArayuzPaneli.BackgroundImage")));
            this.ArayuzPaneli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArayuzPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArayuzPaneli.Location = new System.Drawing.Point(0, 0);
            this.ArayuzPaneli.Name = "ArayuzPaneli";
            this.ArayuzPaneli.Size = new System.Drawing.Size(1350, 681);
            this.ArayuzPaneli.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkindaMesaji,
            this.menuEvrakArama,
            this.menuEmanetAlVer,
            this.menuEvrakEkle,
            this.menuRapor,
            this.menuMemurEkle,
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hakkindaMesaji
            // 
            this.hakkindaMesaji.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgiEdinToolStripMenuItem,
            this.yenileToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.hakkindaMesaji.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hakkindaMesaji.Name = "hakkindaMesaji";
            this.hakkindaMesaji.Size = new System.Drawing.Size(282, 28);
            this.hakkindaMesaji.Text = "UYGULAMA HAKKINDA";
            // 
            // bilgiEdinToolStripMenuItem
            // 
            this.bilgiEdinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bilgiEdinToolStripMenuItem.Image")));
            this.bilgiEdinToolStripMenuItem.Name = "bilgiEdinToolStripMenuItem";
            this.bilgiEdinToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bilgiEdinToolStripMenuItem.Text = "Bilgi Edin";
            this.bilgiEdinToolStripMenuItem.Click += new System.EventHandler(this.bilgiEdinToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yenileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yenileToolStripMenuItem.Image")));
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışYapToolStripMenuItem.Image")));
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // menuEvrakArama
            // 
            this.menuEvrakArama.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEvrakArama.Name = "menuEvrakArama";
            this.menuEvrakArama.Size = new System.Drawing.Size(169, 28);
            this.menuEvrakArama.Text = "|  EVRAK ARA";
            this.menuEvrakArama.Click += new System.EventHandler(this.menuEvrakArama_Click_1);
            // 
            // menuEmanetAlVer
            // 
            this.menuEmanetAlVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTeslimAlVer,
            this.menuEmanetList});
            this.menuEmanetAlVer.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEmanetAlVer.Name = "menuEmanetAlVer";
            this.menuEmanetAlVer.Size = new System.Drawing.Size(316, 28);
            this.menuEmanetAlVer.Text = "|  EVRAK EMANET AL / VER";
            // 
            // menuTeslimAlVer
            // 
            this.menuTeslimAlVer.Image = ((System.Drawing.Image)(resources.GetObject("menuTeslimAlVer.Image")));
            this.menuTeslimAlVer.Name = "menuTeslimAlVer";
            this.menuTeslimAlVer.Size = new System.Drawing.Size(310, 28);
            this.menuTeslimAlVer.Text = "Teslim Verme / Alma";
            this.menuTeslimAlVer.Click += new System.EventHandler(this.menuTeslimAlVer_Click);
            // 
            // menuEmanetList
            // 
            this.menuEmanetList.Image = ((System.Drawing.Image)(resources.GetObject("menuEmanetList.Image")));
            this.menuEmanetList.Name = "menuEmanetList";
            this.menuEmanetList.Size = new System.Drawing.Size(310, 28);
            this.menuEmanetList.Text = "Emanet Listesi";
            this.menuEmanetList.Click += new System.EventHandler(this.menuEmanetList_Click);
            // 
            // menuEvrakEkle
            // 
            this.menuEvrakEkle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEvrakEkle.Name = "menuEvrakEkle";
            this.menuEvrakEkle.Size = new System.Drawing.Size(181, 28);
            this.menuEvrakEkle.Text = "|  EVRAK EKLE";
            this.menuEvrakEkle.Click += new System.EventHandler(this.menuEvrakEkle_Click);
            // 
            // menuRapor
            // 
            this.menuRapor.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRapor.Name = "menuRapor";
            this.menuRapor.Size = new System.Drawing.Size(124, 28);
            this.menuRapor.Text = "|   RAPOR";
            this.menuRapor.Click += new System.EventHandler(this.menuRapor_Click);
            // 
            // menuMemurEkle
            // 
            this.menuMemurEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuMemurEkle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMemurEkle.Name = "menuMemurEkle";
            this.menuMemurEkle.Size = new System.Drawing.Size(194, 28);
            this.menuMemurEkle.Text = "|  MEMUR EKLE";
            this.menuMemurEkle.Click += new System.EventHandler(this.menuMemurEkle_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 28);
            // 
            // ArayuzFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ArayuzPaneli);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "ArayuzFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArayuzFormu";
            this.Load += new System.EventHandler(this.ArayuzFormu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ArayuzPaneli;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkindaMesaji;
        private System.Windows.Forms.ToolStripMenuItem menuEvrakArama;
        private System.Windows.Forms.ToolStripMenuItem menuEmanetAlVer;
        private System.Windows.Forms.ToolStripMenuItem menuTeslimAlVer;
        private System.Windows.Forms.ToolStripMenuItem menuEmanetList;
        private System.Windows.Forms.ToolStripMenuItem menuEvrakEkle;
        private System.Windows.Forms.ToolStripMenuItem menuRapor;
        private System.Windows.Forms.ToolStripMenuItem menuMemurEkle;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiEdinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}