using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemporaryDatabase.Model;

namespace TemporaryDatabase.ViewModel
{
    class EntryPageViewModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ObservableCollection<Person> People { get; set; } =
         new ObservableCollection<Person>();
        public EntryPageViewModel()
        {
            Person person = new Person();
            person.FirstName = "Aswani";
            person.LastName = "P U";
            person.PhoneNumber = "45236";
            People.Add(person);

        }
        public void AddToPeople()
        {
            Person person = new Person();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.PhoneNumber = PhoneNumber;
            Person.People.Add(person);
        }
       
    }

}

