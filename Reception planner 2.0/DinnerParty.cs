#if DEBUG

#endif

namespace Reception_planner_2._0
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal SetHealthyOption()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
                costOfBeveragesPerPerson = 5.00M;
            else
                costOfBeveragesPerPerson = 20.00M;
            return costOfBeveragesPerPerson;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = 50M + (NumberOfPeople * 15.00M);
            else
                costOfDecorations = 30M + (NumberOfPeople * 7.50M);
            return costOfDecorations;
        }

        public decimal CalculateCost
        {
            get
            {
                decimal totalCost = (NumberOfPeople * (CostOfFoodPerPerson + SetHealthyOption())) + CalculateCostOfDecorations();

                if (HealthyOption)
                    return totalCost * 0.95M;
                else
                    return totalCost;
            }
        }
    }
}
