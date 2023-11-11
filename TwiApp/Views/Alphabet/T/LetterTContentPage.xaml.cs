using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.T;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.T
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterTContentPage : ContentPage
    {
        public LetterTContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterTViewModel();
            BindingContext = LetterTViewModel.Instance;

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterTViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterTViewModel.Instance.NavigateNext();
        }
    }
}