using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechenoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 5;
            x++;
            ++x;
            x = x + 1;

            LblAnzeige.Text = "Ergebnis: " + x;
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 5;

            LblAnzeige.Text = "Ergebnis: " + x++;
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int x = 5;

            LblAnzeige.Text = "Ergebnis: " + ++x;
        }
    }
}
