using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_wyścigów
{
    public class Guy
    {
        public string Name;
        public Bet MyBet = null;
        public int Cash;
        public bool isBetting = false;

        public RadioButton MyRadioButton;
        public TextBox MyTextBox;

        public void UpdateLabels()
        {
            MyTextBox.Text = MyBet.GetDescription();
            updateRadioButton();
        }

        public void updateRadioButton()
        {
            MyRadioButton.Text = Name + " ma " + Cash;
        }

        public void ClearBet()
        {
            MyBet = null;
            isBetting = false;
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            if (Cash >= Amount)
            {
                isBetting = true;
                MyBet = new Bet()
                {
                    Amount = Amount,
                    Dog = DogToWin,
                    Bettor = this
                };
                UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show("Nie masz wystarczająco duzo pieniędzy");
                return false;
            }
        }

        public void Collect (int Winner)
        {
            Cash += MyBet.payOut(Winner);
            ClearBet();

            updateRadioButton();
        }
    }
}
