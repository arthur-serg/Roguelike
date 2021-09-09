using System;
using System.Collections.Generic;
using System.Text;

namespace Roguelike
{
    internal class Room : GameObject
    {
        public (int x, int y) RoomPosition { get; set; }
        public Room()
        {
            
        }
    }
}
