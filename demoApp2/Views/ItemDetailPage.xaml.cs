using demoApp2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace demoApp2.Views
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