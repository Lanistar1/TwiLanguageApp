﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.B;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterBContentPage : ContentPage
    {
        public LetterBContentPage()
        {
            InitializeComponent();
            //BindingContext = new LetterBViewModel();
            BindingContext = LetterBViewModel.Instance;

        }

        private void ContentItemView_PreviousClicked(object sender, EventArgs e)
        {
            LetterBViewModel.Instance.NavigatePrevious();
        }

        private void ContentItemView_NextClicked(object sender, EventArgs e)
        {
            LetterBViewModel.Instance.NavigateNext();
        }
    }
}