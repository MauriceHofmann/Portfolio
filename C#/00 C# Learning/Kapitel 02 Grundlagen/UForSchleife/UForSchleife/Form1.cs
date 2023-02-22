using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UForSchleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSchleife1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "";
            for(double d = 35; d >= 20; d -= 2.5)
            {
                LblAnzeige.Text += d + "\n";
            }
        }

        private void CmdSchleife2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "";
            int count = 0;
            double summe = 0, mittelwert;

            for(double d = 35; d >= 20; d -= 2.5)
            {
                LblAnzeige.Text += d + "\n";
                count = count + 1;
                summe = summe + d;
            }

            mittelwert = summe / count;
            LblAnzeige.Text += "Summe: " + summe + "\n" + "Mittelwert: " + mittelwert;
        }
    }
}
