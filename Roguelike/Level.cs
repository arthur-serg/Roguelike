using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;


namespace Roguelike
{
    internal class Level
    {
        //public delegate void GetState();

        public static Random seed = new Random();

        public static int X { get; private set; } = seed.Next(1, 11);
        public static int Y { get; private set; } = seed.Next(1, 11);

        public static Room[,] Rooms = new Room[X, Y];

        Player player = new Player();

        public Level()
        {
            
            
            player.ChangePlayerPosition();
        }

        public static void GetLevelState() => Console.WriteLine($"{X} by {Y} level inited.");
    }
}
