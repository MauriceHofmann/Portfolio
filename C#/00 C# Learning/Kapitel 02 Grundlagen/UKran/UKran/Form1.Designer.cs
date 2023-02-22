
namespace UKran
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CmdHakenAus = new System.Windows.Forms.Button();
            this.CmdHakenEin = new System.Windows.Forms.Button();
            this.CmdAuslegerAus = new System.Windows.Forms.Button();
            this.CmdAuslegerEin = new System.Windows.Forms.Button();
            this.CmdKranRechts = new System.Windows.Forms.Button();
            this.CmdKranLinks = new System.Windows.Forms.Button();
            this.CmdKranAus = new System.Windows.Forms.Button();
            this.CmdKranEin = new System.Windows.Forms.Button();
            this.PanelFundament = new System.Windows.Forms.Panel();
            this.PanelSenkrechtesHauptelement = new System.Windows.Forms.Panel();
            this.PanelWaagrechterAusleger = new System.Windows.Forms.Panel();
            this.PanelSenkrechterHaken = new System.Windows.Forms.Panel();
            this.OptHakenAusfahren = new System.Windows.Forms.RadioButton();
            this.OptHakenEinfahren = new System.Windows.Forms.RadioButton();
            this.OptAuslegerAusfahren = new System.Windows.Forms.RadioButton();
            this.OptAuslegerEinfahren = new System.Windows.Forms.RadioButton();
            this.OptKranRechts = new System.Windows.Forms.RadioButton();
            this.OptKranLinks = new System.Windows.Forms.RadioButton();
            this.OptKranAusfahren = new System.Windows.Forms.RadioButton();
            this.OptKranEinfahren = new System.Windows.Forms.RadioButton();
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdStop = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdHakenAus
            // 
            this.CmdHakenAus.Location = new System.Drawing.Point(543, 43);
            this.CmdHakenAus.Name = "CmdHakenAus";
            this.CmdHakenAus.Size = new System.Drawing.Size(101, 23);
            this.CmdHakenAus.TabIndex = 0;
            this.CmdHakenAus.Text = "Haken aus";
            this.CmdHakenAus.UseVisualStyleBackColor = true;
            this.CmdHakenAus.Click += new System.EventHandler(this.CmdHakenAus_Click);
            // 
            // CmdHakenEin
            // 
            this.CmdHakenEin.Location = new System.Drawing.Point(543, 72);
            this.CmdHakenEin.Name = "CmdHakenEin";
            this.CmdHakenEin.Size = new System.Drawing.Size(101, 23);
            this.CmdHakenEin.TabIndex = 1;
            this.CmdHakenEin.Text = "Haken ein";
            this.CmdHakenEin.UseVisualStyleBackColor = true;
            this.CmdHakenEin.Click += new System.EventHandler(this.CmdHakenEin_Click);
            // 
            // CmdAuslegerAus
            // 
            this.CmdAuslegerAus.Location = new System.Drawing.Point(543, 101);
            this.CmdAuslegerAus.Name = "CmdAuslegerAus";
            this.CmdAuslegerAus.Size = new System.Drawing.Size(101, 23);
            this.CmdAuslegerAus.TabIndex = 2;
            this.CmdAuslegerAus.Text = "Ausleger aus";
            this.CmdAuslegerAus.UseVisualStyleBackColor = true;
            this.CmdAuslegerAus.Click += new System.EventHandler(this.CmdAuslegerAus_Click);
            // 
            // CmdAuslegerEin
            // 
            this.CmdAuslegerEin.Location = new System.Drawing.Point(543, 130);
            this.CmdAuslegerEin.Name = "CmdAuslegerEin";
            this.CmdAuslegerEin.Size = new System.Drawing.Size(101, 23);
            this.CmdAuslegerEin.TabIndex = 3;
            this.CmdAuslegerEin.Text = "Ausleger ein";
            this.CmdAuslegerEin.UseVisualStyleBackColor = true;
            this.CmdAuslegerEin.Click += new System.EventHandler(this.CmdAuslegerEin_Click);
            // 
            // CmdKranRechts
            // 
            this.CmdKranRechts.Location = new System.Drawing.Point(543, 159);
            this.CmdKranRechts.Name = "CmdKranRechts";
            this.CmdKranRechts.Size = new System.Drawing.Size(101, 23);
            this.CmdKranRechts.TabIndex = 4;
            this.CmdKranRechts.Text = "Kran rechts";
            this.CmdKranRechts.UseVisualStyleBackColor = true;
            this.CmdKranRechts.Click += new System.EventHandler(this.CmdKranRechts_Click);
            // 
            // CmdKranLinks
            // 
            this.CmdKranLinks.Location = new System.Drawing.Point(543, 188);
            this.CmdKranLinks.Name = "CmdKranLinks";
            this.CmdKranLinks.Size = new System.Drawing.Size(101, 23);
            this.CmdKranLinks.TabIndex = 5;
            this.CmdKranLinks.Text = "Kran links";
            this.CmdKranLinks.UseVisualStyleBackColor = true;
            this.CmdKranLinks.Click += new System.EventHandler(this.CmdKranLinks_Click);
            // 
            // CmdKranAus
            // 
            this.CmdKranAus.Location = new System.Drawing.Point(543, 217);
            this.CmdKranAus.Name = "CmdKranAus";
            this.CmdKranAus.Size = new System.Drawing.Size(101, 23);
            this.CmdKranAus.TabIndex = 6;
            this.CmdKranAus.Text = "Kran aus";
            this.CmdKranAus.UseVisualStyleBackColor = true;
            this.CmdKranAus.Click += new System.EventHandler(this.CmdKranAus_Click);
            // 
            // CmdKranEin
            // 
            this.CmdKranEin.Location = new System.Drawing.Point(543, 246);
            this.CmdKranEin.Name = "CmdKranEin";
            this.CmdKranEin.Size = new System.Drawing.Size(101, 23);
            this.CmdKranEin.TabIndex = 7;
            this.CmdKranEin.Text = "Kran ein";
            this.CmdKranEin.UseVisualStyleBackColor = true;
            this.CmdKranEin.Click += new System.EventHandler(this.CmdKranEin_Click);
            // 
            // PanelFundament
            // 
            this.PanelFundament.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelFundament.Location = new System.Drawing.Point(157, 303);
            this.PanelFundament.Name = "PanelFundament";
            this.PanelFundament.Size = new System.Drawing.Size(181, 14);
            this.PanelFundament.TabIndex = 8;
            // 
            // PanelSenkrechtesHauptelement
            // 
            this.PanelSenkrechtesHauptelement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelSenkrechtesHauptelement.Location = new System.Drawing.Point(239, 79);
            this.PanelSenkrechtesHauptelement.Name = "PanelSenkrechtesHauptelement";
            this.PanelSenkrechtesHauptelement.Size = new System.Drawing.Size(16, 225);
            this.PanelSenkrechtesHauptelement.TabIndex = 9;
            // 
            // PanelWaagrechterAusleger
            // 
            this.PanelWaagrechterAusleger.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelWaagrechterAusleger.Location = new System.Drawing.Point(81, 79);
            this.PanelWaagrechterAusleger.Name = "PanelWaagrechterAusleger";
            this.PanelWaagrechterAusleger.Size = new System.Drawing.Size(174, 16);
            this.PanelWaagrechterAusleger.TabIndex = 10;
            // 
            // PanelSenkrechterHaken
            // 
            this.PanelSenkrechterHaken.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelSenkrechterHaken.Location = new System.Drawing.Point(81, 79);
            this.PanelSenkrechterHaken.Name = "PanelSenkrechterHaken";
            this.PanelSenkrechterHaken.Size = new System.Drawing.Size(17, 79);
            this.PanelSenkrechterHaken.TabIndex = 11;
            // 
            // OptHakenAusfahren
            // 
            this.OptHakenAusfahren.AutoSize = true;
            this.OptHakenAusfahren.Location = new System.Drawing.Point(747, 46);
            this.OptHakenAusfahren.Name = "OptHakenAusfahren";
            this.OptHakenAusfahren.Size = new System.Drawing.Size(107, 17);
            this.OptHakenAusfahren.TabIndex = 12;
            this.OptHakenAusfahren.TabStop = true;
            this.OptHakenAusfahren.Text = "Haken ausfahren";
            this.OptHakenAusfahren.UseVisualStyleBackColor = true;
            // 
            // OptHakenEinfahren
            // 
            this.OptHakenEinfahren.AutoSize = true;
            this.OptHakenEinfahren.Location = new System.Drawing.Point(747, 75);
            this.OptHakenEinfahren.Name = "OptHakenEinfahren";
            this.OptHakenEinfahren.Size = new System.Drawing.Size(104, 17);
            this.OptHakenEinfahren.TabIndex = 13;
            this.OptHakenEinfahren.TabStop = true;
            this.OptHakenEinfahren.Text = "Haken einfahren";
            this.OptHakenEinfahren.UseVisualStyleBackColor = true;
            // 
            // OptAuslegerAusfahren
            // 
            this.OptAuslegerAusfahren.AutoSize = true;
            this.OptAuslegerAusfahren.Location = new System.Drawing.Point(747, 104);
            this.OptAuslegerAusfahren.Name = "OptAuslegerAusfahren";
            this.OptAuslegerAusfahren.Size = new System.Drawing.Size(116, 17);
            this.OptAuslegerAusfahren.TabIndex = 14;
            this.OptAuslegerAusfahren.TabStop = true;
            this.OptAuslegerAusfahren.Text = "Ausleger ausfahren";
            this.OptAuslegerAusfahren.UseVisualStyleBackColor = true;
            // 
            // OptAuslegerEinfahren
            // 
            this.OptAuslegerEinfahren.AutoSize = true;
            this.OptAuslegerEinfahren.Location = new System.Drawing.Point(747, 133);
            this.OptAuslegerEinfahren.Name = "OptAuslegerEinfahren";
            this.OptAuslegerEinfahren.Size = new System.Drawing.Size(113, 17);
            this.OptAuslegerEinfahren.TabIndex = 15;
            this.OptAuslegerEinfahren.TabStop = true;
            this.OptAuslegerEinfahren.Text = "Ausleger einfahren";
            this.OptAuslegerEinfahren.UseVisualStyleBackColor = true;
            // 
            // OptKranRechts
            // 
            this.OptKranRechts.AutoSize = true;
            this.OptKranRechts.Location = new System.Drawing.Point(747, 162);
            this.OptKranRechts.Name = "OptKranRechts";
            this.OptKranRechts.Size = new System.Drawing.Size(79, 17);
            this.OptKranRechts.TabIndex = 16;
            this.OptKranRechts.TabStop = true;
            this.OptKranRechts.Text = "Kran rechts";
            this.OptKranRechts.UseVisualStyleBackColor = true;
            // 
            // OptKranLinks
            // 
            this.OptKranLinks.AutoSize = true;
            this.OptKranLinks.Location = new System.Drawing.Point(747, 191);
            this.OptKranLinks.Name = "OptKranLinks";
            this.OptKranLinks.Size = new System.Drawing.Size(71, 17);
            this.OptKranLinks.TabIndex = 17;
            this.OptKranLinks.TabStop = true;
            this.OptKranLinks.Text = "Kran links";
            this.OptKranLinks.UseVisualStyleBackColor = true;
            // 
            // OptKranAusfahren
            // 
            this.OptKranAusfahren.AutoSize = true;
            this.OptKranAusfahren.Location = new System.Drawing.Point(747, 220);
            this.OptKranAusfahren.Name = "OptKranAusfahren";
            this.OptKranAusfahren.Size = new System.Drawing.Size(97, 17);
            this.OptKranAusfahren.TabIndex = 18;
            this.OptKranAusfahren.TabStop = true;
            this.OptKranAusfahren.Text = "Kran ausfahren";
            this.OptKranAusfahren.UseVisualStyleBackColor = true;
            // 
            // OptKranEinfahren
            // 
            this.OptKranEinfahren.AutoSize = true;
            this.OptKranEinfahren.Location = new System.Drawing.Point(747, 249);
            this.OptKranEinfahren.Name = "OptKranEinfahren";
            this.OptKranEinfahren.Size = new System.Drawing.Size(94, 17);
            this.OptKranEinfahren.TabIndex = 19;
            this.OptKranEinfahren.TabStop = true;
            this.OptKranEinfahren.Text = "Kran einfahren";
            this.OptKranEinfahren.UseVisualStyleBackColor = true;
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(747, 293);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 20;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(875, 293);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(70, 23);
            this.CmdStop.TabIndex = 21;
            this.CmdStop.Text = "Stop";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 400;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 388);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.OptKranEinfahren);
            this.Controls.Add(this.OptKranAusfahren);
            this.Controls.Add(this.OptKranLinks);
            this.Controls.Add(this.OptKranRechts);
            this.Controls.Add(this.OptAuslegerEinfahren);
            this.Controls.Add(this.OptAuslegerAusfahren);
            this.Controls.Add(this.OptHakenEinfahren);
            this.Controls.Add(this.OptHakenAusfahren);
            this.Controls.Add(this.PanelSenkrechterHaken);
            this.Controls.Add(this.PanelWaagrechterAusleger);
            this.Controls.Add(this.PanelSenkrechtesHauptelement);
            this.Controls.Add(this.PanelFundament);
            this.Controls.Add(this.CmdKranEin);
            this.Controls.Add(this.CmdKranAus);
            this.Controls.Add(this.CmdKranLinks);
            this.Controls.Add(this.CmdKranRechts);
            this.Controls.Add(this.CmdAuslegerEin);
            this.Controls.Add(this.CmdAuslegerAus);
            this.Controls.Add(this.CmdHakenEin);
            this.Controls.Add(this.CmdHakenAus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdHakenAus;
        private System.Windows.Forms.Button CmdHakenEin;
        private System.Windows.Forms.Button CmdAuslegerAus;
        private System.Windows.Forms.Button CmdAuslegerEin;
        private System.Windows.Forms.Button CmdKranRechts;
        private System.Windows.Forms.Button CmdKranLinks;
        private System.Windows.Forms.Button CmdKranAus;
        private System.Windows.Forms.Button CmdKranEin;
        private System.Windows.Forms.Panel PanelFundament;
        private System.Windows.Forms.Panel PanelSenkrechtesHauptelement;
        private System.Windows.Forms.Panel PanelWaagrechterAusleger;
        private System.Windows.Forms.Panel PanelSenkrechterHaken;
        private System.Windows.Forms.RadioButton OptHakenAusfahren;
        private System.Windows.Forms.RadioButton OptHakenEinfahren;
        private System.Windows.Forms.RadioButton OptAuslegerAusfahren;
        private System.Windows.Forms.RadioButton OptAuslegerEinfahren;
        private System.Windows.Forms.RadioButton OptKranRechts;
        private System.Windows.Forms.RadioButton OptKranLinks;
        private System.Windows.Forms.RadioButton OptKranAusfahren;
        private System.Windows.Forms.RadioButton OptKranEinfahren;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Button CmdStop;
        private System.Windows.Forms.Timer Timer;
    }
}

