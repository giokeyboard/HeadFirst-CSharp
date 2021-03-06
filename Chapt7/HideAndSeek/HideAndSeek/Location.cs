﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek
{
    public abstract class Location
    {
        public Location[] Exits;
        public string Name { get; private set; }
        public virtual string Description
        {
            get
            {
                string description = $"You're standing in the {Name}.\r\nYou see exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                    {
                        description += ", ";
                    }
                }
                description += ".\r\n";
                return description;
            }
        }

        public Location(string name)
        {
            Name = name;
        }
    }
}
