using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DELEITE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void Menu_Clicked(object sender, EventArgs e)
        {
            App.Mast.IsPresented = false;
            await App.Mast.Detail.Navigation.PushAsync(new MenuPage());
        }

        private async void buy_Clicked(object sender, EventArgs e)
        {
            App.Mast.IsPresented = false;
            await App.Mast.Detail.Navigation.PushAsync(new Buy());
        }

        private async void bills_Clicked(object sender, EventArgs e)
        {
            App.Mast.IsPresented = false;
            await App.Mast.Detail.Navigation.PushAsync(new BillisPage());
        }

        private async  void offers_Clicked(object sender, EventArgs e)
        {
            App.Mast.IsPresented = false;
            await App.Mast.Detail.Navigation.PushAsync(new OffersPage());
        }

        private async void us_Clicked(object sender, EventArgs e)
        {
            App.Mast.IsPresented = false;
            await App.Mast.Detail.Navigation.PushAsync(new UsPage());
        }
    }
}