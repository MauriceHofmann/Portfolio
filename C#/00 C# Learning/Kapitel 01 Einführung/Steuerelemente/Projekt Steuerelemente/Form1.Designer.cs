
namespace Projekt_Steuerelemente
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
            this.CmdTest = new System.Windows.Forms.Button();
            this.CmdGroesseAbs = new System.Windows.Forms.Button();
            this.CmdPositionAbs = new System.Windows.Forms.Button();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.CmdFarbe = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdPostionRel = new System.Windows.Forms.Button();
            this.CmdGroesseRel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdTest
            // 
            this.CmdTest.Location = new System.Drawing.Point(37, 185);
            this.CmdTest.Name = "CmdTest";
            this.CmdTest.Size = new System.Drawing.Size(115, 23);
            this.CmdTest.TabIndex = 2;
            this.CmdTest.Text = "Test";
            this.CmdTest.UseVisualStyleBackColor = true;
            // 
            // CmdGroesseAbs
            // 
            this.CmdGroesseAbs.Location = new System.Drawing.Point(37, 103);
            this.CmdGroesseAbs.Name = "CmdGroesseAbs";
            this.CmdGroesseAbs.Size = new System.Drawing.Size(75, 23);
            this.CmdGroesseAbs.TabIndex = 4;
            this.CmdGroesseAbs.Text = "Größe Abs";
            this.CmdGroesseAbs.UseVisualStyleBackColor = true;
            this.CmdGroesseAbs.Click += new System.EventHandler(this.CmdGroesseAbs_Click);
            // 
            // CmdPositionAbs
            // 
            this.CmdPositionAbs.Location = new System.Drawing.Point(37, 21);
            this.CmdPositionAbs.Name = "CmdPositionAbs";
            this.CmdPositionAbs.Size = new System.Drawing.Size(75, 23);
            this.CmdPositionAbs.TabIndex = 3;
            this.CmdPositionAbs.Text = "Position Abs";
            this.CmdPositionAbs.UseVisualStyleBackColor = true;
            this.CmdPositionAbs.Click += new System.EventHandler(this.CmdPositionAbs_Click);
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(267, 20);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 5;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // CmdFarbe
            // 
            this.CmdFarbe.Location = new System.Drawing.Point(267, 116);
            this.CmdFarbe.Name = "CmdFarbe";
            this.CmdFarbe.Size = new System.Drawing.Size(75, 23);
            this.CmdFarbe.TabIndex = 6;
            this.CmdFarbe.Text = "Farbe";
            this.CmdFarbe.UseVisualStyleBackColor = true;
            this.CmdFarbe.Click += new System.EventHandler(this.CmdFarbe_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(264, 80);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 7;
            // 
            // CmdPostionRel
            // 
            this.CmdPostionRel.Location = new System.Drawing.Point(37, 62);
            this.CmdPostionRel.Name = "CmdPostionRel";
            this.CmdPostionRel.Size = new System.Drawing.Size(75, 23);
            this.CmdPostionRel.TabIndex = 8;
            this.CmdPostionRel.Text = "Position Rel";
            this.CmdPostionRel.UseVisualStyleBackColor = true;
            this.CmdPostionRel.Click += new System.EventHandler(this.CmdPostionRel_Click);
            // 
            // CmdGroesseRel
            // 
            this.CmdGroesseRel.Location = new System.Drawing.Point(37, 144);
            this.CmdGroesseRel.Name = "CmdGroesseRel";
            this.CmdGroesseRel.Size = new System.Drawing.Size(75, 23);
            this.CmdGroesseRel.TabIndex = 9;
            this.CmdGroesseRel.Text = "Größe Rel";
            this.CmdGroesseRel.UseVisualStyleBackColor = true;
            this.CmdGroesseRel.Click += new System.EventHandler(this.CmdGroesseRel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.CmdGroesseRel);
            this.Controls.Add(this.CmdPostionRel);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdFarbe);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.CmdGroesseAbs);
            this.Controls.Add(this.CmdPositionAbs);
            this.Controls.Add(this.CmdTest);
            this.Name = "Form1";
            this.Text = "Position, Größe, Farbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdTest;
        private System.Windows.Forms.Button CmdGroesseAbs;
        private System.Windows.Forms.Button CmdPositionAbs;
        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Button CmdFarbe;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdPostionRel;
        private System.Windows.Forms.Button CmdGroesseRel;
    }
}

