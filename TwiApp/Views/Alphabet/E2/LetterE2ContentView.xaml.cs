using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models.A;
using TwiApp.ViewModels.E2;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.E2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LetterE2ContentView : ContentView
	{

        private ISimpleAudioPlayer player;
        private bool isPlaying;

        public event EventHandler PreviousClicked;
        public event EventHandler NextClicked;

        public LetterE2ContentView ()
		{
			InitializeComponent ();

            player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        }

        public LetterE2ContentView(LetterE2ViewModel viewModel)
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