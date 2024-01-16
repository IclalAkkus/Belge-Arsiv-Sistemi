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
    public partial class EvrakArama : Form
    {
        public EvrakArama()
        {
            InitializeComponent();
        }

        static string connection = "Server=172.21.54.148;Port=3306;Database=NYP23-6;User=NYP23-6;Password=Uludag9512357.;";
        MySqlConnection baglanti = new MySqlConnection(connection);

        private void button1_Click(object sender, EventArgs e)
        {
           
            string kayitTarihi = msTxtevrakTarihi.Text;
            string evrakTuru = cmEvrakTuru.Text;

            if(!string.IsNullOrWhiteSpace(kayitTarihi) || !string.IsNullOrWhiteSpace(evrakTuru))
            {
                baglanti.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM evrakTablo WHERE KayitTarihi LIKE @KayitTarihi AND EvrakTuru LIKE @EvrakTuru;", baglanti))
                {
                    command.Parameters.AddWithValue("@KayitTarihi", "%" + kayitTarihi + "%");
                    command.Parameters.AddWithValue("@EvrakTuru", "%" + evrakTuru + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGWListele.DataSource = dt;
                    }
                }
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Lütfen sorgulama için en az bir kriter girin!");
            }
        }

        private void EvrakArama_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From evrakTablo", baglanti))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGWListele.DataSource = dt;
            }

            using (MySqlCommand command = new MySqlCommand("SELECT EvrakTuru FROM evrakTuru;", baglanti))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmEvrakTuru.Items.Add(reader["EvrakTuru"].ToString());
                    }
                }
            }
            baglanti.Close();
        }

        private void dataGWListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGWListele.Rows.Count)
            {
                DialogResult result = MessageBox.Show("Seçilen satırı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string idTut = dataGWListele.Rows[rowIndex].Cells[0].Value.ToString();

                    // DataGridView'dan satırı kaldır
                    dataGWListele.Rows.RemoveAt(rowIndex);

                    // Veritabanından kaydı sil
                    baglanti.Open();
                    MySqlCommand komutsil = new MySqlCommand("DELETE FROM evrakTablo WHERE EvrakId = @e1", baglanti);
                    komutsil.Parameters.AddWithValue("@e1", idTut);
                    komutsil.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir satır seçin.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu sayfada evrak araması yaparak konumunu bulabilir ya da evrağın üstüne çift tıklayarak silebilirsiniz.\nArama yaparken iki arama kutusunu da doldurmak zorunda değilsiniz ama doğru yazdığınızdan emin olunuz !!", "BİLGİ",MessageBoxButtons.OK);
        }
    }
}
