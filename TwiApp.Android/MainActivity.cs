using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Media;

namespace TwiApp.Droid
{
    //[Activity(Label = "TwiApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]

    [Activity(Label = "TwiApp", Icon = "@drawable/APPLogo", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]

    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        MediaPlayer player; // Media player to play audio

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());

            player = new MediaPlayer();

            // Play the audio from the Assets folder
            PlayBackgroundAudio("welcome.mp3");
        }

        private void PlayBackgroundAudio(string audioFileName)
        {
            // Load and play the background audio file from Assets
            var assetManager = Assets;
            try
            {
                using (var assetStream = assetManager.OpenFd(audioFileName))
                {
                    player.Reset();
                    player.SetDataSource(assetStream.FileDescriptor, assetStream.StartOffset, assetStream.Length);
                    player.Prepare();

                    // Set the playback rate to normal speed
                    player.PlaybackParams = new PlaybackParams();
                    player.PlaybackParams.SetSpeed(1.0f); // 1.0f is normal speed

                    player.Start();
                }
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error playing audio: " + ex.Message);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}