using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.S
{
    public class LetterSViewModel : INotifyPropertyChanged
    {
        private static LetterSViewModel instance;
        public static LetterSViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterSViewModel();
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

        public LetterSViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bear", Image = "bear.png", Mp3Path = "mouseplay.mp3", TWIName = "Sisire", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cash", Image = "cash.png", Mp3Path = "spiderplay.mp3", TWIName = "Sika", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Colander", Image = "colander.png", Mp3Path = "rabbitplay.mp3", TWIName = "Sɔne3", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Key", Image = "key.png", Mp3Path = "birdplay.mp3", TWIName = "Safoa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Knife", Image = "knife.png", Mp3Path = "butterflyplay.mp3", TWIName = "Sekan", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Ostrich", Image = "ostrich.png", Mp3Path = "eyesplay.mp3", TWIName = "Sohori", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Piano", Image = "piano.png", Mp3Path = "frogplay.mp3", TWIName = "sankuo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pillow", Image = "pillow.png", Mp3Path = "chickenplay.mp3", TWIName = "Sumiiɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pupil", Image = "pupil.png", Mp3Path = "mangoplay.mp3", TWIName = "Sukuuni", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Shovel", Image = "shovel.png", Mp3Path = "monkeyplay.mp3", TWIName = "Sofi", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Skirt", Image = "skirt.png", Mp3Path = "mouthplay.mp3", TWIName = "Slit", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Soap", Image = "soap.png", Mp3Path = "pineplay.mp3", TWIName = "Samina", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sponge", Image = "sponge.png", Mp3Path = "pineplay.mp3", TWIName = "Sapɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Tiger", Image = "tiger.png", Mp3Path = "pineplay.mp3", TWIName = "Sebɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Worm", Image = "worm.png", Mp3Path = "pineplay.mp3", TWIName = "Sonsono", TwiMp3Path = ""},
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
