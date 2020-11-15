using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            //tallGuy.TalkAboutYourself();
            //tallGuy.Honk();

            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadKey();
        }
    }

    interface IClown
    {
        string FunnyThingIHave { get; }

        void Honk();
    }

    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScareLittleChildren();
    }

    class FunnyFunny : IClown
    {
        protected string funnyThingIHave;
        public string FunnyThingIHave { get { return $"Hi kids! I have a {funnyThingIHave}"; } }

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }

    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public string ScaryThingIHave { get { return $"I have {numberOfScaryThings} spiders"; } }

        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public void ScareLittleChildren()
        {
            //Console.WriteLine("Boo! Gotcha!");
            Console.WriteLine($"You can't have my {base.funnyThingIHave}");
        }
    }
}
