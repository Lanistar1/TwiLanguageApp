using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.F;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.F
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterF : ContentPage
    {
        public LetterF()
        {
            InitializeComponent();
           // BindingContext = new LetterFViewModel();
            BindingContext = LetterFViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterFContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterFViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterFContentPage());
        }
    }
}