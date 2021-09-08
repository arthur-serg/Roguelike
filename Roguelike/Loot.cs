using System;
using System.Collections.Generic;
using System.Text;

namespace Roguelike
{
    internal class Loot : Level
    {
        public string Name { get; set; }
        public int Capacity { get; }

        public Loot()
        {
            Name = "loot";
            Capacity = seed.Next(Player.BagCapacityLimit / 2);
        }
    }
}
