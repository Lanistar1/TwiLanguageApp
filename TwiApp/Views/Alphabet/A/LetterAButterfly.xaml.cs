using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Alphabet.A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterAButterfly : ContentPage
    {
        private ISimpleAudioPlayer player;

        public LetterAButterfly()
        {
            InitializeComponent();
            player = CrossSimpleAudioPlayer.Current;
            player.Load("welcome.mp3"); //
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Next(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new LetterABird());

        }

        private void OnPlayAudioClicked(object sender, EventArgs e)
        {
            if (player != null)
            {
                if (player.IsPlaying)
                {
                    player.Pause();
                }
                else
                {
                    player.Play();
                }
            }
        }
    }
}