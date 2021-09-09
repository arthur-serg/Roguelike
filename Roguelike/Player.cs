using System;
using System.Collections.Generic;


namespace Roguelike
{
    internal class Player : AliveObject
    {

        private List<Loot> bag = new(BagCapacityLimit);
        public static int BagCapacityLimit = 100;
        private static (int x, int y) initialPosition = new Room().CurrentRoom;
        public int CurrentBagCapacity { get; set; } = Level.seed.Next(BagCapacityLimit);

        public static (int x, int y) Position { get; set; } = initialPosition;
        //{
        //    get => (initialPosition.x, initialPosition.y);
            
        //    set
        //    {
        //        initialPosition.x = value.x;
        //        initialPosition.y = value.y;
        //    }
        //}



        public Player() 
        {
            Level.GetLevelState();
            GetPlayerState();
            
        }

        public void Init(in Room initialPosition)
        {
            Position = Player.initialPosition;
        }

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
