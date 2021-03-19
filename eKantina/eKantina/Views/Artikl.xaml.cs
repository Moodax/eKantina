
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(App.gumb==1)
            {
                var layout = new StackLayout {  };
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "a.txt");

                Image image = new Image
                {
                    Source = "SendvicSunkaSir.png"
                };
                Label label = new Label
                {
                    Text = File.ReadAllText(fileName)
                    //Text= File.ReadAllText(fileName)
                };
                layout.Children.Add(image);
                layout.Children.Add(label);
                this.Content = layout;
                //File.WriteAllText(fileName, "ajmebreeeeee");
            }
        }
    }
}