using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner_Party
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void NumberOfPeopleNumeric_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)NumberOfPeopleNumeric.Value;
            DisplayDinnerPartyCost();
        }

        private void healthyOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyOptionCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void decorationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(decorationsCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyOptionCheckBox.Checked);
            DinnerPartyCostTextBox.Text = Cost.ToString("c");
        }
    }
    }
