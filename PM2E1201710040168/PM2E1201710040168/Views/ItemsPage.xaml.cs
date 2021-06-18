using PM2E1201710040168.Models;
using PM2E1201710040168.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PM2E1201710040168.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;
        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var LstUbicaciones = await App.SQLiteDB.GetUbicationAsync();
            if (LstUbicaciones != null)
            {
                lstUbicaciones.ItemsSource = LstUbicaciones;
            }
        }

        private async void lstUbicaciones_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            bool answer = await DisplayAlert("Alerta", "¿Desea ir a la Ubicación Seleccionada?", "Si", "No");
            if (answer)
            {
                var objeto = e.Item as Ubicacion;
                var map = new MapView();
                map.BindingContext = new { Position = new Position(objeto.Lat,objeto.Lon), objeto.Descc, objeto.Descl};
                await Navigation.PushAsync(new MapView());
                 
            }
        }
    }
}