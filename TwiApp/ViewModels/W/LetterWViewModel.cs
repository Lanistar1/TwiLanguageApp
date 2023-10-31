using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.W
{

    public class LetterWViewModel : INotifyPropertyChanged
    {
        private List<LetterAModel> contentList;
        public List<LetterAModel> ContentList
        {
            get => contentList;
            set
            {
                contentList = value;
                OnPropertyChanged(nameof(ContentList));
            }
        }


        private int currentIndex;

        public LetterWViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Aeroplane", Image = "aeroplane.png", Mp3Path = "mouseplay.mp3", TWIName = "wiemhyɛn", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Asleep", Image = "asleep.png", Mp3Path = "spiderplay.mp3", TWIName = "Wada", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Chew", Image = "chew.png", Mp3Path = "rabbitplay.mp3", TWIName = "We", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "chimney", Image = "chimney.png", Mp3Path = "birdplay.mp3", TWIName = "Wusikwan", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Clouds", Image = "clouds.png", Mp3Path = "butterflyplay.mp3", TWIName = "Wiem", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Crawl", Image = "crawl.png", Mp3Path = "eyesplay.mp3", TWIName = "Wea", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Finish", Image = "finish.png", Mp3Path = "frogplay.mp3", TWIName = "Wie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Inject", Image = "inject.png", Mp3Path = "chickenplay.mp3", TWIName = "wɔpaneɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Mortar", Image = "mortar.png", Mp3Path = "mangoplay.mp3", TWIName = "Waduro", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Mortar and pestle", Image = "mortarandpestle.png", Mp3Path = "monkeyplay.mp3", TWIName = "Woma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pilot", Image = "pilot.gif", Mp3Path = "mouthplay.mp3", TWIName = "Wiemhyɛnkani", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Rice with beans", Image = "ricewithbeans.png", Mp3Path = "pineplay.mp3", TWIName = "Waakye", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Smoke", Image = "smoke.png", Mp3Path = "pineplay.mp3", TWIName = "Wusie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "World", Image = "world.png", Mp3Path = "pineplay.mp3", TWIName = "Wiase", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "You", Image = "you.png", Mp3Path = "pineplay.mp3", TWIName = "Wo", TwiMp3Path = ""},
            };
            currentIndex = 0;
            //CurrentContent = contentList[currentIndex];

        }

        public LetterAModel CurrentContent => contentList[currentIndex];

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NavigateNext()
        {
            if (currentIndex < contentList.Count - 1)
            {
                currentIndex++;
                OnPropertyChanged(nameof(CurrentContent));
            }
        }

        public void NavigatePrevious()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                OnPropertyChanged(nameof(CurrentContent));
            }
        }


    }

}
