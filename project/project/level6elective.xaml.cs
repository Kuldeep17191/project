using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class level6elective : ContentPage
	{
		public level6elective ()
		{
			InitializeComponent ();
		}
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        //private async void sub1_Clicked(object sender, EventArgs e)
        //{
        //    label1.TextColor = Color.Blue;
        //}


    }
}