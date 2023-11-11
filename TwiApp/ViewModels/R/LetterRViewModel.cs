using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.R
{

    public class LetterRViewModel : INotifyPropertyChanged
    {
        private static LetterRViewModel instance;
        public static LetterRViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterRViewModel();
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

        public LetterRViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Boss", Image = "boss.png", Mp3Path = "mouseplay.mp3", TWIName = "Adwumawura", TwiMp3Path = "mouseplay.mp3"},
                new LetterAModel { EnglishName = "Broom", Image = "broom.png", Mp3Path = "spiderplay.mp3", TWIName = "praeɛ", TwiMp3Path = "mouseplay.mp3"},
                new LetterAModel { EnglishName = "Calendar", Image = "calendar.png", Mp3Path = "rabbitplay.mp3", TWIName = "Asranna", TwiMp3Path = "mouseplay.mp3"},
                new LetterAModel { EnglishName = "Call", Image = "call.png", Mp3Path = "birdplay.mp3", TWIName = "Frɛ", TwiMp3Path = "mouseplay.mp3"},
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
