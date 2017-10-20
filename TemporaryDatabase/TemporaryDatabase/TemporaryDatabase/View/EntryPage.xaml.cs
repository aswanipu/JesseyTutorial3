using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemporaryDatabase.Data;
using TemporaryDatabase.Model;
using TemporaryDatabase.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TemporaryDatabase.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        private List<Person> people = new List<Person>();
        private static int ids=0;
        public EntryPage()
        {
            InitializeComponent();
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           var  person = new Person();
            person.ID = ids++;
            person.FirstName = FirstNameEntry.Text;
            person.LastName = LastNameEntry.Text;
            person.PhoneNumber = PhoneNumberEntry.Text;
            FirstNameEntry.Text = "";
            LastNameEntry.Text = "";
            PhoneNumberEntry.Text = "";
            
           Person.People.Add(person);
            DependencyService.Get<IFile>().SaveText("temp.txt", person.ID.ToString());



        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntrySuccessPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
           IdValue.Text= DependencyService.Get<IFile>().LoadText("temp.txt");
        }
    }
}