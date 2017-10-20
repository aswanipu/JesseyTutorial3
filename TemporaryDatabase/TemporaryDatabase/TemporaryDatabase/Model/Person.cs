using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemporaryDatabase.Data;

namespace TemporaryDatabase.Model
{
    public class Person
    {
       
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public static List<Person> People = new List<Person>();
    }
}
