﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.N
{
    public class LetterNViewModel : INotifyPropertyChanged
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

        public LetterNViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Cow", Image = "cow.png", Mp3Path = "mouseplay.mp3", TWIName = "Nantwie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cutlass", Image = "cutlass.png", Mp3Path = "spiderplay.mp3", TWIName = "Nkrantɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Finger", Image = "finger.png", Mp3Path = "rabbitplay.mp3", TWIName = "Nsateaa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Flower", Image = "flower2a.png", Mp3Path = "birdplay.mp3", TWIName = "Nhwiren", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Garden egg", Image = "gardenegg.png", Mp3Path = "butterflyplay.mp3", TWIName = "Nyaadoa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hand", Image = "hand.png", Mp3Path = "eyesplay.mp3", TWIName = "Nsa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Leg", Image = "leg.png", Mp3Path = "frogplay.mp3", TWIName = "Nan"},
                new LetterAModel { EnglishName = "Mosquitoes", Image = "mosquitoes.png", Mp3Path = "chickenplay.mp3", TWIName = "Ntomtom", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Okro", Image = "okro.png", Mp3Path = "mangoplay.mp3", TWIName = "Nkuruma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Peanut", Image = "peanut.png", Mp3Path = "monkeyplay.mp3", TWIName = "Nkateɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Salt", Image = "salt.png", Mp3Path = "mouthplay.mp3", TWIName = "Nkyene", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Scorpion", Image = "scorpion.png", Mp3Path = "pineplay.mp3", TWIName = "Nyanyankyerɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Snail", Image = "snail.png", Mp3Path = "pineplay.mp3", TWIName = "Nwa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Star", Image = "star.png", Mp3Path = "pineplay.mp3", TWIName = "Nsoroma", TwiMp3Path = ""},
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