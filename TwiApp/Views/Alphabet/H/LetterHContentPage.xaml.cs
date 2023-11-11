using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.H;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.H
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterHContentPage : ContentPage
    {
        public LetterHContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterHViewModel();
            BindingContext = LetterHViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterHViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterHViewModel.Instance.NavigateNext();
        }
    }
}