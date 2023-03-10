using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optionsgruppen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string AusgabeUrlaubsort = "Rom";
        public string AusgabeUnterkunft = "Appartement";

        private void OptUrlaubsort_CheckedChanged(object sender, EventArgs e)
        {
            if(OptBerlin.Checked)
            {
                AusgabeUrlaubsort = "Berlin";
            }
            else if (OptParis.Checked)
            {
                AusgabeUrlaubsort = "Paris";
            }
            else
            {
                AusgabeUrlaubsort = "Rom";
            }

            LblAnzeige.Text = AusgabeUrlaubsort + ", " + AusgabeUnterkunft;
        }

        private void OptUnterkunft_CheckedChanged(object sender, EventArgs e)
        {
            if(OptAppartement.Checked)
            {
                AusgabeUnterkunft = "Appartement";
            }
            else if(OptPension.Checked)
            {
                AusgabeUnterkunft = "Pension";
            }
            else
            {
                AusgabeUnterkunft = "Hotel";
            }

            LblAnzeige.Text = AusgabeUrlaubsort + ", " + AusgabeUnterkunft;
        }
    }
}
