using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Channels;


namespace Roguelike
{
    internal class Level : GameObject
    {
        
        public static Random seed = new Random();

        public string ID { get; private set; } = "Level";
        public static int X { get; private set; } = seed.Next(1, 11);
        public static int Y { get; private set; } = seed.Next(1, 11);

        

        public Level()
        {
            Player player = new Player();
            

        }

        public static void GetLevelState() => Console.WriteLine($"{X} by {Y} level inited.");

        public virtual void GetInfo() => Console.WriteLine($"{ID}");
    }
}
