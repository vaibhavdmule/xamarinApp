﻿
using Autofac;
using Xamarin.Forms;

namespace Cryptollet.Modules.AddTransaction
{
    public partial class AddAssetView : ContentPage
    {
        public AddAssetView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<AddTransactionViewModel>();
        }
    }
}