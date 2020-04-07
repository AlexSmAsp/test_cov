using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_cov.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test_cov.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class covid : ContentPage
    {
        public covid()
        {
            RateViewModel viewModel;
            InitializeComponent();
            ///////////////////////////RateInfo///////////////////
            viewModel = new RateViewModel();
            // установка контекста данных
            this.BindingContext = viewModel;
        }
    }
}