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
    public partial class Kaynak : Form
    {
        public Kaynak()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://www.tayfuntaskin.com/2007/08/mdi-formlarda-parent-formun-arka-plann.html?showComment=1637546989735#c3635446040086870031");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://www.youtube.com/watch?v=4kiqXLJkMIY");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel9.LinkVisited = true;
            System.Diagnostics.Process.Start(@"http://www.ibrahimbayraktar.net/2014/04/sqlde-count-fonksiyonu-kullanm.html");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://stackoverflow.com/questions/50554578/how-to-connect-to-a-mysql-database-without-ssl");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://www.yazilimkodlama.com/programlama/c-comboboxa-veri-cekme-sql-server/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel5.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://stackoverflow.com/questions/7754569/how-to-fill-textboxes-from-datagridview-on-button-click-event");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel6.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://stackoverflow.com/questions/2934844/unable-to-convert-mysql-date-time-value-to-system-datetime");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel7.LinkVisited = true;
            System.Diagnostics.Process.Start(@"https://enginpolat.com/csharp-ile-gmail-uzerinden-eposta-gonderme/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel8.LinkVisited = true;
            System.Diagnostics.Process.Start(@"http://forum.csharpnedir.com/forum_posts.asp?TID=43602&title=mail-gnderirken-spama-dme-yardm-ilginc");
        }
    }
}
