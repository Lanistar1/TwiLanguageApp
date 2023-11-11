using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterAContentPage : ContentPage
    {
        public LetterAContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterAViewModel();
            BindingContext = LetterAViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterAViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterAViewModel.Instance.NavigateNext();
        }
    }
}