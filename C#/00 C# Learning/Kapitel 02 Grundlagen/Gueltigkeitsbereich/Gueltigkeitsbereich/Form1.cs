using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gueltigkeitsbereich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Mx = 0;

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Mx++;
            x++;

            LblAnzeige.Text = "x: " + x + " Mx: " + Mx;
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int Mx = 0;
            Mx++;

            LblAnzeige.Text = "Mx: " + Mx;
        }
    }
}
