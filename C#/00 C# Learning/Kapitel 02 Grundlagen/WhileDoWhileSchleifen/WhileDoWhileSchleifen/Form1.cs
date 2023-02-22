using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDoWhileSchleifen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new Random(); 

        private void CmdWhile_Click(object sender, EventArgs e)
        {
            int summe = 0, z;
            LblAnzeige.Text = "";

            while (summe < 20)
            {
                z = r.Next(1, 7);
                summe += z;
                LblAnzeige.Text += summe + "\n";
            }
        }

        private void CmdDoWhile_Click(object sender, EventArgs e)
        {
            int summe = 0, z;
            LblAnzeige.Text = "";

            do
            {
                z = r.Next(1, 7);
                summe += z;
                LblAnzeige.Text += summe + "\n";
            }
            while (summe < 20);
        }
    }
}
