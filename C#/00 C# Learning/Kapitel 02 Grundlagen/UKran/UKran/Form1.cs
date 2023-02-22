using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Buttons zum steuern des Krans

        private void CmdHakenAus_Click(object sender, EventArgs e)
        {
            if (PanelSenkrechterHaken.Location.Y + PanelSenkrechterHaken.Height + 5 < PanelFundament.Location.Y)
            {
                PanelSenkrechterHaken.Size = new Size(PanelSenkrechterHaken.Width, PanelSenkrechterHaken.Height + 10);
            }

            //PanelSenkrechterHaken.Height += 10;
        }

        private void CmdHakenEin_Click(object sender, EventArgs e)
        {
            if (PanelSenkrechterHaken.Height > 15)
            {
                PanelSenkrechterHaken.Size = new Size(PanelSenkrechterHaken.Width, PanelSenkrechterHaken.Height - 10);
            }

            //PanelSenkrechterHaken.Height -= 10;
        }

        private void CmdAuslegerAus_Click(object sender, EventArgs e)
        {
            if (PanelWaagrechterAusleger.Location.X > 15)
            {
                PanelWaagrechterAusleger.Size = new Size(PanelWaagrechterAusleger.Width + 10, PanelWaagrechterAusleger.Height);
                PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X - 10, PanelWaagrechterAusleger.Location.Y);
                PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X - 10, PanelSenkrechterHaken.Location.Y);
            }

            /*PanelWaagrechterAusleger.Width += 10;
            PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X - 10, PanelWaagrechterAusleger.Location.Y);
            PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X - 10, PanelSenkrechterHaken.Location.Y);*/
        }

        private void CmdAuslegerEin_Click(object sender, EventArgs e)
        {
            if (PanelWaagrechterAusleger.Width > 30)
            {
                PanelWaagrechterAusleger.Size = new Size(PanelWaagrechterAusleger.Width - 10, PanelWaagrechterAusleger.Height);
                PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X + 10, PanelWaagrechterAusleger.Location.Y);
                PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X + 10, PanelSenkrechterHaken.Location.Y);
            }

            /*PanelWaagrechterAusleger.Width += 10;
            PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X + 10, PanelWaagrechterAusleger.Location.Y);
            PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X + 10, PanelSenkrechterHaken.Location.Y);*/
        }

        private void CmdKranRechts_Click(object sender, EventArgs e)
        {
            if (PanelFundament.Location.X < 215)
            {
                PanelFundament.Location = new Point(PanelFundament.Location.X + 10, PanelFundament.Location.Y);
                PanelSenkrechtesHauptelement.Location = new Point(PanelSenkrechtesHauptelement.Location.X + 10, PanelSenkrechtesHauptelement.Location.Y);
                PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X + 10, PanelWaagrechterAusleger.Location.Y);
                PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X + 10, PanelWaagrechterAusleger.Location.Y);
            }
        }

        private void CmdKranLinks_Click(object sender, EventArgs e)
        {
            if (PanelFundament.Location.X > 15 && PanelWaagrechterAusleger.Location.X > 15)
            {
                PanelFundament.Location = new Point(PanelFundament.Location.X - 10, PanelFundament.Location.Y);
                PanelSenkrechtesHauptelement.Location = new Point(PanelSenkrechtesHauptelement.Location.X - 10, PanelSenkrechtesHauptelement.Location.Y);
                PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X - 10, PanelWaagrechterAusleger.Location.Y);
                PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X - 10, PanelSenkrechterHaken.Location.Y);
            }
        }

        private void CmdKranAus_Click(object sender, EventArgs e)
        {
            if (PanelSenkrechtesHauptelement.Location.Y > 15)
            {
                PanelSenkrechtesHauptelement.Size = new Size(PanelSenkrechtesHauptelement.Width, PanelSenkrechtesHauptelement.Height + 10);
                PanelSenkrechtesHauptelement.Location = new Point(PanelSenkrechtesHauptelement.Location.X, PanelSenkrechtesHauptelement.Location.Y - 10);
                PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X, PanelWaagrechterAusleger.Location.Y - 10);
                PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X, PanelSenkrechterHaken.Location.Y - 10);
            }
        }

        private void CmdKranEin_Click(object sender, EventArgs e)
        {
            if (PanelSenkrechterHaken.Location.Y + PanelSenkrechterHaken.Height + 5 < PanelFundament.Location.Y)
            {
                PanelSenkrechtesHauptelement.Size = new Size(PanelSenkrechtesHauptelement.Width, PanelSenkrechtesHauptelement.Height - 10);
                PanelSenkrechtesHauptelement.Location = new Point(PanelSenkrechtesHauptelement.Location.X, PanelSenkrechtesHauptelement.Location.Y + 10);
                PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X, PanelWaagrechterAusleger.Location.Y + 10);
                PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X, PanelSenkrechterHaken.Location.Y + 10);
            }
        }

        //Radiobuttons zum steuern des Krans mithilfe des Timers

        private void CmdStart_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void CmdStop_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(OptHakenAusfahren.Checked)
            {
                if(PanelSenkrechterHaken.Location.Y + PanelSenkrechterHaken.Height + 5 < PanelFundament.Location.Y)
                {
                    PanelSenkrechterHaken.Size = new Size(PanelSenkrechterHaken.Width, PanelSenkrechterHaken.Height + 10);
                }
                else
                {
                    Timer.Enabled = false;
                }
            }

            else if(OptHakenEinfahren.Checked)
            {
                if(PanelSenkrechterHaken.Height > 15)
                {
                    PanelSenkrechterHaken.Size = new Size(PanelSenkrechterHaken.Width, PanelSenkrechterHaken.Height - 10);
                }
                else
                {
                    Timer.Enabled = false;
                }
            }

            else if(OptAuslegerAusfahren.Checked)
            {
                if(PanelWaagrechterAusleger.Location.X > 15)
                {
                    PanelWaagrechterAusleger.Size = new Size(PanelWaagrechterAusleger.Width + 10, PanelWaagrechterAusleger.Height);
                    PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X - 10, PanelWaagrechterAusleger.Location.Y);
                    PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X - 10, PanelSenkrechterHaken.Location.Y);
                }
                else
                {
                    Timer.Enabled = false;
                }
            }

            else if (OptAuslegerEinfahren.Checked)
            {
                if (PanelWaagrechterAusleger.Width > 25)
                {
                    PanelWaagrechterAusleger.Size = new Size(PanelWaagrechterAusleger.Width - 10, PanelWaagrechterAusleger.Height);
                    PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X + 10, PanelWaagrechterAusleger.Location.Y);
                    PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X + 10, PanelSenkrechterHaken.Location.Y);
                }
                else
                {
                    Timer.Enabled = false;
                }
            }

            else if(OptKranRechts.Checked)
            {
                if(PanelFundament.Location.X < 215)
                {
                    PanelFundament.Location = new Point(PanelFundament.Location.X + 10, PanelFundament.Location.Y);
                    PanelSenkrechtesHauptelement.Location = new Point(PanelSenkrechtesHauptelement.Location.X + 10, PanelSenkrechtesHauptelement.Location.Y);
                    PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X + 10, PanelWaagrechterAusleger.Location.Y);
                    PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X + 10, PanelSenkrechterHaken.Location.Y);
                }
                else
                {
                    Timer.Enabled = false;
                }
            }

            else if(OptKranLinks.Checked)
            {
                if(PanelFundament.Location.X > 15 && PanelWaagrechterAusleger.Location.X > 15)
                {
                    PanelFundament.Location = new Point(PanelFundament.Location.X - 10, PanelFundament.Location.Y);
                    PanelSenkrechtesHauptelement.Location = new Point(PanelSenkrechtesHauptelement.Location.X - 10, PanelSenkrechtesHauptelement.Location.Y);
                    PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X - 10, PanelWaagrechterAusleger.Location.Y);
                    PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X - 10, PanelSenkrechterHaken.Location.Y);
                }
                else
                {
                    Timer.Enabled = false;
                }
            }

            else if(OptKranAusfahren.Checked)
            {
                if(PanelSenkrechtesHauptelement.Location.Y > 15)
                {
                    PanelSenkrechtesHauptelement.Size = new Size(PanelSenkrechtesHauptelement.Width, PanelSenkrechtesHauptelement.Height + 10);
                    PanelSenkrechtesHauptelement.Location = new Point(PanelSenkrechtesHauptelement.Location.X, PanelSenkrechtesHauptelement.Location.Y - 10);
                    PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X, PanelWaagrechterAusleger.Location.Y - 10);
                    PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X, PanelSenkrechterHaken.Location.Y - 10);
                }
                else 
                {
                    Timer.Enabled = false;
                }
            }

            else if(OptKranEinfahren.Checked)
            {
                if (PanelSenkrechterHaken.Location.Y + PanelSenkrechterHaken.Height + 5 < PanelFundament.Location.Y)
                {
                    PanelSenkrechtesHauptelement.Size = new Size(PanelSenkrechtesHauptelement.Width, PanelSenkrechtesHauptelement.Height - 10);
                    PanelSenkrechtesHauptelement.Location = new Point(PanelSenkrechtesHauptelement.Location.X, PanelSenkrechtesHauptelement.Location.Y + 10);
                    PanelWaagrechterAusleger.Location = new Point(PanelWaagrechterAusleger.Location.X, PanelWaagrechterAusleger.Location.Y + 10);
                    PanelSenkrechterHaken.Location = new Point(PanelSenkrechterHaken.Location.X, PanelSenkrechterHaken.Location.Y +10);
                }
                else
                {
                    Timer.Enabled = false;
                }
            }
        }
    }
}
