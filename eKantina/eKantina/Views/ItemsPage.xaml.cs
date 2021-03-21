using eKantina.Models;
using eKantina.ViewModels;
using eKantina.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKantina.Views
{
    public partial class ItemsPage : ContentPage
    {

        public ItemsPage()
        {
            InitializeComponent();
            OnAppearing();
        }

        protected override void OnAppearing()
        {
            
            base.OnAppearing();
            int i = 0;
            double height = DeviceDisplay.MainDisplayInfo.Height;
            Label[] label = new Label[10];
            Image[] images = new Image[10];
            StackLayout article = new StackLayout { VerticalOptions = LayoutOptions.StartAndExpand,Orientation=StackOrientation.Horizontal };
            Grid grid = new Grid
            {
                VerticalOptions=LayoutOptions.StartAndExpand
            };
            StackLayout pageContent = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            StackLayout gumb = new StackLayout
            {
                VerticalOptions = LayoutOptions.End,
                Padding = height/480
            };
            Button button = new Button
            {
                VerticalOptions = LayoutOptions.End,
                Padding = height/480,
                Text = "Potvrdi narudžbu"
            };
            /*Label label = new Label
            {
                TextColor = Color.Black,
                FontSize = 15,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Start
            };
            Image image = new Image
            {
                Aspect = Aspect.AspectFit,
                HeightRequest = 80,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start
            };*/

            if (App.articleName[0] == "0")
            {
                label[0] = new Label
                { 
                    Text = "Niste odabrali niti jedan artikl!",
                    TextColor = Color.Black,
                    FontSize = 20,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Start,
                    HeightRequest=height/30
                };
                pageContent.Children.Add(label[0]);
                i = 1;
            }
            if (i == 0)
            {
                for (i = 0; i < 7; i++)
                {
                    if (App.articleName[i] != "0")
                    {
                        label[i] = new Label
                        {
                            Text = App.articleName[i],
                            TextColor = Color.Black,
                            FontSize = 15,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.Start
                        };
                        images[i] = new Image
                        {
                            Source = App.articlePicture[i],
                            Aspect = Aspect.AspectFit,
                            HeightRequest = height / 30,
                            HorizontalOptions = LayoutOptions.Start,
                            VerticalOptions = LayoutOptions.Start
                        };
                        article.Children.Add(images[i]);
                        article.Children.Add(label[i]);
                        /*grid.Children.Add(new StackLayout
                        {
                            VerticalOptions = LayoutOptions.Start,
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                images[i],
                                label[i]
                            }
                        }, 0, i);*/
                        pageContent.Children.Add(new StackLayout
                        {
                            VerticalOptions = LayoutOptions.StartAndExpand,
                            Margin = new Thickness(0, height/ 342.857142857, 0, 0),
                            Orientation = StackOrientation.Horizontal,

                            Children =
                        {
                            images[i],
                            label[i]
                        }
                        });

                    }
                    else
                    {
                        pageContent.Children.Add(new StackLayout
                        {
                            Margin = new Thickness(0, height/ 342.857142857, 0, 0),
                            VerticalOptions = LayoutOptions.StartAndExpand,
                            HeightRequest = height / 30
                        });
                    }
                }
            }
            else
            {
                for (i = 0; i < 6; i++)
                {
                    pageContent.Children.Add(new StackLayout
                    {
                        Margin = new Thickness(0, height/ 342.857142857, 0, 0),
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HeightRequest = height / 30
                    });
                }
            }
            /*grid.Children.Add(new StackLayout
            {
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                WidthRequest =(double) GridUnitType.Auto,
                Padding = 5,
                Children =
                        {
                            button
                        }
            }, 0, j); */
            gumb.Children.Add(button);
            pageContent.Children.Add(gumb);
            Content = pageContent;
        }
    }
}