using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel("Zirve");
            Room room = new Room("Otag-1", 50, 2);
            Room room1 = new Room("Otag-2", 40, 1);
            
            hotel.AddRoom(room);
            hotel.AddRoom(room1);
            foreach (var item in hotel.GetRooms())
            {
                Console.WriteLine(item.ToString());
            }

            foreach (var item in hotel.GetRooms())
            {
                hotel.MakeReservation(1);
            }
        }
    }
}
