using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Popups;
using TwiApp.Views.Alphabet;
using TwiApp.Views.Alphabet.B;
using TwiApp.Views.Alphabet.C;
using TwiApp.Views.Alphabet.D;
using TwiApp.Views.Alphabet.E;
using TwiApp.Views.Alphabet.E2;
using TwiApp.Views.Alphabet.F;
using TwiApp.Views.Alphabet.G;
using TwiApp.Views.Alphabet.H;
using TwiApp.Views.Alphabet.I;
using TwiApp.Views.Alphabet.K;
using TwiApp.Views.Alphabet.L;
using TwiApp.Views.Alphabet.M;
using TwiApp.Views.Alphabet.N;
using TwiApp.Views.Alphabet.O;
using TwiApp.Views.Alphabet.P;
using TwiApp.Views.Alphabet.R;
using TwiApp.Views.Alphabet.S;
using TwiApp.Views.Alphabet.T;
using TwiApp.Views.Alphabet.U;
using TwiApp.Views.Alphabet.W;
using TwiApp.Views.Alphabet.Y;
using TwiApp.Views.More;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private ISimpleAudioPlayer player;

        public HomePage()
        {
            InitializeComponent();

            player = CrossSimpleAudioPlayer.Current;
            //player.Load("welcome.mp3"); // 
        }

        private async void To_AboutApp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutApp());
        }

        private async void To_morepage(object sender, EventArgs e)
        {
            //await MessagePopup.Instance.Show("Feature coming soon.");

            await Application.Current.MainPage.DisplayAlert("Feature coming soon", "", "OK");

            //await Navigation.PushAsync(new MorePage());
        }

        private async void To_letterA(object sender, EventArgs e)
        {
            string mp3Path = "Atwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterA());
        }

        private async void To_letterB(object sender, EventArgs e)
        {
            string mp3Path = "Btwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterB());
        }

        private async void To_letterC(object sender, EventArgs e)
        {
            string mp3Path = "Ctwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterC());
        }

        private async void To_letterD(object sender, EventArgs e)
        {
            string mp3Path = "Dtwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterD());
        }

        private async void To_letterE(object sender, EventArgs e)
        {
            string mp3Path = "Etwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterE());
        }

        private async void To_letterF(object sender, EventArgs e)
        {
            string mp3Path = "Ftwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterF());
        }

        private async void To_letterG(object sender, EventArgs e)
        {
            string mp3Path = "Gtwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterG());
        }

        private async void To_letterH(object sender, EventArgs e)
        {
            string mp3Path = "Htwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterH());
        }

        private async void To_letterI(object sender, EventArgs e)
        {
            string mp3Path = "Itwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterI());
        }

        private async void To_letterK(object sender, EventArgs e)
        {
            string mp3Path = "Ktwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterK());
        }

        private async void To_letterL(object sender, EventArgs e)
        {
            string mp3Path = "Ltwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterL());
        }

        private async void To_letterM(object sender, EventArgs e)
        {
            string mp3Path = "Mtwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterM());
        }

        private async void To_letterN(object sender, EventArgs e)
        {
            string mp3Path = "Ntwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterN());
        }

        private async void To_letterO(object sender, EventArgs e)
        {
            string mp3Path = "Otwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterO());
        }

        private async void To_letterP(object sender, EventArgs e)
        {
            string mp3Path = "Ptwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterP());
        }

        private async void To_letterR(object sender, EventArgs e)
        {
            string mp3Path = "Rtwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterR());
        }

        private async void To_letterS(object sender, EventArgs e)
        {
            string mp3Path = "Stwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterS());
        }

        private async void To_letterT(object sender, EventArgs e)
        {
            string mp3Path = "Ttwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterT());
        }

        private async void To_letterU(object sender, EventArgs e)
        {
            string mp3Path = "Utwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterU());
        }

        private async void To_letterW(object sender, EventArgs e)
        {
            string mp3Path = "Wtwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterW());
        }

        private async void To_letterY(object sender, EventArgs e)
        {
            string mp3Path = "Ytwi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterY());
        }

        private async void To_letterE2(object sender, EventArgs e)
        {
            string mp3Path = "E2twi.mp3";
            player.Load(mp3Path);

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

            await Task.Delay(500);
            await Navigation.PushAsync(new LetterE2());
        }

        private async void To_Incentive(object sender, EventArgs e)
        {
            await MessagePopup.Instance.Show("Feature coming soon.");

            await Application.Current.MainPage.DisplayAlert("Feature coming soon", "", "OK");


        }
    }
}