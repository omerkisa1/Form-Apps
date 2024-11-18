using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation1
{
    class Program
    {
        class Home
        {
            public string Name { get; set; }
            public List<Room> Rooms { get; set; }

            public Home(string name)
            {
                Name = name;
                Rooms = new List<Room>();
            }
            public void addRoom(Room room)
            {
                Rooms.Add(room);
            }
        }

        class Room
        {
            public string area { get; set; }
            public string type { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
