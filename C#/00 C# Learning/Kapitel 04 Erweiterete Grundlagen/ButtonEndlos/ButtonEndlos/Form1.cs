using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEndlos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x = 0;

        private void CmdEreignis1_Click(object sender, EventArgs e)
        {
            CmdEreignis2_Click(sender, e);
        }

        private void CmdEreignis2_Click(object sender, EventArgs e)
        {
            x++;
            if (x < 1000)
            {
                CmdEreignis1_Click(sender, e);
            }
            else
            {
                LblAnzeige.Text = ":" + x;
            }
        }
    }
}
