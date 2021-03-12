using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKantina.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        public void Sendvici(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("Sendvici");
        }
        public void Pice(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("Pice");
        }

        public void Slatkisi(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("Slatkisi");
        }

        public void Grickalice(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("Grickalice");
        }

    }
}