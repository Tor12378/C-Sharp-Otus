using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public  class Hotel
    {
        public static List<Client> listOfClients =new List<Client>()
        {
            new Client("Тупаев","Тимур","Алексеевич","123456","-"),
            new Client("Блинников","Артем","Игоревич","98765","-"),
            new Client("Иванов","Максим","Петрович","847253","-"),
            new Client("Петров","Альфред","Генадьевич","8998442","-"),
        };
        public static List<Rooms> listOfRooms = new List<Rooms>()
        {
            new Rooms(3,1,1500),
            new Rooms(2,2,2500),
            new Rooms(1,4,6000),
            new Rooms(5,0,3000),
        };
        public static List<Settlement> listOfSettlement = new List<Settlement>();
        public static   List<Rooms> CheckingAvailableRooms(DateOnly start,DateOnly end)
        {
            List<Rooms> Rooms = new List<Rooms>();
            foreach (var room in listOfRooms)
            {
                bool svobodie = true;
                foreach (var s in listOfSettlement)
                {
                    if (s.room == room )
                    {
                        if((start<=s.dateOfSettlement) && (end>=s.dateOfRelease)||
                            (start >= s.dateOfSettlement&& start <= s.dateOfRelease) && (end >= s.dateOfRelease)|| 
                            (start >= s.dateOfSettlement && start <= s.dateOfRelease) && (end >= s.dateOfSettlement && end <= s.dateOfRelease))
                        {
                            svobodie = false;
                            break;
                        }
                    }
                }
                if(svobodie)
                {
                    Rooms.Add(room);
                }
            }
            return Rooms;
        }
        public static int CheckKlient(string[] FIO)
        {
            var kol = 0;
            foreach(var client in listOfClients)
            {
                if (client.name == FIO[1]&& client.stringpatronymic == FIO[2] && client.surname == FIO[0])
                {
                    kol++;
                }
            }
            return kol;
        }
        public static Client CheckKlientInList(string[] FIO)
        {
            foreach (var client in listOfClients)
            {
                if (client.name == FIO[1] && client.stringpatronymic == FIO[2] && client.surname == FIO[0])
                {
                    return client;
                }
            }
            Console.WriteLine("Введите данные паспорта");
            var pasport =Console.ReadLine();
            Console.WriteLine("Введите примечание");
            var notis = Console.ReadLine();
            var cl= new Client(FIO[0], FIO[1], FIO[2], pasport, notis);
            listOfClients.Add(cl);
            return cl;

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
        public static DateOnly CreatedataStart()
        {
            Console.WriteLine("Введите дату въезда в формате день.месяц.год");
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
        public static double Pribal(DateOnly st,DateOnly end)
        {
            double res = 0;
            foreach(var l in listOfSettlement)
            {
                if(l.dateOfSettlement<=end && l.dateOfSettlement >= st)
                {
                    if (l.note == "Скидка")
                        res += (l.dateOfRelease.DayNumber - l.dateOfSettlement.DayNumber) * 0.95 * l.room.prise;
                    else
                        res += (l.dateOfRelease.DayNumber - l.dateOfSettlement.DayNumber) * l.room.prise;
                }
            }
            return res;
        }

    }
}
