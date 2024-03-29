﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Certificate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new certificate());
        }
        private async void diploma_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new diplomas());
        }

        private async void degree_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new degree());
        }

    }
}
