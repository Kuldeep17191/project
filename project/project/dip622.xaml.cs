﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class dip622 : ContentPage
	{
		public dip622 ()
		{
			InitializeComponent ();
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

       
    }
}