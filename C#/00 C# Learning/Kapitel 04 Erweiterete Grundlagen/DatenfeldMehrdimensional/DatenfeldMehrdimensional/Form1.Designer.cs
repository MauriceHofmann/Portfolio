
namespace DatenfeldMehrdimensional
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
            this.LstSpalte0 = new System.Windows.Forms.ListBox();
            this.LstSpalte1 = new System.Windows.Forms.ListBox();
            this.LstSpalte2 = new System.Windows.Forms.ListBox();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.CmdInitialisieren = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstSpalte0
            // 
            this.LstSpalte0.FormattingEnabled = true;
            this.LstSpalte0.Location = new System.Drawing.Point(13, 24);
            this.LstSpalte0.Name = "LstSpalte0";
            this.LstSpalte0.Size = new System.Drawing.Size(100, 160);
            this.LstSpalte0.TabIndex = 0;
            this.LstSpalte0.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // LstSpalte1
            // 
            this.LstSpalte1.FormattingEnabled = true;
            this.LstSpalte1.Location = new System.Drawing.Point(130, 24);
            this.LstSpalte1.Name = "LstSpalte1";
            this.LstSpalte1.Size = new System.Drawing.Size(100, 160);
            this.LstSpalte1.TabIndex = 1;
            this.LstSpalte1.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // LstSpalte2
            // 
            this.LstSpalte2.FormattingEnabled = true;
            this.LstSpalte2.Location = new System.Drawing.Point(265, 24);
            this.LstSpalte2.Name = "LstSpalte2";
            this.LstSpalte2.Size = new System.Drawing.Size(100, 160);
            this.LstSpalte2.TabIndex = 2;
            this.LstSpalte2.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(412, 24);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 3;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // CmdInitialisieren
            // 
            this.CmdInitialisieren.Location = new System.Drawing.Point(412, 53);
            this.CmdInitialisieren.Name = "CmdInitialisieren";
            this.CmdInitialisieren.Size = new System.Drawing.Size(75, 23);
            this.CmdInitialisieren.TabIndex = 4;
            this.CmdInitialisieren.Text = "Initialisieren";
            this.CmdInitialisieren.UseVisualStyleBackColor = true;
            this.CmdInitialisieren.Click += new System.EventHandler(this.CmdInitialisieren_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(412, 170);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdInitialisieren);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.LstSpalte2);
            this.Controls.Add(this.LstSpalte1);
            this.Controls.Add(this.LstSpalte0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpalte0;
        private System.Windows.Forms.ListBox LstSpalte1;
        private System.Windows.Forms.ListBox LstSpalte2;
        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Button CmdInitialisieren;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

