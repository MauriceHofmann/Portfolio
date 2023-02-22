
namespace ListenfeldEreignis
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
            this.LstSpeisen = new System.Windows.Forms.ListBox();
            this.CmdEreignis = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.Location = new System.Drawing.Point(13, 13);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.LstSpeisen.TabIndex = 0;
            this.LstSpeisen.SelectedIndexChanged += new System.EventHandler(this.LstSpeisen_SelectedIndexChanged);
            // 
            // CmdEreignis
            // 
            this.CmdEreignis.Location = new System.Drawing.Point(210, 13);
            this.CmdEreignis.Name = "CmdEreignis";
            this.CmdEreignis.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis.TabIndex = 1;
            this.CmdEreignis.Text = "Ereignis";
            this.CmdEreignis.UseVisualStyleBackColor = true;
            this.CmdEreignis.Click += new System.EventHandler(this.CmdEreignis_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 133);
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
            this.Controls.Add(this.CmdEreignis);
            this.Controls.Add(this.LstSpeisen);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.Button CmdEreignis;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

