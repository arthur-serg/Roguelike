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

        public static int MeshSize { get; private set; } = seed.Next(8,16);
        public static int X { get; private set; } = seed.Next(1, 11);
        public static int Y { get; private set; } = seed.Next(1, 11);

        

        public Level()
        {
            
            Init(out Room initialRoom);
            
        }

        public void Init(out Room initialRoom)
        {
            Player player = new Player();
            Room[,] rooms = new Room[MeshSize, MeshSize];
            initialRoom = rooms[seed.Next(rooms.GetLength(0)), seed.Next(rooms.GetLength(1))];
            player.Init(initialRoom);
            
        }

        public static void GetLevelState() => Console.WriteLine($"{MeshSize} by {MeshSize} level inited.");

        public virtual void GetInfo() => Console.WriteLine($"{ID}");
    }
}
