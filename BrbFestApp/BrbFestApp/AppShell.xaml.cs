using BrbFestApp.ViewModels;
using BrbFestApp.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BrbFestApp.Data;
using Xamarin.Forms;

namespace BrbFestApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await 
                Task.Run(() => Utils.GetRemoteDataAsync());;
        }

    }
}
