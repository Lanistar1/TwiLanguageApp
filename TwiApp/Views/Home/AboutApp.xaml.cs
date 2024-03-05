using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutApp : ContentPage
    {
        public AboutApp()
        {
            InitializeComponent();
        }

        private async void To_Visit(object sender, EventArgs e)
        {
            string url = "https://www.ankobra.com/";

            await Navigation.PushAsync(new WebviewPage(url));
        }

        private async void To_Getintouch(object sender, EventArgs e)
        {
            string url = "https://info@ankobra.com";

            await Navigation.PushAsync(new WebviewPage(url));
        }
    }
}