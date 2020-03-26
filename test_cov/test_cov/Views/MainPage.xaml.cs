using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test_cov
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Views.covid()) 
            {
                 BarBackgroundColor = Color.FromHex("#000")
            }; 
           

            IsPresented = false;
        }

        private void bnt_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Views.covid())
            {
                BarBackgroundColor = Color.FromHex("#000")
            };
            IsPresented = false;
        }

        private void bnt_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Views.Simptome())
            {
                BarBackgroundColor = Color.FromHex("#000")
            };
            IsPresented = false;
        }
    }
}
