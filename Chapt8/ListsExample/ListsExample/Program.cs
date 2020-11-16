using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Colour = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Clogs, Colour = "Brown" });
            shoeCloset.Add(new Shoe() { Style = Style.Wingtips, Colour = "Black" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Colour = "White" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Colour = "Red" });
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Colour = "Green" });

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Colour = "Orange";
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe = shoeCloset[1];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if (shoeCloset.Contains(secondShoe)) { Console.WriteLine("That's surprising"); }
        }
    }
}
