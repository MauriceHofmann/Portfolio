using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ZeigeMaximum(double x, double y)
        {
            if (x > y)
            {
                LblAusgabe.Text = "Maximum: " + x;
            }
            else
            {
                LblAusgabe.Text = "Maximum: " + y;
            }
            return;             //nicht notwendig
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = 4.5;
            b = 7.2;
            ZeigeMaximum(a, b);
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            double c, d;
            c = 23.9;
            d = 5.6;
            ZeigeMaximum(c, d);
        }
    }
}
