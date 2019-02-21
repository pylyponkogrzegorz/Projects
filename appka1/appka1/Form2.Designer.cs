namespace appka1
{
    partial class Form2
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
            this.kolorTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.kolorLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.typLabel = new System.Windows.Forms.Label();
            this.DodajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kolorTextBox
            // 
            this.kolorTextBox.Location = new System.Drawing.Point(87, 17);
            this.kolorTextBox.Name = "kolorTextBox";
            this.kolorTextBox.Size = new System.Drawing.Size(185, 20);
            this.kolorTextBox.TabIndex = 0;
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(87, 57);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(185, 20);
            this.materialTextBox.TabIndex = 1;
            // 
            // typTextBox
            // 
            this.typTextBox.Location = new System.Drawing.Point(87, 98);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.Size = new System.Drawing.Size(185, 20);
            this.typTextBox.TabIndex = 2;
            // 
            // kolorLabel
            // 
            this.kolorLabel.AutoSize = true;
            this.kolorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolorLabel.Location = new System.Drawing.Point(12, 15);
            this.kolorLabel.Name = "kolorLabel";
            this.kolorLabel.Size = new System.Drawing.Size(49, 20);
            this.kolorLabel.TabIndex = 3;
            this.kolorLabel.Text = "Kolor:";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.materialLabel.Location = new System.Drawing.Point(12, 55);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(70, 20);
            this.materialLabel.TabIndex = 4;
            this.materialLabel.Text = "Materiał:";
            // 
            // typLabel
            // 
            this.typLabel.AutoSize = true;
            this.typLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typLabel.Location = new System.Drawing.Point(12, 96);
            this.typLabel.Name = "typLabel";
            this.typLabel.Size = new System.Drawing.Size(38, 20);
            this.typLabel.TabIndex = 5;
            this.typLabel.Text = "Typ:";
            // 
            // DodajButton
            // 
            this.DodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajButton.Location = new System.Drawing.Point(68, 134);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(139, 79);
            this.DodajButton.TabIndex = 6;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.typLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.kolorLabel);
            this.Controls.Add(this.typTextBox);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.kolorTextBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.Label kolorLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label typLabel;
        private System.Windows.Forms.Button DodajButton;
        public System.Windows.Forms.TextBox kolorTextBox;
    }
}