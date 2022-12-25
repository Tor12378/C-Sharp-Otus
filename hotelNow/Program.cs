
using System.Security.Principal;

namespace hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var h = new Hotel();
            while (!exit)
            {
              
                Console.WriteLine("1. Заселить,Забронировать");
                Console.WriteLine("2. Показать прибыль");
                Console.WriteLine("3. Выйти");
                var k = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (k)
                {
                  
                    case 1:
                        {
                            var date = Hotel.CreatedataStart();
                            var dateleave = Hotel.Createdata();
                            Console.WriteLine("Выберите id номера из свободных");
                            var rooms = Hotel.CheckingAvailableRooms(date,dateleave);
                            Hotel.ShowRooms(rooms);
                            var id = int.Parse(Console.ReadLine());
                            var name = Hotel.CreateNameClient();
                            var kolPos = Hotel.CheckKlient(name);
                            var client = Hotel.CheckKlientInList(name);
                            
                            var notis = "";
                            if (kolPos > 5)
                            {
                                notis = "Скидка";
                            }
                            else
                            {
                                Console.WriteLine("Оставьте примечание");
                                notis = Console.ReadLine();
                            }
                            Hotel.listOfSettlement.Add(new Settlement(client, Hotel.listOfRooms[id],date, dateleave,notis));
                            break;
                        }
                    case 2:
                        {
                            var date = Hotel.CreatedataStart();
                            var dateleave = Hotel.Createdata();
                            Console.WriteLine(Hotel.Pribal(date, dateleave));
                            break;
                        }
                    case 3:
                        {
                            exit = true;
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}