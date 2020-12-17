using System;
using System.Collections.Generic;
using SparkasseClone.ViewModels;
using SparkasseClone.Views;
using Xamarin.Forms;

namespace SparkasseClone
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
