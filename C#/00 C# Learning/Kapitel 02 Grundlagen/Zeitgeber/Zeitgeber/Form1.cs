using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeitgeber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void CmdStop_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblAnzeige.Text += "x";
        }
    }
}
