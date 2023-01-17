using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StajÖdevi200130087
{
    public partial class Devamsizlik : Form
    {
        public Devamsizlik()
        {
            InitializeComponent();
        }
        MySqlDataReader bolum;
        MySqlDataReader sube;
        MySqlDataReader ders;
        MySqlConnection _mysqlbaglan = new MySqlConnection("Server=127.1.1;Database=staj;Uid=root;Pwd='';SslMode=none;convert zero datetime=False;");//convert zero datetime=True;
        //SQL BAĞLANTISI
        public void SqlBaglan(MySqlConnection _conn)
        {
            try
            {
                _conn.Open();
                if (_conn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("MYSQL İLE BAĞLANTI KURULAMADI");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Doldur(MySqlDataReader dr, MySqlCommand cmd, string alan, ComboBox cb)
        {
            try
            {
                if (_mysqlbaglan.State == ConnectionState.Closed)
                {
                    SqlBaglan(_mysqlbaglan);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[alan]);
            }
            dr.Close();
            _mysqlbaglan.Close();

        }
        private void KayitGetir(string sorgu, DataGridView dtview)
        {
            try
            {
                if (_mysqlbaglan.State == ConnectionState.Closed)
                {
                    SqlBaglan(_mysqlbaglan);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MySqlCommand doldur = new MySqlCommand(sorgu, _mysqlbaglan);

            MySqlDataAdapter da = new MySqlDataAdapter(doldur);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtview.DataSource = dt;
            _mysqlbaglan.Close();
        }

        private void Devamsizlik_Load(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            KayitGetir("Select *from discontinuity",dtFull);
            SqlBaglan(_mysqlbaglan);
            MySqlCommand cmdBolum = new MySqlCommand("Select Name from program", _mysqlbaglan);
            MySqlCommand cmdSube = new MySqlCommand("Select Name from class", _mysqlbaglan);
            Doldur(bolum, cmdBolum, "Name", CboxBolum);
            Doldur(bolum, cmdSube, "Name", CboxSube);

        }
   
        private void BtnListele_Click(object sender, EventArgs e)
        {
            CboxDers.Text = "";
            CboxDers.Items.Clear();
            SqlBaglan(_mysqlbaglan);
            MySqlCommand cmd = new MySqlCommand("Select Lesson from lesson where Program = '" + CboxBolum.SelectedItem.ToString() + "'", _mysqlbaglan);
            Doldur(ders, cmd, "Lesson", CboxDers);
            string bolumSube = "Select *from students where Program='" + CboxBolum.Text + "' and Class = '" + CboxSube.Text + "'";
            KayitGetir(bolumSube,dtList);
            MessageBox.Show("'" + CboxBolum.Text + " Bölümü '" + CboxSube.Text + "' 'n deki \n\t\t Öğrenciler");
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dtList.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dtList.CurrentRow.Cells[1].Value.ToString();
            txtCins.Text = dtList.CurrentRow.Cells[3].Value.ToString();      
            txtBolum.Text = dtList.CurrentRow.Cells[6].Value.ToString();
      
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            MySqlCommand ekle = new MySqlCommand("INSERT INTO `discontinuity`(`StudentNo`, `Name`, `Gender`, `Program`, `Lesson`, `Tarih`) VALUES (@no,@name,@gender,@bolum,@lesson,@date)", _mysqlbaglan);
            //@no,@name,@gender,@bolum,@lesson,date
            ekle.Parameters.AddWithValue("@no",txtNo.Text);
            ekle.Parameters.AddWithValue("@name",txtAd.Text);
            ekle.Parameters.AddWithValue("@gender",txtCins.Text);
            ekle.Parameters.AddWithValue("@bolum",txtBolum.Text);
            ekle.Parameters.AddWithValue("@lesson",CboxDers.Text);
            ekle.Parameters.AddWithValue("@date",dateTimePicker1.Value);
            ekle.ExecuteNonQuery();
            KayitGetir("Select *from discontinuity",dtFull);
            MessageBox.Show("İŞLEM BAŞARILI");
        }

    }
}
