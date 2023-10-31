using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.L;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.L
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterLContentPage : ContentPage
    {
        public LetterLContentPage()
        {
            InitializeComponent();
            BindingContext = new LetterLViewModel();

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterLViewModel viewModel)
            {
                viewModel.NavigatePrevious();
            }
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            if (BindingContext is LetterLViewModel viewModel)
            {
                viewModel.NavigateNext();
            }
        }
    }
}