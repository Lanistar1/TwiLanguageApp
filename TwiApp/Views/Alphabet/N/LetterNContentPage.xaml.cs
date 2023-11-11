using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.N;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.N
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterNContentPage : ContentPage
    {
        public LetterNContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterNViewModel();
            BindingContext = LetterNViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterNViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterNViewModel.Instance.NavigateNext();
        }
    }
}