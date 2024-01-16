using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Proje_Forms
{
    public partial class RaporFormu : Form
    {
        public RaporFormu()
        {
            InitializeComponent();
        }

        static string connection = "Server=172.21.54.148;Port=3306;Database=NYP23-6;User=NYP23-6;Password=Uludag9512357.;";
        MySqlConnection baglanti = new MySqlConnection(connection);


        private void RaporFormu_Load(object sender, EventArgs e)
        {
           baglanti.Open();

            //Evrak Turu Grafiği
            MySqlCommand grf1 = new MySqlCommand("SELECT EvrakTuru, Count(*) FROM evrakTablo group by EvrakTuru", baglanti);
            MySqlDataReader dr1 = grf1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Evrak Turu"].Points.AddXY(dr1[0], dr1[1]);
            }
           baglanti.Close();

            // Toplam Memur
            baglanti.Open();
            MySqlCommand m1 = new MySqlCommand("SELECT Count(*) FROM memurTablo Where MemurId", baglanti);
            MySqlDataReader dr2 = m1.ExecuteReader();
            while (dr2.Read())
            {
                lblMemur.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // Toplam Evrak
            baglanti.Open();
            MySqlCommand m2 = new MySqlCommand("Select Count(*) FROM evrakTablo Where EvrakId", baglanti);
            MySqlDataReader dr3 = m2.ExecuteReader();
            while (dr3.Read())
            {
                lblEvrak.Text = dr3[0].ToString();  
            }
            baglanti.Close();

            //Toplam Emanet
            baglanti.Open();
            MySqlCommand m3 = new MySqlCommand("Select Count(*) FROM emanetTablo Where EmanetId", baglanti);
            MySqlDataReader dr4 = m3.ExecuteReader();
            while (dr4.Read())
            {
                lblEmanet.Text = dr4[0].ToString();
            }
            baglanti.Close();


        }
    }
}
