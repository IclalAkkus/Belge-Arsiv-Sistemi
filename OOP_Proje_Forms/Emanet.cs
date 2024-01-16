using MySql.Data.MySqlClient;
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
    public partial class Emanet : Form
    {

        public Emanet()
        {
            InitializeComponent();
        }

        static string connection = "Server=172.21.54.148;Port=3306;Database=NYP23-6;User=NYP23-6;Password=Uludag9512357.;";
        MySqlConnection baglanti = new MySqlConnection(connection);

        public string kulaniciAdi;
        
    
        private void Emanet_Load(object sender, EventArgs e)
        {
            
            lblAd.Text = kulaniciAdi;
            lblETarih.Text = DateTime.Now.ToString();
            baglanti.Open();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From emanetTablo", baglanti))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEmanet.DataSource = dt;
            }
            baglanti.Close();
        } 
        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            string bos = "-";

            baglanti.Open();
            MySqlCommand EVer = new MySqlCommand("Insert Into emanetTablo (EmanetVeren, EmanetAlan, EmanetVermeTarihi, EmanetBilgi, EmanetAlinmaTarihi) values (@v1, @v2, @v3, @v4, @v5)", baglanti);
            EVer.Parameters.AddWithValue("@v1", lblAd.Text);
            EVer.Parameters.AddWithValue("@v2", txtAlanGorevli.Text);
            EVer.Parameters.AddWithValue("@v3", lblETarih.Text);
            EVer.Parameters.AddWithValue("@v4", txtVBilgi.Text);
            EVer.Parameters.AddWithValue("@v5", bos);
            EVer.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Evrak Emanet Verildi!");

            baglanti.Open();
             
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From emanetTablo", baglanti))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEmanet.DataSource = dt;
            }
            baglanti.Close();
        }

        private void dataGridViewEmanet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewEmanet.SelectedCells[0].RowIndex;
            lblidTutucu.Text = dataGridViewEmanet.Rows[secilen].Cells[0].Value.ToString();
            txtAlanGorevli.Text = dataGridViewEmanet.Rows[secilen].Cells[2].Value.ToString();
            lblETarih.Text = dataGridViewEmanet.Rows[secilen].Cells[3].Value.ToString();
            txtVBilgi.Text = dataGridViewEmanet.Rows[secilen].Cells[4].Value.ToString();
            lblBosTutucu.Text = dataGridViewEmanet.Rows[secilen].Cells[5].Value.ToString();

        }
        

        private void btnEAl_Click(object sender, EventArgs e)
        {
            string suan = DateTime.Now.ToString();
            baglanti.Open();
            MySqlCommand geriAl = new MySqlCommand("Update emanetTablo Set EmanetVeren=@e1, EmanetAlan=@e2, EmanetVermeTarihi=@e3, EmanetBilgi=@e4, EmanetAlinmaTarihi=@e5 where EmanetId=@e6", baglanti);
            geriAl.Parameters.AddWithValue("@e1",lblAd.Text);
            geriAl.Parameters.AddWithValue("@e2",txtAlanGorevli.Text);
            geriAl.Parameters.AddWithValue("@e3",lblETarih.Text);
            geriAl.Parameters.AddWithValue("@e4",txtVBilgi.Text);
            geriAl.Parameters.AddWithValue("@e5",suan);
            geriAl.Parameters.AddWithValue("@e6",lblidTutucu.Text);
            geriAl.ExecuteNonQuery();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From emanetTablo", baglanti))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEmanet.DataSource = dt;
            }
            
            baglanti.Close() ;

            MessageBox.Show("Emanet edilen dosya teslim edildi!", "Bilgi Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAlanGorevli.Text = "";
            lblETarih.Text = DateTime.Now.ToString();
            lblBosTutucu.Text = "-";
            txtVBilgi.Text = "";
            txtAlanGorevli.Focus();

        }
    }
}
