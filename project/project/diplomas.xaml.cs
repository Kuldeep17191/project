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
	public partial class diplomas : ContentPage
	{
		public diplomas ()
		{
			InitializeComponent ();
		}
        private async void dip51_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip51());
        }
        private async void dip52_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip52());
        }
        private async void dip61_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip61());
        }
        private async void dip62_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip62());
        }
        private async void dip71_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip71());
        }
        private async void dip72_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip72());
        }
        private async void dip73_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip73());
        }
        private async void dip74_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip74());
        }
        private async void dip75_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new dip75());
        }

    }
}