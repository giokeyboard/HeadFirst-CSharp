using System;

namespace CovarianceExample
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly!");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }
    }
}
