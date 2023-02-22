
namespace Wiederholung_Kapitel_1
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
            this.CmdPositionRel = new System.Windows.Forms.Button();
            this.CmdGrößeRel = new System.Windows.Forms.Button();
            this.CmdPositionAbs = new System.Windows.Forms.Button();
            this.CmdGrößeAbs = new System.Windows.Forms.Button();
            this.CmdFarbe = new System.Windows.Forms.Button();
            this.CmdBewegung = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.CmdInformation = new System.Windows.Forms.Button();
            this.CmdNett = new System.Windows.Forms.Button();
            this.CmdBöse = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdPositionRel
            // 
            this.CmdPositionRel.Location = new System.Drawing.Point(73, 42);
            this.CmdPositionRel.Name = "CmdPositionRel";
            this.CmdPositionRel.Size = new System.Drawing.Size(75, 23);
            this.CmdPositionRel.TabIndex = 0;
            this.CmdPositionRel.Text = "Position Rel";
            this.CmdPositionRel.UseVisualStyleBackColor = true;
            this.CmdPositionRel.Click += new System.EventHandler(this.CmdPositionRel_Click);
            // 
            // CmdGrößeRel
            // 
            this.CmdGrößeRel.Location = new System.Drawing.Point(73, 85);
            this.CmdGrößeRel.Name = "CmdGrößeRel";
            this.CmdGrößeRel.Size = new System.Drawing.Size(75, 23);
            this.CmdGrößeRel.TabIndex = 1;
            this.CmdGrößeRel.Text = "Größe Rel";
            this.CmdGrößeRel.UseVisualStyleBackColor = true;
            this.CmdGrößeRel.Click += new System.EventHandler(this.CmdGrößeRel_Click);
            // 
            // CmdPositionAbs
            // 
            this.CmdPositionAbs.Location = new System.Drawing.Point(198, 42);
            this.CmdPositionAbs.Name = "CmdPositionAbs";
            this.CmdPositionAbs.Size = new System.Drawing.Size(75, 23);
            this.CmdPositionAbs.TabIndex = 2;
            this.CmdPositionAbs.Text = "Position Abs";
            this.CmdPositionAbs.UseVisualStyleBackColor = true;
            this.CmdPositionAbs.Click += new System.EventHandler(this.CmdPositionAbs_Click);
            // 
            // CmdGrößeAbs
            // 
            this.CmdGrößeAbs.Location = new System.Drawing.Point(198, 84);
            this.CmdGrößeAbs.Name = "CmdGrößeAbs";
            this.CmdGrößeAbs.Size = new System.Drawing.Size(75, 23);
            this.CmdGrößeAbs.TabIndex = 3;
            this.CmdGrößeAbs.Text = "Größe Abs";
            this.CmdGrößeAbs.UseVisualStyleBackColor = true;
            this.CmdGrößeAbs.Click += new System.EventHandler(this.CmdGrößeAbs_Click);
            // 
            // CmdFarbe
            // 
            this.CmdFarbe.Location = new System.Drawing.Point(73, 327);
            this.CmdFarbe.Name = "CmdFarbe";
            this.CmdFarbe.Size = new System.Drawing.Size(75, 23);
            this.CmdFarbe.TabIndex = 4;
            this.CmdFarbe.Text = "Farbe";
            this.CmdFarbe.UseVisualStyleBackColor = true;
            this.CmdFarbe.Click += new System.EventHandler(this.CmdFarbe_Click);
            // 
            // CmdBewegung
            // 
            this.CmdBewegung.Location = new System.Drawing.Point(143, 153);
            this.CmdBewegung.Name = "CmdBewegung";
            this.CmdBewegung.Size = new System.Drawing.Size(75, 23);
            this.CmdBewegung.TabIndex = 5;
            this.CmdBewegung.Text = "Bewegung";
            this.CmdBewegung.UseVisualStyleBackColor = true;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(652, 327);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 6;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // CmdInformation
            // 
            this.CmdInformation.Location = new System.Drawing.Point(336, 327);
            this.CmdInformation.Name = "CmdInformation";
            this.CmdInformation.Size = new System.Drawing.Size(75, 23);
            this.CmdInformation.TabIndex = 7;
            this.CmdInformation.Text = "Information";
            this.CmdInformation.UseVisualStyleBackColor = true;
            this.CmdInformation.Click += new System.EventHandler(this.CmdInformation_Click);
            // 
            // CmdNett
            // 
            this.CmdNett.Location = new System.Drawing.Point(498, 152);
            this.CmdNett.Name = "CmdNett";
            this.CmdNett.Size = new System.Drawing.Size(96, 23);
            this.CmdNett.TabIndex = 8;
            this.CmdNett.Text = "Nette Nachricht";
            this.CmdNett.UseVisualStyleBackColor = true;
            this.CmdNett.Click += new System.EventHandler(this.CmdNett_Click);
            // 
            // CmdBöse
            // 
            this.CmdBöse.Location = new System.Drawing.Point(652, 152);
            this.CmdBöse.Name = "CmdBöse";
            this.CmdBöse.Size = new System.Drawing.Size(100, 23);
            this.CmdBöse.TabIndex = 9;
            this.CmdBöse.Text = "Böse Nachricht";
            this.CmdBöse.UseVisualStyleBackColor = true;
            this.CmdBöse.Click += new System.EventHandler(this.CmdBöse_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(481, 42);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdBöse);
            this.Controls.Add(this.CmdNett);
            this.Controls.Add(this.CmdInformation);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdBewegung);
            this.Controls.Add(this.CmdFarbe);
            this.Controls.Add(this.CmdGrößeAbs);
            this.Controls.Add(this.CmdPositionAbs);
            this.Controls.Add(this.CmdGrößeRel);
            this.Controls.Add(this.CmdPositionRel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPositionRel;
        private System.Windows.Forms.Button CmdGrößeRel;
        private System.Windows.Forms.Button CmdPositionAbs;
        private System.Windows.Forms.Button CmdGrößeAbs;
        private System.Windows.Forms.Button CmdFarbe;
        private System.Windows.Forms.Button CmdBewegung;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Button CmdInformation;
        private System.Windows.Forms.Button CmdNett;
        private System.Windows.Forms.Button CmdBöse;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

