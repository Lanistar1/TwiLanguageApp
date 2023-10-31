using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.W;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.W
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterWContentPage : ContentPage
    {
        public LetterWContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterWViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterWViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterWViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}