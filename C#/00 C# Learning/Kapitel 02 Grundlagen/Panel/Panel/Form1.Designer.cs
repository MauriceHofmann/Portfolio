
namespace Panel
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
            this.Panel = new System.Windows.Forms.Panel();
            this.CmdNachOben = new System.Windows.Forms.Button();
            this.CmdNachRechts = new System.Windows.Forms.Button();
            this.CmdNachUnten = new System.Windows.Forms.Button();
            this.CmdNachLinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(145, 80);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(100, 100);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // CmdNachOben
            // 
            this.CmdNachOben.Location = new System.Drawing.Point(156, 12);
            this.CmdNachOben.Name = "CmdNachOben";
            this.CmdNachOben.Size = new System.Drawing.Size(75, 23);
            this.CmdNachOben.TabIndex = 1;
            this.CmdNachOben.Text = "nach oben";
            this.CmdNachOben.UseVisualStyleBackColor = true;
            this.CmdNachOben.Click += new System.EventHandler(this.CmdNachOben_Click);
            // 
            // CmdNachRechts
            // 
            this.CmdNachRechts.Location = new System.Drawing.Point(290, 113);
            this.CmdNachRechts.Name = "CmdNachRechts";
            this.CmdNachRechts.Size = new System.Drawing.Size(75, 23);
            this.CmdNachRechts.TabIndex = 2;
            this.CmdNachRechts.Text = "nach rechts";
            this.CmdNachRechts.UseVisualStyleBackColor = true;
            this.CmdNachRechts.Click += new System.EventHandler(this.CmdNachRechts_Click);
            // 
            // CmdNachUnten
            // 
            this.CmdNachUnten.Location = new System.Drawing.Point(156, 223);
            this.CmdNachUnten.Name = "CmdNachUnten";
            this.CmdNachUnten.Size = new System.Drawing.Size(75, 23);
            this.CmdNachUnten.TabIndex = 3;
            this.CmdNachUnten.Text = "nach unten";
            this.CmdNachUnten.UseVisualStyleBackColor = true;
            this.CmdNachUnten.Click += new System.EventHandler(this.CmdNachUnten_Click);
            // 
            // CmdNachLinks
            // 
            this.CmdNachLinks.Location = new System.Drawing.Point(24, 113);
            this.CmdNachLinks.Name = "CmdNachLinks";
            this.CmdNachLinks.Size = new System.Drawing.Size(75, 23);
            this.CmdNachLinks.TabIndex = 4;
            this.CmdNachLinks.Text = "nach links";
            this.CmdNachLinks.UseVisualStyleBackColor = true;
            this.CmdNachLinks.Click += new System.EventHandler(this.CmdNachLinks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdNachLinks);
            this.Controls.Add(this.CmdNachUnten);
            this.Controls.Add(this.CmdNachRechts);
            this.Controls.Add(this.CmdNachOben);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button CmdNachOben;
        private System.Windows.Forms.Button CmdNachRechts;
        private System.Windows.Forms.Button CmdNachUnten;
        private System.Windows.Forms.Button CmdNachLinks;
    }
}

