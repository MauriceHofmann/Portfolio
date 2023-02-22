using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDatenfeldMehrdimensional
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
            //Deklaration
            int[,,] array = new int[6, 3, 4];
            int MinWert;

            LblAnzeige.Text = "";

            //Füllen des Labels mit Zufallswerten
            for(int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    LblAnzeige.Text += "( ";
                    for(int k = 0; j < array.GetUpperBound(2); k++)
                    {
                        array[i, j, k] = r.Next(20, 31);
                        LblAnzeige.Text += array[i, j, k];
                    }
                }
                LblAnzeige.Text += ") ";
            }

            //Minimaler Wert ermitteln
            MinWert = array[0, 0, 0];
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= array.GetUpperBound(2); k++)
                    {
                        if (array[i,j,k] < MinWert)
                        {
                            MinWert = array[i, j, k];
                        }
                    }
                }
            }

            LblMinima.Text = "Minimum " + MinWert + ", an Position:\n";
            for(int i=0; i<=array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= array.GetUpperBound(2); k++)
                    {
                        if (array[i, j, k] == MinWert)
                        {
                            LblMinima.Text += "Zeile " + i + ", Gruppe " + j + ", Element " + k + "\n";
                        }
                    }
                }
            }
        }
    }
}
