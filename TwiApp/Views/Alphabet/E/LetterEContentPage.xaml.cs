using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
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
           // BindingContext = new LetterEViewModel();
            BindingContext = LetterEViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterEViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterEViewModel.Instance.NavigateNext();
        }
    }
}