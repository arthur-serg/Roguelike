using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Channels;


namespace Roguelike
{
    internal class Level : GameObject
    {
        public static Random seed = new();

        public string ID { get; private set; } = "Level";

        public static int MeshSize { get; private set; } = seed.Next(5, 8);
        public static int X { get; private set; } = seed.Next(1, 11);
        public static int Y { get; private set; } = seed.Next(1, 11);


        public Level()
        {
            Init(out Room initialRoom);
            GetLevelState();
        }

        public void Init(out Room initialRoom)
        {
            var rooms = Room.GenerateRooms();
            initialRoom = rooms[seed.Next(rooms.GetLength(0)), seed.Next(rooms.GetLength(1))];
        }

        public static void GetLevelState() => Console.WriteLine($"{MeshSize} by {MeshSize} level inited.");

        public virtual void GetInfo() => Console.WriteLine($"{ID}");
    }
}