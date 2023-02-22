
namespace USteuerbetrag
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
            this.TxtBoxGehalt = new System.Windows.Forms.TextBox();
            this.CmdBerechnen = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gehalt:";
            // 
            // TxtBoxGehalt
            // 
            this.TxtBoxGehalt.Location = new System.Drawing.Point(16, 30);
            this.TxtBoxGehalt.Name = "TxtBoxGehalt";
            this.TxtBoxGehalt.Size = new System.Drawing.Size(103, 20);
            this.TxtBoxGehalt.TabIndex = 1;
            // 
            // CmdBerechnen
            // 
            this.CmdBerechnen.Location = new System.Drawing.Point(16, 75);
            this.CmdBerechnen.Name = "CmdBerechnen";
            this.CmdBerechnen.Size = new System.Drawing.Size(103, 23);
            this.CmdBerechnen.TabIndex = 2;
            this.CmdBerechnen.Text = "Berechnen";
            this.CmdBerechnen.UseVisualStyleBackColor = true;
            this.CmdBerechnen.Click += new System.EventHandler(this.CmdBerechnen_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(218, 36);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 3;
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(221, 13);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 4;
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(489, 13);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 5;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdAnzeigen);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdBerechnen);
            this.Controls.Add(this.TxtBoxGehalt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Steuerbetrag berechnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxGehalt;
        private System.Windows.Forms.Button CmdBerechnen;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Button CmdAnzeigen;
    }
}

