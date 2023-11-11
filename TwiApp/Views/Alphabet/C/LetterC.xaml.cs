using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.c;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.C
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterC : ContentPage
    {
        public LetterC()
        {
            InitializeComponent();
            //BindingContext = new LetterCViewModel();
            BindingContext = LetterCViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterCContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterCViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterCContentPage());
        }
    }
}