using eKantina.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eKantina.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}