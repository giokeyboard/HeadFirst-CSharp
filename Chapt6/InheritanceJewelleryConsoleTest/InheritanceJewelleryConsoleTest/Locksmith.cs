using System;

namespace InheritanceJewelleryConsoleTest
{
    class Locksmith
    {
        private string writtenDownCombination = null;
        public void WriteDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }

        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        virtual public void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
