using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VererbungKonstruktoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            PKW fiat = new PKW("Kompaktwagen", 50, 2);
            PKW peugeot = new PKW();

            lblAnzeige.Text = fiat + "\n" + peugeot;
        }
    }

    class Fahrzeug
    {
        private readonly string bezeichnung;
        private int geschwindigkeit;

        public Fahrzeug()
        {
            bezeichnung = "(leer)";
            geschwindigkeit = 0;
        }

        public Fahrzeug(string _bezeichnung, int _geschwindkeit)
        {
            bezeichnung = _bezeichnung;
            geschwindigkeit = _geschwindkeit;
        }

        public override string ToString()
        {
            return "Bezeichnung: " + bezeichnung + "\nGeschwindigkeit: " + geschwindigkeit;
        }
    }

    class PKW : Fahrzeug
    {
        private int insassen;

        public PKW()
        {
            insassen = 0;
        }

        public PKW(string _bezeichnung, int _geschwindigkeit, int _insassen) : base(_bezeichnung, _geschwindigkeit)
        {
            insassen = _insassen;
        }

        public override string ToString()
        {
            return base.ToString() + "\nInsassen: " + insassen + "\n";
        }
    }
}
