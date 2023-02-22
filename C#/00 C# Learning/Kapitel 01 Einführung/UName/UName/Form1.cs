using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdMeinName_Click(object sender, EventArgs e)
        {
            LblMeinName.Text = "Maurice Hofmann";
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
