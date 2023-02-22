
namespace Optionen
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
            this.LblTest1 = new System.Windows.Forms.Label();
            this.LblTest2 = new System.Windows.Forms.Label();
            this.CmdPrüfen = new System.Windows.Forms.Button();
            this.CmdSchalter = new System.Windows.Forms.Button();
            this.OptFarbeRot = new System.Windows.Forms.RadioButton();
            this.OptFarbeGruen = new System.Windows.Forms.RadioButton();
            this.OptFarbeBlau = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LblTest1
            // 
            this.LblTest1.AutoSize = true;
            this.LblTest1.Location = new System.Drawing.Point(13, 13);
            this.LblTest1.Name = "LblTest1";
            this.LblTest1.Size = new System.Drawing.Size(0, 13);
            this.LblTest1.TabIndex = 0;
            // 
            // LblTest2
            // 
            this.LblTest2.AutoSize = true;
            this.LblTest2.Location = new System.Drawing.Point(13, 100);
            this.LblTest2.Name = "LblTest2";
            this.LblTest2.Size = new System.Drawing.Size(0, 13);
            this.LblTest2.TabIndex = 1;
            // 
            // CmdPrüfen
            // 
            this.CmdPrüfen.Location = new System.Drawing.Point(154, 13);
            this.CmdPrüfen.Name = "CmdPrüfen";
            this.CmdPrüfen.Size = new System.Drawing.Size(75, 23);
            this.CmdPrüfen.TabIndex = 2;
            this.CmdPrüfen.Text = "Prüfen";
            this.CmdPrüfen.UseVisualStyleBackColor = true;
            this.CmdPrüfen.Click += new System.EventHandler(this.CmdPrüfen_Click);
            // 
            // CmdSchalter
            // 
            this.CmdSchalter.Location = new System.Drawing.Point(154, 114);
            this.CmdSchalter.Name = "CmdSchalter";
            this.CmdSchalter.Size = new System.Drawing.Size(75, 23);
            this.CmdSchalter.TabIndex = 3;
            this.CmdSchalter.Text = "Rot schalten";
            this.CmdSchalter.UseVisualStyleBackColor = true;
            this.CmdSchalter.Click += new System.EventHandler(this.CmdSchalter_Click);
            // 
            // OptFarbeRot
            // 
            this.OptFarbeRot.AutoSize = true;
            this.OptFarbeRot.Location = new System.Drawing.Point(154, 43);
            this.OptFarbeRot.Name = "OptFarbeRot";
            this.OptFarbeRot.Size = new System.Drawing.Size(42, 17);
            this.OptFarbeRot.TabIndex = 4;
            this.OptFarbeRot.TabStop = true;
            this.OptFarbeRot.Text = "Rot";
            this.OptFarbeRot.UseVisualStyleBackColor = true;
            this.OptFarbeRot.CheckedChanged += new System.EventHandler(this.OptFarbeRot_CheckedChanged);
            // 
            // OptFarbeGruen
            // 
            this.OptFarbeGruen.AutoSize = true;
            this.OptFarbeGruen.Location = new System.Drawing.Point(154, 66);
            this.OptFarbeGruen.Name = "OptFarbeGruen";
            this.OptFarbeGruen.Size = new System.Drawing.Size(48, 17);
            this.OptFarbeGruen.TabIndex = 5;
            this.OptFarbeGruen.TabStop = true;
            this.OptFarbeGruen.Text = "Grün";
            this.OptFarbeGruen.UseVisualStyleBackColor = true;
            this.OptFarbeGruen.CheckedChanged += new System.EventHandler(this.OptFarbeGruen_CheckedChanged);
            // 
            // OptFarbeBlau
            // 
            this.OptFarbeBlau.AutoSize = true;
            this.OptFarbeBlau.Location = new System.Drawing.Point(154, 89);
            this.OptFarbeBlau.Name = "OptFarbeBlau";
            this.OptFarbeBlau.Size = new System.Drawing.Size(46, 17);
            this.OptFarbeBlau.TabIndex = 6;
            this.OptFarbeBlau.TabStop = true;
            this.OptFarbeBlau.Text = "Blau";
            this.OptFarbeBlau.UseVisualStyleBackColor = true;
            this.OptFarbeBlau.CheckedChanged += new System.EventHandler(this.OptFarbeBlau_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 277);
            this.Controls.Add(this.OptFarbeBlau);
            this.Controls.Add(this.OptFarbeGruen);
            this.Controls.Add(this.OptFarbeRot);
            this.Controls.Add(this.CmdSchalter);
            this.Controls.Add(this.CmdPrüfen);
            this.Controls.Add(this.LblTest2);
            this.Controls.Add(this.LblTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTest1;
        private System.Windows.Forms.Label LblTest2;
        private System.Windows.Forms.Button CmdPrüfen;
        private System.Windows.Forms.Button CmdSchalter;
        private System.Windows.Forms.RadioButton OptFarbeRot;
        private System.Windows.Forms.RadioButton OptFarbeGruen;
        private System.Windows.Forms.RadioButton OptFarbeBlau;
    }
}

