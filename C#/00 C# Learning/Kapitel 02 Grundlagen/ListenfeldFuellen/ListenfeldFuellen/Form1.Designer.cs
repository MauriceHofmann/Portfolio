
namespace ListenfeldFuellen
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
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.LblAnzeige3 = new System.Windows.Forms.Label();
            this.LblAnzeige4 = new System.Windows.Forms.Label();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.CmdForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.Location = new System.Drawing.Point(13, 13);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.Size = new System.Drawing.Size(120, 43);
            this.LstSpeisen.TabIndex = 0;
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(13, 82);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige1.TabIndex = 1;
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(13, 121);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 2;
            // 
            // LblAnzeige3
            // 
            this.LblAnzeige3.AutoSize = true;
            this.LblAnzeige3.Location = new System.Drawing.Point(13, 160);
            this.LblAnzeige3.Name = "LblAnzeige3";
            this.LblAnzeige3.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige3.TabIndex = 3;
            // 
            // LblAnzeige4
            // 
            this.LblAnzeige4.AutoSize = true;
            this.LblAnzeige4.Location = new System.Drawing.Point(13, 202);
            this.LblAnzeige4.Name = "LblAnzeige4";
            this.LblAnzeige4.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige4.TabIndex = 4;
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(273, 13);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 5;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // CmdForeach
            // 
            this.CmdForeach.Location = new System.Drawing.Point(273, 367);
            this.CmdForeach.Name = "CmdForeach";
            this.CmdForeach.Size = new System.Drawing.Size(75, 23);
            this.CmdForeach.TabIndex = 6;
            this.CmdForeach.Text = "foreach";
            this.CmdForeach.UseVisualStyleBackColor = true;
            this.CmdForeach.Click += new System.EventHandler(this.CmdForeach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdForeach);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.LblAnzeige4);
            this.Controls.Add(this.LblAnzeige3);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.LstSpeisen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Label LblAnzeige3;
        private System.Windows.Forms.Label LblAnzeige4;
        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Button CmdForeach;
    }
}

