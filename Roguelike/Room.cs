using System;
using System.Collections.Generic;
using System.Text;

namespace Roguelike
{
    internal class Room : GameObject
    {
        public (int x, int y) CurrentRoom { get; set; } = (Level.seed.Next(Level.MeshSize), Level.seed.Next(Level.MeshSize));

        public Room()
        {
            CurrentRoom = (CurrentRoom.x, CurrentRoom.y);
        }


    }
}
