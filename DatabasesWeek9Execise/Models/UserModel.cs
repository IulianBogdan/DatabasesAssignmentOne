using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabasesWeek9Execise.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int PostNr { get; set; }
        public string City { get; set; }
    }
}
