
namespace UName
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
            this.CmdMeinName = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblMeinName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdMeinName
            // 
            this.CmdMeinName.Location = new System.Drawing.Point(46, 86);
            this.CmdMeinName.Name = "CmdMeinName";
            this.CmdMeinName.Size = new System.Drawing.Size(75, 23);
            this.CmdMeinName.TabIndex = 0;
            this.CmdMeinName.Text = "Mein Name";
            this.CmdMeinName.UseVisualStyleBackColor = true;
            this.CmdMeinName.Click += new System.EventHandler(this.CmdMeinName_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(205, 86);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 1;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // LblMeinName
            // 
            this.LblMeinName.AutoSize = true;
            this.LblMeinName.Location = new System.Drawing.Point(43, 45);
            this.LblMeinName.Name = "LblMeinName";
            this.LblMeinName.Size = new System.Drawing.Size(0, 13);
            this.LblMeinName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMeinName);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdMeinName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMeinName;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblMeinName;
    }
}

