using System;
using System.Collections.Generic;
using System.Text;

namespace Roguelike
{
    internal class Loot : NonLivingObject
    {
        public new string ID { get; private set; } = "Loot";

        public new string Name { get; private set; } = "unknown";
        public int Capacity { get; }

        public Loot()
        {
            Capacity = Level.seed.Next(Player.BagCapacityLimit / 2);
        }
    }
}