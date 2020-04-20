namespace Schachbrett
{
    partial class frmSchachbrett
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudAnzahlZeilen = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSchachbrett = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahlZeilen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAnzahlZeilen
            // 
            this.nudAnzahlZeilen.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAnzahlZeilen.Location = new System.Drawing.Point(27, 35);
            this.nudAnzahlZeilen.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAnzahlZeilen.Name = "nudAnzahlZeilen";
            this.nudAnzahlZeilen.Size = new System.Drawing.Size(83, 22);
            this.nudAnzahlZeilen.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(137, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.nudAnzahlZeilen);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 95);
            this.panel1.TabIndex = 2;
            // 
            // pnlSchachbrett
            // 
            this.pnlSchachbrett.BackColor = System.Drawing.Color.White;
            this.pnlSchachbrett.Location = new System.Drawing.Point(12, 130);
            this.pnlSchachbrett.Name = "pnlSchachbrett";
            this.pnlSchachbrett.Size = new System.Drawing.Size(576, 580);
            this.pnlSchachbrett.TabIndex = 3;
            // 
            // frmSchachbrett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 722);
            this.Controls.Add(this.pnlSchachbrett);
            this.Controls.Add(this.panel1);
            this.Name = "frmSchachbrett";
            this.Text = "Schachbrett";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahlZeilen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAnzahlZeilen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSchachbrett;
    }
}

