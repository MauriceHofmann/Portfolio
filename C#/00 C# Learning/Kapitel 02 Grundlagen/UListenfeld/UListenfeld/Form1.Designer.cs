
namespace UListenfeld
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
            this.LstLinks = new System.Windows.Forms.ListBox();
            this.CmdRechts = new System.Windows.Forms.Button();
            this.CmdLinks = new System.Windows.Forms.Button();
            this.LstRechts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstLinks
            // 
            this.LstLinks.FormattingEnabled = true;
            this.LstLinks.Location = new System.Drawing.Point(13, 13);
            this.LstLinks.Name = "LstLinks";
            this.LstLinks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstLinks.Size = new System.Drawing.Size(120, 134);
            this.LstLinks.TabIndex = 0;
            // 
            // CmdRechts
            // 
            this.CmdRechts.Location = new System.Drawing.Point(155, 13);
            this.CmdRechts.Name = "CmdRechts";
            this.CmdRechts.Size = new System.Drawing.Size(47, 23);
            this.CmdRechts.TabIndex = 1;
            this.CmdRechts.Text = ">>";
            this.CmdRechts.UseVisualStyleBackColor = true;
            this.CmdRechts.Click += new System.EventHandler(this.CmdRechts_Click);
            // 
            // CmdLinks
            // 
            this.CmdLinks.Location = new System.Drawing.Point(155, 42);
            this.CmdLinks.Name = "CmdLinks";
            this.CmdLinks.Size = new System.Drawing.Size(47, 23);
            this.CmdLinks.TabIndex = 2;
            this.CmdLinks.Text = "<<";
            this.CmdLinks.UseVisualStyleBackColor = true;
            this.CmdLinks.Click += new System.EventHandler(this.CmdLinks_Click);
            // 
            // LstRechts
            // 
            this.LstRechts.FormattingEnabled = true;
            this.LstRechts.Location = new System.Drawing.Point(230, 13);
            this.LstRechts.Name = "LstRechts";
            this.LstRechts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstRechts.Size = new System.Drawing.Size(120, 134);
            this.LstRechts.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstRechts);
            this.Controls.Add(this.CmdLinks);
            this.Controls.Add(this.CmdRechts);
            this.Controls.Add(this.LstLinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstLinks;
        private System.Windows.Forms.Button CmdRechts;
        private System.Windows.Forms.Button CmdLinks;
        private System.Windows.Forms.ListBox LstRechts;
    }
}

