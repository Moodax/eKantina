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
            App.Current.MainPage = new SettingsPage();
            alo.Text="JEBEO MAJKU";
        }
    }
}