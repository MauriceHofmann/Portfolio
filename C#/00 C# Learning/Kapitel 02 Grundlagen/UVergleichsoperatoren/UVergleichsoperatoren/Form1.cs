using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UVergleichsoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            bool p;
            p = 12 - 3 >= 4 * 2.5; ;

            LblAnzeige.Text = "Ergebnis: " + p;
        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {
            bool p;
            p = "Maier" != "Mayer";

            LblAnzeige.Text = "Ergebnis: " + p;
        }
    }
}
