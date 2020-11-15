using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek
{
    class Opponent
    {
        private Random random;
        private Location myLocation;

        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        public void Move()
        {
            bool hidden = false;

            while (!hidden)
            {
                if (myLocation is IHasExteriorDoor && random.Next(2) == 1)
                {
                    myLocation = (myLocation as IHasExteriorDoor).DoorLocation;
                }
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
                hidden = myLocation is IHidingPlace;
            }
        }

        public bool Check(Location locationToCheck)
        {
            return myLocation == locationToCheck;
        }
    }
}
