using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasseObjekt
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Die Klasse Fahrzzeug wird im Hauptprogramm in der Klasse des Formulars genutzt
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            ///Die Anweisung Fahrzeug vespa erzeugt einen Verweis auf ein Objekt der Klasse Fahrzeug.
            Fahrzeug vespa;             
            
            ///Die Answeisung vespa = new Fahrzeug() erzeugt ein neues Objekt der Klasse Fahrzeug, das über den Verweis vespa erreicht werden kann.
            ///Meist werden Verweis und Objekt in einer Anweisung gemeinsam erzeugt --> Fahrzeug vespa = new Fahrzeug();
            ///Dieses Fahrzeug verfügt über die Eigenschaften und Methoden, die in der Klassendefinition festgelegt sind. 
            ///Man spricht auch von einer Instanz der Klasse Fahrzeug bzw. vom Instanziieren der Klasse.
            vespa = new Fahrzeug();

            ///Mit der Anweisung lblAusgabe.Text = vespa.Ausgabe(); wird die Methode Ausgabe für das Objekt vespa aufgerufen. Diese Methode liefert gemäß Definition den Wert der Geschwindikeit.
            ///Dieser Wert wird dem Label zugewiesen.
            lblAusgabe.Text = vespa.Ausgabe();

            ///Die Anweisung vespa.Beschleunigen(20) ruft die Methode Beschleunigen() für das Objekt vespa auf. 
            ///In dieser Methode wird die Eigenshaft geschwindigkeit um den übergebenen Wert erhöht.
            vespa.Beschleunigen(20);

            ///Anschließend folgt wieder die Ausgabe. Sie sehen nun, wie sich das Objekt verändert hat.
            lblAusgabe.Text += "\n" + vespa.Ausgabe();

            ///In der letzten Zeile steht (auskommentiert) eine Anweisung, die nicht durchgeführt werden kann. Das Objekt vespa hat zwar eine Eigenschaft geschwindigkeit, diese ist aber nicht
            ///öffentlich erreichbar. Daher wird das Program mit diesem Fehler nicht übersetzt. Einen Hinweis darauf liefert bereits die Tatsache, dass diese Eigenschaft nicht in der IntelliSense-
            ///Liste enthalten ist, die sich im Editor nach Eingabe des Punkts hinter vespa öffnet.
            //lblAusgabe.Text = vespa.geschwindigkeit;
        }
    }
}
