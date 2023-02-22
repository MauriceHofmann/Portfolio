
namespace ListenfeldMethoden
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNeu = new System.Windows.Forms.TextBox();
            this.CmdEinfügen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdLöschen = new System.Windows.Forms.Button();
            this.CmdErsetzen = new System.Windows.Forms.Button();
            this.TxtErsetzen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptEnde = new System.Windows.Forms.RadioButton();
            this.OptAnfang = new System.Windows.Forms.RadioButton();
            this.OptAuswahl = new System.Windows.Forms.RadioButton();
            this.CmdAllesLoeschen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.Location = new System.Drawing.Point(13, 13);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.LstSpeisen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neues Element:";
            // 
            // TxtNeu
            // 
            this.TxtNeu.Location = new System.Drawing.Point(210, 30);
            this.TxtNeu.Name = "TxtNeu";
            this.TxtNeu.Size = new System.Drawing.Size(100, 20);
            this.TxtNeu.TabIndex = 2;
            // 
            // CmdEinfügen
            // 
            this.CmdEinfügen.Location = new System.Drawing.Point(210, 57);
            this.CmdEinfügen.Name = "CmdEinfügen";
            this.CmdEinfügen.Size = new System.Drawing.Size(75, 23);
            this.CmdEinfügen.TabIndex = 3;
            this.CmdEinfügen.Text = "Einfügen";
            this.CmdEinfügen.UseVisualStyleBackColor = true;
            this.CmdEinfügen.Click += new System.EventHandler(this.CmdEinfügen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ausgewähltes Element:";
            // 
            // CmdLöschen
            // 
            this.CmdLöschen.Location = new System.Drawing.Point(13, 191);
            this.CmdLöschen.Name = "CmdLöschen";
            this.CmdLöschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLöschen.TabIndex = 5;
            this.CmdLöschen.Text = "Löschen";
            this.CmdLöschen.UseVisualStyleBackColor = true;
            this.CmdLöschen.Click += new System.EventHandler(this.CmdLöschen_Click);
            // 
            // CmdErsetzen
            // 
            this.CmdErsetzen.Location = new System.Drawing.Point(12, 220);
            this.CmdErsetzen.Name = "CmdErsetzen";
            this.CmdErsetzen.Size = new System.Drawing.Size(100, 23);
            this.CmdErsetzen.TabIndex = 6;
            this.CmdErsetzen.Text = "Ersetzten durch:";
            this.CmdErsetzen.UseVisualStyleBackColor = true;
            this.CmdErsetzen.Click += new System.EventHandler(this.CmdErsetzen_Click);
            // 
            // TxtErsetzen
            // 
            this.TxtErsetzen.Location = new System.Drawing.Point(16, 251);
            this.TxtErsetzen.Name = "TxtErsetzen";
            this.TxtErsetzen.Size = new System.Drawing.Size(96, 20);
            this.TxtErsetzen.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptAuswahl);
            this.groupBox1.Controls.Add(this.OptAnfang);
            this.groupBox1.Controls.Add(this.OptEnde);
            this.groupBox1.Location = new System.Drawing.Point(210, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einfügeort:";
            // 
            // OptEnde
            // 
            this.OptEnde.AutoSize = true;
            this.OptEnde.Location = new System.Drawing.Point(3, 16);
            this.OptEnde.Name = "OptEnde";
            this.OptEnde.Size = new System.Drawing.Size(111, 17);
            this.OptEnde.TabIndex = 0;
            this.OptEnde.TabStop = true;
            this.OptEnde.Text = "Am Ende der Liste";
            this.OptEnde.UseVisualStyleBackColor = true;
            // 
            // OptAnfang
            // 
            this.OptAnfang.AutoSize = true;
            this.OptAnfang.Location = new System.Drawing.Point(3, 39);
            this.OptAnfang.Name = "OptAnfang";
            this.OptAnfang.Size = new System.Drawing.Size(120, 17);
            this.OptAnfang.TabIndex = 1;
            this.OptAnfang.TabStop = true;
            this.OptAnfang.Text = "Am Anfang der Liste";
            this.OptAnfang.UseVisualStyleBackColor = true;
            // 
            // OptAuswahl
            // 
            this.OptAuswahl.AutoSize = true;
            this.OptAuswahl.Location = new System.Drawing.Point(3, 62);
            this.OptAuswahl.Name = "OptAuswahl";
            this.OptAuswahl.Size = new System.Drawing.Size(153, 17);
            this.OptAuswahl.TabIndex = 2;
            this.OptAuswahl.TabStop = true;
            this.OptAuswahl.Text = "Vor ausgewähltem Element";
            this.OptAuswahl.UseVisualStyleBackColor = true;
            // 
            // CmdAllesLoeschen
            // 
            this.CmdAllesLoeschen.Location = new System.Drawing.Point(210, 251);
            this.CmdAllesLoeschen.Name = "CmdAllesLoeschen";
            this.CmdAllesLoeschen.Size = new System.Drawing.Size(91, 23);
            this.CmdAllesLoeschen.TabIndex = 9;
            this.CmdAllesLoeschen.Text = "Alles löschen";
            this.CmdAllesLoeschen.UseVisualStyleBackColor = true;
            this.CmdAllesLoeschen.Click += new System.EventHandler(this.CmdAllesLoeschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 344);
            this.Controls.Add(this.CmdAllesLoeschen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtErsetzen);
            this.Controls.Add(this.CmdErsetzen);
            this.Controls.Add(this.CmdLöschen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdEinfügen);
            this.Controls.Add(this.TxtNeu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstSpeisen);
            this.Name = "Form1";
            this.Text = "Listenfeld-Methoden";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNeu;
        private System.Windows.Forms.Button CmdEinfügen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdLöschen;
        private System.Windows.Forms.Button CmdErsetzen;
        private System.Windows.Forms.TextBox TxtErsetzen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OptAuswahl;
        private System.Windows.Forms.RadioButton OptAnfang;
        private System.Windows.Forms.RadioButton OptEnde;
        private System.Windows.Forms.Button CmdAllesLoeschen;
    }
}

