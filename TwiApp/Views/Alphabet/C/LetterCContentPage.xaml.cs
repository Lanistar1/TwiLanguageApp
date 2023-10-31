using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.c;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.C
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterCContentPage : ContentPage
    {
        public LetterCContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterCViewModel();

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterCViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterCViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}