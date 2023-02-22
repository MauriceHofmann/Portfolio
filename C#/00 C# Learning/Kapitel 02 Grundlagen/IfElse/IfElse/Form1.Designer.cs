
namespace IfElse
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
            this.CmdAnzeige1 = new System.Windows.Forms.Button();
            this.CmdAnzeige2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumX = new System.Windows.Forms.NumericUpDown();
            this.NumY = new System.Windows.Forms.NumericUpDown();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdAnzeige3 = new System.Windows.Forms.Button();
            this.CmdAnzeige4 = new System.Windows.Forms.Button();
            this.CmdAnzeige5 = new System.Windows.Forms.Button();
            this.CmdAnzeige6 = new System.Windows.Forms.Button();
            this.CmdAnzeige7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            this.CmdAnzeige1.Location = new System.Drawing.Point(12, 63);
            this.CmdAnzeige1.Name = "CmdAnzeige1";
            this.CmdAnzeige1.Size = new System.Drawing.Size(110, 23);
            this.CmdAnzeige1.TabIndex = 0;
            this.CmdAnzeige1.Text = "if";
            this.CmdAnzeige1.UseVisualStyleBackColor = true;
            this.CmdAnzeige1.Click += new System.EventHandler(this.CmdAnzeige1_Click);
            // 
            // CmdAnzeige2
            // 
            this.CmdAnzeige2.Location = new System.Drawing.Point(13, 93);
            this.CmdAnzeige2.Name = "CmdAnzeige2";
            this.CmdAnzeige2.Size = new System.Drawing.Size(109, 23);
            this.CmdAnzeige2.TabIndex = 1;
            this.CmdAnzeige2.Text = "if else";
            this.CmdAnzeige2.UseVisualStyleBackColor = true;
            this.CmdAnzeige2.Click += new System.EventHandler(this.CmdAnzeige2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "y:";
            // 
            // NumX
            // 
            this.NumX.Location = new System.Drawing.Point(237, 61);
            this.NumX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.NumX.Name = "NumX";
            this.NumX.Size = new System.Drawing.Size(120, 20);
            this.NumX.TabIndex = 4;
            // 
            // NumY
            // 
            this.NumY.Location = new System.Drawing.Point(237, 96);
            this.NumY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.NumY.Name = "NumY";
            this.NumY.Size = new System.Drawing.Size(120, 20);
            this.NumY.TabIndex = 5;
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 6;
            // 
            // CmdAnzeige3
            // 
            this.CmdAnzeige3.Location = new System.Drawing.Point(13, 123);
            this.CmdAnzeige3.Name = "CmdAnzeige3";
            this.CmdAnzeige3.Size = new System.Drawing.Size(109, 23);
            this.CmdAnzeige3.TabIndex = 7;
            this.CmdAnzeige3.Text = "Ternärer Operator";
            this.CmdAnzeige3.UseVisualStyleBackColor = true;
            this.CmdAnzeige3.Click += new System.EventHandler(this.CmdAnzeige3_Click);
            // 
            // CmdAnzeige4
            // 
            this.CmdAnzeige4.Location = new System.Drawing.Point(16, 153);
            this.CmdAnzeige4.Name = "CmdAnzeige4";
            this.CmdAnzeige4.Size = new System.Drawing.Size(106, 23);
            this.CmdAnzeige4.TabIndex = 8;
            this.CmdAnzeige4.Text = "if else if";
            this.CmdAnzeige4.UseVisualStyleBackColor = true;
            this.CmdAnzeige4.Click += new System.EventHandler(this.CmdAnzeige4_Click);
            // 
            // CmdAnzeige5
            // 
            this.CmdAnzeige5.Location = new System.Drawing.Point(16, 183);
            this.CmdAnzeige5.Name = "CmdAnzeige5";
            this.CmdAnzeige5.Size = new System.Drawing.Size(106, 23);
            this.CmdAnzeige5.TabIndex = 9;
            this.CmdAnzeige5.Text = "log. Und";
            this.CmdAnzeige5.UseVisualStyleBackColor = true;
            this.CmdAnzeige5.Click += new System.EventHandler(this.CmdAnzeige5_Click);
            // 
            // CmdAnzeige6
            // 
            this.CmdAnzeige6.Location = new System.Drawing.Point(16, 213);
            this.CmdAnzeige6.Name = "CmdAnzeige6";
            this.CmdAnzeige6.Size = new System.Drawing.Size(106, 23);
            this.CmdAnzeige6.TabIndex = 10;
            this.CmdAnzeige6.Text = "log. Oder";
            this.CmdAnzeige6.UseVisualStyleBackColor = true;
            this.CmdAnzeige6.Click += new System.EventHandler(this.CmdAnzeige6_Click);
            // 
            // CmdAnzeige7
            // 
            this.CmdAnzeige7.Location = new System.Drawing.Point(16, 242);
            this.CmdAnzeige7.Name = "CmdAnzeige7";
            this.CmdAnzeige7.Size = new System.Drawing.Size(106, 23);
            this.CmdAnzeige7.TabIndex = 11;
            this.CmdAnzeige7.Text = "log. exkl. Oder";
            this.CmdAnzeige7.UseVisualStyleBackColor = true;
            this.CmdAnzeige7.Click += new System.EventHandler(this.CmdAnzeige7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 347);
            this.Controls.Add(this.CmdAnzeige7);
            this.Controls.Add(this.CmdAnzeige6);
            this.Controls.Add(this.CmdAnzeige5);
            this.Controls.Add(this.CmdAnzeige4);
            this.Controls.Add(this.CmdAnzeige3);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.NumY);
            this.Controls.Add(this.NumX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdAnzeige2);
            this.Controls.Add(this.CmdAnzeige1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeige1;
        private System.Windows.Forms.Button CmdAnzeige2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumX;
        private System.Windows.Forms.NumericUpDown NumY;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdAnzeige3;
        private System.Windows.Forms.Button CmdAnzeige4;
        private System.Windows.Forms.Button CmdAnzeige5;
        private System.Windows.Forms.Button CmdAnzeige6;
        private System.Windows.Forms.Button CmdAnzeige7;
    }
}

