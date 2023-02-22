using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPanelZeitgeber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PanelTopLeft_Paint(object sender, PaintEventArgs e)
        {
            PanelTopLeft.BackColor = Color.Red;
            PanelTopRight.BackColor = Color.Blue;
            PanelBottomLeft.BackColor = Color.Green;
            PanelBottomRight.BackColor = Color.Yellow;
        }


        private void CmdStart_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            PanelTopLeft.Location = new Point(PanelTopLeft.Location.X - 5, PanelTopLeft.Location.Y - 5);
            PanelTopRight.Location = new Point(PanelTopRight.Location.X + 5, PanelTopRight.Location.Y - 5);
            PanelBottomLeft.Location = new Point(PanelBottomLeft.Location.X - 5, PanelBottomLeft.Location.Y + 5);
            PanelBottomRight.Location = new Point(PanelBottomRight.Location.X + 5, PanelBottomRight.Location.Y + 5);
        }
    }
}
