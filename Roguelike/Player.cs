using System;
using System.Collections.Generic;


namespace Roguelike
{
    internal class Player
    {
        public delegate void Move();

        private Move movePlayer;

        private List<Loot> bag = new List<Loot>(BagCapacityLimit);
        public static int BagCapacityLimit = 100;

        public int BagCapacity { get; set; } = Level.seed.Next(BagCapacityLimit);

        public (int, int) Position { get; set; } = (0, 0);

        public Player() 
        {
            Position = (Level.seed.Next(Level.Width) , Level.seed.Next(Level.Height));
            
            bag.Capacity = BagCapacity;
            Level.GetLevelState();
            GetPlayerState();
            
        }

        public void GetPlayerState() => Console.WriteLine($"Player is here: {Position} with {BagCapacity} / {BagCapacityLimit} bag");

        public void MoveNorth() => Position = (Position.Item1 + 1, Position.Item2);

        public void MoveEast() => Position = (Position.Item1, Position.Item2+1);

        public void MoveSouth() => Position = (Position.Item1 -1, Position.Item2);

        public void MoveWest() => Position = (Position.Item1, Position.Item2-1);

        public void ChangePlayerPosition()
        {
            ConsoleKey key = Console.ReadKey().Key;
            while (key!=ConsoleKey.Escape)
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.N:
                        movePlayer = MoveNorth;
                        continue;
                    case ConsoleKey.E:
                        movePlayer = MoveEast;
                        continue;
                    case ConsoleKey.W:
                        movePlayer = MoveWest;
                        continue;
                    case ConsoleKey.S:
                        movePlayer = MoveSouth;
                        continue;
                }
            }
            
        }
    }
}
