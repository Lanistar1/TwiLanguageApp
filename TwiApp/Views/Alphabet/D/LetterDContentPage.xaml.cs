using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.D;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.D
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterDContentPage : ContentPage
    {
        public LetterDContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterDViewModel();

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterDViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterDViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}