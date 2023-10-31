using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.H;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.H
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterHContentPage : ContentPage
    {
        public LetterHContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterHViewModel();

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterHViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterHViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}