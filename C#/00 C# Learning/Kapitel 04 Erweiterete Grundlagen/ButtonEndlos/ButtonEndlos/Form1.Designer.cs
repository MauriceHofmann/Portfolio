﻿
namespace ButtonEndlos
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
            this.CmdEreignis1 = new System.Windows.Forms.Button();
            this.CmdEreignis2 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdEreignis1
            // 
            this.CmdEreignis1.Location = new System.Drawing.Point(12, 12);
            this.CmdEreignis1.Name = "CmdEreignis1";
            this.CmdEreignis1.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis1.TabIndex = 0;
            this.CmdEreignis1.Text = "Ereignis1";
            this.CmdEreignis1.UseVisualStyleBackColor = true;
            this.CmdEreignis1.Click += new System.EventHandler(this.CmdEreignis1_Click);
            // 
            // CmdEreignis2
            // 
            this.CmdEreignis2.Location = new System.Drawing.Point(129, 12);
            this.CmdEreignis2.Name = "CmdEreignis2";
            this.CmdEreignis2.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis2.TabIndex = 1;
            this.CmdEreignis2.Text = "Ereignis2";
            this.CmdEreignis2.UseVisualStyleBackColor = true;
            this.CmdEreignis2.Click += new System.EventHandler(this.CmdEreignis2_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 60);
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
            this.Controls.Add(this.CmdEreignis2);
            this.Controls.Add(this.CmdEreignis1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdEreignis1;
        private System.Windows.Forms.Button CmdEreignis2;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

