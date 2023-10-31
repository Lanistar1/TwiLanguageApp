using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwiApp
{
    public partial class MainPage : ContentPage
    {
        private ISimpleAudioPlayer player;

        public MainPage()
        {
            InitializeComponent();

            player = CrossSimpleAudioPlayer.Current;
            player.Load("welcome.mp3"); // 
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
