
namespace BedienungTastatur
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
            this.TxtEingabe3 = new System.Windows.Forms.TextBox();
            this.TxtEingabe4 = new System.Windows.Forms.TextBox();
            this.CmdBestellen = new System.Windows.Forms.Button();
            this.OptBerlin = new System.Windows.Forms.RadioButton();
            this.OptParis = new System.Windows.Forms.RadioButton();
            this.OptPrag = new System.Windows.Forms.RadioButton();
            this.ChkMietwagen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(13, 13);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe1.TabIndex = 0;
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(12, 39);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe2.TabIndex = 3;
            // 
            // TxtEingabe3
            // 
            this.TxtEingabe3.Location = new System.Drawing.Point(12, 65);
            this.TxtEingabe3.Name = "TxtEingabe3";
            this.TxtEingabe3.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe3.TabIndex = 1;
            this.TxtEingabe3.TabStop = false;
            // 
            // TxtEingabe4
            // 
            this.TxtEingabe4.Location = new System.Drawing.Point(12, 91);
            this.TxtEingabe4.Name = "TxtEingabe4";
            this.TxtEingabe4.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe4.TabIndex = 2;
            // 
            // CmdBestellen
            // 
            this.CmdBestellen.Location = new System.Drawing.Point(235, 13);
            this.CmdBestellen.Name = "CmdBestellen";
            this.CmdBestellen.Size = new System.Drawing.Size(75, 23);
            this.CmdBestellen.TabIndex = 4;
            this.CmdBestellen.Text = "&Bestellen";
            this.CmdBestellen.UseVisualStyleBackColor = true;
            // 
            // OptBerlin
            // 
            this.OptBerlin.AutoSize = true;
            this.OptBerlin.Checked = true;
            this.OptBerlin.Location = new System.Drawing.Point(235, 43);
            this.OptBerlin.Name = "OptBerlin";
            this.OptBerlin.Size = new System.Drawing.Size(51, 17);
            this.OptBerlin.TabIndex = 5;
            this.OptBerlin.TabStop = true;
            this.OptBerlin.Text = "Berl&in";
            this.OptBerlin.UseVisualStyleBackColor = true;
            // 
            // OptParis
            // 
            this.OptParis.AutoSize = true;
            this.OptParis.Location = new System.Drawing.Point(235, 65);
            this.OptParis.Name = "OptParis";
            this.OptParis.Size = new System.Drawing.Size(48, 17);
            this.OptParis.TabIndex = 6;
            this.OptParis.Text = "&Paris";
            this.OptParis.UseVisualStyleBackColor = true;
            // 
            // OptPrag
            // 
            this.OptPrag.AutoSize = true;
            this.OptPrag.Location = new System.Drawing.Point(235, 88);
            this.OptPrag.Name = "OptPrag";
            this.OptPrag.Size = new System.Drawing.Size(47, 17);
            this.OptPrag.TabIndex = 7;
            this.OptPrag.Text = "P&rag";
            this.OptPrag.UseVisualStyleBackColor = true;
            // 
            // ChkMietwagen
            // 
            this.ChkMietwagen.AutoSize = true;
            this.ChkMietwagen.Location = new System.Drawing.Point(235, 122);
            this.ChkMietwagen.Name = "ChkMietwagen";
            this.ChkMietwagen.Size = new System.Drawing.Size(78, 17);
            this.ChkMietwagen.TabIndex = 8;
            this.ChkMietwagen.Text = "Miet&wagen";
            this.ChkMietwagen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkMietwagen);
            this.Controls.Add(this.OptPrag);
            this.Controls.Add(this.OptParis);
            this.Controls.Add(this.OptBerlin);
            this.Controls.Add(this.CmdBestellen);
            this.Controls.Add(this.TxtEingabe4);
            this.Controls.Add(this.TxtEingabe3);
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
        private System.Windows.Forms.TextBox TxtEingabe3;
        private System.Windows.Forms.TextBox TxtEingabe4;
        private System.Windows.Forms.Button CmdBestellen;
        private System.Windows.Forms.RadioButton OptBerlin;
        private System.Windows.Forms.RadioButton OptParis;
        private System.Windows.Forms.RadioButton OptPrag;
        private System.Windows.Forms.CheckBox ChkMietwagen;
    }
}

