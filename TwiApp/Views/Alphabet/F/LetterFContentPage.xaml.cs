using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.F;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.F
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterFContentPage : ContentPage
    {
        public LetterFContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterFViewModel();
            BindingContext = LetterFViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterFViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterFViewModel.Instance.NavigateNext();
        }
    }
}