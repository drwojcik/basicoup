﻿using basicoup.Models;
using basicoup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace basicoup.ViewModels
{
    public sealed class  HomeViewModel : BaseViewModel
    {
        private readonly IItemService itemService;

        private ObservableCollection<Item> items = new ObservableCollection<Item>();
        public HomeViewModel()
        {
            itemService = new ItemService();
            
        }
        public ObservableCollection<Item> Items
        {
            get => items;
            set { items = value; OnPropertyChanged(); }
        }

        public override async Task Initialize()
        {
            
            await ExecuteBusyAction(async () =>
            {
                var itemCollection = await itemService.GetAll();
                Items.Clear();
                foreach (var item in itemCollection)
                    Items.Add(item);
            });


            
        }
    }
}