using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_wyścigów
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Amount >= 5 && Amount <= 15)
            {
                return Bettor.Name + " stawia " + Amount + " na charta numer " + (Dog + 1);
            }
            else
            {
                return Bettor.Name +"nie zawarł zakładu";
            }
        }

        public int payOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return (Amount * -1);
            }
        }
    }
}
