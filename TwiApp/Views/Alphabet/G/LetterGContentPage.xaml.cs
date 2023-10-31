using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.G;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.G
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterGContentPage : ContentPage
    {
        public LetterGContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterGViewModel();

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterGViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterGViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}