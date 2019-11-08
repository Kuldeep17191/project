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
	public partial class degree : ContentPage
	{
		public degree ()
		{
			InitializeComponent ();
		}
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void deglevel5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deglevel5());
        }

        private async void deglevel6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deglevel6());
        }

        private async void deglevel7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deglevel7());
        }

        private async void requirement_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Reqirements", "1.IELTS Academic score with overall 6 not less than 5 bands.\n 2.Secondary Education with 60% in any stream with Computer Subject.\n3.Standard Entry Criteria- By Interview.", "ok");
        }

    }
}