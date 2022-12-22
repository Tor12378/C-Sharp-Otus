using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public  class Hotel
    {
        public static List<Client> listOfClients =new List<Client>();
        public static List<Rooms> listOfRooms = new List<Rooms>()
        {
            new Rooms(3,1,1500),
            new Rooms(2,2,2500),
            new Rooms(1,4,6000),
            new Rooms(5,0,3000),
        };
        public static List<Settlement> listOfSettlement = new List<Settlement>();
        public static   List<Rooms> CheckingAvailableRooms()
        {
            List<Rooms> Rooms = new List<Rooms>();
            foreach (var room in listOfRooms)
            {
                DateOnly ?start = null;
                DateOnly? end = null;
                DateOnly now = new DateOnly(2022,12,22);
                foreach (var s in listOfSettlement)
                {
                    if (s.room == room )
                    {
                        start = s.dateOfSettlement;
                        end = s.dateOfRelease;
                    }
                }
                if(start<= now && end >= now)
                {
                    continue;
                }
                else
                {
                    Rooms.Add(room);
                }
            }
            return Rooms;
        }
        public static void ShowRooms(List<Rooms> rooms)
        {
            foreach(var room in rooms)
            {
                Console.WriteLine(room);
            }
        }
        public static  DateOnly Createdata()
        {
            Console.WriteLine("Введите дату выезда в формате день.месяц.год");
            var s = Console.ReadLine();
            string[] subs = s.Split(".");

            return new DateOnly(int.Parse(subs[2]), int.Parse(subs[1]), int.Parse(subs[0]));
        }
        public static string[] CreateNameClient()
        {
            Console.WriteLine("Введите ФИО клиета");
            var s = Console.ReadLine();
            string[] subs = s.Split(" ");

            return  subs;
        }

    }
}
