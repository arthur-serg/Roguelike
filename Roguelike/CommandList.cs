using System;
using System.Collections.Generic;
using System.Text;

namespace Roguelike
{
    internal class CommandList 
    {
        public Dictionary<string, Action> Commands = new()
        {
            {"up", Player.MoveUp},
            {"down", Player.MoveDown},
            {"right", Player.MoveRight},
            {"left", Player.MoveLeft},
            {"pick", Player.Pick},
            {"look", Player.LookAround},
            {"eat", Player.Eat}
        };
        
        




    }
}
