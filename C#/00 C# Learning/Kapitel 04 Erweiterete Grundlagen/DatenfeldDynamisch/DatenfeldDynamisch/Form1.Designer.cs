
namespace DatenfeldDynamisch
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
            this.LstFeld = new System.Windows.Forms.ListBox();
            this.CmdOriginal = new System.Windows.Forms.Button();
            this.CmdNeu1 = new System.Windows.Forms.Button();
            this.NumGroesse = new System.Windows.Forms.NumericUpDown();
            this.CmdNeu2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumGroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // LstFeld
            // 
            this.LstFeld.FormattingEnabled = true;
            this.LstFeld.Location = new System.Drawing.Point(13, 13);
            this.LstFeld.Name = "LstFeld";
            this.LstFeld.Size = new System.Drawing.Size(120, 95);
            this.LstFeld.TabIndex = 0;
            // 
            // CmdOriginal
            // 
            this.CmdOriginal.Location = new System.Drawing.Point(196, 13);
            this.CmdOriginal.Name = "CmdOriginal";
            this.CmdOriginal.Size = new System.Drawing.Size(81, 23);
            this.CmdOriginal.TabIndex = 1;
            this.CmdOriginal.Text = "Feld Original";
            this.CmdOriginal.UseVisualStyleBackColor = true;
            this.CmdOriginal.Click += new System.EventHandler(this.CmdOriginal_Click);
            // 
            // CmdNeu1
            // 
            this.CmdNeu1.Location = new System.Drawing.Point(196, 42);
            this.CmdNeu1.Name = "CmdNeu1";
            this.CmdNeu1.Size = new System.Drawing.Size(81, 23);
            this.CmdNeu1.TabIndex = 2;
            this.CmdNeu1.Text = "Feld neu 1";
            this.CmdNeu1.UseVisualStyleBackColor = true;
            this.CmdNeu1.Click += new System.EventHandler(this.CmdNeu1_Click);
            // 
            // NumGroesse
            // 
            this.NumGroesse.Location = new System.Drawing.Point(196, 72);
            this.NumGroesse.Name = "NumGroesse";
            this.NumGroesse.Size = new System.Drawing.Size(81, 20);
            this.NumGroesse.TabIndex = 3;
            // 
            // CmdNeu2
            // 
            this.CmdNeu2.Location = new System.Drawing.Point(196, 98);
            this.CmdNeu2.Name = "CmdNeu2";
            this.CmdNeu2.Size = new System.Drawing.Size(81, 23);
            this.CmdNeu2.TabIndex = 4;
            this.CmdNeu2.Text = "Feld Neu 2";
            this.CmdNeu2.UseVisualStyleBackColor = true;
            this.CmdNeu2.Click += new System.EventHandler(this.CmdNeu2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdNeu2);
            this.Controls.Add(this.NumGroesse);
            this.Controls.Add(this.CmdNeu1);
            this.Controls.Add(this.CmdOriginal);
            this.Controls.Add(this.LstFeld);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumGroesse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstFeld;
        private System.Windows.Forms.Button CmdOriginal;
        private System.Windows.Forms.Button CmdNeu1;
        private System.Windows.Forms.NumericUpDown NumGroesse;
        private System.Windows.Forms.Button CmdNeu2;
    }
}

