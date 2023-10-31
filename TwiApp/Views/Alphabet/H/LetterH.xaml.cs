using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.H;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.H
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterH : ContentPage
    {
        public LetterH()
        {
            InitializeComponent();
            BindingContext = new LetterHViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterHContentPage());
        }
    }
}