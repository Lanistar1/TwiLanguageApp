using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.M;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.M
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterMContentPage : ContentPage
    {
        public LetterMContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterMViewModel();

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterMViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterMViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}