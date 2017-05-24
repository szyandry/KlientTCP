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
            this.SuspendLayout();
            // 
            // przycisk1
            // 
            this.przycisk1.Location = new System.Drawing.Point(416, 164);
            this.przycisk1.Name = "przycisk1";
            this.przycisk1.Size = new System.Drawing.Size(75, 23);
            this.przycisk1.TabIndex = 0;
            this.przycisk1.Text = "Zamknij";
            this.przycisk1.UseVisualStyleBackColor = true;
            this.przycisk1.Click += new System.EventHandler(this.przycisk1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 459);
            this.Controls.Add(this.przycisk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button przycisk1;
    }
}

