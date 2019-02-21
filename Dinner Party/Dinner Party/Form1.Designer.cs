namespace Dinner_Party
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfPeopleNumeric = new System.Windows.Forms.NumericUpDown();
            this.decorationsCheckBox = new System.Windows.Forms.CheckBox();
            this.healthyOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.DinnerPartyCostTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość osób";
            // 
            // NumberOfPeopleNumeric
            // 
            this.NumberOfPeopleNumeric.Location = new System.Drawing.Point(12, 29);
            this.NumberOfPeopleNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberOfPeopleNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPeopleNumeric.Name = "NumberOfPeopleNumeric";
            this.NumberOfPeopleNumeric.Size = new System.Drawing.Size(120, 20);
            this.NumberOfPeopleNumeric.TabIndex = 1;
            this.NumberOfPeopleNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberOfPeopleNumeric.ValueChanged += new System.EventHandler(this.NumberOfPeopleNumeric_ValueChanged);
            // 
            // decorationsCheckBox
            // 
            this.decorationsCheckBox.AutoSize = true;
            this.decorationsCheckBox.Checked = true;
            this.decorationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decorationsCheckBox.Location = new System.Drawing.Point(16, 55);
            this.decorationsCheckBox.Name = "decorationsCheckBox";
            this.decorationsCheckBox.Size = new System.Drawing.Size(126, 17);
            this.decorationsCheckBox.TabIndex = 2;
            this.decorationsCheckBox.Text = "Dekoracje fantazyjne";
            this.decorationsCheckBox.UseVisualStyleBackColor = true;
            this.decorationsCheckBox.CheckedChanged += new System.EventHandler(this.decorationsCheckBox_CheckedChanged);
            // 
            // healthyOptionCheckBox
            // 
            this.healthyOptionCheckBox.AutoSize = true;
            this.healthyOptionCheckBox.Location = new System.Drawing.Point(16, 78);
            this.healthyOptionCheckBox.Name = "healthyOptionCheckBox";
            this.healthyOptionCheckBox.Size = new System.Drawing.Size(91, 17);
            this.healthyOptionCheckBox.TabIndex = 3;
            this.healthyOptionCheckBox.Text = "Opcja zdrowa";
            this.healthyOptionCheckBox.UseVisualStyleBackColor = true;
            this.healthyOptionCheckBox.CheckedChanged += new System.EventHandler(this.healthyOptionCheckBox_CheckedChanged);
            // 
            // DinnerPartyCostTextBox
            // 
            this.DinnerPartyCostTextBox.Enabled = false;
            this.DinnerPartyCostTextBox.Location = new System.Drawing.Point(61, 101);
            this.DinnerPartyCostTextBox.Name = "DinnerPartyCostTextBox";
            this.DinnerPartyCostTextBox.ReadOnly = true;
            this.DinnerPartyCostTextBox.Size = new System.Drawing.Size(71, 20);
            this.DinnerPartyCostTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Koszt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 136);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DinnerPartyCostTextBox);
            this.Controls.Add(this.healthyOptionCheckBox);
            this.Controls.Add(this.decorationsCheckBox);
            this.Controls.Add(this.NumberOfPeopleNumeric);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dinner party";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox healthyOptionCheckBox;
        public System.Windows.Forms.NumericUpDown NumberOfPeopleNumeric;
        public System.Windows.Forms.CheckBox decorationsCheckBox;
        public System.Windows.Forms.TextBox DinnerPartyCostTextBox;
    }
}

