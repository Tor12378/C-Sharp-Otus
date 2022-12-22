
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
                Console.WriteLine("1. Показать свободные номера на данный момент");
                Console.WriteLine("2. Заселить");
                Console.WriteLine("3. Выйти");
                var k = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (k)
                {
                    case 1:
                        {
                            var rooms = Hotel.CheckingAvailableRooms();
                            Hotel.ShowRooms(rooms);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Выберите id номера из свободных");
                            var rooms = Hotel.CheckingAvailableRooms();
                            Hotel.ShowRooms(rooms);
                            var id = int.Parse(Console.ReadLine());
                            var date= Hotel.Createdata();
                            var name = Hotel.CreateNameClient();
                            Console.WriteLine("Оставьте примечание");
                            var notis=Console.ReadLine();
                            DateOnly now = new DateOnly(2022, 12, 22);
                            Hotel.listOfSettlement.Add(new Settlement(new Client(name[0], name[1], name[2], "1231432", "Норм чел"), Hotel.listOfRooms[id],now, date,"Принести приборы"));

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