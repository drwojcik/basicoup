using basicoup.ViewModels;
using basicoup.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace basicoup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            var homepage = new HomePage();
            MainPage = new NavigationPage(homepage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
