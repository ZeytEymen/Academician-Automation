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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        MySqlDataReader bolum;
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
        private void Grafikler_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            MySqlCommand doldur = new MySqlCommand("Select Name from Program", _mysqlbaglan);
            //MySqlCommand cmdDers = new MySqlCommand("Select Lesson from lesson where Program='" + cBoxOrt.SelectedItem.ToString() +"'",_mysqlbaglan);
            Doldur(bolum,doldur,"Name",CboxKizErkek);
            Doldur(bolum, doldur, "Name", cBoxOrt);
            chartKizErkek.Visible = false;
            chartOrtlama.Visible = false;
        }

        private void BtnKizErkek_Click(object sender, EventArgs e)
        {
            try
            {
                chartKizErkek.Series[0].Points.Clear();
                chartKizErkek.Titles.Clear();
                chartKizErkek.Visible = true;
                SqlBaglan(_mysqlbaglan);
                MySqlCommand kiz = new MySqlCommand("SELECT COUNT(Gender) from students WHERE Gender='KIZ' and Program='" + CboxKizErkek.SelectedItem.ToString() + "'", _mysqlbaglan);
                MySqlCommand erkek = new MySqlCommand("SELECT COUNT(Gender) from students WHERE Gender='ERKEK' and Program='" + CboxKizErkek.SelectedItem.ToString() + "'", _mysqlbaglan);
                int kizSayisi = Convert.ToInt32(kiz.ExecuteScalar().ToString());
                int erkekSayisi = Convert.ToInt32(erkek.ExecuteScalar().ToString());
                MessageBox.Show(erkekSayisi.ToString());
                chartKizErkek.Titles.Add(CboxKizErkek.SelectedItem.ToString() + " BÖLÜMÜNDEKİ KIZ VE ERKEK DAĞILIMI");
                chartKizErkek.Series["Seri1"].IsValueShownAsLabel = true;
                chartKizErkek.Series["Seri1"].Points.AddXY("ERKEKLER", erkekSayisi);
                chartKizErkek.Series["Seri1"].Points.AddXY("KIZLAR", kizSayisi);
                _mysqlbaglan.Close();

                //MessageBox.Show(sayi.ToString());
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void BtnOrtlama_Click(object sender, EventArgs e)
        {
            try
            {
                chartOrtlama.Visible = true;
                chartOrtlama.Titles.Clear();
                chartOrtlama.Series[0].Points.Clear();
                chartOrtlama.Series[1].Points.Clear();
                SqlBaglan(_mysqlbaglan);
                MySqlCommand kizOrt = new MySqlCommand("Select AVG(Note) from notes where Program='" + cBoxOrt.SelectedItem.ToString() + "' and Lesson = '" + CboxDers.SelectedItem.ToString() + "' and Gender='KIZ' ", _mysqlbaglan);
                int kiz = Convert.ToInt32(kizOrt.ExecuteScalar());
                MySqlCommand erkOrt = new MySqlCommand("Select AVG(Note) from notes where Program='" + cBoxOrt.SelectedItem.ToString() + "' and Lesson = '" + CboxDers.SelectedItem.ToString() + "' and Gender='ERKEK' ", _mysqlbaglan); ;
                int erkek = Convert.ToInt32(erkOrt.ExecuteScalar());
                chartOrtlama.Titles.Add(cBoxOrt.SelectedItem.ToString() + " BÖLÜMÜNDEKİ KIZ VE ERKEKLERİN NOT ORTALAMASI");
                chartOrtlama.Series["Seri1"].IsValueShownAsLabel = true;
                chartOrtlama.Series["Seri1"].Points.AddXY("ERKEKLER", erkek);
                chartOrtlama.Series["Seri1"].Points.AddXY("KIZLAR", kiz);
                MySqlCommand genelOrt = new MySqlCommand("Select AVG(Note) from notes where Program='" + cBoxOrt.SelectedItem.ToString() + "' and Lesson = '" + CboxDers.SelectedItem.ToString() + "'", _mysqlbaglan);
                double genel = Convert.ToDouble(genelOrt.ExecuteScalar());
                label6.Visible = true;
                /*
                chartOrtlama.Series["Seri2"].IsValueShownAsLabel = true;
                chartOrtlama.Series["Seri2"].Points.AddXY("GENEL ORTALAMA", genel);
                */
                label6.Text = "Genel Ortama : " + genel.ToString();
                _mysqlbaglan.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void cBoxOrt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CboxDers.Items.Clear();
                SqlBaglan(_mysqlbaglan);
                MySqlCommand cmdDers = new MySqlCommand("Select Lesson from lesson where Program='" + cBoxOrt.SelectedItem.ToString() + "'", _mysqlbaglan);
                Doldur(ders, cmdDers, "Lesson", CboxDers);
                _mysqlbaglan.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
