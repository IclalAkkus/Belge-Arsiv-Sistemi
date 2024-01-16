using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace OOP_Proje_Forms
{
    public partial class GirisFormu : Form
    {

        public GirisFormu()
        {
            InitializeComponent();


        }
        static string connection = "Server=172.21.54.148;Port=3306;Database=NYP23-6;User=NYP23-6;Password=Uludag9512357.;";
        MySqlConnection baglanti = new MySqlConnection(connection);


        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı bağlı değil! Bağlan!", "UYARI", MessageBoxButtons.OK);
                throw;
            }
           
            MySqlCommand girisM = new MySqlCommand("SELECT MemurAdi, MemurNo, MemurSifre, Roller FROM memurTablo WHERE MemurAdi=@m1 AND MemurNo=@m2 AND MemurSifre=@m3 ", baglanti);
            girisM.Parameters.AddWithValue("@m1", txtAdi.Text);
            girisM.Parameters.AddWithValue("@m2", txtNo.Text);
            girisM.Parameters.AddWithValue("@m3", txtSifre.Text);
             MySqlDataReader Mreader = girisM.ExecuteReader();
            if (Mreader.Read())
            {
                ArayuzFormu arayuzf = new ArayuzFormu();
                MemurEkle m = new MemurEkle();
                m.rol = Mreader["Roller"].ToString();
                if(m.rol == "Memur")
                {
                    arayuzf.gorunurluk = false;
                }
                else
                {
                    arayuzf.gorunurluk = true;
                }
                arayuzf.girisAdi = txtAdi.Text;
                arayuzf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı girişi ya da şifre !!", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Mreader.Close();
            baglanti.Close();
        }
    }
}
