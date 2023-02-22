using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new Random();

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int[] a;
            a = new int[7];

            LstFeld.Items.Clear();
            for(int i = 0; i < 7; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] a = new int[7];
            int MaxWert, MinWert, MaxWertIndex, MinWertIndex;

            LstFeld.Items.Clear();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }

            /* Max/Min initialisieren */
            MaxWert = a[0];
            MinWert = a[0];
            MaxWertIndex = 0;
            MinWertIndex = 0;

            /* Max/Min suchen */
            for(int i = 1; i < a.Length; i++)
            { 
                if (a[i] > MaxWert)
                {
                    MaxWert = a[i];
                    MaxWertIndex = i;
                }

                if (a[i] < MaxWert)
                {
                    MinWert = a[i];
                    MinWertIndex = i;
                }
              
            }

            /* Max/Min ausgeben */
            LblAnzeige.Text = "Max. Wert: " + MaxWert + " bei Index " + MaxWertIndex +
                       "\n" + "Min. Wert: " + MinWert + " bei Index " + MinWertIndex;
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int[] a = new int[7], b;
            int SuchIndex;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
            }

            b = (int[])a.Clone();

            Array.Sort(b);

            LstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                LstFeld.Items.Add(b[i]);
            }

            SuchIndex = Array.IndexOf(b, 25);
            LblAnzeige.Text = "Gesuchter Wert 25 bei Index: " + SuchIndex;
        }
    }
}
