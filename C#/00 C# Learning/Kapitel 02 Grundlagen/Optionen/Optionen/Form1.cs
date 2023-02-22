using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optionen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPrüfen_Click(object sender, EventArgs e)
        {
            if(OptFarbeRot.Checked)
            {
                LblTest1.Text = "Rot";
            }
            else if(OptFarbeGruen.Checked)
            {
                LblTest1.Text = "Grün";
            }
            else
            {
                LblTest1.Text = "Blau";
            }
        }

        private void OptFarbeRot_CheckedChanged(object sender, EventArgs e)
        {
            if(OptFarbeRot.Checked)
            {
                LblTest2.Text = "Rot";
            }
        }

        private void OptFarbeGruen_CheckedChanged(object sender, EventArgs e)
        {
            if(OptFarbeGruen.Checked)
            {
                LblTest2.Text = "Grün";
            }
        }

        private void OptFarbeBlau_CheckedChanged(object sender, EventArgs e)
        {
            if(OptFarbeBlau.Checked)
            {
                LblTest2.Text = "Blau";
            }
        }

        private void CmdSchalter_Click(object sender, EventArgs e)
        {
            OptFarbeRot.Checked = true;
        }
    }
}
