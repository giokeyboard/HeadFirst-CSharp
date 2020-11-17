using System.Collections.Generic;

namespace DuckListComparable
{
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
            {
                return -1;
            }
            else if (x.Kind > y.Kind)
            {
                return 1;
            }
            else { return 0; }
        }
    }
}
