using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajÖdevi200130087
{
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
        }

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {
            //FORM AÇILIRKEN TİMER BAŞLATILDI
            timer1.Start();

        }
        int sayac;// Progress Bar Ve Yüklenme Yazısı için 
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac%5 == 0)//İlerlemenin 5 er 5 er olması için mod işlemi yapıyorum
            {
                label1.Text = "% " + sayac.ToString();
                progressBar1.Value++;
            }
            
            if (sayac==104)//İlerleme Bittikten Sonra Timer ve Açılış Ekranımı Kapatıyorum
            {
                timer1.Stop();
                progressBar1.Style = ProgressBarStyle.Blocks;
                this.Close();

            }
        }

    }
}
