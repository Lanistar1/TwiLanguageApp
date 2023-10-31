using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.W;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.W
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterW : ContentPage
    {
        public LetterW()
        {
            InitializeComponent();
            BindingContext = new LetterWViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterWContentPage());
        }
    }
}