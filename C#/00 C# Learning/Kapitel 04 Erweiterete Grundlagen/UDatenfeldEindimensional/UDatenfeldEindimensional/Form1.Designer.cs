
namespace UDatenfeldEindimensional
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
            this.LstFeld = new System.Windows.Forms.ListBox();
            this.CmdMinima = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstFeld
            // 
            this.LstFeld.FormattingEnabled = true;
            this.LstFeld.Location = new System.Drawing.Point(13, 13);
            this.LstFeld.Name = "LstFeld";
            this.LstFeld.Size = new System.Drawing.Size(118, 199);
            this.LstFeld.TabIndex = 0;
            // 
            // CmdMinima
            // 
            this.CmdMinima.Location = new System.Drawing.Point(205, 13);
            this.CmdMinima.Name = "CmdMinima";
            this.CmdMinima.Size = new System.Drawing.Size(75, 23);
            this.CmdMinima.TabIndex = 1;
            this.CmdMinima.Text = "Minima";
            this.CmdMinima.UseVisualStyleBackColor = true;
            this.CmdMinima.Click += new System.EventHandler(this.CmdMinima_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(205, 72);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdMinima);
            this.Controls.Add(this.LstFeld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstFeld;
        private System.Windows.Forms.Button CmdMinima;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

