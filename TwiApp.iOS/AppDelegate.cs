using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AVFoundation;
using Foundation;
using MediaPlayer;
using UIKit;

namespace TwiApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //

        private AVAudioPlayer player;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {

            PlayAudioWithDelay();
            Task.Delay(10000); // Delay for 5000 milliseconds (5 seconds)

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            //PlayBackgroundAudio("welcome.mp3");

            // Play audio sound


            return base.FinishedLaunching(app, options);
        }

        //private async void PlayAudioWithDelay()
        //{
        //    // Play audio sound
        //    PlayAudio();

        //    // Add a delay of 5 seconds (for example)
        //    await Task.Delay(5000); // Delay for 5000 milliseconds (5 seconds)

        //    // Code after delay
        //    // For example, you can stop the audio here
        //    player?.Stop(); // Stop the audio if player is not null
        //}

        private void PlayAudioWithDelay()
        {
            var audioFilePath = NSBundle.MainBundle.PathForResource("welcome", "mp3"); // Update with your audio file name and extension
            var audioUrl = NSUrl.FromFilename(audioFilePath);

            var player = AVAudioPlayer.FromUrl(audioUrl);
            //player.NumberOfLoops = -1; // Set to -1 for infinite loop, or any positive integer for a specific number of loops
            //player.Volume = 1.0f; // Adjust volume as needed
            //player.PrepareToPlay();
            player.Play();
        }
    }
}
