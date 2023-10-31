using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.Y;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.Y
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterYContentPage : ContentPage
    {
        public LetterYContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterYViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterYViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterYViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}