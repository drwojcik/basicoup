﻿using basicoup.Models;
using basicoup.View;
using basicoup.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace basicoup.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private HomeViewModel ViewModel;
        public HomePage()
        {
            InitializeComponent();

            ViewModel = new HomeViewModel();
            BindingContext = ViewModel;
        }

        protected override async void OnAppearing()
        {
            await ViewModel.Initialize();

        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var movie = e.Item as Movie;
            await Navigation.PushAsync(new DetailPage(movie));
        }
    }
}