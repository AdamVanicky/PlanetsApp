using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PlanetsApp.View;

namespace PlanetsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OurPlanetsPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
