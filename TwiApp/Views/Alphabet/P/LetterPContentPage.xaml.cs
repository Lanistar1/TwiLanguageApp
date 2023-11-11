using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.P;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.P
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterPContentPage : ContentPage
    {
        public LetterPContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterPViewModel();
            BindingContext = LetterPViewModel.Instance;

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterPViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterPViewModel.Instance.NavigateNext();
        }
    }
}