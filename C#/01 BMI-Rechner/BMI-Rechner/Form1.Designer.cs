
namespace BMI_Rechner
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGewicht = new System.Windows.Forms.TextBox();
            this.tbGröße = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.btnFarbe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gewicht in kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Körpergröße in cm";
            // 
            // tbGewicht
            // 
            this.tbGewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGewicht.Location = new System.Drawing.Point(10, 47);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(301, 26);
            this.tbGewicht.TabIndex = 2;
            // 
            // tbGröße
            // 
            this.tbGröße.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGröße.Location = new System.Drawing.Point(10, 129);
            this.tbGröße.Name = "tbGröße";
            this.tbGröße.Size = new System.Drawing.Size(301, 26);
            this.tbGröße.TabIndex = 3;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerechnen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBerechnen.Location = new System.Drawing.Point(41, 182);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(185, 38);
            this.btnBerechnen.TabIndex = 4;
            this.btnBerechnen.Text = "BMI BERECHNEN";
            this.btnBerechnen.UseVisualStyleBackColor = false;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ihr BMI-Wert lautet:";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(486, 71);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 29);
            this.lblBMI.TabIndex = 6;
            // 
            // btnFarbe
            // 
            this.btnFarbe.Enabled = false;
            this.btnFarbe.Location = new System.Drawing.Point(440, 129);
            this.btnFarbe.Name = "btnFarbe";
            this.btnFarbe.Size = new System.Drawing.Size(181, 66);
            this.btnFarbe.TabIndex = 7;
            this.btnFarbe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 290);
            this.Controls.Add(this.btnFarbe);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.tbGröße);
            this.Controls.Add(this.tbGewicht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "BMI-Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGewicht;
        private System.Windows.Forms.TextBox tbGröße;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnFarbe;
    }
}

