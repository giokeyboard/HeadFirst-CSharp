﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckListComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13},
            };

            PrintDucks(ducks);
            //ducks.Sort();
            //PrintDucks(ducks);

            //DuckComparerBySize sizeComparer = new DuckComparerBySize();
            //ducks.Sort(sizeComparer);
            //PrintDucks(ducks);

            //ducks.Sort(new DuckComparerByKind());

            ducks.Sort(new DuckComparer(SortCriteria.SizeThenKind));
            PrintDucks(ducks);

            //Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
            Console.WriteLine("End of ducks!");
        }
    }
}
