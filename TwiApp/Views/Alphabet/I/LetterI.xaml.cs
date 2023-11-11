using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.I;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.I
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterI : ContentPage
    {
        public LetterI()
        {
            InitializeComponent();
            //BindingContext = new LetterIViewModel();
            BindingContext = LetterIViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterIContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterIViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterIContentPage());
        }
    }
}