﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.c
{

    public class LetterCViewModel : INotifyPropertyChanged
    {
        private static LetterCViewModel instance;
        public static LetterCViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterCViewModel();
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

        public LetterCViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bald eagle", Image = "baldeagle.png", Mp3Path = "mouseplay.mp3", TWIName = "ɔkɔdeɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cat", Image = "cat.png", Mp3Path = "spiderplay.mp3", TWIName = "ɔkra", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Clock", Image = "clock.png", Mp3Path = "rabbitplay.mp3", TWIName = "ɔdɔn", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Deer", Image = "deer.png", Mp3Path = "birdplay.mp3", TWIName = "ɔforoteɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Duiker", Image = "duiker.png", Mp3Path = "butterflyplay.mp3", TWIName = "ɔtwe", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Elephant", Image = "elephant.png", Mp3Path = "eyesplay.mp3", TWIName = "ɔsono", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hunter", Image = "Hunter.png", Mp3Path = "frogplay.mp3", TWIName = "ɔbɔmmɔfoɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Lazy", Image = "lazy.png", Mp3Path = "chickenplay.mp3", TWIName = "ɔkwadwofoɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Mason", Image = "Mason.png", Mp3Path = "mangoplay.mp3", TWIName = "ɔdansifoɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Priest", Image = "Priest.png", Mp3Path = "monkeyplay.mp3", TWIName = "ɔsofo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Queen", Image = "Queen.png", Mp3Path = "mouthplay.mp3", TWIName = "ɔhemaa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Rock", Image = "rock.png", Mp3Path = "pineplay.mp3", TWIName = "ɔbotan", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Snake", Image = "snake.png", Mp3Path = "pineplay.mp3", TWIName = "ɔwɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Soldier", Image = "soldier.png", Mp3Path = "pineplay.mp3", TWIName = "ɔsraani", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Teacher", Image = "teacher.png", Mp3Path = "pineplay.mp3", TWIName = "ɔkyerɛkyerɛni", TwiMp3Path = ""},
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
