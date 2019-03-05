using System;
using System.Windows.Forms;

namespace Reception_planner_2._0
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)NumberOfPeopleNumeric.Value, healthyOptionCheckBox.Checked, decorationsCheckBox.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void NumberOfPeopleNumeric_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)NumberOfPeopleNumeric.Value;
            DisplayDinnerPartyCost();
        }

        private void healthyOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyOptionCheckBox.Checked;

            DisplayDinnerPartyCost();
        }

        private void decorationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = decorationsCheckBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal dinnerCost = dinnerParty.CalculateCost;
            DinnerPartyCostTextBox.Text = dinnerCost.ToString("c");
        }

        

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        } 

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal birthdayCost = birthdayParty.Cost;
            this.birthdayCost.Text = birthdayCost.ToString("c");
        }
    }
}
