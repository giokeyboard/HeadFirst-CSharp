using System;

namespace InterfacesFirstApproach
{
    class Bee : IStingPatrol
    {
        public int AlertLevel { get { return 0; } }

        public int StingerLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool LookForEnemies()
        {
            return false;
        }

        public int SharpenStinger(int length)
        {
            return 0;
        }
    }
}
