using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            Console.WriteLine(Card.DoesCardMatch(cardToCheck, Suits.Hearts));
            Console.WriteLine(Card.DoesCardMatch(cardToCheck,Values.Three));
        }
    }
}
