using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.U;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.U
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterUContentPage : ContentPage
    {
        public LetterUContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterUViewModel();

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterUViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterUViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}