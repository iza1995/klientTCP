namespace klientTCP
{
    partial class Form1
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
            this.przycisk1 = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.port_p = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.polaczenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk1
            // 
            this.przycisk1.Location = new System.Drawing.Point(520, 443);
            this.przycisk1.Name = "przycisk1";
            this.przycisk1.Size = new System.Drawing.Size(128, 32);
            this.przycisk1.TabIndex = 0;
            this.przycisk1.Text = "zamknij";
            this.przycisk1.UseVisualStyleBackColor = true;
            this.przycisk1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(40, 42);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(167, 20);
            this.adres.TabIndex = 1;
            this.adres.Text = "Adres";
            // 
            // port_p
            // 
            this.port_p.Location = new System.Drawing.Point(506, 41);
            this.port_p.Maximum = new decimal(new int[] {
            55535,
            0,
            0,
            0});
            this.port_p.Name = "port_p";
            this.port_p.Size = new System.Drawing.Size(120, 20);
            this.port_p.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(673, 303);
            this.listBox1.TabIndex = 3;
            // 
            // polaczenie
            // 
            this.polaczenie.Location = new System.Drawing.Point(183, 443);
            this.polaczenie.Name = "polaczenie";
            this.polaczenie.Size = new System.Drawing.Size(116, 32);
            this.polaczenie.TabIndex = 4;
            this.polaczenie.Text = "polącz";
            this.polaczenie.UseVisualStyleBackColor = true;
            this.polaczenie.Click += new System.EventHandler(this.polaczenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 487);
            this.Controls.Add(this.polaczenie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port_p);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.przycisk1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk1;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown port_p;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button polaczenie;
    }
}

