using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.O
{

    public class LetterOViewModel : INotifyPropertyChanged
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

        public LetterOViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "African", Image = "african.png", Mp3Path = "mouseplay.mp3", TWIName = "Obibini", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Alligator", Image = "alligator.png", Mp3Path = "spiderplay.mp3", TWIName = "Okyekye", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Boardgame", Image = "boardgame.png", Mp3Path = "rabbitplay.mp3", TWIName = "Owara", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Boat", Image = "boat.png", Mp3Path = "birdplay.mp3", TWIName = "Obonto", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Caterpillar", Image = "caterpillar.png", Mp3Path = "butterflyplay.mp3", TWIName = "Osa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Dishonest", Image = "dishonest.png", Mp3Path = "eyesplay.mp3", TWIName = "Okotomponi", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fireman", Image = "fireman.png", Mp3Path = "frogplay.mp3", TWIName = "Odumgya", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Gentleman", Image = "gentleman.png", Mp3Path = "chickenplay.mp3", TWIName = "Owura", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pharmacist", Image = "pharmacist.png", Mp3Path = "mangoplay.mp3", TWIName = "Oduyɛfo)", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Professor", Image = "professor.png", Mp3Path = "monkeyplay.mp3", TWIName = "Okunini", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Rain", Image = "rain.png", Mp3Path = "mouthplay.mp3", TWIName = "Osuo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Scarecrow", Image = "scarecrow.png", Mp3Path = "pineplay.mp3", TWIName = "Oberekutu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sheep", Image = "sheep.png", Mp3Path = "pineplay.mp3", TWIName = "Odwan", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Squirrel", Image = "squirrel.png", Mp3Path = "pineplay.mp3", TWIName = "Opuro", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sun", Image = "sun.png", Mp3Path = "pineplay.mp3", TWIName = "Owia", TwiMp3Path = ""},
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
