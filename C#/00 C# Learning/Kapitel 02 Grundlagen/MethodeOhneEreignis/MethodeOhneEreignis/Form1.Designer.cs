
namespace MethodeOhneEreignis
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptRom = new System.Windows.Forms.RadioButton();
            this.OptParis = new System.Windows.Forms.RadioButton();
            this.OptBerlin = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OptAppartement = new System.Windows.Forms.RadioButton();
            this.OptPension = new System.Windows.Forms.RadioButton();
            this.OptHotel = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptRom);
            this.groupBox1.Controls.Add(this.OptParis);
            this.groupBox1.Controls.Add(this.OptBerlin);
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urlaubsort";
            // 
            // OptRom
            // 
            this.OptRom.AutoSize = true;
            this.OptRom.Location = new System.Drawing.Point(3, 62);
            this.OptRom.Name = "OptRom";
            this.OptRom.Size = new System.Drawing.Size(47, 17);
            this.OptRom.TabIndex = 2;
            this.OptRom.TabStop = true;
            this.OptRom.Text = "Rom";
            this.OptRom.UseVisualStyleBackColor = true;
            this.OptRom.CheckedChanged += new System.EventHandler(this.OptUrlaubsort_CheckedChanged);
            // 
            // OptParis
            // 
            this.OptParis.AutoSize = true;
            this.OptParis.Location = new System.Drawing.Point(3, 39);
            this.OptParis.Name = "OptParis";
            this.OptParis.Size = new System.Drawing.Size(48, 17);
            this.OptParis.TabIndex = 1;
            this.OptParis.TabStop = true;
            this.OptParis.Text = "Paris";
            this.OptParis.UseVisualStyleBackColor = true;
            this.OptParis.CheckedChanged += new System.EventHandler(this.OptUrlaubsort_CheckedChanged);
            // 
            // OptBerlin
            // 
            this.OptBerlin.AutoSize = true;
            this.OptBerlin.Location = new System.Drawing.Point(3, 16);
            this.OptBerlin.Name = "OptBerlin";
            this.OptBerlin.Size = new System.Drawing.Size(51, 17);
            this.OptBerlin.TabIndex = 0;
            this.OptBerlin.TabStop = true;
            this.OptBerlin.Text = "Berlin";
            this.OptBerlin.UseVisualStyleBackColor = true;
            this.OptBerlin.CheckedChanged += new System.EventHandler(this.OptUrlaubsort_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OptHotel);
            this.groupBox2.Controls.Add(this.OptPension);
            this.groupBox2.Controls.Add(this.OptAppartement);
            this.groupBox2.Location = new System.Drawing.Point(294, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unterkunft";
            // 
            // OptAppartement
            // 
            this.OptAppartement.AutoSize = true;
            this.OptAppartement.Location = new System.Drawing.Point(3, 16);
            this.OptAppartement.Name = "OptAppartement";
            this.OptAppartement.Size = new System.Drawing.Size(85, 17);
            this.OptAppartement.TabIndex = 0;
            this.OptAppartement.TabStop = true;
            this.OptAppartement.Text = "Appartement";
            this.OptAppartement.UseVisualStyleBackColor = true;
            this.OptAppartement.CheckedChanged += new System.EventHandler(this.OptUnterkunft_CheckedChanged);
            // 
            // OptPension
            // 
            this.OptPension.AutoSize = true;
            this.OptPension.Location = new System.Drawing.Point(3, 39);
            this.OptPension.Name = "OptPension";
            this.OptPension.Size = new System.Drawing.Size(63, 17);
            this.OptPension.TabIndex = 1;
            this.OptPension.TabStop = true;
            this.OptPension.Text = "Pension";
            this.OptPension.UseVisualStyleBackColor = true;
            this.OptPension.CheckedChanged += new System.EventHandler(this.OptUnterkunft_CheckedChanged);
            // 
            // OptHotel
            // 
            this.OptHotel.AutoSize = true;
            this.OptHotel.Location = new System.Drawing.Point(3, 62);
            this.OptHotel.Name = "OptHotel";
            this.OptHotel.Size = new System.Drawing.Size(50, 17);
            this.OptHotel.TabIndex = 2;
            this.OptHotel.TabStop = true;
            this.OptHotel.Text = "Hotel";
            this.OptHotel.UseVisualStyleBackColor = true;
            this.OptHotel.CheckedChanged += new System.EventHandler(this.OptUnterkunft_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OptRom;
        private System.Windows.Forms.RadioButton OptParis;
        private System.Windows.Forms.RadioButton OptBerlin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton OptHotel;
        private System.Windows.Forms.RadioButton OptPension;
        private System.Windows.Forms.RadioButton OptAppartement;
    }
}

