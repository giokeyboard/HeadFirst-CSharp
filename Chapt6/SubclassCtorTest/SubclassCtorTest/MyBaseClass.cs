using System.Windows.Forms;

namespace SubclassCtorTest
{
    class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show("This is the base class: " + baseClassNeedsThis);
        }
    }

    class MySubClass : MyBaseClass
    {
        public MySubClass(string baseClassNeedsThis, int anotherValue) : base(baseClassNeedsThis)
        {
            MessageBox.Show("This is the subclass: " + baseClassNeedsThis + " and " + anotherValue);
        }
    }
}
