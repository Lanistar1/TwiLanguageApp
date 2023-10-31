using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            BindingContext = new LetterTViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterTViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterTViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}