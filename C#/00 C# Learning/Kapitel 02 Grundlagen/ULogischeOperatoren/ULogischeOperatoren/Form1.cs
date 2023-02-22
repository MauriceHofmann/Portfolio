using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULogischeOperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            bool Ausdruck;
            Ausdruck = 4 > 3 && -4 > -3;

            LblAnzeigen.Text = "Ergebnis: " + Ausdruck;
        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {
            bool Ausdruck;
            Ausdruck = 4 > 3 || -4 > -3;

            LblAnzeigen.Text = "Ergebnis: " + Ausdruck;
        }
    }
}
