using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrollkaestchen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            if(ChkSchalter.Checked)
            {
                LblTest1.Text = "An";

            }
            else
            {
                LblTest1.Text = "Aus";
            }
        }

        private void ChkSchalter_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkSchalter.Checked)
            {
                LblTest2.Text = "An";
            }
            else
            {
                LblTest2.Text = "Aus";
            }
        }

        private void CmdUmschalten_Click(object sender, EventArgs e)
        {
            ChkSchalter.Checked = !ChkSchalter.Checked;
        }
    }
}
