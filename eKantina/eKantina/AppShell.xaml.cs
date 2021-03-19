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
            Routing.RegisterRoute(nameof(Sendvici),typeof(Sendvici));
            Routing.RegisterRoute(nameof(Pice),typeof(Pice));
            Routing.RegisterRoute(nameof(Slatkisi),typeof(Slatkisi));
            Routing.RegisterRoute(nameof(Grickalice), typeof(Grickalice));
            Routing.RegisterRoute(nameof(Artikl), typeof(Artikl));
        }

    }
}
