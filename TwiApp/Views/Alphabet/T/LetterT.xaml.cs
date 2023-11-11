using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.T;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.T
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterT : ContentPage
    {
        public LetterT()
        {
            InitializeComponent();
            //BindingContext = new LetterTViewModel();
            BindingContext = LetterTViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterTContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterTViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterTContentPage());
        }
    }
}