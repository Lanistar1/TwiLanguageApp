using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.R;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.R
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterR : ContentPage
    {
        public LetterR()
        {
            InitializeComponent();
            //BindingContext = new LetterRViewModel();
            BindingContext = LetterRViewModel.Instance;


        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterRContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterRViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterRContentPage());
        }
    }
}