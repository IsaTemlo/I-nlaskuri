using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iänlaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            KuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            PäivinäLB.Text = (erotus + " päivää");
            TunteinaLB.Text = (erotus * 24 + " tuntia");
            MinuutteinaLB.Text = (erotus * 24 * 60 + " minuuttia");
            SekunteinaLB.Text = (erotus * 24 * 3600 + " sekunttia");

            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PäivinäLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekunteinaLB.Visible = true;

        }
    }
}
