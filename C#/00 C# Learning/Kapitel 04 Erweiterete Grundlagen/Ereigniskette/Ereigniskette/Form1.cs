using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ereigniskette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdEreignis1_Click(object sender, EventArgs e)
        {
            LblAnzeige1.Text = "Eins";
        }

        private void CmdEreignis2_Click(object sender, EventArgs e)
        {
            LblAnzeige2.Text = "Zwei";
        }

        private void CmdEreignis3_Click(object sender, EventArgs e)
        {
            CmdEreignis1_Click(sender, e);
            CmdEreignis2_Click(sender, e);
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            LblAnzeige1.Text = "";
            LblAnzeige2.Text = "";
        }
    }
}
