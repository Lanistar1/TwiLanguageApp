using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.K
{

    public class LetterKViewModel : INotifyPropertyChanged
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

        public LetterKViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Banana", Image = "banana.png", Mp3Path = "mouseplay.mp3", TWIName = "Kwadu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Basket", Image = "basket.png", Mp3Path = "spiderplay.mp3", TWIName = "Kɛntɛn", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cocoa", Image = "cocoa.png", Mp3Path = "rabbitplay.mp3", TWIName = "Kookoo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Coconut", Image = "coconut.png", Mp3Path = "birdplay.mp3", TWIName = "Kube", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Coconut tree", Image = "coconuttree.png", Mp3Path = "butterflyplay.mp3", TWIName = "Kube", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cup", Image = "cup.png", Mp3Path = "eyesplay.mp3", TWIName = "Kuruwa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Dog", Image = "dog.png", Mp3Path = "frogplay.mp3", TWIName = "Kraman", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Egg", Image = "egg.png", Mp3Path = "chickenplay.mp3", TWIName = "Kosua", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fox", Image = "fox.png", Mp3Path = "mangoplay.mp3", TWIName = "Krada", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Lightbulb", Image = "lightbulb.png", Mp3Path = "monkeyplay.mp3", TWIName = "Kanea", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Porcupine", Image = "porcupine.png", Mp3Path = "mouthplay.mp3", TWIName = "kɔtɔkɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Ring", Image = "ring.png", Mp3Path = "mouthplay.mp3", TWIName = "Kawa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Television", Image = "television.png", Mp3Path = "mouthplay.mp3", TWIName = "kasamfoni", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Umbrella", Image = "umbrella.png", Mp3Path = "pineplay.mp3", TWIName = "Kyiniiɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Wasp", Image = "wasp.png", Mp3Path = "pineplay.mp3", TWIName = "Kotokurodu", TwiMp3Path = ""},
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
