using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHalbierung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(TxtEingabe.Text);
            LblAnzeige.Text = "";

            while (d >= 0.001)
            {
                d /= 2;
                LblAnzeige.Text += d + "\n";
            }
        }
    }
}
