﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapt7PoolPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            Nose[] i = new Nose[3];
            i[0] = new Acts();
            i[1] = new Clowns();
            i[2] = new Of76();

            for (int x = 0; x < 3; x++)
            {
                result += (i[x].Ear() + " " + i[x].Face) + "\n";
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    interface Nose
    {
        int Ear();
        string Face { get; }
    }

    class Acts : Picasso
    {
        public Acts() : base("Acts") { }

        public override int Ear()
        {
            return 5;
        }
    }

    class Clowns : Picasso
    {
        public Clowns() : base("Clowns") { }
    }

    class Of76 : Clowns
    {
        public override string Face { get { return "Of76"; } }
    }

    abstract class Picasso : Nose
    {
        public virtual int Ear() { return 7; }

        public Picasso(string face)
        {
            this.face = face;
        }

        public virtual string Face { get { return face; } }
        string face;
    }

}
