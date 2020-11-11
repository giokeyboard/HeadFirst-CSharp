using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner_v3._0
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                return (HealthyOption) ? totalCost * .95M : totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return (HealthyOption) ? 5.00M : 20.00M;
        }
    }
}
