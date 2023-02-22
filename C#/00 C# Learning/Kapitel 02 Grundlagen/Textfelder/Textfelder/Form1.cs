using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textfelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = "Sie haben '" + TxtEingabe.Text + "' eingegeben";
        }

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            double wert;
            wert = Convert.ToDouble(TxtEingabe.Text);
            wert *= 2;
            LblAusgabe.Text = "Ergebnis: " + wert;
        }
    }
}
