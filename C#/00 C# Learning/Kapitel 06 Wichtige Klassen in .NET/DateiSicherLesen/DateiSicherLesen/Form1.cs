using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DateiSicherLesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdExistenz_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string dateiname = "ein.txt";
            string zeile;

            if (!File.Exists(dateiname))
            {
                MessageBox.Show("Datei " + dateiname + " existiert nicht");
                return;
            }

            fs = new FileStream(dateiname, FileMode.Open);
            sr = new StreamReader(fs);
            LblAnzeige.Text = "";
            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                LblAnzeige.Text += zeile + "\n";
            }
            sr.Close();
        }

        private void CmdAusnahme_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string zeile;

            try
            {
                fs = new FileStream("ein.txt", FileMode.Open);
                sr = new StreamReader(fs);
                LblAnzeige.Text = "";
                while (sr.Peek() != -1)
                {
                    zeile = sr.ReadLine();
                    LblAnzeige.Text += zeile + "\n";
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
