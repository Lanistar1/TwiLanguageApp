using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.More
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            InitializeComponent();
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}