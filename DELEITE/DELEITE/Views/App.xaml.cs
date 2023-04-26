using System;
using Xamarin.Forms;
using DELEITE.Views;
using Xamarin.Forms.Xaml;
using DELEITE.Views.bd;

namespace DELEITE
{
    public partial class App : Application
    {
        public static MasterDetailPage Mast {get;set;}
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new Detail());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
