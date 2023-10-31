﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.U
{
    public class LetterUViewModel : INotifyPropertyChanged
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

        public LetterUViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Banana", Image = "banana.png", Mp3Path = "mouseplay.mp3", TWIName = "Kwadu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Black", Image = "black.png", Mp3Path = "spiderplay.mp3", TWIName = "Tuntun", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Blow", Image = "blow.png", Mp3Path = "rabbitplay.mp3", TWIName = "Hu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "BoxJump", Image = "boxJump.png", Mp3Path = "birdplay.mp3", TWIName = "Huri", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Crying", Image = "crying.png", Mp3Path = "butterflyplay.mp3", TWIName = "Su", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fear", Image = "fear.png", Mp3Path = "eyesplay.mp3", TWIName = "Suro", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fly", Image = "fly.png", Mp3Path = "frogplay.mp3", TWIName = "Tu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Food", Image = "food.png", Mp3Path = "chickenplay.mp3", TWIName = "Aduane", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hold", Image = "hold.png", Mp3Path = "mangoplay.mp3", TWIName = "So mu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Measure", Image = "measure.png", Mp3Path = "monkeyplay.mp3", TWIName = "Susu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Rat", Image = "rat.png", Mp3Path = "mouthplay.mp3", TWIName = "Akura", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Riceballs", Image = "riceballs.png", Mp3Path = "pineplay.mp3", TWIName = "Emotuo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Shout", Image = "shout.png", Mp3Path = "pineplay.mp3", TWIName = "Tea mu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sibling", Image = "sibling.png", Mp3Path = "pineplay.mp3", TWIName = "Nua", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Water", Image = "water.png", Mp3Path = "pineplay.mp3", TWIName = "Nsuo", TwiMp3Path = ""},
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