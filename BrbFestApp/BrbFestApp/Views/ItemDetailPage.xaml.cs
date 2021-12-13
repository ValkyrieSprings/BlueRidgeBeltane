using BrbFestApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BrbFestApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}