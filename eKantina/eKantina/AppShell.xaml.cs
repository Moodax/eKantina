using eKantina.ViewModels;
using eKantina.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace eKantina
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SettingsPage),typeof(SettingsPage));
        }

    }
}
