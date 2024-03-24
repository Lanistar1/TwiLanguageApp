using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Plugin.SimpleAudioPlayer;
using TwiApp.Models.A;
using TwiApp.Views.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Welcome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        private ISimpleAudioPlayer player;
        private bool isPlaying;

        public WelcomePage()
        {
            InitializeComponent();

            player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            if (!isPlaying)
            {
                string mp3Path = "welcome.mp3";
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

        private async void To_Homepage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}