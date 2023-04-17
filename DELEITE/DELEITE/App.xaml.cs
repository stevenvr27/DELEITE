using System;
using Xamarin.Forms;
using DELEITE.Views;
using Xamarin.Forms.Xaml;

namespace DELEITE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new DeleiteLoginPage());
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
