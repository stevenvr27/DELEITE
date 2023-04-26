using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace DELEITE.Views.MenuPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class whats : ContentPage
	{
		public whats ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtmensaje.Text))
                {
                    string CodigoPaisCelular;
                    CodigoPaisCelular = "+50686053345";
                    Chat.Open(CodigoPaisCelular, txtmensaje.Text);

                }
            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

    }
}