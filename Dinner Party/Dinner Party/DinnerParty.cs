using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party
{
    public class DinnerParty
    {
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }

        public void CalculateCostOfDecorations(bool decorations)
        {
            if (decorations)
                CostOfDecorations = 50M + (NumberOfPeople * 15.00M);
            else
                CostOfDecorations = 30M + (NumberOfPeople * 7.50M);
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = (NumberOfPeople * (CostOfFoodPerPerson + CostOfBeveragesPerPerson)) + CostOfDecorations;

            if (healthyOption)
                return totalCost * 0.95M;
            else
                return totalCost;
        }
    }
}
