using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_14._2._11
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_VALUE_Click(object sender, EventArgs e)
        {
            //lees getal
            int getal = int.Parse(txt_getal.Text);
            //uitkomst = kwadraadkwadraad_byvalue(getal)
            int uitkomst = KwadraadKwadraad_ByValue(getal);
            //Toon uitkomst
            lbl_uitkomst.Text = uitkomst.ToString();
        }

        private int KwadraadKwadraad_ByValue(int getal)
        {
            //uitkomst = getal * getal
            int uitkomst = getal * getal;
            //return uitkomst
            return uitkomst;
        }

        private void btn_OUT_Click(object sender, EventArgs e)
        {
            //lees getal
            int getal = int.Parse(txt_getal.Text);
            int resultaat;
            //kwadraad_ByRefOut(getal, resultaat)
            Kwadraad_ByRefOut(getal, out resultaat);
            //Toon resultaat
            lbl_uitkomst.Text = resultaat.ToString();
        }

        private void Kwadraad_ByRefOut(int getal, out int uitkomst)
        {
            uitkomst = getal * getal;
        }

        private void btn_REF_Click(object sender, EventArgs e)
        {
            //Lees getal
            int getal = int.Parse(txt_getal.Text);
            //KwadraadKwadraad_ByRefREF(getal)
            KwadraadKwadraad_ByRefREF(ref getal);
            //Toon getal
            lbl_uitkomst.Text = getal.ToString();
        }

        private void KwadraadKwadraad_ByRefREF(ref int getal)
        {
            getal *= getal;
        }
    }
}
