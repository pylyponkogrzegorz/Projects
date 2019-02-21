namespace appka1
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
            this.DodajDrzwiButton = new System.Windows.Forms.Button();
            this.WyswietlDrzwiButton = new System.Windows.Forms.Button();
            this.ZamknijButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DodajDrzwiButton
            // 
            this.DodajDrzwiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajDrzwiButton.Location = new System.Drawing.Point(53, 12);
            this.DodajDrzwiButton.Name = "DodajDrzwiButton";
            this.DodajDrzwiButton.Size = new System.Drawing.Size(178, 62);
            this.DodajDrzwiButton.TabIndex = 0;
            this.DodajDrzwiButton.Text = "Dodaj drzwi";
            this.DodajDrzwiButton.UseVisualStyleBackColor = true;
            this.DodajDrzwiButton.Click += new System.EventHandler(this.DodajDrzwiButton_Click);
            // 
            // WyswietlDrzwiButton
            // 
            this.WyswietlDrzwiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyswietlDrzwiButton.Location = new System.Drawing.Point(53, 94);
            this.WyswietlDrzwiButton.Name = "WyswietlDrzwiButton";
            this.WyswietlDrzwiButton.Size = new System.Drawing.Size(178, 62);
            this.WyswietlDrzwiButton.TabIndex = 1;
            this.WyswietlDrzwiButton.Text = "Wyświetl drzwi";
            this.WyswietlDrzwiButton.UseVisualStyleBackColor = true;
            this.WyswietlDrzwiButton.Click += new System.EventHandler(this.WyswietlDrzwiButton_Click);
            // 
            // ZamknijButton
            // 
            this.ZamknijButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamknijButton.Location = new System.Drawing.Point(53, 175);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(178, 62);
            this.ZamknijButton.TabIndex = 2;
            this.ZamknijButton.Text = "Zamknij";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.ZamknijButton);
            this.Controls.Add(this.WyswietlDrzwiButton);
            this.Controls.Add(this.DodajDrzwiButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DodajDrzwiButton;
        private System.Windows.Forms.Button WyswietlDrzwiButton;
        private System.Windows.Forms.Button ZamknijButton;
    }
}

