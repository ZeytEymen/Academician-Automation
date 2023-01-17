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
using System.Net.Mail;
using System.Net;

namespace StajÖdevi200130087
{
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
        }
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
            dataGridView1.DataSource = dt;
           
            _mysqlbaglan.Close();
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

        private void Duyurular_Load(object sender, EventArgs e)
        {
            SqlBaglan(_mysqlbaglan);
            MySqlCommand cmdGender = new MySqlCommand("Select *from gender", _mysqlbaglan);
            MySqlCommand cmdProgram = new MySqlCommand("Select *from program", _mysqlbaglan);
            MySqlCommand cmdClass = new MySqlCommand("Select *from class", _mysqlbaglan);
            Doldur(drGender, cmdGender, "Gender",CboxCinsSec);
            Doldur(drProgram, cmdProgram, "Name",CboxBolumSec);
            Doldur(drClass, cmdClass, "Name",CboxSubeSec);
            _mysqlbaglan.Close();
            KayitGetir("select *from notice");
        }

        private void BtnMailGonder_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("zeyteymenforstudy@gmail.com", "stajOdevi200130087");
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("zeyteymenforstudy@gmail.com", "AKADEMİSYEN OTOMASYONU", System.Text.Encoding.UTF8);

            for (int i = 0; i < ListOfMail.Items.Count; i++)
            {
                mail.To.Add(ListOfMail.Items[i].ToString());                
            }
            mail.Subject = TxtSubject.Text;
            mail.IsBodyHtml = true;
            mail.Body = TxtContent.Text + "<br><br><font color='#ff6600'>Created by: ZEYT EYMEN - 05459052651 - 200130087</font>";
            mail.Priority = MailPriority.High;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            sc.Send(mail);
            MessageBox.Show("MAİLLER BAŞARIYLA GÖNDERİLDİ \n\t SPAM KUTUSUNU KONTROL EDİNİZ");
            SqlBaglan(_mysqlbaglan);
            MySqlCommand command = new MySqlCommand("insert into notice (Subject,Content,MailTo) values(@konu,@icerik,@mail)",_mysqlbaglan);
            command.Parameters.AddWithValue("@konu", TxtSubject.Text);
            command.Parameters.AddWithValue("@icerik", TxtContent.Text);
            command.Parameters.AddWithValue("@mail",txtMailler.Text);
            
            command.ExecuteNonQuery();
            _mysqlbaglan.Close();
            KayitGetir("select *from notice");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            ListOfMail.Items.Clear();
            txtMailler.Text = "";
            if (CboxBolumSec.Text != "" && CboxSubeSec.Text != "" && CboxCinsSec.Text != "")
            {
                SqlBaglan(_mysqlbaglan);
                string bolumSubeCıns = "Select  Mail from students where Program='" + CboxBolumSec.Text + "' and Class = '" + CboxSubeSec.Text + "' and Gender='" + CboxCinsSec.Text + "'";
                MySqlCommand cmd = new MySqlCommand(bolumSubeCıns, _mysqlbaglan);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListOfMail.Items.Add(dr[0]);
                }
                dr.Close();
                for (int i = 0; i < ListOfMail.Items.Count; i++)
                {
                    txtMailler.Text += ListOfMail.Items[i].ToString()+";";
                }
                _mysqlbaglan.Close();
                MessageBox.Show("'" + CboxBolumSec.Text + " Bölümü '" + CboxSubeSec.Text + "' 'n deki \n\t\t'" + CboxCinsSec.Text + "' Öğrenciler'");
            }
            else if (CboxBolumSec.Text != "" && CboxSubeSec.Text != "" && CboxCinsSec.Text == "")
            {
                SqlBaglan(_mysqlbaglan);
                string bolumSube = "Select *from students where Program='" + CboxBolumSec.Text + "' and Class = '" + CboxSubeSec.Text + "'";
                MySqlCommand cmd = new MySqlCommand(bolumSube, _mysqlbaglan);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListOfMail.Items.Add(dr[0]);

                }
                dr.Close();
                _mysqlbaglan.Close();
                MessageBox.Show("'" + CboxBolumSec.Text + " Bölümü '" + CboxSubeSec.Text + "' 'n deki \n\t\t Öğrenciler");
                
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
            }        
        }

   



    }
}
