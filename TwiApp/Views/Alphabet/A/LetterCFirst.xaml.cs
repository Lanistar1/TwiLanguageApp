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
    public partial class LetterCFirst : ContentPage
    {
        private ISimpleAudioPlayer player;

        public LetterCFirst()
        {
            InitializeComponent();

            player = CrossSimpleAudioPlayer.Current;
            player.Load("welcome.mp3"); //
        }

        private async void Next(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new LetterAHen());
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
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