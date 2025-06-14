using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
    struct Interval
    {
        private Random random;
        private int minValue;
        private int maxValue;

        public int Min
        {
            get => minValue;
        }

        public int Max
        {
            get => maxValue;
        }

        public int Get()
        {
            return random.Next(minValue, maxValue);
        }
        public Interval(int minValue, int maxValue)
        {
            random = new Random();

            if (minValue > maxValue)
            {
                (minValue, maxValue) = (maxValue, minValue);
                Console.WriteLine("incorrect input data, minValue > maxValue");
            }
            if (minValue < 0)
            {
                Console.WriteLine("incorrect input data, minValue < 0");
                minValue = 0;
            }
            if (maxValue < 0)
            {
                Console.WriteLine("incorrect input data, maxValue < 0");
                maxValue = 0;
            }
            if (maxValue == minValue)
            {
                Console.WriteLine("incorrect input data, maxValue == minValue");
                maxValue += 10;
            }
        }
    }
    public struct Room
    {
        public Unit Unit { get; set; }
        public Weapon Weapon { get; set; }

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }
    public class Dungeon
    {
        private Room[] rooms;

        public Dungeon()
        {
            rooms = new Room[]
            {
            new Room(new Unit("Воин"), new Weapon("Меч", new Interval(5, 10))),
            new Room(new Unit("Лучник"), new Weapon("Лук", new Interval(3, 8))),
            new Room(new Unit("Маг"), new Weapon("Посох", new Interval(2, 6))),
            };
        }
        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];
                Console.WriteLine("Unit of room: " + room.Unit);
                Console.WriteLine("Weapon of room: " + room.Weapon);
                Console.WriteLine("—");
            }
        }

    }
}

