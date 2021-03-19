using eKantina.Services;
using eKantina.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKantina
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            
    }
        public static int gumb { get; set; }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
