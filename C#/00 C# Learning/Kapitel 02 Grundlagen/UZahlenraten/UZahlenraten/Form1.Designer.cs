
namespace UZahlenraten
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
            this.CmdErzeugen = new System.Windows.Forms.Button();
            this.CmdPrüfen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdErzeugen
            // 
            this.CmdErzeugen.Location = new System.Drawing.Point(199, 12);
            this.CmdErzeugen.Name = "CmdErzeugen";
            this.CmdErzeugen.Size = new System.Drawing.Size(75, 23);
            this.CmdErzeugen.TabIndex = 0;
            this.CmdErzeugen.Text = "Erzeugen";
            this.CmdErzeugen.UseVisualStyleBackColor = true;
            this.CmdErzeugen.Click += new System.EventHandler(this.CmdErzeugen_Click);
            // 
            // CmdPrüfen
            // 
            this.CmdPrüfen.Location = new System.Drawing.Point(199, 41);
            this.CmdPrüfen.Name = "CmdPrüfen";
            this.CmdPrüfen.Size = new System.Drawing.Size(75, 23);
            this.CmdPrüfen.TabIndex = 1;
            this.CmdPrüfen.Text = "Prüfen";
            this.CmdPrüfen.UseVisualStyleBackColor = true;
            this.CmdPrüfen.Click += new System.EventHandler(this.CmdPrüfen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eingabe:";
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(93, 44);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 3;
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(15, 84);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdPrüfen);
            this.Controls.Add(this.CmdErzeugen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdErzeugen;
        private System.Windows.Forms.Button CmdPrüfen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

