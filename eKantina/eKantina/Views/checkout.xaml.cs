using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKantina.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class checkout : ContentPage
    {
        public checkout()
        {
            double cijena = 0;
            InitializeComponent();
            for(int i=0;i<7;i++)
            {
                cijena += App.articlePrice[i];
            }
            StackLayout stack = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
        };
            Label label = new Label
            {
                Text = "Hvala na narudžbi!\nCijena Vaše narudžbe iznosi " + cijena.ToString() + " kuna.",
                FontAttributes = FontAttributes.Bold,
                FontSize = 30,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center
            };
            stack.Children.Add(label);
            Content = stack;
        }
    }
}