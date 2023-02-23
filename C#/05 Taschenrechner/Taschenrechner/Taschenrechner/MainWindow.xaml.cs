using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //=========================================
        // Zahlen- und Operator-Buttons Logik 
        //=========================================
        private void BtnNull_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "0";
        }

        private void BtnEins_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "1";
        }

        private void BtnZwei_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "2";
        }

        private void BtnDrei_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "3";
        }

        private void BtnVier_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "4";
        }

        private void BtnFuenf_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "5";
        }

        private void BtnSechs_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "6";
        }

        private void BtnSieben_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "7";
        }

        private void BtnAcht_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "8";
        }

        private void BtnNeun_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += "9";
        }

        private void BtnKomma_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += ",";
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += " + ";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += " - ";
        }

        private void BtnMal_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += " x ";
        }

        private void BtnGeteilt_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Text += " ÷ ";
        }


        //=================================================================================
        // Benötigte Werte holen und anschliesend die mathematische Operation ausführen
        //=================================================================================
        private void BtnBerechne_Click(object sender, RoutedEventArgs e)
        {
            //Variablen Deklarieren
            string eingabe;
            string[] eingabeSplit;
            double zahl1;
            double zahl2;
            string mathematischerOperator;
            double ergebnis;

            //Eingabe vom Nutzer in die Bestandteile (Zahl1, Zahl2 und mathematischer Operator) zu unterteilen
            eingabe = txtAusgabe.Text;
            eingabeSplit = eingabe.Split(' ');
            zahl1 = Convert.ToDouble(eingabeSplit[0]);
            mathematischerOperator = eingabeSplit[1];
            zahl2 = Convert.ToDouble(eingabeSplit[2]);

            //Evaluieren-Funktion aufrufen, die das Ergbnis berechnet und zurückliefert
            ergebnis = Evaluieren(zahl1, zahl2, mathematischerOperator);
            txtAusgabe.Text = Convert.ToString(ergebnis);
        }

        //===============================================
        // Mathematische Berechnungen definieren
        //===============================================
        private double Evaluieren(double zahl1, double zahl2, string mathematischerOperator)
        {
            double ergebnis = 0;
            switch(mathematischerOperator)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    break;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    break;
                case "x":
                    ergebnis = zahl1 * zahl2;
                    break;
                case "÷":
                    ergebnis = zahl1 / zahl2;
                    break;
            }
            return ergebnis;
        }


        //===============================================
        // Logik zum entfernen und löschen von Zeichen
        //===============================================

        private void BtnLoeschen_Click(object sender, RoutedEventArgs e)
        {
            //Wenn die Rechnungs-Zeichenkette mit einem Leerzeichen endet (nach Operator +,-,x÷), dann soll das Zeichen gelöscht werden -> Leer + Leer => 3 Zeichen müssen weg
            //Wenn die Rechnungs-Zeichenkette mit einer Zahl endet, dann soll nur das letzte Zeichen gelöscht werden => 1 Zeichen muss weg
            if (txtAusgabe.Text.EndsWith(" "))
            {
                txtAusgabe.Text = txtAusgabe.Text.Remove(txtAusgabe.Text.Length - 3);
            }
            else
            {
                txtAusgabe.Text = txtAusgabe.Text.Remove(txtAusgabe.Text.Length-1);
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Clear();
        }
    }
}
