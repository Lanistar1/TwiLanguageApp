using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            BindingContext = new LetterSViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterSViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterSViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}