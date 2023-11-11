using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using TwiApp.ViewModels.Y;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.Y
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterYContentPage : ContentPage
    {
        public LetterYContentPage()
        {
            InitializeComponent();
           // BindingContext = new LetterYViewModel();
            BindingContext = LetterYViewModel.Instance;

        }
        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterYViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterYViewModel.Instance.NavigateNext();
        }
    }
}