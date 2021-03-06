﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner
{
    class DinnerParty
    {
        private const int costOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations() + NumberOfPeople * (CalculateCostOfBeveragesPerPerson() + costOfFoodPerPerson);
                return (HealthyOption) ? totalCost * .95M : totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            return (FancyDecorations) ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return (HealthyOption) ? 5.00M : 20.00M;
        }
    }
}
