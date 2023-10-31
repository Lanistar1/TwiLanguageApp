using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.E;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.E
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterEContentPage : ContentPage
    {
        public LetterEContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterEViewModel();

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterEViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterEViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}