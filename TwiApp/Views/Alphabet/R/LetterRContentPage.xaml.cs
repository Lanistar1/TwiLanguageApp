using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.R;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.R
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterRContentPage : ContentPage
    {
        public LetterRContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterRViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterRViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterRViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}