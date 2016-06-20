using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_14._2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double BerekenGeredenKm(double beginkm, double eindkm)
        {
            double geredenkm = eindkm - beginkm;
            return geredenkm;
        }

        static double BerekenPrijs(double geredenkm, double prijsperkm)
        {
            double prijs = geredenkm * prijsperkm;
            return prijs;
        }

        static double BerekenBTW(double bedrag)
        {
            double BTW_PERCENTAGE = 0.19;
            double btw = bedrag * BTW_PERCENTAGE;
            return btw;

        }
        private void btn_bereken_Click(object sender, EventArgs e)
        {
            double KMverschil = BerekenGeredenKm(double.Parse(txt_eindkm.Text), double.Parse(txt_beginkm.Text));
            double prijs = BerekenPrijs(KMverschil, double.Parse(txt_prijsperkm.Text));
            double btw = BerekenBTW(prijs);
            double prijsinclbtw = prijs + btw;

            lbl_prijsexclbtw.Text = prijs.ToString();
            lbl_btw.Text = btw.ToString();
            lbl_prijsinclbtw.Text = prijsinclbtw.ToString();

        }
    }
}
