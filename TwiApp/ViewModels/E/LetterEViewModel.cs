using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.E
{

    public class LetterEViewModel : INotifyPropertyChanged
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

        public LetterEViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bird nest", Image = "birdnest.png", Mp3Path = "mouseplay.mp3", TWIName = "Ebuo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Birds cage", Image = "birdscage.png", Mp3Path = "spiderplay.mp3", TWIName = "Ebuo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Darkness", Image = "darkness.png", Mp3Path = "rabbitplay.mp3", TWIName = "Esum", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fire", Image = "fire.png", Mp3Path = "birdplay.mp3", TWIName = "Egya", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Five", Image = "five.png", Mp3Path = "butterflyplay.mp3", TWIName = "Enum", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Forge", Image = "forge.png", Mp3Path = "eyesplay.mp3", TWIName = "Ebura", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Gun", Image = "gun.png", Mp3Path = "frogplay.mp3", TWIName = "Etuo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Head", Image = "head.png", Mp3Path = "chickenplay.mp3", TWIName = "Etire", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Home work", Image = "homework.png", Mp3Path = "mangoplay.mp3", TWIName = "Efie dwuma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "House", Image = "house.png", Mp3Path = "monkeyplay.mp3", TWIName = "Efie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Lice", Image = "lice.png", Mp3Path = "mouthplay.mp3", TWIName = "Edwie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pain", Image = "pain.png", Mp3Path = "pineplay.mp3", TWIName = "Ekuro", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Scary", Image = "scary.png", Mp3Path = "pineplay.mp3", TWIName = "Ehu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Ten", Image = "ten.png", Mp3Path = "pineplay.mp3", TWIName = "Edu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Weather", Image = "weather.png", Mp3Path = "pineplay.mp3", TWIName = "Ewiem", TwiMp3Path = ""},
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
