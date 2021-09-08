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

        public static int Width { get; private set; } = seed.Next(1, 11);
        public static int Height { get; private set; } = seed.Next(1, 11);

        public static Room[,] Rooms = new Room[Width, Height];

        Player player = new Player();

        public Level()
        {
            
            player.Position = (Width, Height);
            
        }

        public static void GetLevelState() => Console.WriteLine($"{Width} by {Height} level inited.");
    }
}
