using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.K;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.K
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterKContentPage : ContentPage
    {
        public LetterKContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterKViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterKViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterKViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}