using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemporaryDatabase.Model;
using TemporaryDatabase.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TemporaryDatabase.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntrySuccessPage : ContentPage
    {
        public ObservableCollection<Person> People { get; set; } =
         new ObservableCollection<Person>();
        public EntrySuccessPage()
        {
            InitializeComponent();
            EntrySuccessPageViewModel v = new EntrySuccessPageViewModel();
            BindingContext = v;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());
        }
        

    }
}