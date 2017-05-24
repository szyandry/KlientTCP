namespace KlientTCP
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.polaczenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk1
            // 
            this.przycisk1.Location = new System.Drawing.Point(708, 387);
            this.przycisk1.Name = "przycisk1";
            this.przycisk1.Size = new System.Drawing.Size(75, 23);
            this.przycisk1.TabIndex = 0;
            this.przycisk1.Text = "Zamknij";
            this.przycisk1.UseVisualStyleBackColor = true;
            this.przycisk1.Click += new System.EventHandler(this.przycisk1_Click);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(13, 13);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(269, 20);
            this.Adres.TabIndex = 1;
            this.Adres.Text = "Adres";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(360, 12);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(290, 20);
            this.Port.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(902, 264);
            this.listBox1.TabIndex = 3;
            // 
            // polaczenie
            // 
            this.polaczenie.Location = new System.Drawing.Point(428, 387);
            this.polaczenie.Name = "polaczenie";
            this.polaczenie.Size = new System.Drawing.Size(75, 23);
            this.polaczenie.TabIndex = 4;
            this.polaczenie.Text = "Połącz";
            this.polaczenie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 459);
            this.Controls.Add(this.polaczenie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.przycisk1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk1;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button polaczenie;
    }
}

