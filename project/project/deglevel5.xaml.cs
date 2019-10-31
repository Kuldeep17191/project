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
	public partial class deglevel5 : ContentPage
	{
		public deglevel5 ()
		{
			InitializeComponent ();
		}
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deglevel6());
        }
        private async void deg51_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deg5elective());
        }
        private async void deg52_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deg5elective());
        }
        private async void deg53_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deg5elective());
        }
        private async void deg54_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deg5elective());
        }
               
    }
}