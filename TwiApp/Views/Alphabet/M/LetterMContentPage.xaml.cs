using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.M;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.M
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterMContentPage : ContentPage
    {
        public LetterMContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterMViewModel();
            BindingContext = LetterMViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterMViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterMViewModel.Instance.NavigateNext();
        }
    }
}