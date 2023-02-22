
namespace Schieberegler
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
            this.PanFarbe = new System.Windows.Forms.Panel();
            this.TrkRot = new System.Windows.Forms.TrackBar();
            this.TrkGruen = new System.Windows.Forms.TrackBar();
            this.TrkBlau = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblRotWert = new System.Windows.Forms.Label();
            this.LblGruenWert = new System.Windows.Forms.Label();
            this.LblBlauWert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrkRot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGruen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlau)).BeginInit();
            this.SuspendLayout();
            // 
            // PanFarbe
            // 
            this.PanFarbe.Location = new System.Drawing.Point(353, 49);
            this.PanFarbe.Name = "PanFarbe";
            this.PanFarbe.Size = new System.Drawing.Size(200, 151);
            this.PanFarbe.TabIndex = 0;
            // 
            // TrkRot
            // 
            this.TrkRot.LargeChange = 32;
            this.TrkRot.Location = new System.Drawing.Point(37, 49);
            this.TrkRot.Maximum = 255;
            this.TrkRot.Name = "TrkRot";
            this.TrkRot.Size = new System.Drawing.Size(259, 45);
            this.TrkRot.SmallChange = 8;
            this.TrkRot.TabIndex = 1;
            this.TrkRot.TickFrequency = 16;
            this.TrkRot.ValueChanged += new System.EventHandler(this.Schieberegler_ValueChanged);
            // 
            // TrkGruen
            // 
            this.TrkGruen.LargeChange = 32;
            this.TrkGruen.Location = new System.Drawing.Point(37, 104);
            this.TrkGruen.Maximum = 255;
            this.TrkGruen.Name = "TrkGruen";
            this.TrkGruen.Size = new System.Drawing.Size(259, 45);
            this.TrkGruen.SmallChange = 8;
            this.TrkGruen.TabIndex = 2;
            this.TrkGruen.TickFrequency = 16;
            this.TrkGruen.ValueChanged += new System.EventHandler(this.Schieberegler_ValueChanged);
            // 
            // TrkBlau
            // 
            this.TrkBlau.LargeChange = 32;
            this.TrkBlau.Location = new System.Drawing.Point(37, 155);
            this.TrkBlau.Maximum = 255;
            this.TrkBlau.Name = "TrkBlau";
            this.TrkBlau.Size = new System.Drawing.Size(259, 45);
            this.TrkBlau.SmallChange = 8;
            this.TrkBlau.TabIndex = 3;
            this.TrkBlau.TickFrequency = 16;
            this.TrkBlau.ValueChanged += new System.EventHandler(this.Schieberegler_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blau";
            // 
            // LblRotWert
            // 
            this.LblRotWert.AutoSize = true;
            this.LblRotWert.Location = new System.Drawing.Point(303, 66);
            this.LblRotWert.Name = "LblRotWert";
            this.LblRotWert.Size = new System.Drawing.Size(0, 13);
            this.LblRotWert.TabIndex = 7;
            // 
            // LblGruenWert
            // 
            this.LblGruenWert.AutoSize = true;
            this.LblGruenWert.Location = new System.Drawing.Point(303, 126);
            this.LblGruenWert.Name = "LblGruenWert";
            this.LblGruenWert.Size = new System.Drawing.Size(0, 13);
            this.LblGruenWert.TabIndex = 8;
            // 
            // LblBlauWert
            // 
            this.LblBlauWert.AutoSize = true;
            this.LblBlauWert.Location = new System.Drawing.Point(303, 177);
            this.LblBlauWert.Name = "LblBlauWert";
            this.LblBlauWert.Size = new System.Drawing.Size(0, 13);
            this.LblBlauWert.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBlauWert);
            this.Controls.Add(this.LblGruenWert);
            this.Controls.Add(this.LblRotWert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrkBlau);
            this.Controls.Add(this.TrkGruen);
            this.Controls.Add(this.TrkRot);
            this.Controls.Add(this.PanFarbe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrkRot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGruen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanFarbe;
        private System.Windows.Forms.TrackBar TrkRot;
        private System.Windows.Forms.TrackBar TrkGruen;
        private System.Windows.Forms.TrackBar TrkBlau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblRotWert;
        private System.Windows.Forms.Label LblGruenWert;
        private System.Windows.Forms.Label LblBlauWert;
    }
}

