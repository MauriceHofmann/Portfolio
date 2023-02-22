
namespace EreignisEnter
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ChkKunde = new System.Windows.Forms.CheckBox();
            this.OptKreditkarte = new System.Windows.Forms.RadioButton();
            this.OptLastschrift = new System.Windows.Forms.RadioButton();
            this.OptÜberweisung = new System.Windows.Forms.RadioButton();
            this.LstPaketdienst = new System.Windows.Forms.ListBox();
            this.LblHilfe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(13, 13);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(120, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.Enter += new System.EventHandler(this.TxtName_Enter);
            // 
            // ChkKunde
            // 
            this.ChkKunde.AutoSize = true;
            this.ChkKunde.Location = new System.Drawing.Point(13, 40);
            this.ChkKunde.Name = "ChkKunde";
            this.ChkKunde.Size = new System.Drawing.Size(97, 17);
            this.ChkKunde.TabIndex = 1;
            this.ChkKunde.Text = "bereits Kunde?";
            this.ChkKunde.UseVisualStyleBackColor = true;
            this.ChkKunde.Enter += new System.EventHandler(this.ChkKunde_Enter);
            // 
            // OptKreditkarte
            // 
            this.OptKreditkarte.AutoSize = true;
            this.OptKreditkarte.Location = new System.Drawing.Point(13, 73);
            this.OptKreditkarte.Name = "OptKreditkarte";
            this.OptKreditkarte.Size = new System.Drawing.Size(76, 17);
            this.OptKreditkarte.TabIndex = 2;
            this.OptKreditkarte.TabStop = true;
            this.OptKreditkarte.Text = "Kreditkarte";
            this.OptKreditkarte.UseVisualStyleBackColor = true;
            this.OptKreditkarte.CheckedChanged += new System.EventHandler(this.OptZahlungsform_CheckedChanged);
            // 
            // OptLastschrift
            // 
            this.OptLastschrift.AutoSize = true;
            this.OptLastschrift.Location = new System.Drawing.Point(13, 96);
            this.OptLastschrift.Name = "OptLastschrift";
            this.OptLastschrift.Size = new System.Drawing.Size(73, 17);
            this.OptLastschrift.TabIndex = 3;
            this.OptLastschrift.TabStop = true;
            this.OptLastschrift.Text = "Lastschrift";
            this.OptLastschrift.UseVisualStyleBackColor = true;
            this.OptLastschrift.CheckedChanged += new System.EventHandler(this.OptZahlungsform_CheckedChanged);
            // 
            // OptÜberweisung
            // 
            this.OptÜberweisung.AutoSize = true;
            this.OptÜberweisung.Location = new System.Drawing.Point(13, 119);
            this.OptÜberweisung.Name = "OptÜberweisung";
            this.OptÜberweisung.Size = new System.Drawing.Size(87, 17);
            this.OptÜberweisung.TabIndex = 4;
            this.OptÜberweisung.TabStop = true;
            this.OptÜberweisung.Text = "Überweisung";
            this.OptÜberweisung.UseVisualStyleBackColor = true;
            this.OptÜberweisung.CheckedChanged += new System.EventHandler(this.OptZahlungsform_CheckedChanged);
            // 
            // LstPaketdienst
            // 
            this.LstPaketdienst.FormattingEnabled = true;
            this.LstPaketdienst.Location = new System.Drawing.Point(13, 154);
            this.LstPaketdienst.Name = "LstPaketdienst";
            this.LstPaketdienst.Size = new System.Drawing.Size(120, 95);
            this.LstPaketdienst.TabIndex = 5;
            this.LstPaketdienst.Enter += new System.EventHandler(this.LstPaketdienst_Enter);
            // 
            // LblHilfe
            // 
            this.LblHilfe.AutoSize = true;
            this.LblHilfe.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHilfe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblHilfe.Location = new System.Drawing.Point(13, 276);
            this.LblHilfe.Name = "LblHilfe";
            this.LblHilfe.Size = new System.Drawing.Size(0, 27);
            this.LblHilfe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblHilfe);
            this.Controls.Add(this.LstPaketdienst);
            this.Controls.Add(this.OptÜberweisung);
            this.Controls.Add(this.OptLastschrift);
            this.Controls.Add(this.OptKreditkarte);
            this.Controls.Add(this.ChkKunde);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.CheckBox ChkKunde;
        private System.Windows.Forms.RadioButton OptKreditkarte;
        private System.Windows.Forms.RadioButton OptLastschrift;
        private System.Windows.Forms.RadioButton OptÜberweisung;
        private System.Windows.Forms.ListBox LstPaketdienst;
        private System.Windows.Forms.Label LblHilfe;
    }
}

