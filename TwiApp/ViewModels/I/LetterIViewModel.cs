using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.I
{
    public class LetterIViewModel : INotifyPropertyChanged
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

        public LetterIViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Ask", Image = "ask.png", Mp3Path = "mouseplay.mp3", TWIName = "Bisa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Bicycle", Image = "bycicle.jpg", Mp3Path = "spiderplay.mp3", TWIName = "Basikere", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Chrismas", Image = "chrismas.png", Mp3Path = "rabbitplay.mp3", TWIName = "Afehyia pa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cocoyam", Image = "cocoyam.png", Mp3Path = "birdplay.mp3", TWIName = "Mankani", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Eat", Image = "eat.png", Mp3Path = "butterflyplay.mp3", TWIName = "Didi", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Eyebrow", Image = "eyebrow3.png", Mp3Path = "eyesplay.mp3", TWIName = "Aniakyinwi", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "greet", Image = "greet.png", Mp3Path = "frogplay.mp3", TWIName = "Kyea", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Jump", Image = "jump.png", Mp3Path = "chickenplay.mp3", TWIName = "Huri", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Meeting", Image = "meeting.png", Mp3Path = "mangoplay.mp3", TWIName = "Nhyiamu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Occiput", Image = "occiput.png", Mp3Path = "mangoplay.mp3", TWIName = "Atikɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Shoulder", Image = "shoulder.png", Mp3Path = "monkeyplay.mp3", TWIName = "Abɛtiri", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Squeeze", Image = "squeeze.png", Mp3Path = "mouthplay.mp3", TWIName = "Mia", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sugar", Image = "sugar.png", Mp3Path = "pineplay.mp3", TWIName = "Abrɔbɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Poorman", Image = "poorman.png", Mp3Path = "pineplay.mp3", TWIName = "Ohiani", TwiMp3Path = ""},
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
