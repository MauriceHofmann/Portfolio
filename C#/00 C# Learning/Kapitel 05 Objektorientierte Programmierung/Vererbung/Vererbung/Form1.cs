using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vererbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            PKW fiat = new PKW();

            vespa.Beschleunigen(35);
            lblAnzeigen.Text = vespa + "";
            lblAnzeigen.Text += "\n" + fiat;

            fiat.Einsteigen(3);
            fiat.Beschleunigen(30);
            lblAnzeigen.Text += "\n" + fiat;
        }
    }

    class Fahrzeug
    {
        private int geschwindigkeit;

        public void Beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }

        public override string ToString()
        {
            return "Geschwindkeit: " + geschwindigkeit + "\n";
        }
    }

    class PKW : Fahrzeug
    {
        private int insassen;

        public void Einsteigen(int anzahl)
        {
            insassen += anzahl;
        }

        public override string ToString()
        {
            return "Insassen: " + insassen + "\n" + base.ToString();
        }
    }
}
