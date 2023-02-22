using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double BMI;
            double Gewicht = (Convert.ToDouble(tbGewicht.Text));
            double Größe = (Convert.ToDouble(tbGröße.Text));

            BMI = Gewicht / ((Größe / 100) * (Größe / 100));
            
            if(BMI < 16.0)
            {
                btnFarbe.BackColor = Color.Red;
            }
            if(BMI >= 16.0)
            {
                btnFarbe.BackColor = Color.Orange;
            }
            if(BMI >= 17.0)
            {
                btnFarbe.BackColor = Color.Yellow;
            }
            if(BMI >= 18.5)
            {
                btnFarbe.BackColor = Color.LightGreen;
            }
            if(BMI >= 25.0)
            {
                btnFarbe.BackColor = Color.Yellow;
            }
            if(BMI >= 30.0)
            {
                btnFarbe.BackColor = Color.Orange;
            }
            if(BMI >= 35.0)
            {
                btnFarbe.BackColor = Color.Red;
            }

            lblBMI.Text = BMI.ToString("0.#");

           
        }
    }
}
