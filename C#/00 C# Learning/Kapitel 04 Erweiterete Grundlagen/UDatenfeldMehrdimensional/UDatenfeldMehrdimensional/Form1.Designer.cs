
namespace UDatenfeldMehrdimensional
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.LblMinima = new System.Windows.Forms.Label();
            this.CmdMinima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 0;
            // 
            // LblMinima
            // 
            this.LblMinima.AutoSize = true;
            this.LblMinima.Location = new System.Drawing.Point(16, 215);
            this.LblMinima.Name = "LblMinima";
            this.LblMinima.Size = new System.Drawing.Size(0, 13);
            this.LblMinima.TabIndex = 1;
            // 
            // CmdMinima
            // 
            this.CmdMinima.Location = new System.Drawing.Point(434, 215);
            this.CmdMinima.Name = "CmdMinima";
            this.CmdMinima.Size = new System.Drawing.Size(75, 23);
            this.CmdMinima.TabIndex = 2;
            this.CmdMinima.Text = "Minima";
            this.CmdMinima.UseVisualStyleBackColor = true;
            this.CmdMinima.Click += new System.EventHandler(this.CmdMinima_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdMinima);
            this.Controls.Add(this.LblMinima);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Label LblMinima;
        private System.Windows.Forms.Button CmdMinima;
    }
}

