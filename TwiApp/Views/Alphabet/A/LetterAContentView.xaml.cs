﻿using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterAContentView : ContentView
    {
        private ISimpleAudioPlayer player;
        private bool isPlaying;

        public event EventHandler PreviousClicked;
        public event EventHandler NextClicked;

        public LetterAContentView()
        {
            InitializeComponent();
            //BindingContext = new LetterAViewModel();

            player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        }
        public LetterAContentView(LetterAViewModel viewModel)
        : this()
        {
            BindingContext = viewModel; // Set the BindingContext to the provided ViewModel
        }

        private void PlayButton_Clicked(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                string mp3Path = (BindingContext as LetterAModel)?.Mp3Path;
                if (!string.IsNullOrEmpty(mp3Path))
                {
                    player.Load(mp3Path);
                    player.Play();
                    isPlaying = true;
                    isPlaying = false;

                }
            }
            else
            {
                player.Pause();
                isPlaying = false;
            }
        }

        private void PlayTwiButton_Clicked(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                string mp3Path = (BindingContext as LetterAModel)?.TwiMp3Path;
                if (!string.IsNullOrEmpty(mp3Path))
                {
                    player.Load(mp3Path);
                    player.Play();
                    isPlaying = true;
                    isPlaying = false;

                }
            }
            else
            {
                player.Pause();
                isPlaying = false;
            }
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PreviousButton_Clicked(object sender, EventArgs e)
        {
            PreviousClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

       
    }
}