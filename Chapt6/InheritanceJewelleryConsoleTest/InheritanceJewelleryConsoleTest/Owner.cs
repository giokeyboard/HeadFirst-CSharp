namespace InheritanceJewelleryConsoleTest
{
    class Owner
    {
        private Jewels returnedContents;

        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            System.Console.WriteLine("Than you for returning my jewels! " + safeContents.Sparkle());
        }
    }
}
