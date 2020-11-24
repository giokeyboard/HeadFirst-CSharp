using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberjacksCafeteria
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount
        {
            get { return meal.Count; }
        }

        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            // Add some number of flapjacks to the Meal stack
            for (int i = 0; i < howMany; i++)
            {
                meal.Push(food);
            }
        }

        public void EatFlapjacks()
        {
            // Write this output to the console
            Console.WriteLine($"{Name}'s eating flapjacks");
            while (meal.Count > 0)
            {
                Console.WriteLine($"{Name} ate a {meal.Pop().ToString().ToLower()} flapjack");
            }
        }
    }
}