
namespace ZahlenAufAb
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
            this.NumEingabe = new System.Windows.Forms.NumericUpDown();
            this.LblAusgabe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumEingabe)).BeginInit();
            this.SuspendLayout();
            // 
            // NumEingabe
            // 
            this.NumEingabe.DecimalPlaces = 1;
            this.NumEingabe.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumEingabe.Location = new System.Drawing.Point(12, 31);
            this.NumEingabe.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.NumEingabe.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147418112});
            this.NumEingabe.Name = "NumEingabe";
            this.NumEingabe.Size = new System.Drawing.Size(120, 20);
            this.NumEingabe.TabIndex = 0;
            this.NumEingabe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumEingabe.ValueChanged += new System.EventHandler(this.NumEingabe_ValueChanged);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(194, 37);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.LblAusgabe.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.NumEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumEingabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumEingabe;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

