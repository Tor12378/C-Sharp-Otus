using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Settlement
    {
        private Client client;
        public Rooms room;
        public DateOnly dateOfSettlement;
        public DateOnly dateOfRelease;
        public string note;

        public Settlement(Client client, Rooms room, DateOnly dateOfSettlement, DateOnly dateOfRelease, string note)
        {
            this.client = client;
            this.room = room;
            this.dateOfSettlement = dateOfSettlement;
            this.dateOfRelease = dateOfRelease;
            this.note = note;
        }
    }
}
