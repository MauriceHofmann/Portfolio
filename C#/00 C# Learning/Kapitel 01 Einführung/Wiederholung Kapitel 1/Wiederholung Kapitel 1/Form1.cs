using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wiederholung_Kapitel_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPositionRel_Click(object sender, EventArgs e)
        {
            CmdBewegung.Location = new Point(CmdBewegung.Location.X + 30, CmdBewegung.Location.Y + 30);
        }

        private void CmdPositionAbs_Click(object sender, EventArgs e)
        {
            CmdBewegung.Location = new Point(205, 327);
        }

        private void CmdGrößeRel_Click(object sender, EventArgs e)
        {
            CmdBewegung.Size = new Size(CmdBewegung.Size.Width *2, CmdBewegung.Size.Height *2);
        }

        private void CmdGrößeAbs_Click(object sender, EventArgs e)
        {
            CmdBewegung.Size = new Size(130, 30);
        }

        private void CmdNett_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Sehr geehrter Nutzer, \nVielen Dank, dass Sie unsere Anwendung testen!";
        }

        private void CmdBöse_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Verpiss dich sofort aus dem Programm!";
        }

        private void CmdInformation_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Der Button ´Bewegung´ hat derzeit folgende Werte:\n\nX: " + CmdBewegung.Location.X + "\nY: " + CmdBewegung.Location.Y
                               + "\n\nBreite: " + CmdBewegung.Size.Width + "\nHöhe: " + CmdBewegung.Size.Height;
        }

        private void CmdFarbe_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            CmdBewegung.BackColor = Color.GreenYellow;
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
