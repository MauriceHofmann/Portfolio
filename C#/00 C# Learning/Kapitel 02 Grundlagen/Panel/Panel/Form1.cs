using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel.BackColor = Color.GreenYellow;
        }

        private void CmdNachOben_Click(object sender, EventArgs e)
        {
            Panel.Location = new Point(Panel.Location.X, Panel.Location.Y - 10);
        }

        private void CmdNachLinks_Click(object sender, EventArgs e)
        {
            Panel.Location = new Point(Panel.Location.X - 10, Panel.Location.Y);
        }

        private void CmdNachRechts_Click(object sender, EventArgs e)
        {
            Panel.Location = new Point(Panel.Location.X + 10, Panel.Location.Y);
        }

        private void CmdNachUnten_Click(object sender, EventArgs e)
        {
            Panel.Location = new Point(Panel.Location.X, Panel.Location.Y + 10);
        }
    }
}
