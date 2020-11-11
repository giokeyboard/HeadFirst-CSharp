using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner_v3._0
{
    class Party
    {
        public const int costOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations() + (costOfFoodPerPerson * NumberOfPeople);
                return (NumberOfPeople > 12) ? totalCost + 100 : totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            return (FancyDecorations) ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;
        }

    }
}
