using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
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
            //BindingContext = new LetterGViewModel();
            BindingContext = LetterGViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterGViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterGViewModel.Instance.NavigateNext();
        }
    }
}