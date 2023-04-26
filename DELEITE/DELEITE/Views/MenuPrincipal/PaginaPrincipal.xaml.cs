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

namespace DELEITE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();
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
    }
}