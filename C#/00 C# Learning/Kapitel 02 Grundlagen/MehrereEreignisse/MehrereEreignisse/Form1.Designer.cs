
namespace MehrereEreignisse
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
            this.OptFarbeGruen = new System.Windows.Forms.RadioButton();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.OptFarbeRot = new System.Windows.Forms.RadioButton();
            this.OptFarbeBlau = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OptFarbeGruen
            // 
            this.OptFarbeGruen.AutoSize = true;
            this.OptFarbeGruen.Location = new System.Drawing.Point(163, 34);
            this.OptFarbeGruen.Name = "OptFarbeGruen";
            this.OptFarbeGruen.Size = new System.Drawing.Size(48, 17);
            this.OptFarbeGruen.TabIndex = 0;
            this.OptFarbeGruen.TabStop = true;
            this.OptFarbeGruen.Text = "Grün";
            this.OptFarbeGruen.UseVisualStyleBackColor = true;
            this.OptFarbeGruen.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 1;
            // 
            // OptFarbeRot
            // 
            this.OptFarbeRot.AutoSize = true;
            this.OptFarbeRot.Location = new System.Drawing.Point(163, 11);
            this.OptFarbeRot.Name = "OptFarbeRot";
            this.OptFarbeRot.Size = new System.Drawing.Size(42, 17);
            this.OptFarbeRot.TabIndex = 2;
            this.OptFarbeRot.TabStop = true;
            this.OptFarbeRot.Text = "Rot";
            this.OptFarbeRot.UseVisualStyleBackColor = true;
            this.OptFarbeRot.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // OptFarbeBlau
            // 
            this.OptFarbeBlau.AutoSize = true;
            this.OptFarbeBlau.Location = new System.Drawing.Point(163, 57);
            this.OptFarbeBlau.Name = "OptFarbeBlau";
            this.OptFarbeBlau.Size = new System.Drawing.Size(46, 17);
            this.OptFarbeBlau.TabIndex = 3;
            this.OptFarbeBlau.TabStop = true;
            this.OptFarbeBlau.Text = "Blau";
            this.OptFarbeBlau.UseVisualStyleBackColor = true;
            this.OptFarbeBlau.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OptFarbeBlau);
            this.Controls.Add(this.OptFarbeRot);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.OptFarbeGruen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton OptFarbeGruen;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.RadioButton OptFarbeRot;
        private System.Windows.Forms.RadioButton OptFarbeBlau;
    }
}

