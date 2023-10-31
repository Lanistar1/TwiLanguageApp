using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.More
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MorePage : ContentPage
    {
        public MorePage()
        {
            InitializeComponent();
            BindingContext = new MoreViewmodel(Navigation);

        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void To_greetingpage(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new GreetingPage());
        }
    }
}