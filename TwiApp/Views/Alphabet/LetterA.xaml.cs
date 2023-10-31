﻿using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.ViewModels.A;
using TwiApp.Views.Alphabet.A;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterA : ContentPage
    {
        private ISimpleAudioPlayer player;
        private bool isPlaying;

        public LetterA()
        {
            InitializeComponent();
            BindingContext = new LetterAViewModel();

        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void To_letterAFirst(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LetterAContentPage());
        }

        private void To_mouth(object sender, EventArgs e)
        {

            Navigation.PushAsync(new LetterAContentPage());
        }

        private void To_spider(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_rabbit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_hen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_chair(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_pine(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_frog(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_butterfly(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_bird(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_monkey(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_mango(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }

        private void To_LetterAContentPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterAContentPage());

        }
    }
}