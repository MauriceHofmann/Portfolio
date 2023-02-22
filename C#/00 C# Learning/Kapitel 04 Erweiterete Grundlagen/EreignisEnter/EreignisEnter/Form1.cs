using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EreignisEnter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstPaketdienst.Items.Add("DHL");
            LstPaketdienst.Items.Add("Hermes");
            LstPaketdienst.Items.Add("UPS");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LblHilfe.Text = "";
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            LblHilfe.Text = "Bitte geben Sie Nachname, Vorname ein";
        }

        private void ChkKunde_Enter(object sender, EventArgs e)
        {
            LblHilfe.Text = "Kreuzen Sie an, ob Sie bereits Kunde sind";
        }

        private void LstPaketdienst_Enter(object sender, EventArgs e)
        {
            LblHilfe.Text = "Wählen Sie den Paketdienst aus";
        }

        private void OptZahlungsform_CheckedChanged(object sender, EventArgs e)
        {
            LblHilfe.Text = "Wählen Sie die Zahlungsform aus";
        }
    }
}
