using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public readonly Random r = new Random();

        private void CmdMinima_Click(object sender, EventArgs e)
        {
            //Deklarieren
            int[] array = new int[10];
            int MinWert;

            LstFeld.Items.Clear();

            //Listenfeld füllen
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(20, 31);
                LstFeld.Items.Add(array[i]);
            }

            //Kleinster Wert ermitteln und ausgeben
            MinWert = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < MinWert)
                {
                    MinWert = array[i];
                    LblAnzeige.Text = "Minimum: " + MinWert + "\n";
                }
            }

            //An welchem Index liegt jeweils der kleinste Wert
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == MinWert)
                {
                    LblAnzeige.Text += "an Position: " + i + "\n";
                }
            }
        }
    }
}
