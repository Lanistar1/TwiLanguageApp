using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.L
{
    public class LetterLViewModel : INotifyPropertyChanged
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

        public LetterLViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Calendar", Image = "calendar.png", Mp3Path = "mouseplay.mp3", TWIName = "Kalanda", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Bus", Image = "bus.png", Mp3Path = "spiderplay.mp3", TWIName = "Lɔre", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Car", Image = "car.png", Mp3Path = "rabbitplay.mp3", TWIName = "Lɔre", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fashionable", Image = "fashionable.jpj", Mp3Path = "birdplay.mp3", TWIName = "Laif", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Football", Image = "football.png", Mp3Path = "butterflyplay.mp3", TWIName = "Bɔɔlɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Friedplantain", Image = "friedplantain.png", Mp3Path = "eyesplay.mp3", TWIName = "kelewele", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Galon", Image = "galon.png", Mp3Path = "frogplay.mp3", TWIName = "Galɔn", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Letter", Image = "letter.png", Mp3Path = "chickenplay.mp3", TWIName = "Lɛtɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Lottery", Image = "lottery.png", Mp3Path = "mangoplay.mp3", TWIName = "Lotto", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Ludo", Image = "ludo.png", Mp3Path = "monkeyplay.mp3", TWIName = "Ludu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Macaroni", Image = "macaroni.png", Mp3Path = "mouthplay.mp3", TWIName = "Taalia", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Policeman", Image = "policeman2.png", Mp3Path = "pineplay.mp3", TWIName = "Polisini", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sandal", Image = "sandals.png", Mp3Path = "pineplay.mp3", TWIName = "Kyalewɔte", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Skirt", Image = "skirt.png", Mp3Path = "pineplay.mp3", TWIName = "Slit", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Street", Image = "street.png", Mp3Path = "pineplay.mp3", TWIName = "Lɔre kwan", TwiMp3Path = ""},
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
