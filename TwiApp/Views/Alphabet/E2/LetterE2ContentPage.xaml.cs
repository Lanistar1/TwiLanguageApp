using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.E;
using TwiApp.ViewModels.E2;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.E2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LetterE2ContentPage : ContentPage
	{
		public LetterE2ContentPage ()
		{
			InitializeComponent ();
            BindingContext = LetterE2ViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterE2ViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterE2ViewModel.Instance.NavigateNext();
        }
    }
}