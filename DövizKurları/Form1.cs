using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DövizKurları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string bugün = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmltur = new XmlDocument();
            xmltur.Load(bugün);
            string dolaralıs = xmltur.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolaralıs.Text = dolaralıs;
            string dolarsatıs = xmltur.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolarsatıs.Text = dolarsatıs;
            string eurosatıs=xmltur.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosatıs.Text = eurosatıs;
            string euroalıs = xmltur.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroalıs.Text = euroalıs;
        }

        private void btndolaral_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaralıs.Text;
        }

        private void btndolarsat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsatıs.Text;
        }

        private void btneuroal_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroalıs.Text;
        }

        private void btneurosat_Click(object sender, EventArgs e)
        {
           
                txtkur.Text = lbleurosatıs.Text;
          
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text=txtkur.Text.Replace(".", ",");
        }

        private void btnsatıs_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(txtmiktar.Text);
            tutar = kur * miktar;
            txttutar.Text = tutar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(txtmiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txttutar.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            txtkalan.Text = kalan.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToLongDateString();
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
