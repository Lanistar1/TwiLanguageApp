using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterAContent : ContentPage
    {
        public LetterAContent()
        {
            InitializeComponent();
            BindingContext = new LetterAViewModel();
            //BindingContext = this;
        }
    }
}