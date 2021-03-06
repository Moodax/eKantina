using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKantina.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slatkisi : ContentPage
    {
        public Slatkisi()
        {
            InitializeComponent();
            double height = DeviceDisplay.MainDisplayInfo.Height;
            StackLayout stack = new StackLayout
            {
            };
            StackLayout Article = new StackLayout
            {

            };
            Image image = new Image
            {
                HeightRequest = height / 7.5,
                Source = "doublejoy.png",
                Aspect = Aspect.AspectFit
            };
            Label label = new Label
            {
                Text = "Double Joy",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                Margin = 0,
                TextColor=Color.Black
            };
            Article.Children.Add(image);
            Article.Children.Add(label);
            stack.Children.Add(Article);

            StackLayout Article1 = new StackLayout
            {

            };
            Image image1 = new Image
            {
                HeightRequest = height / 7.5,
                Source = "leo.png",
                Aspect = Aspect.AspectFit
            };
            Label label1 = new Label
            {
                Text = "Leo",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                Margin = 0,
                TextColor = Color.Black
            };
            Article1.Children.Add(image1);
            Article1.Children.Add(label1);
            stack.Children.Add(Article1);

            StackLayout Article2 = new StackLayout
            {

            };
            Image image2 = new Image
            {
                HeightRequest = height / 7.5,
                Source = "milka.png",
                Aspect = Aspect.AspectFit
            };
            Label label2 = new Label
            {
                TextColor = Color.Black,
                Text = "Milka",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                Margin = 0
            };
            Article2.Children.Add(image2);
            Article2.Children.Add(label2);
            stack.Children.Add(Article2);

            StackLayout Article3 = new StackLayout
            {

            };
            Image image3 = new Image
            {
                HeightRequest = height / 7.5,
                Source = "jafa.png",
                Aspect = Aspect.AspectFit
            };
            Label label3 = new Label
            {
                TextColor = Color.Black,
                Text = "Jafa kekse",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                Margin = 0
            };
            Article3.Children.Add(image3);
            Article3.Children.Add(label3);
            stack.Children.Add(Article3);

            StackLayout Article4 = new StackLayout
            {

            };
            Image image4 = new Image
            {
                HeightRequest = height / 7.5,
                Source = "zvake.png",
                Aspect = Aspect.AspectFit
            };
            Label label4 = new Label
            {
                TextColor = Color.Black,
                Text = "Extra kaugume",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                Margin = 0
            };
            Article4.Children.Add(image4);
            Article4.Children.Add(label4);
            stack.Children.Add(Article4);

            StackLayout Article5 = new StackLayout
            {

            };
            Image image5 = new Image
            {
                HeightRequest = height / 7.5,
                Source = "snickers.png",
                Aspect = Aspect.AspectFit
            };
            Label label5 = new Label
            {
                TextColor = Color.Black,
                Text = "Snickers",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                Margin = 0
            };
            Article5.Children.Add(image5);
            Article5.Children.Add(label5);
            stack.Children.Add(Article5);

            StackLayout Article6 = new StackLayout
            {

            };
            Image image6 = new Image
            {
                HeightRequest = height / 7.5,
                Source = "twix.png",
                Aspect = Aspect.AspectFit
            };
            Label label6 = new Label
            {
                TextColor = Color.Black,
                Text = "Twix",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                Margin = 0
            };
            Article6.Children.Add(image6);
            Article6.Children.Add(label6);
            stack.Children.Add(Article6);

            StackLayout Article7 = new StackLayout
            {

            };
            Image image7 = new Image
            {
                HeightRequest = height / 7.5,
                Source = "mikic.png",
                Aspect = Aspect.AspectFit
            };
            Label label7 = new Label
            {
                TextColor = Color.Black,
                Text = "Lizalica",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                Margin = 0
            };
            Article7.Children.Add(image7);
            Article7.Children.Add(label7);
            stack.Children.Add(Article7);

            var touch = new TapGestureRecognizer();
            touch.Tapped += (s, e) =>
            {
                App.price = 12;
                App.ime = "Double Joy";
                App.gumb = "doublejoy";
                Shell.Current.GoToAsync("Artikl");
            };
            Article.GestureRecognizers.Add(touch);

            var touch1 = new TapGestureRecognizer();
            touch1.Tapped += (s, e) =>
            {
                App.price = 12;
                App.ime = "Leo";
                App.gumb = "leo";
                Shell.Current.GoToAsync("Artikl");
            };
            Article1.GestureRecognizers.Add(touch1);

            var touch2 = new TapGestureRecognizer();
            touch2.Tapped += (s, e) =>
            {
                App.price = 12;
                App.ime = "Milka";
                App.gumb = "milka";
                Shell.Current.GoToAsync("Artikl");
            };
            Article2.GestureRecognizers.Add(touch2);

            var touch3 = new TapGestureRecognizer();
            touch3.Tapped += (s, e) =>
            {
                App.price = 12;
                App.ime = "Jafa kekse";
                App.gumb = "jafa";
                Shell.Current.GoToAsync("Artikl");
            };
            Article3.GestureRecognizers.Add(touch3);

            var touch4 = new TapGestureRecognizer();
            touch4.Tapped += (s, e) =>
            {
                App.price = 12;
                App.ime = "Extra kaugume";
                App.gumb = "zvake";
                Shell.Current.GoToAsync("Artikl");
            };
            Article4.GestureRecognizers.Add(touch4);

            var touch5 = new TapGestureRecognizer();
            touch5.Tapped += (s, e) =>
            {
                App.price = 12;
                App.ime = "Snickers";
                App.gumb = "snickers";
                Shell.Current.GoToAsync("Artikl");
            };
            Article5.GestureRecognizers.Add(touch5);

            var touch6 = new TapGestureRecognizer();
            touch6.Tapped += (s, e) =>
            {
                App.price = 12;
                App.ime = "Twix";
                App.gumb = "twix";
                Shell.Current.GoToAsync("Artikl");
            };
            Article6.GestureRecognizers.Add(touch6);

            var touch7 = new TapGestureRecognizer();
            touch7.Tapped += (s, e) =>
            {
                App.price = 12;
                App.ime = "Lizalica";
                App.gumb = "mikic";
                Shell.Current.GoToAsync("Artikl");

            };
            Article7.GestureRecognizers.Add(touch7);



            ScrollView scrollView = new ScrollView
            {
                Content = stack
            };
            Content = scrollView;
        }
    }
}