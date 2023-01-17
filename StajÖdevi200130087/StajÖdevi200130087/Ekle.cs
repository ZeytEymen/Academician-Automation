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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }
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
        private void ListGetir(string komut,ListBox lBox)
        {
            lBox.Items.Clear();
       
            MySqlCommand cmd = new MySqlCommand(komut, _mysqlbaglan);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lBox.Items.Add(dr[0]);
            }
            dr.Close();
        }
        private void CboxDoldur()
        {
            CboxBolum.Items.Clear();
            SqlBaglan(_mysqlbaglan);
            MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand("Select Name from program", _mysqlbaglan);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CboxBolum.Items.Add(dr[0]);
            }
            dr.Close();
            _mysqlbaglan.Close();
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            ListGetir("Select Name from program",ListBolum);
            //ListGetir("Select Lesson from lesson",ListDers);

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
            _mysqlbaglan.Close();
            CboxDoldur();
            
        }

   
    

        private void BtnBolum_Click(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            MySqlCommand ekle = new MySqlCommand("insert into program (Name) values('"+txtBolum.Text+"')",_mysqlbaglan);
            ekle.ExecuteNonQuery();
            ListGetir("Select Name from program", ListBolum);
            MessageBox.Show("EKLENDİ");
            _mysqlbaglan.Close();
            CboxDoldur();
        }

        private void BtnDers_Click(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            MySqlCommand ekle = new MySqlCommand("insert into lesson (Program,Lesson) values('" + CboxBolum.Text + "','"+txtDers.Text+"')",_mysqlbaglan);
            ekle.ExecuteNonQuery();
            ListGetir("Select Lesson from lesson where Program='"+CboxBolum.Text+"'", ListDers);
            MessageBox.Show("EKLENDİ");
            _mysqlbaglan.Close();
        }

        private void CboxBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            ListGetir("Select Lesson from lesson where Program='"+CboxBolum.SelectedItem.ToString()+"'", ListDers);
            _mysqlbaglan.Close();
        }

  
    }
}
