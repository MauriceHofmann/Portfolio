using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {
            double Gehalt;
            double Steuerbetrag;
            Gehalt = Convert.ToDouble(TxtBoxGehalt.Text);

            if(Gehalt <= 12000)
            {
                double Steuersatz = 0.12;
                Steuerbetrag = Gehalt * Steuersatz;
                LblAnzeige.Text = "Steuerbetrag: " + Steuerbetrag;
            }

            if(Gehalt >12000 && Gehalt <= 20000)
            {
                double Steuersatz = 0.15;
                Steuerbetrag = Gehalt * Steuersatz;
                LblAnzeige.Text = "Steuerbetrag: " + Steuerbetrag;
            }

            if(Gehalt > 20000 && Gehalt <= 30000)
            {
                double Steuersatz = 0.2;
                Steuerbetrag = Gehalt * Steuersatz;
                LblAnzeige.Text = "Steuerbetrag: " + Steuerbetrag;
            }

            if (Gehalt > 30000)
            {
                double Steuersatz = 0.25;
                Steuerbetrag = Gehalt * Steuersatz;
                LblAnzeige.Text = "Steuerbetrag: " + Steuerbetrag;
            }

           /* double gehalt, steuersatz, steuerbetrag;
            gehalt = Convert.ToDouble(TxtBoxGehalt.Text);

            if (gehalt <= 12000)
            {
                steuersatz = 12;
            }
            else if (gehalt <= 20000)
            {
                steuersatz = 15;
            }
            else if(gehalt <= 30000)
            {
                steuersatz = 20;
            }
            else
            {
                steuersatz = 25;
            }

            steuerbetrag = gehalt * steuersatz / 100;
            LblAnzeige.Text = "Steuerbetrag: " + steuerbetrag;
           */
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double steuersatz, steuerbetrag, netto;

            LblAnzeige2.Text = "";
            for (double gehalt = 5000; gehalt <= 35000; gehalt += 3000)
            {
                if (gehalt <= 12000)
                {
                    steuersatz = 0.12;
                }
                else if (gehalt <= 20000)
                {
                    steuersatz = 0.15;
                }
                else if (gehalt <= 30000)
                {
                    steuersatz = 0.20;
                }
                else
                {
                    steuersatz = 0.25;
                }

                steuerbetrag = gehalt * steuersatz;
                netto = gehalt - steuerbetrag;
                LblAnzeige2.Text += gehalt + ", " + steuersatz +"%" + ", " + steuerbetrag + ", " + netto + "\n";
            }
        }
    }
}
