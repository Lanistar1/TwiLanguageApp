using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterB : ContentPage
    {
        public LetterB()
        {
            InitializeComponent();
            BindingContext = new LetterBViewModel();

        }

        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterBContentPage());

        }
    }
}