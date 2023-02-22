
namespace UForSchleife
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
            this.CmdSchleife1 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdSchleife2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdSchleife1
            // 
            this.CmdSchleife1.Location = new System.Drawing.Point(207, 13);
            this.CmdSchleife1.Name = "CmdSchleife1";
            this.CmdSchleife1.Size = new System.Drawing.Size(75, 23);
            this.CmdSchleife1.TabIndex = 0;
            this.CmdSchleife1.Text = "Schleife 1";
            this.CmdSchleife1.UseVisualStyleBackColor = true;
            this.CmdSchleife1.Click += new System.EventHandler(this.CmdSchleife1_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 1;
            // 
            // CmdSchleife2
            // 
            this.CmdSchleife2.Location = new System.Drawing.Point(207, 43);
            this.CmdSchleife2.Name = "CmdSchleife2";
            this.CmdSchleife2.Size = new System.Drawing.Size(75, 23);
            this.CmdSchleife2.TabIndex = 2;
            this.CmdSchleife2.Text = "Schleife 2";
            this.CmdSchleife2.UseVisualStyleBackColor = true;
            this.CmdSchleife2.Click += new System.EventHandler(this.CmdSchleife2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdSchleife2);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdSchleife1);
            this.Name = "Form1";
            this.Text = "For-Schleife";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSchleife1;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdSchleife2;
    }
}

