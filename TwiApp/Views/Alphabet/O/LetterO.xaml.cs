using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.O;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.O
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterO : ContentPage
    {
        public LetterO()
        {
            InitializeComponent();
            //BindingContext = new LetterOViewModel();
            BindingContext = LetterOViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterOContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterOViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterOContentPage());
        }
    }
}