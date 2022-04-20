using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms = new Room[0];

        public Hotel(string name)
        {
            Name = name;
        }
        public Room[] GetRooms()
        {
            return Rooms;
        }

        public void AddRoom(Room roomId)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = roomId;
        }
        public void MakeReservation(int roomId)
        {

            foreach (var item in Rooms)
            {
                if (roomId == item.Id)
                {
                    if (item.IsAvailable == false)
                    {
                        Console.WriteLine("Room is Full!");
                    }
                    else
                    {
                        item.IsAvailable = false;
                    }
                }
            }

        }

    }
}
