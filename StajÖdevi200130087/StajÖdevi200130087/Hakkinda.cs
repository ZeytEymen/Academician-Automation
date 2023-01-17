using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace StajÖdevi200130087
{
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void BtnKaynak_Click(object sender, EventArgs e)
        {
            Kaynak kynk = new Kaynak();
            kynk.Show();
        }
    }
}
