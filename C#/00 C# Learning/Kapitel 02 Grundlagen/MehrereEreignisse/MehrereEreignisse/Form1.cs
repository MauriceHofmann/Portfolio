using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehrereEreignisse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OptFarbe_CheckedChanged(object sender, EventArgs e)
        {
            if(OptFarbeRot.Checked)
            {
                LblAnzeige.Text = "Rot";
            }
            else if(OptFarbeGruen.Checked)
            {
                LblAnzeige.Text = "Grün";
            }
            else
            {
                LblAnzeige.Text = "Blau";
            }
        }
    }
}
