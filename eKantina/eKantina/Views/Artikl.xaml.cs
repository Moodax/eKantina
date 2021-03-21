
using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKantina.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Artikl : ContentPage
    {
        public Artikl()
        {
            InitializeComponent();
            double height = DeviceDisplay.MainDisplayInfo.Height;
            string ReadFromFile(string fileName)
            {
                string text;
                AssetManager assets = Android.App.Application.Context.Assets;
                using (StreamReader reader = new StreamReader(assets.Open(fileName)))
                {
                    text = reader.ReadToEnd();
                }
                return text;
            }
            void PageBuilder(string fileSource,string pictureSource)
            {
                bool wrote = false;
                var artikl = new StackLayout { VerticalOptions = LayoutOptions.StartAndExpand };
                var button = new StackLayout
                {
                    Padding = 5,
                    VerticalOptions = LayoutOptions.End
                };

                //string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "a.txt");
                string text = ReadFromFile(fileSource);
                Image image = new Image
                {
                    Source = pictureSource,
                    HeightRequest=height/7

                };
                Label name = new Label
                {
                    Text = App.ime,
                    HorizontalTextAlignment = TextAlignment.Center,
                    TextColor=Color.Black,
                    FontAttributes=FontAttributes.Bold,
                    FontSize=25

                };
                Label label = new Label
                {
                    Text = text
                    //Text= File.ReadAllText(fileName)
                };
                
                Button AddToCart = new Button
                {
                    Text = "Dodaj u narudžbu"
                };
               
                artikl.Children.Add(image);
                artikl.Children.Add(name);
                artikl.Children.Add(label);
                button.Children.Add(AddToCart);
                StackLayout PageContent = new StackLayout
                {
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children =
                    {
                        artikl,
                        button
                    }
                };
                AddToCart.Clicked += (sender, args) =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (App.articleName[i] == "0" && wrote==false)
                        {
                            App.articleName[i] = App.ime;
                            App.articlePicture[i] = pictureSource;
                            wrote = true;
                            
                        }
                    }
                    wrote = false;
                };
                Content = PageContent;
            }
                PageBuilder(App.gumb+".txt", App.gumb +".png");
        }
    }
}