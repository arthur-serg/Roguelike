using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    class NonLivingObject : GameObject
    {
        public new string ID { get; private set; } = "NonLivingObject";

        public string Name
        {
            get => garbage[Level.seed.Next(0, garbage.Length)];

            private set => garbage[Level.seed.Next(0, garbage.Length)] = value;
        }

        public string Description { get; private set; }

        public string[] garbage =
        {
            "stone",
            "weed",
            "glass",
            "cash",
            "stem",
            "charcoal",
        };
    }
}