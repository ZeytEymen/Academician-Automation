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
    public partial class Notlar : Form
    {
        public Notlar()
        {
            InitializeComponent();
        }
        MySqlDataReader ders;
        MySqlDataReader bolum;
        MySqlDataReader sube;
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

        private void Notlar_Load(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            KayitGetir("Select *from notes",dtNot);
            MySqlCommand cmdBolum = new MySqlCommand("Select Name from Program",_mysqlbaglan);
            MySqlCommand cmdClass = new MySqlCommand("Select *from class", _mysqlbaglan);
            Doldur(bolum,cmdBolum,"Name",CboxBolum);
            Doldur(sube, cmdClass, "Name", CboxSube);
            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            CboxDers.Items.Clear();
            SqlBaglan(_mysqlbaglan);
            MySqlCommand cmd = new MySqlCommand("Select Lesson from lesson where Program = '" + CboxBolum.SelectedItem.ToString() + "'", _mysqlbaglan);
            Doldur(ders, cmd, "Lesson", CboxDers);
            string bolumSube = "Select *from students where Program='" + CboxBolum.Text + "' and Class = '" + CboxSube.Text + "'";
            KayitGetir(bolumSube,dtList);
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dtList.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dtList.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dtList.CurrentRow.Cells[2].Value.ToString();
            txtCins.Text = dtList.CurrentRow.Cells[3].Value.ToString();
            

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            MySqlCommand ekle = new MySqlCommand("Insert into notes (StudentNo,Name,Surname,Gender,Program,Lesson,Note) values(@no,@ad,@soyad,@cins,@program,@ders,@not)", _mysqlbaglan);
            ekle.Parameters.AddWithValue("@no", txtNo.Text);
            ekle.Parameters.AddWithValue("@ad",txtAd.Text);
            ekle.Parameters.AddWithValue("@soyad",txtSoyad.Text);
            ekle.Parameters.AddWithValue("@cins", txtCins.Text);
            ekle.Parameters.AddWithValue("@program", CboxBolum.Text);
            ekle.Parameters.AddWithValue("@ders",CboxDers.Text);
            ekle.Parameters.AddWithValue("@not",Convert.ToInt32(txtNot.Text));
            ekle.ExecuteNonQuery();
            MessageBox.Show("İŞLEM BAŞARILI");
            _mysqlbaglan.Close();
            string notlar = "Select *from notes";
            KayitGetir(notlar,dtNot);

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            MySqlCommand update = new MySqlCommand("Update notes set Name='" + txtAd.Text + "',Surname='" + txtSoyad.Text + "',Lesson='" + CboxDers.Text + "',Note='"+txtNot.Text+"' where id=@ID", _mysqlbaglan);
            update.Parameters.AddWithValue("@ID", dtNot.CurrentRow.Cells[0].Value);
            update.ExecuteNonQuery();
            MessageBox.Show("İŞLEM BAŞARILI");
            _mysqlbaglan.Close();
            string notlar = "Select *from notes";
            KayitGetir(notlar, dtNot);
        }

        private void dtNot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dtNot.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dtNot.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dtNot.CurrentRow.Cells[3].Value.ToString();
            txtCins.Text = dtNot.CurrentRow.Cells[4].Value.ToString();
            CboxDers.Text = dtNot.CurrentRow.Cells[6].Value.ToString();
            txtNot.Text = dtNot.CurrentRow.Cells[7].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            MySqlCommand delete = new MySqlCommand("Delete from notes where id=@ID", _mysqlbaglan);
            delete.Parameters.AddWithValue("@ID", dtNot.CurrentRow.Cells[0].Value.ToString());
            delete.ExecuteNonQuery();
            MessageBox.Show("İŞLEM BAŞARILI");
            _mysqlbaglan.Close();
            string notlar = "Select *from notes";
            KayitGetir(notlar, dtNot);
        }




    }
}
