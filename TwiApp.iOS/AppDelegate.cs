using System;
using System.Collections.Generic;
using System.Linq;
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

        private AVAudioPlayer backgroundAudioPlayer;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            PlayBackgroundAudio("welcome.mp3");

            return base.FinishedLaunching(app, options);
        }

        private void PlayBackgroundAudio(string audioFileName)
        {
            // Get the path to the audio file in the Resources folder
            var audioPath = NSBundle.MainBundle.PathForResource(audioFileName, "mp3");

            if (!string.IsNullOrEmpty(audioPath))
            {
                // Set up the audio session
                var session = AVAudioSession.SharedInstance();
                session.SetCategory(AVAudioSessionCategory.Playback);

                // Initialize the AVAudioPlayer
                NSError error;
                backgroundAudioPlayer = new AVAudioPlayer(new NSUrl(audioPath), "mp3", out error);

                if (error == null)
                {
                    // Set the playback rate to normal speed
                    backgroundAudioPlayer.EnableRate = true;
                    backgroundAudioPlayer.Rate = 1.0f; // 1.0f is normal speed

                    // Play the audio
                    backgroundAudioPlayer.Play();
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Error playing background audio: " + error.LocalizedDescription);
                }
            }
        }
    }
}
