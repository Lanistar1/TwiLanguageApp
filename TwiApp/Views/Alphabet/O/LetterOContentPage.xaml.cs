using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.O;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.O
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterOContentPage : ContentPage
    {
        public LetterOContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterOViewModel();
            BindingContext = LetterOViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterOViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterOViewModel.Instance.NavigateNext();
        }
    }
}