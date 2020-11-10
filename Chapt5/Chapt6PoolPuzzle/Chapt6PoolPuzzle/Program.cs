using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapt6PoolPuzzle
{
    class Boat
    {
        private int length;

        public void SetLength(int len)
        {
            length = len;
        }

        public int GetLength()
        {
            return length;
        }

        public virtual string Move()
        {
            return " drift ";
        }
    }

    class Rowboat : Boat
    {
        public string RowTheBoat()
        {
            return "stroke natasha";
        }
    }

    class Sailboat : Boat
    {
        public override string Move()
        {
            return " hoist sail ";
        }
    }

    class TestBoats
    {
        static void Main()
        {
            string xyz = "";
            Boat b1 = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();

            b2.SetLength(32);
            xyz = b1.Move();
            xyz += b3.Move();
            xyz += b2.Move();

            MessageBox.Show(xyz);
        }
    }
}
