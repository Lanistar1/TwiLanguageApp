using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.R
{

    public class LetterRViewModel : INotifyPropertyChanged
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

        public LetterRViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Boss", Image = "boss.png", Mp3Path = "mouseplay.mp3", TWIName = "Adwumawura", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Broom", Image = "broom.png", Mp3Path = "spiderplay.mp3", TWIName = "praeɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Calendar", Image = "calendar.png", Mp3Path = "rabbitplay.mp3", TWIName = "Asranna", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Call", Image = "call.png", Mp3Path = "birdplay.mp3", TWIName = "Frɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cat", Image = "cat.png", Mp3Path = "butterflyplay.mp3", TWIName = "Ɔkra", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Child", Image = "child.png", Mp3Path = "eyesplay.mp3", TWIName = "Abɔfra", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Come", Image = "come.png", Mp3Path = "frogplay.mp3", TWIName = "Bra", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Field", Image = "field.png", Mp3Path = "chickenplay.mp3", TWIName = "Agoprama so", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Halk", Image = "halk.png", Mp3Path = "mangoplay.mp3", TWIName = "Akoroma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Laugh", Image = "laugh.png", Mp3Path = "monkeyplay.mp3", TWIName = "Sre", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pawpaw", Image = "pawpaw.png", Mp3Path = "mouthplay.mp3", TWIName = "Bɔfrɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "PINEAPPLE", Image = "pineapple.png", Mp3Path = "pineplay.mp3", TWIName = "Abrɔbɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Turkey", Image = "turkey.png", Mp3Path = "pineplay.mp3", TWIName = "Kurokurokoko", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Wind", Image = "wind.png", Mp3Path = "pineplay.mp3", TWIName = "Mframa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Yam", Image = "yam.png", Mp3Path = "pineplay.mp3", TWIName = "Bayerɛ", TwiMp3Path = ""},
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
