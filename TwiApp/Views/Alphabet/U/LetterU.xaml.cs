using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.U;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.U
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterU : ContentPage
    {
        public LetterU()
        {
            InitializeComponent();
            //BindingContext = new LetterUViewModel();
            BindingContext = LetterUViewModel.Instance;

        }
        //private void To_LetterAContentPage(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new LetterUContentPage());
        //}
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            if (sender is View view && view.BindingContext is LetterAModel selectedModel)
            {
                LetterUViewModel.Instance.SelectedContent = selectedModel;
            }
            Navigation.PushAsync(new LetterUContentPage());
        }
    }
}