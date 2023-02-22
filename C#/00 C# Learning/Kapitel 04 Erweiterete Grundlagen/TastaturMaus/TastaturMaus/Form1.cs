using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TastaturMaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            LblEingabe.Text = "KeyDown, Code:" + e.KeyCode + ", Value:" + e.KeyValue +
                              ", Alt" + e.Alt + ", Control:" + e.Control + ",Shift:" + e.Shift;

            if(e.KeyCode == Keys.Return)
            {
                LblEingabe.Text += ", Return";
            }
            else if (e.KeyCode == Keys.Delete)
            {
                LblEingabe.Text += ", Delete";
            }
        }

        private void PanMaus_MouseDown(object sender, MouseEventArgs e)
        {
            LblMaus.Text = "MouseDown, X:" + e.X + "Y:" + e.Y + ", Button" + e.Button +
                           ", Clicks:" + e.Clicks;
        }
    }
}
