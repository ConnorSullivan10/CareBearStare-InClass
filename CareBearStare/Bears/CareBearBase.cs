﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    abstract class CareBearBase
    {
        // protected means that I get access to the setter, and anyone who inherits from me gets to the setter
        public string Name { get; protected set; }
        public BearColor Color { get; set; }
        public string BellyBadge { get; set; }

        // below indicates that any Stare function has to be called for each Care Bear
        public abstract void Stare();

        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}.");
        }


        public virtual void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them," +
                $" pressing their {BellyBadge} and {careBearToHug.BellyBadge} together.");
        }
    }

    
}
