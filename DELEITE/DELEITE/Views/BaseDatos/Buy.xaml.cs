using DELEITE.Models;
using DELEITE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DELEITE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buy : ContentPage
    {
        buyvm buyvm;
        Models.Item Items;
        public Buy()
        {
            InitializeComponent();
            BindingContext = buyvm = new buyvm();
            BindingContext = Items = new Models.Item();
            
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            loaditems();
        }
        private async void loaditems()
        {
            Itemspc.ItemsSource = await Items.Getitems();
        }

        private async void BtnApply_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}