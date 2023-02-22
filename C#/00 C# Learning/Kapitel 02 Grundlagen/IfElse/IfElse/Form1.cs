using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            LblAnzeige.Text = "";

            if(x > 0)
            {
                LblAnzeige.Text = "x ist größer als 0";
                NumX.BackColor = Color.LightGreen;
            }

        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;

            if(x > 0)
            {
                LblAnzeige.Text = "x ist größer als 0";
                NumX.BackColor = Color.LightGreen;
            }
            else 
            {
                LblAnzeige.Text = "x ist kleiner als 0 oder gleich 0";
                NumX.BackColor = Color.LightBlue;
            }
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;

            LblAnzeige.Text = x > 0 ? "x > 0" : "x <= 0";
            NumX.BackColor = x > 0 ? Color.LightGreen : Color.LightBlue;
        }

        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;

            if (x > 0)
            {
                LblAnzeige.Text = "x ist größer als 0";
                NumX.BackColor = Color.LightGreen;
            }
            else
            {
                NumX.BackColor = Color.LightBlue;

                if (x < 0)
                {
                    LblAnzeige.Text = "x ist kleiner als 0";
                }
                else
                {
                    LblAnzeige.Text = "x ist gleich 0";
                }
            }
        }

        private void CmdAnzeige5_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            int y = (int)NumY.Value;
            NumX.BackColor = Color.White;

            if(x > 0 && y > 0)
            {
                LblAnzeige.Text = " x und y sind größer als 0";
            }
            else
            {
                LblAnzeige.Text = "Mind. eine der beiden Zahlen ist nicht größer als 0";
            }

        }

        private void CmdAnzeige6_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            int y = (int)NumY.Value;
            NumX.BackColor = Color.White;

            if(x > 0 || y > 0)
            {
                LblAnzeige.Text = "x oder y oder beide sind größer als 0";
            }
            else
            {
                LblAnzeige.Text = "Keine der Zahlen ist größer als 0";
            }
        }

        private void CmdAnzeige7_Click(object sender, EventArgs e)
        {
            int x = (int)NumX.Value;
            int y = (int)NumY.Value;
            NumX.BackColor = Color.White;
            LblAnzeige.Text = "";

            if(x > 0 ^ y > 0)
            {
                LblAnzeige.Text = "Nur x oder nur y ist größer als 0";
            }
        }
    }
}
