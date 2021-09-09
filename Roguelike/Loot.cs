using System;
using System.Collections.Generic;
using System.Text;

namespace Roguelike
{
    internal class Loot : NonLivingObject
    {
        public string Name { get; set; }
        public int Capacity { get; }

        public Loot()
        {
            Name = "loot";
            Capacity = Level.seed.Next(Player.BagCapacityLimit / 2);
        }
    }
}
