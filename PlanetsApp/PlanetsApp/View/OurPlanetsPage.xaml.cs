using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using PlanetsApp.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlanetsApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OurPlanetsPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public OurPlanetsPage()
        {
            InitializeComponent();
            OurPlanets oP = new OurPlanets();
            BindingContext = oP;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Page p = new PlanetPage((((ListView)sender).SelectedItem) as Planet, (BindingContext as OurPlanets).AllPlanets);
            NavigationPage np = new NavigationPage(p);
            await Application.Current.MainPage.Navigation.PushAsync(np);

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
