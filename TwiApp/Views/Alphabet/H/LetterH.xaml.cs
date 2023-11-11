using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.H;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.H
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterH : ContentPage
    {
        public LetterH()
        {
            InitializeComponent();
            //BindingContext = new LetterHViewModel();
            BindingContext = LetterHViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterHContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterHViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterHContentPage());
        }
    }
}