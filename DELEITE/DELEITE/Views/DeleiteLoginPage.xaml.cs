using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DELEITE.Models;
using DELEITE.Views;
using DELEITE.ViewModels;

namespace DELEITE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeleiteLoginPage : ContentPage
    {
        UserViewModel viewModel;
        public DeleiteLoginPage()
        {
            InitializeComponent();
             this.BindingContext= viewModel = new UserViewModel();


        }

        

        private async void BtnSignUp_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new SignUpPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool R = false;

            if ( txtUserName.Text != null && !string.IsNullOrEmpty(txtUserName.Text.Trim()) &&
                txtPassword.Text != null && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                //si hay datos en el usuario y contraseña se puede continuar 
                try
                {
                    UserDialogs.Instance.ShowLoading("Cheking User Access...");
                    await Task.Delay(2000);

                    string email = txtUserName.Text.Trim();
                    string password = txtPassword.Text.Trim();

                    R = await viewModel.UserAccessValidation(email, password);




                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    UserDialogs.Instance.HideLoading();
                }
            }
            else
            {
                await DisplayAlert("Validation Error", "User Email and Password are required!", "OK");
                return;
            }


            if (R)
            {
                await Navigation.PushAsync(new MainPage());

                return;
            }
            else
            {
                await DisplayAlert("Validation Failed", "Access Denied!!", "OK");
                return;
            }

        }


    }

    }
