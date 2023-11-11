using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.N;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.N
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterN : ContentPage
    {
        public LetterN()
        {
            InitializeComponent();
            //BindingContext = new LetterNViewModel();
            BindingContext = LetterNViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterNContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterNViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterNContentPage());
        }
    }
}