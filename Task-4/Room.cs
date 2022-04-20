using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    internal class Room
    {
        public int Id;
        public static int count = 1;
        public string Name { get; set; }
        private int _price;
        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public int PersonCapacity { get; set; }
        public bool IsAvailable = false;
        public Room(string name, int price, int personcapacity)
        {
            Id = count;
            count++;
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
        }

        public string Showinfo()
        {
            return $" ID:{Id} Name:{Name} Price:{Price} PersonCapacity:{PersonCapacity} IsAvailable:{IsAvailable}";
        }
        public override string ToString()
        {
            return Showinfo();
        }

    }
}
