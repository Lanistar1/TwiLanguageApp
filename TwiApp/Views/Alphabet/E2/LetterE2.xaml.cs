using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.E;
using TwiApp.ViewModels.E2;
using TwiApp.Views.Alphabet.E;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.E2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LetterE2 : ContentPage
	{
		public LetterE2 ()
		{
			InitializeComponent ();
            BindingContext = LetterE2ViewModel.Instance;

        }

        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterE2ViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterE2ContentPage());
        }
    }
}