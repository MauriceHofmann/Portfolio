
namespace Konstanten
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
            this.CmdKonstanten = new System.Windows.Forms.Button();
            this.CmdEnumeration1 = new System.Windows.Forms.Button();
            this.CmdEnumeration2 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdKonstanten
            // 
            this.CmdKonstanten.Location = new System.Drawing.Point(208, 46);
            this.CmdKonstanten.Name = "CmdKonstanten";
            this.CmdKonstanten.Size = new System.Drawing.Size(95, 23);
            this.CmdKonstanten.TabIndex = 0;
            this.CmdKonstanten.Text = "Konstanten";
            this.CmdKonstanten.UseVisualStyleBackColor = true;
            this.CmdKonstanten.Click += new System.EventHandler(this.CmdKonstanten_Click);
            // 
            // CmdEnumeration1
            // 
            this.CmdEnumeration1.Location = new System.Drawing.Point(208, 76);
            this.CmdEnumeration1.Name = "CmdEnumeration1";
            this.CmdEnumeration1.Size = new System.Drawing.Size(95, 23);
            this.CmdEnumeration1.TabIndex = 1;
            this.CmdEnumeration1.Text = "Enumeration 1";
            this.CmdEnumeration1.UseVisualStyleBackColor = true;
            this.CmdEnumeration1.Click += new System.EventHandler(this.CmdEnumeration1_Click);
            // 
            // CmdEnumeration2
            // 
            this.CmdEnumeration2.Location = new System.Drawing.Point(208, 106);
            this.CmdEnumeration2.Name = "CmdEnumeration2";
            this.CmdEnumeration2.Size = new System.Drawing.Size(95, 23);
            this.CmdEnumeration2.TabIndex = 2;
            this.CmdEnumeration2.Text = "Enumeration 2";
            this.CmdEnumeration2.UseVisualStyleBackColor = true;
            this.CmdEnumeration2.Click += new System.EventHandler(this.CmdEnumeration2_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(23, 46);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 236);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEnumeration2);
            this.Controls.Add(this.CmdEnumeration1);
            this.Controls.Add(this.CmdKonstanten);
            this.Name = "Form1";
            this.Text = "Konstanten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdKonstanten;
        private System.Windows.Forms.Button CmdEnumeration1;
        private System.Windows.Forms.Button CmdEnumeration2;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

