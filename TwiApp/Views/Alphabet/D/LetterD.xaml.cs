using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.D;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.D
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterD : ContentPage
    {
        public LetterD()
        {
            InitializeComponent();
            BindingContext = new LetterDViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterDContentPage());
        }
    }
}