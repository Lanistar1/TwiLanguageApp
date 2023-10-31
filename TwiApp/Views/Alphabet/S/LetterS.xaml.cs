using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.S;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.S
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterS : ContentPage
    {
        public LetterS()
        {
            InitializeComponent();
            BindingContext = new LetterSViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterSContentPage());
        }
    }
}