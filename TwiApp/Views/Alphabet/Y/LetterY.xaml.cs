using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.Y;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.Y
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterY : ContentPage
    {
        public LetterY()
        {
            InitializeComponent();
            BindingContext = new LetterYViewModel();

        }

        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterYContentPage());

        }
    }
}