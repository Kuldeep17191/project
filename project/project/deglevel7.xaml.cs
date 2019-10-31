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
	public partial class deglevel7 : ContentPage
	{
		public deglevel7 ()
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
        private async void deg71_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level7elective());
        }
        private async void deg72_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level7elective());
        }
        private async void deg73_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level7elective());
        }
        private async void deg74_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level7elective());
        }
        private async void deg75_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new level7elective());
        }


    }
}