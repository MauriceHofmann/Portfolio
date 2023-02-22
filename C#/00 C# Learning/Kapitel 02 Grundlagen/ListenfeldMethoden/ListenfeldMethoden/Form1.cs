using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenfeldMethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            int x = LstSpeisen.SelectedIndex;
            if ( x != -1)
            {
                LstSpeisen.Items.RemoveAt(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }

        private void CmdEinfügen_Click(object sender, EventArgs e)
        {
            if(TxtNeu.Text == "")
            {
                return;
            }

            if(OptAnfang.Checked)
            {
                LstSpeisen.Items.Insert(0, TxtNeu.Text);
            }
            else if (OptAuswahl.Checked)
            {
                if(LstSpeisen.SelectedIndex != -1)
                {
                    LstSpeisen.Items.Insert(LstSpeisen.SelectedIndex, TxtNeu.Text);
                }
            }
            else
            {
                LstSpeisen.Items.Add(TxtNeu.Text);
            }
            TxtNeu.Text = "";
        }

        private void CmdErsetzen_Click(object sender, EventArgs e)
        {
            int x = LstSpeisen.SelectedIndex;

            if(TxtErsetzen.Text != "" && x != -1)
            {
                LstSpeisen.Items.RemoveAt(x);
                LstSpeisen.Items.Insert(x, TxtErsetzen.Text);
                TxtErsetzen.Text = "";
            }
        }

        private void CmdAllesLoeschen_Click(object sender, EventArgs e)
        {
            LstSpeisen.Items.Clear();
        }
    }
}
