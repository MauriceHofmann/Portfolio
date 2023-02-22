
namespace EnabledVisible
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
            this.TxtEingabe1 = new System.Windows.Forms.TextBox();
            this.TxtEingabe2 = new System.Windows.Forms.TextBox();
            this.CmdRechnen1 = new System.Windows.Forms.Button();
            this.CmdRechnen2 = new System.Windows.Forms.Button();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(12, 12);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(59, 20);
            this.TxtEingabe1.TabIndex = 0;
            this.TxtEingabe1.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(93, 12);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(59, 20);
            this.TxtEingabe2.TabIndex = 1;
            this.TxtEingabe2.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // CmdRechnen1
            // 
            this.CmdRechnen1.Location = new System.Drawing.Point(13, 76);
            this.CmdRechnen1.Name = "CmdRechnen1";
            this.CmdRechnen1.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen1.TabIndex = 2;
            this.CmdRechnen1.Text = "Rechnen 1";
            this.CmdRechnen1.UseVisualStyleBackColor = true;
            this.CmdRechnen1.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // CmdRechnen2
            // 
            this.CmdRechnen2.Location = new System.Drawing.Point(153, 76);
            this.CmdRechnen2.Name = "CmdRechnen2";
            this.CmdRechnen2.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen2.TabIndex = 3;
            this.CmdRechnen2.Text = "Rechnen 2";
            this.CmdRechnen2.UseVisualStyleBackColor = true;
            this.CmdRechnen2.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(13, 39);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.LblAusgabe.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CmdRechnen2);
            this.Controls.Add(this.CmdRechnen1);
            this.Controls.Add(this.TxtEingabe2);
            this.Controls.Add(this.TxtEingabe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe1;
        private System.Windows.Forms.TextBox TxtEingabe2;
        private System.Windows.Forms.Button CmdRechnen1;
        private System.Windows.Forms.Button CmdRechnen2;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

