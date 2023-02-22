
namespace Kombinationsfeld
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
            this.CmbWerkzeug1 = new System.Windows.Forms.ComboBox();
            this.CmbWerkzeug2 = new System.Windows.Forms.ComboBox();
            this.CmbWerkzeug3 = new System.Windows.Forms.ComboBox();
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.CmdAnzeigen2 = new System.Windows.Forms.Button();
            this.CmdAnzeigen3 = new System.Windows.Forms.Button();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.LblAnzeige3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbWerkzeug1
            // 
            this.CmbWerkzeug1.FormattingEnabled = true;
            this.CmbWerkzeug1.Location = new System.Drawing.Point(13, 13);
            this.CmbWerkzeug1.Name = "CmbWerkzeug1";
            this.CmbWerkzeug1.Size = new System.Drawing.Size(121, 21);
            this.CmbWerkzeug1.TabIndex = 0;
            // 
            // CmbWerkzeug2
            // 
            this.CmbWerkzeug2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbWerkzeug2.FormattingEnabled = true;
            this.CmbWerkzeug2.Location = new System.Drawing.Point(13, 95);
            this.CmbWerkzeug2.Name = "CmbWerkzeug2";
            this.CmbWerkzeug2.Size = new System.Drawing.Size(121, 21);
            this.CmbWerkzeug2.TabIndex = 1;
            // 
            // CmbWerkzeug3
            // 
            this.CmbWerkzeug3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CmbWerkzeug3.FormattingEnabled = true;
            this.CmbWerkzeug3.Location = new System.Drawing.Point(13, 185);
            this.CmbWerkzeug3.Name = "CmbWerkzeug3";
            this.CmbWerkzeug3.Size = new System.Drawing.Size(121, 150);
            this.CmbWerkzeug3.TabIndex = 2;
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(192, 11);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen1.TabIndex = 3;
            this.CmdAnzeigen1.Text = "Anzeigen 1";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // CmdAnzeigen2
            // 
            this.CmdAnzeigen2.Location = new System.Drawing.Point(192, 95);
            this.CmdAnzeigen2.Name = "CmdAnzeigen2";
            this.CmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen2.TabIndex = 4;
            this.CmdAnzeigen2.Text = "Anzeigen 2";
            this.CmdAnzeigen2.UseVisualStyleBackColor = true;
            this.CmdAnzeigen2.Click += new System.EventHandler(this.CmdAnzeigen2_Click);
            // 
            // CmdAnzeigen3
            // 
            this.CmdAnzeigen3.Location = new System.Drawing.Point(192, 183);
            this.CmdAnzeigen3.Name = "CmdAnzeigen3";
            this.CmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen3.TabIndex = 5;
            this.CmdAnzeigen3.Text = "Anzeigen 3";
            this.CmdAnzeigen3.UseVisualStyleBackColor = true;
            this.CmdAnzeigen3.Click += new System.EventHandler(this.CmdAnzeigen3_Click);
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(361, 13);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige1.TabIndex = 6;
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(361, 100);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 7;
            // 
            // LblAnzeige3
            // 
            this.LblAnzeige3.AutoSize = true;
            this.LblAnzeige3.Location = new System.Drawing.Point(361, 188);
            this.LblAnzeige3.Name = "LblAnzeige3";
            this.LblAnzeige3.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeige3);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.CmdAnzeigen3);
            this.Controls.Add(this.CmdAnzeigen2);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Controls.Add(this.CmbWerkzeug3);
            this.Controls.Add(this.CmbWerkzeug2);
            this.Controls.Add(this.CmbWerkzeug1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbWerkzeug1;
        private System.Windows.Forms.ComboBox CmbWerkzeug2;
        private System.Windows.Forms.ComboBox CmbWerkzeug3;
        private System.Windows.Forms.Button CmdAnzeigen1;
        private System.Windows.Forms.Button CmdAnzeigen2;
        private System.Windows.Forms.Button CmdAnzeigen3;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Label LblAnzeige3;
    }
}

