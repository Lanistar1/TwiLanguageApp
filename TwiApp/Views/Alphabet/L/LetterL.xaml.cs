﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.L;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.L
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterL : ContentPage
    {
        public LetterL()
        {
            InitializeComponent();
            BindingContext = new LetterLViewModel();

        }
        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterLContentPage());
        }
    }
}