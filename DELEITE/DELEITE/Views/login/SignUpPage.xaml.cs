using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DELEITE.ViewModels;
using DELEITE.Models;

namespace DELEITE.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{

        UserViewModel viewModel;
        public SignUpPage ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new UserViewModel();
        }

        private async void BtnApply_Clicked(object sender, EventArgs e)
        {
            bool R = await viewModel.AddUser(TxtEmail.Text.Trim(),
                                             TxtName.Text.Trim(),
                                             TxtPassword.Text.Trim(),
                                              TxtCardID.Text.Trim(),
                                             TxtPhone.Text.Trim(),
                                             TxtAddress.Text.Trim());

            if (R)
            {
                await DisplayAlert(":)", "User added ok!!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert(":(", "Something went wrong", "OK");
            }


        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}