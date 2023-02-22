using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldDynamisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly Random r = new Random();
        private int[] a;


        private void CmdOriginal_Click(object sender, EventArgs e)
        {
            a = new int[4];
            LstFeld.Items.Clear();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }

        }

        private void CmdNeu1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref a, 6);
            LstFeld.Items.Clear();

            for (int i = 0; i < a.Length; i++)
            {
                LstFeld.Items.Add(a[i]);
            }
        }

        private void CmdNeu2_Click(object sender, EventArgs e)
        {
            Array.Resize(ref a, (int)NumGroesse.Value);
            LstFeld.Items.Clear();

            for(int i = 0; i < a.Length; i++)
            {
                LstFeld.Items.Add(a[i]);
            }
        }
    }
}
