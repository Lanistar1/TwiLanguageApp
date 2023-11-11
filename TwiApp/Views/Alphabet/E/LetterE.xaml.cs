using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.E;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.E
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterE : ContentPage
    {
        public LetterE()
        {
            InitializeComponent();
           // BindingContext = new LetterEViewModel();
            BindingContext = LetterEViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterEContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterEViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterEContentPage());
        }
    }
}