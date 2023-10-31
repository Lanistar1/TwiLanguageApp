using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.U;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.U
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterU : ContentPage
    {
        public LetterU()
        {
            InitializeComponent();
            BindingContext = new LetterUViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterUContentPage());
        }
    }
}