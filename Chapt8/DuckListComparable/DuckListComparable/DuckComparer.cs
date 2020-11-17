using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckListComparable
{
    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy { get; private set; }

        public DuckComparer(SortCriteria sortBy)
        {
            SortBy = sortBy;
        }

        public int Compare(Duck x, Duck y)
        {
            switch (SortBy)
            {
                case SortCriteria.SizeThenKind:
                    if (x.Size > y.Size) { return 1; }
                    else if (x.Size < y.Size) { return -1; }
                    else
                    {
                        if (x.Kind > y.Kind) { return 1; }
                        else if (x.Kind < y.Kind) { return -1; }
                        else { return 0; }
                    }
                case SortCriteria.KindThenSize:
                    if (x.Kind > y.Kind) { return 1; }
                    else if (x.Kind < y.Kind) { return -1; }
                    else
                    {
                        if (x.Size > y.Size) { return 1; }
                        else if (x.Size < y.Size) { return -1; }
                        else { return 0; }
                    }
                default:
                    return 0;
            }
        }
    }
}
