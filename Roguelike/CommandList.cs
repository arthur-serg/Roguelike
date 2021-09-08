using System;
using System.Collections.Generic;
using System.Text;

namespace Roguelike
{
    internal class CommandList : Player
    {
        public Dictionary<string, Action> Commands = new()
        {
            {"up", MoveUp},
            {"down", MoveDown},
            {"right", MoveRight},
            {"left", MoveLeft},
            {"pick", Pick},
            {"look", LookAround},
            {"eat", Eat}
        };
        
        




    }
}
