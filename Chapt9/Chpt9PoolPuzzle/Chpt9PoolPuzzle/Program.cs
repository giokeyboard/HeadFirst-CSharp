﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt9PoolPuzzle
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //    }
    //}

    class Pineapple
    {
        const string d = "delivery.txt";
        public enum Fargo { North, South, East, West, Flamingo, }

        public static void Main(string[] args)
        {
            StreamWriter o = new StreamWriter("order.txt");
            Pizza pz = new Pizza(new StreamWriter(d, true));
            pz.Idaho(Fargo.Flamingo);
            for (int w = 3; w >= 0; w--)
            {
                Pizza i = new Pizza(new StreamWriter(d, false));
                i.Idaho((Fargo)w);
                Party p = new Party(new StreamReader(d));
                p.HowMuch(o);
            }
            o.Write("That's all folks!");
            o.Close();
        }
    }

    class Pizza
    {
        private StreamWriter writer;

        public Pizza(StreamWriter writer)
        {
            this.writer = writer;
        }

        public void Idaho(Pineapple.Fargo f)
        {
            writer.WriteLine(f);
            writer.Close();
        }
    }

    class Party
    {
        private StreamReader reader;

        public Party(StreamReader reader)
        {
            this.reader = reader;
        }

        public void HowMuch(StreamWriter q)
        {
            q.WriteLine(reader.ReadLine());
            reader.Close();
        }
    }
}