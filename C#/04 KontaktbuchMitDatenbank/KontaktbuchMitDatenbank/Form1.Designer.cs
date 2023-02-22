
namespace KontaktbuchMitDatenbank
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
            this.lstBoxKontakte = new System.Windows.Forms.ListBox();
            this.btnErstellen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.btnLaden = new System.Windows.Forms.Button();
            this.txtBoxVorname = new System.Windows.Forms.TextBox();
            this.txtBoxNachname = new System.Windows.Forms.TextBox();
            this.txtBoxTelefonnummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuchen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxKontakte
            // 
            this.lstBoxKontakte.FormattingEnabled = true;
            this.lstBoxKontakte.Location = new System.Drawing.Point(13, 65);
            this.lstBoxKontakte.Name = "lstBoxKontakte";
            this.lstBoxKontakte.Size = new System.Drawing.Size(206, 368);
            this.lstBoxKontakte.TabIndex = 0;
            this.lstBoxKontakte.SelectedIndexChanged += new System.EventHandler(this.lstBoxKontakte_SelectedIndexChanged);
            // 
            // btnErstellen
            // 
            this.btnErstellen.Location = new System.Drawing.Point(223, 342);
            this.btnErstellen.Name = "btnErstellen";
            this.btnErstellen.Size = new System.Drawing.Size(181, 35);
            this.btnErstellen.TabIndex = 1;
            this.btnErstellen.Text = "Erstellen";
            this.btnErstellen.UseVisualStyleBackColor = true;
            this.btnErstellen.Click += new System.EventHandler(this.btnErstellen_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(420, 342);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(181, 35);
            this.btnBearbeiten.TabIndex = 2;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(543, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(256, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(618, 342);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(181, 35);
            this.btnLoeschen.TabIndex = 4;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // btnLaden
            // 
            this.btnLaden.Location = new System.Drawing.Point(225, 398);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(256, 35);
            this.btnLaden.TabIndex = 5;
            this.btnLaden.Text = "Alle Laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            this.btnLaden.Click += new System.EventHandler(this.btnLaden_Click);
            // 
            // txtBoxVorname
            // 
            this.txtBoxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVorname.Location = new System.Drawing.Point(420, 152);
            this.txtBoxVorname.Name = "txtBoxVorname";
            this.txtBoxVorname.Size = new System.Drawing.Size(330, 29);
            this.txtBoxVorname.TabIndex = 6;
            // 
            // txtBoxNachname
            // 
            this.txtBoxNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNachname.Location = new System.Drawing.Point(420, 199);
            this.txtBoxNachname.Name = "txtBoxNachname";
            this.txtBoxNachname.Size = new System.Drawing.Size(330, 29);
            this.txtBoxNachname.TabIndex = 7;
            // 
            // txtBoxTelefonnummer
            // 
            this.txtBoxTelefonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefonnummer.Location = new System.Drawing.Point(420, 250);
            this.txtBoxTelefonnummer.Name = "txtBoxTelefonnummer";
            this.txtBoxTelefonnummer.Size = new System.Drawing.Size(330, 29);
            this.txtBoxTelefonnummer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefonnummer";
            // 
            // txtSuchen
            // 
            this.txtSuchen.Location = new System.Drawing.Point(13, 39);
            this.txtSuchen.Name = "txtSuchen";
            this.txtSuchen.Size = new System.Drawing.Size(206, 20);
            this.txtSuchen.TabIndex = 14;
            this.txtSuchen.TextChanged += new System.EventHandler(this.txtSuchen_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Nova Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 58);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kontakte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSuchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTelefonnummer);
            this.Controls.Add(this.txtBoxNachname);
            this.Controls.Add(this.txtBoxVorname);
            this.Controls.Add(this.btnLaden);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnErstellen);
            this.Controls.Add(this.lstBoxKontakte);
            this.Name = "Form1";
            this.Text = "KontaktbuchMitDatenbank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxKontakte;
        private System.Windows.Forms.Button btnErstellen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.Button btnLaden;
        private System.Windows.Forms.TextBox txtBoxVorname;
        private System.Windows.Forms.TextBox txtBoxNachname;
        private System.Windows.Forms.TextBox txtBoxTelefonnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSuchen;
        private System.Windows.Forms.Label label6;
    }
}

