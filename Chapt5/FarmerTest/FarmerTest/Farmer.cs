using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerTest
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }
        public int FeedMultiplier { get; }

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = FeedMultiplier * numberOfCows;
            }
        }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            FeedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}
