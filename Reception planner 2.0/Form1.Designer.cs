namespace Reception_planner_2._0
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
            this.label2 = new System.Windows.Forms.Label();
            this.DinnerPartyCostTextBox = new System.Windows.Forms.TextBox();
            this.healthyOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.decorationsCheckBox = new System.Windows.Forms.CheckBox();
            this.NumberOfPeopleNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.TextBox();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleNumeric)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cost";
            // 
            // DinnerPartyCostTextBox
            // 
            this.DinnerPartyCostTextBox.Enabled = false;
            this.DinnerPartyCostTextBox.Location = new System.Drawing.Point(56, 91);
            this.DinnerPartyCostTextBox.Name = "DinnerPartyCostTextBox";
            this.DinnerPartyCostTextBox.ReadOnly = true;
            this.DinnerPartyCostTextBox.Size = new System.Drawing.Size(71, 20);
            this.DinnerPartyCostTextBox.TabIndex = 10;
            // 
            // healthyOptionCheckBox
            // 
            this.healthyOptionCheckBox.AutoSize = true;
            this.healthyOptionCheckBox.Location = new System.Drawing.Point(11, 68);
            this.healthyOptionCheckBox.Name = "healthyOptionCheckBox";
            this.healthyOptionCheckBox.Size = new System.Drawing.Size(94, 17);
            this.healthyOptionCheckBox.TabIndex = 9;
            this.healthyOptionCheckBox.Text = "Healthy option";
            this.healthyOptionCheckBox.UseVisualStyleBackColor = true;
            this.healthyOptionCheckBox.CheckedChanged += new System.EventHandler(this.healthyOptionCheckBox_CheckedChanged);
            // 
            // decorationsCheckBox
            // 
            this.decorationsCheckBox.AutoSize = true;
            this.decorationsCheckBox.Checked = true;
            this.decorationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decorationsCheckBox.Location = new System.Drawing.Point(11, 45);
            this.decorationsCheckBox.Name = "decorationsCheckBox";
            this.decorationsCheckBox.Size = new System.Drawing.Size(113, 17);
            this.decorationsCheckBox.TabIndex = 8;
            this.decorationsCheckBox.Text = "Fancy decorations";
            this.decorationsCheckBox.UseVisualStyleBackColor = true;
            this.decorationsCheckBox.CheckedChanged += new System.EventHandler(this.decorationsCheckBox_CheckedChanged);
            // 
            // NumberOfPeopleNumeric
            // 
            this.NumberOfPeopleNumeric.Location = new System.Drawing.Point(7, 19);
            this.NumberOfPeopleNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPeopleNumeric.Name = "NumberOfPeopleNumeric";
            this.NumberOfPeopleNumeric.Size = new System.Drawing.Size(120, 20);
            this.NumberOfPeopleNumeric.TabIndex = 7;
            this.NumberOfPeopleNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberOfPeopleNumeric.ValueChanged += new System.EventHandler(this.NumberOfPeopleNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nuber of people";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(218, 166);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NumberOfPeopleNumeric);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DinnerPartyCostTextBox);
            this.tabPage1.Controls.Add(this.decorationsCheckBox);
            this.tabPage1.Controls.Add(this.healthyOptionCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(210, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(210, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(8, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cost";
            // 
            // birthdayCost
            // 
            this.birthdayCost.Enabled = false;
            this.birthdayCost.Location = new System.Drawing.Point(56, 111);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.ReadOnly = true;
            this.birthdayCost.Size = new System.Drawing.Size(71, 20);
            this.birthdayCost.TabIndex = 15;
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(7, 81);
            this.cakeWriting.MaxLength = 1000;
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(185, 20);
            this.cakeWriting.TabIndex = 14;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(129, 65);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 13;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inscription on the cake";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(7, 19);
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 10;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nuber of people";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Location = new System.Drawing.Point(11, 45);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(113, 17);
            this.fancyBirthday.TabIndex = 11;
            this.fancyBirthday.Text = "Fancy decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 166);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Reception planner 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleNumeric)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DinnerPartyCostTextBox;
        public System.Windows.Forms.CheckBox healthyOptionCheckBox;
        public System.Windows.Forms.CheckBox decorationsCheckBox;
        public System.Windows.Forms.NumericUpDown NumberOfPeopleNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox birthdayCost;
    }
}

