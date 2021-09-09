using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Roguelike
{
    internal class Room : GameObject
    {
        public Room Up
        {
            get
            {

            }
            set
            {

            }
        }

        public Room Right { get; set; }
        public Room Down { get; set; }
        public Room Left { get; set; }

        
        public new string ID { get; private set; } = "Room";

        public (int x, int y) CurrentRoomCoords { get; set; } =
            (Level.seed.Next(Level.MeshSize), Level.seed.Next(Level.MeshSize));

        
        

        public string Name
        {
            get => locations[Level.seed.Next(0, locations.Length)];
            private set => locations[Level.seed.Next(0, locations.Length)] = value;
        }

        public string Description { get; private set; }

        public string[] locations =
        {
            "forest",
            "lake",
            "river",
            "house",
            "mountain",
            "town",
            "inn",
            "cave",
            "tower",
        };


        public Room()
        {
            CurrentRoomCoords = (CurrentRoomCoords.x, CurrentRoomCoords.y);
            
        }

        public void Init(out Room initialRoom)
        {
            initialRoom = GenerateRooms()[Level.seed.Next(0, Level.MeshSize), Level.seed.Next(0, Level.MeshSize)];
        }

        public Room[,] GenerateRooms()
        {
            var world = new Room[Level.MeshSize, Level.MeshSize];
            for (int i = 0; i < world.GetLength(0); ++i)
            {
                for (int j = 0; j < world.GetLength(1); ++j)
                {
                    world[i, j] = new Room();
                }
            }

            return world;
        }

        public bool MoveNext()
        {
            return true;
        }
    }
}