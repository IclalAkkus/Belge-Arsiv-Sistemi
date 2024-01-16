using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OOP_Proje_Forms
{
    public partial class EvrakEkle : Form
    {
        public EvrakEkle()
        {
            InitializeComponent();
        }

        static string connection = "Server=172.21.54.148;Port=3306;Database=NYP23-6;User=NYP23-6;Password=Uludag9512357.;";
        MySqlConnection baglanti = new MySqlConnection(connection);

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmBoxETuru.Text = "";
            mskBoxTarih.Text = "";
            txtBoxAciklama.Text = "";
            txtBoxLocation.Text = "";
            cmBoxETuru.Focus();

        }

        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string yeniTur = cmBoxETuru.Text;
            if (!string.IsNullOrWhiteSpace(yeniTur))
            {
                if (!cmBoxETuru.Items.Contains(yeniTur))
                {
                    cmBoxETuru.Items.Add(yeniTur);
                    VeritabaninaEkle(yeniTur);
                }
                else
                {
                    MessageBox.Show("Bu seçenek zaten mevcut!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek girin!");
            }
            baglanti.Close();
        }
       private void VeritabaninaEkle(string yeniTur)
        {
            using (MySqlCommand com = new MySqlCommand("INSERT INTO evrakTuru (EvrakTuru) VALUES (@yeniTur)", baglanti))
            {
                com.Parameters.AddWithValue("@yeniTur", yeniTur);
                com.ExecuteNonQuery();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni evrak türü eklemek için yeni evrak türünü yazın ve ekle butonuna basın!",
                "BİLGİ PENCERESİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEKaydet_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand kaydet = new MySqlCommand("Insert Into evrakTablo (EvrakTuru, KayitTarihi, EvrakKonum, EvrakBilgi) values (@k1, @k2, @k3, @k4)", baglanti);
            kaydet.Parameters.AddWithValue("@k1", cmBoxETuru.Text);
            kaydet.Parameters.AddWithValue("@k2", mskBoxTarih.Text);
            kaydet.Parameters.AddWithValue("@k3", txtBoxLocation.Text);
            kaydet.Parameters.AddWithValue("@k4", txtBoxAciklama.Text);
            kaydet.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Evrak Eklendi!");
        }

        private void EvrakEkle_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT EvrakTuru FROM evrakTuru;", baglanti))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmBoxETuru.Items.Add(reader["EvrakTuru"].ToString());
                    }
                }
            }
            baglanti.Close();
        }

        
    }
}
