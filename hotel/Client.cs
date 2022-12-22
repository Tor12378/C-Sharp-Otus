using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Client
    {
        private string surname { get; set; }
        public string name { get; set; }
        private string stringpatronymic{ get; set; }
        private string pasport { get; set; }
        private string comments { get; set; }
        public Client(string surname, string name, string stringpatronymic, string pasport, string comments)
        {
            this.surname = surname;
            this.name = name;
            this.stringpatronymic = stringpatronymic;
            this.pasport = pasport;
            this.comments = comments;
        }
    }
}
