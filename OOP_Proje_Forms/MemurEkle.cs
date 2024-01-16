using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP_Proje_Forms
{
    public partial class MemurEkle : Form
    {
        public MemurEkle()
        {
            InitializeComponent();
        }

        public string rol;
 
        static string connection = "Server=172.21.54.148;Port=3306;Database=NYP23-6;User=NYP23-6;Password=Uludag9512357.;";
        MySqlConnection baglanti = new MySqlConnection(connection);
        
        void temizle()
        {
            txtMAdi.Text = "";
            txtMNo.Text = "";
            txtSifre.Text = "";
            txtMAdi.Focus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (rBmemur.Checked)
            {
                rol = "Fakülte Sekreteri";
            }
            else
            {
                rol = "Memur";
            }

            baglanti.Open();
            MySqlCommand mkaydet = new MySqlCommand("Insert Into memurTablo (MemurAdi, MemurNo, MemurSifre, Roller) values (@m1, @m2, @m3, @m4)", baglanti);
            mkaydet.Parameters.AddWithValue("@m1", txtMAdi.Text);
            mkaydet.Parameters.AddWithValue("@m2", txtMNo.Text);
            mkaydet.Parameters.AddWithValue("@m3", txtSifre.Text);
            mkaydet.Parameters.AddWithValue("@m4", rol);
            mkaydet.ExecuteNonQuery();
            MessageBox.Show("Memur Eklendi! ", " BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listele: Kayıtlı memurları listeler. \nGüncelle: Listeledikten sonra bilgisini güncellemek istenilen yer değiştirilip butona bas." +
                "\nSil: Silmek istediğin memurun bilgilerine tıkla ve butona bas.", "BİLGİLENDİRME PENCERESİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            using(MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From memurTablo",baglanti))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewMemur.DataSource = dt;
            }
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komutguncelle = new MySqlCommand("Update memurTablo Set MemurAdi= @a1, MemurNo=@a2, Roller=@a3, MemurSifre=@a4 where MemurId= @a5", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtMAdi.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtMNo.Text);
            komutguncelle.Parameters.AddWithValue("@a3", rol);
            komutguncelle.Parameters.AddWithValue("@a4", txtSifre.Text); 
            komutguncelle.Parameters.AddWithValue("@a5", lblMid.Text); //random bir label yazdım çünkü değer otomatik atanıyor.
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Memurun Bilgileri Güncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komutsil = new MySqlCommand("Delete From memurTablo Where MemurId=@s1", baglanti);
            komutsil.Parameters.AddWithValue("@s1", lblMid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Memur Kaydı Silindi!");
        }

        private void dataGridViewMemur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewMemur.SelectedCells[0].RowIndex;
            lblMid.Text= dataGridViewMemur.Rows[secilen].Cells[0].Value.ToString();
            txtMAdi.Text= dataGridViewMemur.Rows[secilen].Cells[1].Value.ToString();
            txtMNo.Text= dataGridViewMemur.Rows[secilen].Cells[2].Value.ToString();
            txtSifre.Text= dataGridViewMemur.Rows[secilen].Cells[3].Value.ToString();
            rol = dataGridViewMemur.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
