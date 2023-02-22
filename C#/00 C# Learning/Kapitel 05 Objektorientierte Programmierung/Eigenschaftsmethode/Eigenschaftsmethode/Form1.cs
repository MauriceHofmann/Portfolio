using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eigenschaftsmethode
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

            ///Zur Ausgabe wird der (öffentlich zugängliche) get-Accessor der Eigenschaftsmethode geschwindigkeit benuztzt.
            lblAusgabe.Text = "Geschwindkeit: " + vespa.Geschwindigkeit;

            ///Es wird versucht, das Fahrzeug um 120 zu beschleunigen. Das gelingt allerdings nicht, da der set-Accessor der Eigenschaftsmethode Geschwindigkeit das verhindert.
            vespa.Beschleunigen(120);

            ///In der vorletzten Zeile steht (auskommentiert) eine Anweisung, die nict durchgeführt werden kann. Der set-Accessor der Eigenschaftsmethode geschwindigkeit() ist gekapselt,
            ///daher führt die Anweisung vespa.Geschwindigkeit() ist gekapselt, daher führt die Anweisung vespa.Geschwindkeit = 50 zu einem Fehler.
            // vespa.Geschwindigkeit = 50;

            lblAusgabe.Text += "\nGeschwindigkeit: " + vespa.Geschwindigkeit;
        }
    }
}
