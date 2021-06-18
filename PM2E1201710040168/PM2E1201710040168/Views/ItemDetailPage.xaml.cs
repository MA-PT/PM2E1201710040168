using PM2E1201710040168.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PM2E1201710040168.Views
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