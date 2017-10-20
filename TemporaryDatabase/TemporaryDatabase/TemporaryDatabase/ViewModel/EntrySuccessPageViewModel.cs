using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemporaryDatabase.Model;

namespace TemporaryDatabase.ViewModel
{
    class EntrySuccessPageViewModel
    {
       
        public ObservableCollection<Person> People { get; set; } =
              new ObservableCollection<Person>();
        public bool IsEnabled { get; set; }
        public EntrySuccessPageViewModel()
        {
           // Person person = new Person();
           // person.FirstName = "Aswani";
           // person.LastName = "Unni";
           // person.PhoneNumber = "452-785";

           // People.Add(person);
            foreach (Person p in Person.People)
            {
                People.Add(p);
                IsEnabled = true;
               
            }
        }
       
    }
}
