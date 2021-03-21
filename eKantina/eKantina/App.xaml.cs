using Android.Content.Res;
using eKantina.Services;
using eKantina.Views;
using System;
using System.IO;
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
        
        public static string gumb { get; set; }
        public static string ime { get; set; }
        protected override void OnStart()
        {
            Application.Current.UserAppTheme = OSAppTheme.Light;
            for(int i=0;i<10;i++)
            {
                articleName[i] = "0";
                articlePicture[i] = "0";
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        public static string[] articleName = new string[10];

        public static string[] articlePicture = new string[10];

    }
   
        
        
}
