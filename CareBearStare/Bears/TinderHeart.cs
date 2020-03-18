using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class TinderHeart : CareBearBase
    {
        public TinderHeart()
        {
            Name = "Tinder Heart";
            BellyBadge = "Cell Phone";
        }
        public override void Stare()
        {
            Console.WriteLine("Swipe left");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Swipes right on {careBearToHug.Name}");
        }

    }
}
