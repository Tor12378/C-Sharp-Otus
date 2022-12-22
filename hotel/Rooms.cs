using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Rooms
    {
        enum comfortType
        {
            Эконом,
            Комфорт,
            КомфортПлюс,
            Люкс,
        };
        private static int id=0;
        public  int idRooms;
        private int numberOfPersons;
        private int comfort;
        private double prise;
        public Rooms(int numberOfPersons, int comfort, double prise)
        {
            this.numberOfPersons = numberOfPersons;
            this.comfort = comfort;
            this.prise = prise;
            this.idRooms = id++;

        }
        public override string ToString()
        {
            return $"Кол-во чел {numberOfPersons}, Комфортность {comfort}, цена {prise}, id{idRooms}";
        }
    }
}
