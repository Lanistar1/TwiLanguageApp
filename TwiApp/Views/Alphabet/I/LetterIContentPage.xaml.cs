using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.I;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.I
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterIContentPage : ContentPage
    {
        public LetterIContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterIViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterIViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterIViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}