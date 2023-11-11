using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.K;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.K
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterK : ContentPage
    {
        public LetterK()
        {
            InitializeComponent();
            //BindingContext = new LetterKViewModel();
            BindingContext = LetterKViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterKContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterKViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterKContentPage());
        }
    }
}