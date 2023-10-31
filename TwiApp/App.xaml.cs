using Plugin.SimpleAudioPlayer;
using System;
using TwiApp.Views.Alphabet;
using TwiApp.Views.Alphabet.A;
using TwiApp.Views.More;
using TwiApp.Views.Welcome;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("AkayaTelivigala-Regular.ttf", Alias = "Akaya")]

namespace TwiApp
{
    public partial class App : Application
    {
        //private ISimpleAudioPlayer player;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
