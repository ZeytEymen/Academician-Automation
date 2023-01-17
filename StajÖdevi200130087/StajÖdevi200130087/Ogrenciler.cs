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
    public partial class Ogrenciler : Form
    {
        public Ogrenciler()
        {
            InitializeComponent();
        }
        //"Select *from students"
        MySqlDataReader drGender;
        MySqlDataReader drProgram;
        MySqlDataReader drClass;
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
        //Combobox doldurur
        public void Doldur(MySqlDataReader dr,MySqlCommand cmd,string alan,ComboBox cb,ComboBox cb2)
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
                cb2.Items.Add(dr[alan]);
            }
            dr.Close();
            _mysqlbaglan.Close();
            
        }
        private void KayitGetir(string sorgu)
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
            dtOgrenci.DataSource = dt;
            foreach (Control item in GboxOgrenci.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            _mysqlbaglan.Close();
        }
        private void Ogrenciler_Load(object sender, EventArgs e)
        {          
            //SqlBaglan(_mysqlbaglan);  
            KayitGetir("Select *from students");
            MySqlCommand cmdGender = new MySqlCommand("Select *from gender",_mysqlbaglan);
            MySqlCommand cmdProgram = new MySqlCommand("Select *from program", _mysqlbaglan);
            MySqlCommand cmdClass = new MySqlCommand("Select *from class", _mysqlbaglan);      
            Doldur(drGender, cmdGender,"Gender",CboxCinsiyet,CboxCinsSec);  
            Doldur(drProgram, cmdProgram, "Name", CboxBolum,CboxBolumSec);
            Doldur(drClass, cmdClass, "Name", CboxSube,CboxSubeSec);
            _mysqlbaglan.Close();
        }
        /// EKLEME BÖLÜMÜ SORUNSUZ ÇALIŞIYOR////
        private void BtnEkle_Click(object sender, EventArgs e)
        {     
            try
            {
                
                SqlBaglan(_mysqlbaglan);
                MySqlCommand ekle = new MySqlCommand("Insert into students (`StudentNo`, `Name`, `Surname`, `Gender`, `Mail`, `Tel`, `Program`, `Class`) values(@no,@ad,@soyad,@cinsiyet,@mail,@tel,@bolum,@sinif)", _mysqlbaglan);
                ekle.Parameters.AddWithValue("@no", Convert.ToInt32(txtNo.Text));
                ekle.Parameters.AddWithValue("@ad", txtAd.Text);
                ekle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                ekle.Parameters.AddWithValue("@cinsiyet", CboxCinsiyet.SelectedItem.ToString());
                ekle.Parameters.AddWithValue("@mail", txtMail.Text);
                ekle.Parameters.AddWithValue("@tel", txtTel.Text);
                ekle.Parameters.AddWithValue("@bolum", CboxBolum.SelectedItem.ToString());
                ekle.Parameters.AddWithValue("@sinif", CboxSube.SelectedItem.ToString());
                ekle.ExecuteNonQuery();
                _mysqlbaglan.Close();
                KayitGetir("Select *from students");
                MessageBox.Show("İşlem Başarıyla Gerçekleşti");
                /*
                SqlBaglan(_mysqlbaglan);
                MySqlCommand ekle = new MySqlCommand("Insert into students (`StudentNo`, `Name`, `Surname`, `Gender`, `Mail`, `Tel`, `Program`, `Class`,StartDate) values(@no,@ad,@soyad,@cinsiyet,@mail,@tel,@bolum,@sinif,@date)", _mysqlbaglan);
                ekle.Parameters.AddWithValue("@no", Convert.ToInt32(txtNo.Text));
                ekle.Parameters.AddWithValue("@ad", txtAd.Text);
                ekle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                ekle.Parameters.AddWithValue("@cinsiyet", CboxCinsiyet.SelectedItem.ToString());
                ekle.Parameters.AddWithValue("@mail", txtMail.Text);
                ekle.Parameters.AddWithValue("@tel", txtTel.Text);
                ekle.Parameters.AddWithValue("@bolum", CboxBolum.SelectedItem.ToString());
                ekle.Parameters.AddWithValue("@sinif", CboxSube.SelectedItem.ToString());
                ekle.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                ekle.ExecuteNonQuery();
                _mysqlbaglan.Close();
                KayitGetir("Select *from students");
                MessageBox.Show("İşlem Başarıyla Gerçekleşti");
                */
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        ///// GÜNCELLEME PROBLEMLİ /////
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {        
            try
            {
                
                SqlBaglan(_mysqlbaglan);
                MySqlCommand guncelle = new MySqlCommand("UPDATE `students` SET `Name`='"+txtAd.Text+"',`Surname`='"+txtSoyad.Text+"',`Gender`='"+CboxCinsiyet.Text+"',`Mail`='"+txtMail.Text+"',`Tel`='"+txtTel.Text+"',`Program`='"+CboxBolum.Text+"',`Class`='"+CboxSube.Text+"' WHERE StudentNo=@id",_mysqlbaglan);
                guncelle.Parameters.AddWithValue("@id", Convert.ToInt32(txtNo.Text));
                guncelle.ExecuteNonQuery();
                _mysqlbaglan.Close();
                KayitGetir("Select *from students");
                MessageBox.Show("İşlem Başarıyla Gerçekleşti");
                
                /*
               SqlBaglan(_mysqlbaglan);
               MySqlCommand guncelle = new MySqlCommand("UPDATE `students` SET `Name`='"+txtAd.Text+"',`Surname`='"+txtSoyad.Text+"',`Gender`='"+CboxCinsiyet.Text+"',`Mail`='"+txtMail.Text+"',`Tel`='"+txtTel.Text+"',`Program`='"+CboxBolum.Text+"',`Class`='"+CboxSube.Text+ "',`StartDate`='"+dateTimePicker1.Value+"' WHERE StudentNo=@id", _mysqlbaglan);
               guncelle.Parameters.AddWithValue("@id", Convert.ToInt32(txtNo.Text));
               guncelle.ExecuteNonQuery();
               _mysqlbaglan.Close();
               KayitGetir("Select *from students");
               MessageBox.Show("İşlem Başarıyla Gerçekleşti");
               */
            }
            catch (Exception hata)
           {
               MessageBox.Show(hata.Message);
           }
       }

       private void BtnSil_Click(object sender, EventArgs e)
       {
           try
           {
               SqlBaglan(_mysqlbaglan);
               MySqlCommand sil = new MySqlCommand("Delete from students where StudentNo='" + txtNo.Text + "'", _mysqlbaglan);
               sil.ExecuteNonQuery();                
               _mysqlbaglan.Close();
               KayitGetir("Select *from students");
               MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
           }
           catch (Exception hata)
           {
               MessageBox.Show(hata.Message);
           }
       }

       private void dtOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           txtNo.Text = dtOgrenci.CurrentRow.Cells[0].Value.ToString();
           txtAd.Text = dtOgrenci.CurrentRow.Cells[1].Value.ToString();
           txtSoyad.Text = dtOgrenci.CurrentRow.Cells[2].Value.ToString();
           CboxCinsiyet.Text = dtOgrenci.CurrentRow.Cells[3].Value.ToString();
           txtMail.Text = dtOgrenci.CurrentRow.Cells[4].Value.ToString();
           txtTel.Text = dtOgrenci.CurrentRow.Cells[5].Value.ToString();
           CboxBolum.Text = dtOgrenci.CurrentRow.Cells[6].Value.ToString();
           CboxSube.Text = dtOgrenci.CurrentRow.Cells[7].Value.ToString();
       }

       private void BtnSecListele_Click(object sender, EventArgs e)
       {
           if (CboxBolumSec.Text != "" && CboxSubeSec.Text != "" && CboxCinsSec.Text != "")
           {
               SqlBaglan(_mysqlbaglan);
               string bolumSubeCıns = "Select *from students where Program='"+CboxBolumSec.Text+"' and Class = '"+CboxSubeSec.Text+"' and Gender='"+CboxCinsSec.Text+"'";
               KayitGetir(bolumSubeCıns);
               MessageBox.Show("'"+CboxBolumSec.Text+" Bölümü '"+CboxSubeSec.Text+"' 'n deki \n\t\t'"+CboxCinsSec.Text+"' Öğrenciler'");
           }
           else if (CboxBolumSec.Text != "" && CboxSubeSec.Text != "" && CboxCinsSec.Text == "")
           {
               SqlBaglan(_mysqlbaglan);
               string bolumSube = "Select *from students where Program='" + CboxBolumSec.Text + "' and Class = '" + CboxSubeSec.Text + "'";
               KayitGetir(bolumSube);
               MessageBox.Show("'" + CboxBolumSec.Text + " Bölümü '" + CboxSubeSec.Text + "' 'n deki \n\t\t Öğrenciler");
           }
           else
           {
               MessageBox.Show("HATALI GİRİŞ");
           }
       }

       private void BtnHepsiListe_Click(object sender, EventArgs e)
       {
           KayitGetir("Select *from students");
       }


   }
}
