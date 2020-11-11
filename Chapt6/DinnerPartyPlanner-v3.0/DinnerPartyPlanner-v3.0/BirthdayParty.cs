using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner_v3._0
{
    class BirthdayParty : Party
    {
        public string CakeWriting { get; set; }
        private int ActualLength
        {
            get { return (CakeWriting.Length > MaxWritingLength()) ? MaxWritingLength() : CakeWriting.Length; }
        }
        public bool CakeWritingTooLong
        {
            get { return CakeWriting.Length > MaxWritingLength(); }
        }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost = (CakeSize() == 8) ? 40M + (ActualLength * .25M) : 75M + (ActualLength * .25M);
                return totalCost + cakeCost;
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
