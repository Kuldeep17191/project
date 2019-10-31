using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class deglevel6 : ContentPage
	{
		public deglevel6 ()
		{
			InitializeComponent ();
		}
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deglevel7());

        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void deg61_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level6elective());
        }
        private async void deg62_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level6elective());
        }
        private async void deg63_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level6elective());
        }
        private async void deg64_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level6elective());
        }
        private async void deg65_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level6elective());
        }
        private async void deg66_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level6elective());
        }
        private async void deg67_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level6elective());
        }
        private async void deg68_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level6elective());
        }



    }
}