using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.W;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.W
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterWContentView : ContentView
    {
        private ISimpleAudioPlayer player;
        private bool isPlaying;

        public event EventHandler PreviousClicked;
        public event EventHandler NextClicked;
        public LetterWContentView()
        {
            InitializeComponent();
            //BindingContext = new LetterWViewModel();

            player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        }
        public LetterWContentView(LetterWViewModel viewModel)
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