using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGueltigkeitsbereich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double x = 0;

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double y = 0;
            x += 0.1;
            y += 0.1;

            LblAnzeigen.Text = "x: " + x + "\n" + "y: " + y;
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double z = 0;
            x += 0.1;
            z += 0.1;

            LblAnzeigen.Text = "x: " + x + "\n"+ "z: " + z;
        }
    }
}
