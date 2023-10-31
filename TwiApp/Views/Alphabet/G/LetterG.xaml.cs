using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.G;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.G
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterG : ContentPage
    {
        public LetterG()
        {
            InitializeComponent();
            BindingContext = new LetterGViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterGContentPage());
        }
    }
}