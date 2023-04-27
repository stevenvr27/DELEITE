using DELEITE.Views.MenuPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.OpenWhatsApp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DELEITE.Views.bd;
using DELEITE.ViewModels;
using Xamarin.Essentials;

namespace DELEITE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : ContentPage
    {
      
        public PaginaPrincipal()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            ///
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new whats());

        }

        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UsPage());
        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {

        }

        private async void Menu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new menup());
        }

        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {

        }

        private async void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new socialmedia());
        }

        private void Billing_Clicked(object sender, EventArgs e)
        {

        }

        private async void menu_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Buy());
        }

        private async void  ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Buy());
        }

        private async void ImageButton_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Buy());
        }

        private  async void ImageButton_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BillisPage());
        }

        private async void ImageButton_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OffersPage());
        }

        private  async void ImageButton_Clicked_10(object sender, EventArgs e)
        {
            await Launcher.TryOpenAsync("https://www.instagram.com/deleite_cr/");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new menup());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Buy());
        }

        private async void ImageButton_Clicked_11(object sender, EventArgs e)
        {
            await Launcher.TryOpenAsync("https://www.instagram.com/deleite_cr/");
        }

        private async void ImageButton_Clicked_12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UsPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Buy());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OffersPage());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new whats());
        }
    }
}