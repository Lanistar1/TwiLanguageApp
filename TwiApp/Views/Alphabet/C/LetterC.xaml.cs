using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.c;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.C
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterC : ContentPage
    {
        public LetterC()
        {
            InitializeComponent();
            BindingContext = new LetterCViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterCContentPage());
        }
    }
}