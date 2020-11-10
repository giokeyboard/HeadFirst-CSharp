namespace InheritanceJewelleryConsoleTest
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";

        public Jewels Open(string combination) { return (combination == safeCombination) ? contents : null; }

        public void PickLock(Locksmith lockpicker) { lockpicker.WriteDownCombination(safeCombination); }
    }
}
