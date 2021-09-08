using System;
using System.Collections.Generic;


namespace Roguelike
{
    internal class Player
    {
        public delegate void Move();

        public static Move movePlayer;

        private List<Loot> bag = new List<Loot>(BagCapacityLimit);
        public static int BagCapacityLimit = 100;

        public int BagCapacity { get; set; } = Level.seed.Next(BagCapacityLimit);

        public static (int x, int y) Position { get; set; }

        public Player() 
        {
            Position = (Level.seed.Next(Level.X) , Level.seed.Next(Level.Y));
            
            bag.Capacity = BagCapacity;
            Level.GetLevelState();
            GetPlayerState();
            
        }

        public bool IsStepPossible((int x, int y) position) => position.x >= 0 && position.y <= Level.Y;

        public void GetPlayerState() => Console.WriteLine($"Player is here: {Position} with {BagCapacity} / {BagCapacityLimit} bag");

        public static void MoveUp() => Position = (Position.x + 1, Position.y);

        public static void MoveRight() => Position = (Position.x, Position.y + 1);

        public static void MoveDown() => Position = (Position.x - 1, Position.y);

        public static void MoveLeft() => Position = (Position.x, Position.y - 1);

        public static void Pick()
        {

        }

        public static void LookAround()
        {

        }

        public static void Eat()
        {

        }

        //public void ChangePlayerPosition()
        //{
        //    ConsoleKey key = Console.ReadKey().Key;
            
        //    //TO DO: словарь строка-действие
        //    //       сообщение, что пройти невозможно, если упёрлись в стенку, либо ограничения на кол-во столкновений. =)
        //    while (IsStepPossible(Position))
        //    {
        //        while (key != ConsoleKey.Escape)
        //        {
        //            key = Console.ReadKey().Key;
        //            switch (key)
        //            {
        //                case ConsoleKey.UpArrow:
        //                    movePlayer = MoveUp;
        //                    movePlayer.Invoke();
        //                    GetPlayerState();
        //                    break;
        //                case ConsoleKey.LeftArrow:
        //                    movePlayer = MoveRight;
        //                    movePlayer.Invoke();
        //                    GetPlayerState();
        //                    break;
        //                case ConsoleKey.RightArrow:
        //                    movePlayer = MoveLeft;
        //                    movePlayer.Invoke();
        //                    GetPlayerState();
        //                    break;
        //                case ConsoleKey.DownArrow:
        //                    movePlayer = MoveDown;
        //                    movePlayer.Invoke();
        //                    GetPlayerState();
        //                    break;
        //            }
        //        }
        //    }
            
            
        //}

        public void ChangePlayerState()
        {
            string cmd = Console.ReadLine();

        }
    }
}
