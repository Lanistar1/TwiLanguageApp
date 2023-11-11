﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.B
{

    public class LetterBViewModel : INotifyPropertyChanged
    {
        private static LetterBViewModel instance;
        public static LetterBViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterBViewModel();
                }
                return instance;
            }
        }


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

        private LetterAModel selectedContent;
        public LetterAModel SelectedContent
        {
            get => selectedContent;
            set
            {
                selectedContent = value;
                OnPropertyChanged(nameof(SelectedContent));
            }
        }


        private int currentIndex;

        public LetterBViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Archery", Image = "archery.png", Mp3Path = "mouseplay.mp3", TWIName = "Bɛmmatoɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Ball", Image = "ball.png", Mp3Path = "spiderplay.mp3", TWIName = "Bɔɔlo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Bread", Image = "bread.png", Mp3Path = "rabbitplay.mp3", TWIName = "Brodo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Bucket", Image = "bucket.png", Mp3Path = "birdplay.mp3", TWIName = "Bokiti", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cassava", Image = "cassava.png", Mp3Path = "butterflyplay.mp3", TWIName = "Bankye", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Charcoal", Image = "Charcoal.png", Mp3Path = "eyesplay.mp3", TWIName = "Bidie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Grapes", Image = "grapes.png", Mp3Path = "frogplay.mp3", TWIName = "Bobe", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Kolanut", Image = "kolanut.png", Mp3Path = "chickenplay.mp3", TWIName = "Bese", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Matches", Image = "matches.png", Mp3Path = "mangoplay.mp3", TWIName = "Burogya", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pawpaw", Image = "pawpaw.png", Mp3Path = "monkeyplay.mp3", TWIName = "Borɔferɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Ribbons", Image = "ribbon.jpg", Mp3Path = "mouthplay.mp3", TWIName = "Bamma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sack", Image = "sack.png", Mp3Path = "pineplay.mp3", TWIName = "Bɔtɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Shark", Image = "Shark.png", Mp3Path = "pineplay.mp3", TWIName = "Boodede", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Smock", Image = "smock.png", Mp3Path = "pineplay.mp3", TWIName = "Batakari", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Yam", Image = "yam.png", Mp3Path = "pineplay.mp3", TWIName = "Bayerɛ", TwiMp3Path = ""},
            };
            currentIndex = 0;
            SelectedContent = ContentList.FirstOrDefault();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NavigatePrevious()
        {
            int currentIndex = ContentList.IndexOf(SelectedContent);
            if (currentIndex > 0)
            {
                SelectedContent = ContentList[currentIndex - 1];
            }
        }

        public void NavigateNext()
        {
            int currentIndex = ContentList.IndexOf(SelectedContent);
            if (currentIndex < ContentList.Count - 1)
            {
                SelectedContent = ContentList[currentIndex + 1];
            }
        }
    }

}
