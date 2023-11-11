using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;
using TwiApp.ViewModels.c;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.C
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterCContentView : ContentView
    {

        private ISimpleAudioPlayer player;
        private bool isPlaying;

        public event EventHandler PreviousClicked;
        public event EventHandler NextClicked;

        public LetterCContentView()
        {
            InitializeComponent();
            //BindingContext = new LetterCViewModel();

            player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        }
        public LetterCContentView(LetterCViewModel viewModel)
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