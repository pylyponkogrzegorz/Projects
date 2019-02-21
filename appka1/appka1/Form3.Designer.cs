using System.Windows.Forms;

namespace appka1
{
    partial class Form3
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
            this.numerDrzwiNumeric = new System.Windows.Forms.NumericUpDown();
            this.WyswietlButton = new System.Windows.Forms.Button();
            this.wyswietlDrzwiLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numerDrzwiNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // numerDrzwiNumeric
            // 
            this.numerDrzwiNumeric.Location = new System.Drawing.Point(87, 12);
            this.numerDrzwiNumeric.Name = "numerDrzwiNumeric";
            this.numerDrzwiNumeric.Size = new System.Drawing.Size(120, 20);
            this.numerDrzwiNumeric.TabIndex = 0;
            // 
            // WyswietlButton
            // 
            this.WyswietlButton.Location = new System.Drawing.Point(108, 38);
            this.WyswietlButton.Name = "WyswietlButton";
            this.WyswietlButton.Size = new System.Drawing.Size(75, 23);
            this.WyswietlButton.TabIndex = 1;
            this.WyswietlButton.Text = "Wyświetl";
            this.WyswietlButton.UseVisualStyleBackColor = true;
            this.WyswietlButton.Click += new System.EventHandler(this.WyswietlButton_Click);
            // 
            // wyswietlDrzwiLabel
            // 
            this.wyswietlDrzwiLabel.AllowDrop = true;
            this.wyswietlDrzwiLabel.AutoEllipsis = true;
            this.wyswietlDrzwiLabel.AutoSize = true;
            this.wyswietlDrzwiLabel.Location = new System.Drawing.Point(70, 83);
            this.wyswietlDrzwiLabel.MinimumSize = new System.Drawing.Size(150, 100);
            this.wyswietlDrzwiLabel.Name = "wyswietlDrzwiLabel";
            this.wyswietlDrzwiLabel.Size = new System.Drawing.Size(150, 100);
            this.wyswietlDrzwiLabel.TabIndex = 2;
            this.wyswietlDrzwiLabel.Click += new System.EventHandler(this.wyswietlDrzwiLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wyswietlDrzwiLabel);
            this.Controls.Add(this.WyswietlButton);
            this.Controls.Add(this.numerDrzwiNumeric);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numerDrzwiNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button WyswietlButton;
        public System.Windows.Forms.NumericUpDown numerDrzwiNumeric;
        private Label wyswietlDrzwiLabel;
        private TextBox textBox1;
    }
}