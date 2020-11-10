namespace InheritanceJewelleryConsoleTest
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;

        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            System.Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
        }
    }
}
