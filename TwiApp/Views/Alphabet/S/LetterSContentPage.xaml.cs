using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.S;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.S
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterSContentPage : ContentPage
    {
        public LetterSContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterSViewModel();
            BindingContext = LetterSViewModel.Instance;

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterSViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterSViewModel.Instance.NavigateNext();
        }
    }
}