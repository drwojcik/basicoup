using basicoup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace basicoup.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        //private Item ViewModel;
        public DetailPage( Item gangMember)
        {
            InitializeComponent();
            BindingContext = gangMember;
        }
    }
}