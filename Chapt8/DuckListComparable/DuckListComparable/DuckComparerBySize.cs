using System.Collections.Generic;

namespace DuckListComparable
{
    class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Size > y.Size)
            {
                return 1;
            }
            else if (x.Size < y.Size)
            {
                return -1;
            }
            else { return 0; }
        }
    }
}
