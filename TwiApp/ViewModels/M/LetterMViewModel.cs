﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.M
{

    public class LetterMViewModel : INotifyPropertyChanged
    {
        private static LetterMViewModel instance;
        public static LetterMViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterMViewModel();
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

        public LetterMViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bamboo", Image = "bamboo.jpg", Mp3Path = "BAMBOO.mp3", TWIName = "Mpampuro", TwiMp3Path = "MPAMPURO.mp3"},
                new LetterAModel { EnglishName = "Bed", Image = "bed.jpg", Mp3Path = "BED.mp3", TWIName = "Mpa", TwiMp3Path = "MPA.mp3"},
                new LetterAModel { EnglishName = "Children", Image = "children.JPG", Mp3Path = "CHILDREN.mp3", TWIName = "Mmɔfra", TwiMp3Path = "MM)FRA.mp3"},
                new LetterAModel { EnglishName = "Cocoyam", Image = "cocoyam.jpg", Mp3Path = "COCOYAM.mp3", TWIName = "Mankani", TwiMp3Path = "MANKANI.mp3"},
                new LetterAModel { EnglishName = "First aid box", Image = "firstaidbox.jpg", Mp3Path = "FIRSTAIDBOX.mp3", TWIName = "Mmoa adaka", TwiMp3Path = "MMOAADAKA.mp3"},
                new LetterAModel { EnglishName = "Horns", Image = "horn.png", Mp3Path = "NEWHORNS.mp3", TWIName = "Mmɛn", TwiMp3Path = "AB3N.mp3"},
                new LetterAModel { EnglishName = "Mushroom", Image = "mushroom.jpg", Mp3Path = "MUSHROOM.mp3", TWIName = "Mmire", TwiMp3Path = "MMIRE.mp3"},
                new LetterAModel { EnglishName = "Pepper", Image = "pepper.jpg", Mp3Path = "PEPPER.mp3", TWIName = "Mako", TwiMp3Path = "MAKO.mp3"},
                new LetterAModel { EnglishName = "Photo album", Image = "photoalbum.jpg", Mp3Path = "PHOTOALBUM.mp3", TWIName = "Mfoni nnwoma", TwiMp3Path = "MFONINWOMA.mp3"},
                new LetterAModel { EnglishName = "Shoe", Image = "shoe.jpg", Mp3Path = "SHOE.mp3", TWIName = "Mpaboa", TwiMp3Path = "MPABOA.mp3"},
                new LetterAModel { EnglishName = "Squeeze", Image = "squeeze.jpg", Mp3Path = "SQUEEZE.mp3", TWIName = "Mia", TwiMp3Path = "MIA.mp3"},
                new LetterAModel { EnglishName = "Towel", Image = "towel.jpg", Mp3Path = "TOWEL.mp3", TWIName = "Mpopaho", TwiMp3Path = "MPOPAHO.mp3"},
                new LetterAModel { EnglishName = "Window", Image = "window.jpg", Mp3Path = "WINDOW.mp3", TWIName = "Mpoma", TwiMp3Path = "NEWMPOMA.mp3"},
                new LetterAModel { EnglishName = "Wind", Image = "windy.jpg", Mp3Path = "WIND.mp3", TWIName = "Mframa", TwiMp3Path = "MFRAMA.mp3"},
                new LetterAModel { EnglishName = "Zoo", Image = "zoo.JPG", Mp3Path = "ZOO.mp3", TWIName = "Mmoa turo", TwiMp3Path = "MMOATURO.mp3"},
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
