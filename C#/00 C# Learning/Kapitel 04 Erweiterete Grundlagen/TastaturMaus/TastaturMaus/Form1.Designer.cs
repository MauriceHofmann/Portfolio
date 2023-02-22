
namespace TastaturMaus
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
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.PanMaus = new System.Windows.Forms.Panel();
            this.LblMaus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(13, 13);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 0;
            this.TxtEingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEingabe_KeyDown);
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(13, 40);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(0, 13);
            this.LblEingabe.TabIndex = 1;
            // 
            // PanMaus
            // 
            this.PanMaus.Location = new System.Drawing.Point(13, 89);
            this.PanMaus.Name = "PanMaus";
            this.PanMaus.Size = new System.Drawing.Size(200, 100);
            this.PanMaus.TabIndex = 2;
            this.PanMaus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanMaus_MouseDown);
            // 
            // LblMaus
            // 
            this.LblMaus.AutoSize = true;
            this.LblMaus.Location = new System.Drawing.Point(13, 214);
            this.LblMaus.Name = "LblMaus";
            this.LblMaus.Size = new System.Drawing.Size(0, 13);
            this.LblMaus.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMaus);
            this.Controls.Add(this.PanMaus);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Label LblEingabe;
        private System.Windows.Forms.Panel PanMaus;
        private System.Windows.Forms.Label LblMaus;
    }
}

