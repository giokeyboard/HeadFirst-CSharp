﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceExample
{
    class Duck : Bird, IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck duckToCompare)
        {
            if (Size > duckToCompare.Size)
            {
                return 1;
            }
            else if (Size < duckToCompare.Size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"A {Size} inch {Kind.ToString()}";
        }
    }
}
