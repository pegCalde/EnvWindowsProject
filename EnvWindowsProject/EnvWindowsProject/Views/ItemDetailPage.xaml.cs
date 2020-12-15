using EnvWindowsProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EnvWindowsProject.Views
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