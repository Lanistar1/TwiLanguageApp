using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.N;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.N
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterN : ContentPage
    {
        public LetterN()
        {
            InitializeComponent();
            BindingContext = new LetterNViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterNContentPage());
        }
    }
}