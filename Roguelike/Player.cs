using System;
using System.Collections.Generic;


namespace Roguelike
{
    internal class Player : AliveObject
    {
        public new string ID { get; private set; } = "Player";
        private List<Loot> bag = new(BagCapacityLimit);
        public static int BagCapacityLimit = 100;
        private static (int x, int y) initialPlayerCoords = new Room().CurrentRoomCoords;
        public int CurrentBagCapacity { get; set; } = Level.seed.Next(BagCapacityLimit);

        public static (int x, int y) PlayerCoords { get; set; } = initialPlayerCoords;


        public Player()
        {
            GetPlayerState();
        }

        public void Init(in Room initialPlayerPosition)
        {
            Room location = new Room();
            PlayerCoords = initialPlayerPosition.CurrentRoomCoords;
        }

        public void GetPlayerState() =>
            Console.WriteLine($"Player's coords: {PlayerCoords} bag: {CurrentBagCapacity} / {BagCapacityLimit} ");

        public static void MoveUp() => PlayerCoords = (PlayerCoords.x + 1, PlayerCoords.y);

        public static void MoveRight() => PlayerCoords = (PlayerCoords.x, PlayerCoords.y + 1);

        public static void MoveDown() => PlayerCoords = (PlayerCoords.x - 1, PlayerCoords.y);

        public static void MoveLeft() => PlayerCoords = (PlayerCoords.x, PlayerCoords.y - 1);

        public static void Pick()
        {
        }

        public static void LookAround()
        {
        }

        public static void Eat()
        {
        }


        public void ChangePlayerState()
        {
            string cmd = Console.ReadLine();
        }
    }
}