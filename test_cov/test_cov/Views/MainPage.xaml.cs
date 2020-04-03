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
                BarBackgroundColor = Color.FromHex("#34495E")

            };
            IsPresented = false;
            ///////////////////////////////////////////ToolbarItem//////////////////////////////////////////////////////
            ToolbarItem tb = new ToolbarItem
            {
                Text = "Andrei",
                Order =ToolbarItemOrder.Secondary,
                Priority = 3,
            };

            ToolbarItem tb1 = new ToolbarItem
            {
                Text = "Vasile",
                Order = ToolbarItemOrder.Secondary,
                Priority = 2,
            };

            ToolbarItem tb2 = new ToolbarItem
            {
                Text = "Alex",
                Order = ToolbarItemOrder.Secondary,
                Priority = 1,
            };
            ToolbarItems.Add(tb);
            ToolbarItems.Add(tb1);
            ToolbarItems.Add(tb2);
          
        }
        /////////////////////////////////////////////////bnt_menu///////////////////////////////////////////////////////////
        private void bnt_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Views.covid())
            {
                BarBackgroundColor = Color.FromHex("#34495E")
            };
            IsPresented = false;
        }

        private void bnt_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Views.Simptome())
            {
                BarBackgroundColor = Color.FromHex("#34495E")
            };
            IsPresented = false;
        }

        private void bnt_3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Views.Profilaxie())
            {
                BarBackgroundColor = Color.FromHex("#34495E")
            };
            IsPresented = false;
        }

        private void bnt_4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Views.Tratament())
            {
                BarBackgroundColor = Color.FromHex("#34495E")
            };
            IsPresented = false; 
        }

        private void bnt_5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Views.Primulajutor())
            {
                BarBackgroundColor = Color.FromHex("#34495E")
            };
            IsPresented = false; 
        }
        /////////////////////////////////////////////////////////////////////////
    }
}
