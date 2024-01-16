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
    public partial class EmanetList : Form
    {
        public EmanetList()
        {
            InitializeComponent();
        }

        static string connection = "Server=172.21.54.148;Port=3306;Database=NYP23-6;User=NYP23-6;Password=Uludag9512357.;";
        MySqlConnection baglanti = new MySqlConnection(connection);

        private void dataGridViewEmanetListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("BU ALANDA İŞLEM YAPILMAZ !", "BİLGİ KUTUSU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EmanetList_Load(object sender, EventArgs e)
        {
            //Emanet edilip teslim edilmiş evraklar listelensin.
            baglanti.Open();
            

            using (MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From emanetTablo", baglanti))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEmanetListesi.DataSource = dt;
            }
            baglanti.Close();

        }
    }
}
