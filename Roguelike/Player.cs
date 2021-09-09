using System;
using System.Collections.Generic;


namespace Roguelike
{
    internal class Player : AliveObject
    {

        private List<Loot> bag = new(BagCapacityLimit);
        public static int BagCapacityLimit = 100;

        public int CurrentBagCapacity { get; set; } = Level.seed.Next(BagCapacityLimit);

        public static (int x, int y) Position { get; set; }

        public Player() 
        {
            Position = (Level.seed.Next(0, Level.X + 1), Level.seed.Next(0, Level.Y + 1));
            bag.Capacity = CurrentBagCapacity;
            Level.GetLevelState();
            GetPlayerState();
            
        }

        public bool IsStepPossible((int x, int y) position) => position.x >= 0 && position.y <= Level.Y;

        public void GetPlayerState() => Console.WriteLine($"Player is here: {Position} with {CurrentBagCapacity} / {BagCapacityLimit} bag");

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

        
        //TO DO: словарь строка-действие

        public void ChangePlayerState()
        {
            string cmd = Console.ReadLine();


        }
    }
}
