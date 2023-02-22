
namespace URechenoperatoren
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
            this.CmdAusdruck1 = new System.Windows.Forms.Button();
            this.CmdAusdruck2 = new System.Windows.Forms.Button();
            this.LblAnzeigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAusdruck1
            // 
            this.CmdAusdruck1.Location = new System.Drawing.Point(173, 39);
            this.CmdAusdruck1.Name = "CmdAusdruck1";
            this.CmdAusdruck1.Size = new System.Drawing.Size(75, 23);
            this.CmdAusdruck1.TabIndex = 0;
            this.CmdAusdruck1.Text = "1. Ausdruck";
            this.CmdAusdruck1.UseVisualStyleBackColor = true;
            this.CmdAusdruck1.Click += new System.EventHandler(this.CmdAusdruck1_Click);
            // 
            // CmdAusdruck2
            // 
            this.CmdAusdruck2.Location = new System.Drawing.Point(173, 69);
            this.CmdAusdruck2.Name = "CmdAusdruck2";
            this.CmdAusdruck2.Size = new System.Drawing.Size(75, 23);
            this.CmdAusdruck2.TabIndex = 1;
            this.CmdAusdruck2.Text = "2. Ausdruck";
            this.CmdAusdruck2.UseVisualStyleBackColor = true;
            this.CmdAusdruck2.Click += new System.EventHandler(this.CmdAusdruck2_Click);
            // 
            // LblAnzeigen
            // 
            this.LblAnzeigen.AutoSize = true;
            this.LblAnzeigen.Location = new System.Drawing.Point(22, 39);
            this.LblAnzeigen.Name = "LblAnzeigen";
            this.LblAnzeigen.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeigen.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 181);
            this.Controls.Add(this.LblAnzeigen);
            this.Controls.Add(this.CmdAusdruck2);
            this.Controls.Add(this.CmdAusdruck1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAusdruck1;
        private System.Windows.Forms.Button CmdAusdruck2;
        private System.Windows.Forms.Label LblAnzeigen;
    }
}

