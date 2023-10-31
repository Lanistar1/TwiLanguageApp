using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Views.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Welcome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void To_Homepage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}