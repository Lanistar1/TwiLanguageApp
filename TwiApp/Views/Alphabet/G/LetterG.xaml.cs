using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.G;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.G
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterG : ContentPage
    {
        public LetterG()
        {
            InitializeComponent();
           // BindingContext = new LetterGViewModel();
            BindingContext = LetterGViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterGContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterGViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterGContentPage());
        }
    }
}