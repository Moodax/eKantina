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
    public partial class Grickalice : ContentPage
    {
        public int buttonPressed=0;
        public Grickalice()
        {
            InitializeComponent();
        }
       
    }
}