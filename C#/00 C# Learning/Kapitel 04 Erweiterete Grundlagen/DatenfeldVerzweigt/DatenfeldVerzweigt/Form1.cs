using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldVerzweigt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new Random();
        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double[][] a = new double[5][];
            int anz = 0;

            a[0] = new double[2];
            a[1] = new double[4];
            a[2] = new double[2];
            a[3] = new double[3];
            a[4] = new double[1];

            LblAnzeigen.Text = "";
            for(int i = 0; i < a.Length; i++)
            {
                for(int k = 0; k < a[i].Length; k++)
                {
                    a[i][k] = Math.Round(r.NextDouble(), 3);
                    LblAnzeigen.Text += a[i][k] + " ";
                }
                anz += a[i].Length;
                LblAnzeigen.Text += "\n";
            }
            LblAnzeigen.Text += "Anzahl: " + anz;
        }
    }
}
