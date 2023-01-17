using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StajÖdevi200130087
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!DesignMode)
            {
                //eğer tasarım anında hata olursa bunu aktifleştirin.
                //    PaintBackground(e.Graphics);
            }
        }
        [DefaultValue(false)]
        public new bool IsMdiContainer
        {
            get
            {
                return base.IsMdiContainer;
            }
            set
            {
                base.IsMdiContainer = value;
                if (!value) return;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    MdiClient mdiClient = this.Controls[i] as MdiClient;
                    if (mdiClient != null)
                    {
                        mdiClient.Paint += new PaintEventHandler(this.MdiClient_Paint);
                        break;
                    }
                }
            }
        }
        private void MdiClient_Paint(object sender, PaintEventArgs e)
        {
            // if (!DesignMode)//eğer tasarım anında hata olursa bunu aktifleştirin.
            //PaintBackground(e.Graphics);
        }
        
        private void PaintBackground(Graphics g)
        {
           this.BackgroundImage = Image.FromFile(@"C:\Users\zeyt\Downloads\ArkaPlan.png");
        }


        //SqlConnection conn_ = new SqlConnection("Data Source=ZEYTEYMEN;Initial Catalog=NotTakip;Integrated Security=True");
       

        /// 200130087 -- EYMEN KARABUDAK -- ///
        private void AnaForm_Load(object sender, EventArgs e)
        {
            /*
            conn_.Open();
            if (conn_.State == ConnectionState.Closed)
            {
                MessageBox.Show("BAĞLANTI HATASI MSSQL");
            }
            else
            {
                MessageBox.Show("Test");
            }
             * */
            Hakkinda frmHakkinda = new Hakkinda();
            FormGetir(frmHakkinda);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FormGetir(Form frm)
        {
            panelMain.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ClientSize = new System.Drawing.Size(880, 582);
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void BtnHakkinda_Click(object sender, EventArgs e)
        {
            Hakkinda frmHakkinda = new Hakkinda();
            FormGetir(frmHakkinda);
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            Duyurular frmDuyuru = new Duyurular();
            FormGetir(frmDuyuru);
        }

        private void BtnOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenciler frmOgrenci = new Ogrenciler();
            FormGetir(frmOgrenci);
        }

        private void BtnNotİslem_Click(object sender, EventArgs e)
        {
            Notlar frmNotlar = new Notlar();
            FormGetir(frmNotlar);
        }

        private void BtnDevamsizlik_Click(object sender, EventArgs e)
        {
            Devamsizlik frmDevamsizlik = new Devamsizlik();
            FormGetir(frmDevamsizlik);
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            Grafikler frmGrafik = new Grafikler();
            FormGetir(frmGrafik);
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            Ekle frmEkle = new Ekle();
            FormGetir(frmEkle);
        }





    }
}
