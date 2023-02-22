using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konstruktor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            /// Es werden vier Objekte der Klasse Fahrzeug erzeugt und ausgegeben. Jedes der Objekte nutzt einen anderen Konstruktor.
            /// Aufgrund der Tatsache, dass für diese Klasse eine eigene Methode ToString() definiert wurde, ist eine einfache Ausgabe mithilfe des Objektnamens möglich. Beachten
            /// Sie in diesem Zusammenhang, dass die Answeisung lblAusgabe.Text = vespa; zu einem fehler führen würde. Erst die die Verkettung des Objektnamens mi einer Zeichenkette
            /// (z.B. "" oder "\n" führt zu einer automatischen Umwandlung sowie einr fehlerfreien Zuweisung an die Eigenschaft Text.
            /// 
            ///Während der Codierung erscheint nach Eingabe von new Fahrzeug eine InstelliSense-QuickInfo. Darin werden dem Entwickler die vier Möglichkeiten zur Objekterzeugung,
            ///also die vier Konstrukotren mit Anzahl und Typ der Parameter, zur Auswahl angeboten. Dieses Verhalten kennen wir bereits von der Benutzung der vordefinierten Methode.
            ///

            ///HINWEIS: Sobald Sie eigene Konstruktoren definieren, können Sie nur noch diese nutzen. Falls es keine eigenen Konstruktoren gibt, wird ein interner, parameterloser 
            ///         Konstruktor verwenet, wie im ersten Beispiel dieses Abschnitts.
      
            Fahrzeug vespa = new Fahrzeug();
            Fahrzeug schwalbe = new Fahrzeug("Moped");
            Fahrzeug yamaha = new Fahrzeug(50);
            Fahrzeug honda = new Fahrzeug("Motorrad", 75);

            lblAusgabe.Text = vespa + "\n" + schwalbe + "\n" + yamaha + "\n" + honda;
        }
    }
}
