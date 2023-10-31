using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.P;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.P
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterPContentPage : ContentPage
    {
        public LetterPContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterPViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterPViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterPViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}