using System.ComponentModel;
using Xamarin.Forms;
using SparkasseClone.ViewModels;

namespace SparkasseClone.Views
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