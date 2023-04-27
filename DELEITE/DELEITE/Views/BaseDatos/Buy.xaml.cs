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
        ItemVM itemVM;
        ToppingVM topi;
        
        public Buy()
        {
            InitializeComponent();
            BindingContext = topi= new ToppingVM();
            BindingContext = itemVM = new ItemVM();
            loadlist();
             
             
           
        }
        private async void loadlist()
        {
            s.ItemsSource = await topi.gettop();
        }
        






    }
}