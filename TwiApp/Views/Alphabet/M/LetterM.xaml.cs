using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.M;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.M
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterM : ContentPage
    {
        public LetterM()
        {
            InitializeComponent();
            BindingContext = new LetterMViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterMContentPage());
        }
    }
}