using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URechenoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            double x;
            x = 3 * -2.5 + 4 * 2;
            LblAnzeigen.Text = "Ergebnis: " + x;
        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {
            double x;
            x = 3 * (-2.5 + 4) * 2;
            LblAnzeigen.Text = "Ergebnis: " + x;
        }
    }
}
