﻿using DELEITE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DELEITE.Views.bd
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class menup : ContentPage
	{
		public menup ()
		{
			InitializeComponent ();
            BindingContext = new MainPageVM();
        }
	}
}