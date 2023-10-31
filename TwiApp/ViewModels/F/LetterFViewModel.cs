using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.F
{
    public class LetterFViewModel : INotifyPropertyChanged
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

        public LetterFViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Beautiful", Image = "beautiful.png", Mp3Path = "mouseplay.mp3", TWIName = "Fɛfɛɛfɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Bring", Image = "bring.png", Mp3Path = "spiderplay.mp3", TWIName = "Fa bra", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Call", Image = "call.png", Mp3Path = "rabbitplay.mp3", TWIName = "Fre", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Flag", Image = "flag.png", Mp3Path = "birdplay.mp3", TWIName = "Frankaa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Forgive", Image = "forgive.png", Mp3Path = "butterflyplay.mp3", TWIName = "Fa kyɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fufu", Image = "fufu.png", Mp3Path = "eyesplay.mp3", TWIName = "Fufu0", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Gift", Image = "gift.png", Mp3Path = "frogplay.mp3", TWIName = "Fa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hand over", Image = "handover.png", Mp3Path = "chickenplay.mp3", TWIName = "Fa Ma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Miner", Image = "miner.png", Mp3Path = "mangoplay.mp3", TWIName = "Fagudeɛtuni", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Oven", Image = "oven.png", Mp3Path = "monkeyplay.mp3", TWIName = "Fononoo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Put inside", Image = "putinside.png", Mp3Path = "mouthplay.mp3", TWIName = "Fa to mu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Show", Image = "show.png", Mp3Path = "pineplay.mp3", TWIName = "Fa kyerɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Takeaway", Image = "takeaway.png", Mp3Path = "pineplay.mp3", TWIName = "Fa kɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Trap", Image = "trap.png", Mp3Path = "pineplay.mp3", TWIName = "Fidie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "White", Image = "white.png", Mp3Path = "pineplay.mp3", TWIName = "Fitaa", TwiMp3Path = ""},
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
