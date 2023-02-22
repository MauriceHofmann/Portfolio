using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            // Deklaration
            string nachname, vorname,  Straße, Ort, Postleitzahl;
            int Alter;
            double Gehalt;

            // Initialisierung
            nachname = "Hofmann";
            vorname = "Maurice";
            Straße = "Ahornweg 3/1";
            Ort = "Bönnigheim";
            Postleitzahl = "74357";

            Alter = 20;

            Gehalt = 1610.00;

            // Ausgabe
            LblAnzeige.Text =
                "Adresse:" + "\n" + vorname + nachname + "\n" + Straße +  "\n" +
                Postleitzahl + " " + Ort + "\n\n" +
                "Alter: " + Alter + "\n" + "Gehalt: " + Gehalt;
            
        }
    }
}
