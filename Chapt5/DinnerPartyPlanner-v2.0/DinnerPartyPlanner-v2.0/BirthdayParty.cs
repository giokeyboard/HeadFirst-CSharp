using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner_v2._0
{
    class BirthdayParty
    {
        private const int costOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }
        private int ActualLength
        {
            get { return (CakeWriting.Length > MaxWritingLength()) ? MaxWritingLength() : CakeWriting.Length; }
        }
        public bool CakeWritingTooLong
        {
            get { return CakeWriting.Length > MaxWritingLength(); }
        }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations() + (costOfFoodPerPerson * NumberOfPeople);
                decimal cakeCost = (CakeSize() == 8) ? 40M + (ActualLength * .25M) : 75M + (ActualLength * .25M);
                totalCost += cakeCost;
                return (NumberOfPeople > 12) ? totalCost + 100 : totalCost;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int MaxWritingLength() { return (CakeSize() == 8) ? 16 : 40; }

        private int CakeSize() { return (NumberOfPeople <= 4) ? 8 : 16; }

        private decimal CalculateCostOfDecorations()
        {
            return (FancyDecorations) ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;
        }
    }
}
