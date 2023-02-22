using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenfeldEreignis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }

        private void CmdEreignis_Click(object sender, EventArgs e)
        {
            LstSpeisen.SelectedIndex = 3;
        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Auswahl: " + LstSpeisen.SelectedItem;
        }
    }
}
