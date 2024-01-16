using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Proje_Forms
{
    public partial class ArayuzFormu : Form
    {
        public ArayuzFormu()
        {
            InitializeComponent();
        }
        public Boolean gorunurluk;

        static string connection = "Server=172.21.54.148;Port=3306;Database=NYP23-6;User=NYP23-6;Password=Uludag9512357.;";
        MySqlConnection baglanti = new MySqlConnection(connection);

        private void FormuGetir(Form frm)
        {
            ArayuzPaneli.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new System.Drawing.Point(
             (ArayuzPaneli.Width - frm.Width) / 2,
             (ArayuzPaneli.Height - frm.Height) / 2);
            ArayuzPaneli.Controls.Add(frm);
            frm.Show();
        }

        private void menuEvrakArama_Click_1(object sender, EventArgs e)
        {
            EvrakArama arama = new EvrakArama();
            FormuGetir(arama);
        }

        public string girisAdi;

        private void menuTeslimAlVer_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet();
            emanet.kulaniciAdi= girisAdi;
            FormuGetir(emanet);

        }

        private void menuEmanetList_Click(object sender, EventArgs e)
        {
            EmanetList eList = new EmanetList();
            FormuGetir(eList);
        }

        private void menuEvrakEkle_Click(object sender, EventArgs e)
        {
            EvrakEkle eEkle = new EvrakEkle();
            FormuGetir(eEkle);
        }

        private void bilgiEdinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Uludağ Üniversitesi İnegöl İşletme Fakültesi'nin Belge Arşiv Yönetim Sistemi'dir. \nBu uygulama ile evraklar hakkındaki bilgilere ulaşabilirsiniz, evrak emanet verebilirsiniz, yeni evrak kayıtları yapabilirsiniz " +
              "ya da evrağın arşivdeki yerine ulaşabilirsiniz.", "Uygulama Hakkındaki Bilgi Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuRapor_Click(object sender, EventArgs e)
        {
            RaporFormu raporFormu = new RaporFormu();
            FormuGetir(raporFormu);
        }

        private void ArayuzFormu_Load(object sender, EventArgs e)
        {
            menuMemurEkle.Enabled = true;
            menuMemurEkle.Enabled = gorunurluk;

        }

        private void menuMemurEkle_Click(object sender, EventArgs e)
        {
            MemurEkle mEkle = new MemurEkle();
            FormuGetir(mEkle);


        }
    }   
}
