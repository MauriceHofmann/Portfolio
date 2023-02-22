
namespace UPanelZeitgeber
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
            this.components = new System.ComponentModel.Container();
            this.CmdStart = new System.Windows.Forms.Button();
            this.PanelTopLeft = new System.Windows.Forms.Panel();
            this.PanelTopRight = new System.Windows.Forms.Panel();
            this.PanelBottomLeft = new System.Windows.Forms.Panel();
            this.PanelBottomRight = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(203, 25);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 0;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // PanelTopLeft
            // 
            this.PanelTopLeft.Location = new System.Drawing.Point(203, 103);
            this.PanelTopLeft.Name = "PanelTopLeft";
            this.PanelTopLeft.Size = new System.Drawing.Size(20, 20);
            this.PanelTopLeft.TabIndex = 1;
            this.PanelTopLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTopLeft_Paint);
            // 
            // PanelTopRight
            // 
            this.PanelTopRight.Location = new System.Drawing.Point(258, 103);
            this.PanelTopRight.Name = "PanelTopRight";
            this.PanelTopRight.Size = new System.Drawing.Size(20, 20);
            this.PanelTopRight.TabIndex = 2;
            // 
            // PanelBottomLeft
            // 
            this.PanelBottomLeft.Location = new System.Drawing.Point(203, 145);
            this.PanelBottomLeft.Name = "PanelBottomLeft";
            this.PanelBottomLeft.Size = new System.Drawing.Size(20, 20);
            this.PanelBottomLeft.TabIndex = 2;
            // 
            // PanelBottomRight
            // 
            this.PanelBottomRight.Location = new System.Drawing.Point(258, 145);
            this.PanelBottomRight.Name = "PanelBottomRight";
            this.PanelBottomRight.Size = new System.Drawing.Size(20, 20);
            this.PanelBottomRight.TabIndex = 3;
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 364);
            this.Controls.Add(this.PanelBottomRight);
            this.Controls.Add(this.PanelBottomLeft);
            this.Controls.Add(this.PanelTopRight);
            this.Controls.Add(this.PanelTopLeft);
            this.Controls.Add(this.CmdStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Panel PanelTopLeft;
        private System.Windows.Forms.Panel PanelTopRight;
        private System.Windows.Forms.Panel PanelBottomLeft;
        private System.Windows.Forms.Panel PanelBottomRight;
        private System.Windows.Forms.Timer Timer;
    }
}

