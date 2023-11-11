using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.P;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.P
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterP : ContentPage
    {
        public LetterP()
        {
            InitializeComponent();
            //BindingContext = new LetterPViewModel();
            BindingContext = LetterPViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterPContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterPViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterPContentPage());
        }
    }
}