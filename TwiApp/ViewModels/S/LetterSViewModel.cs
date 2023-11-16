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
                new LetterAModel { EnglishName = "Bear", Image = "bear.png", Mp3Path = "BEAR.mp3", TWIName = "Sisire", TwiMp3Path = "SISIRE.mp3"},
                new LetterAModel { EnglishName = "Money", Image = "cash.png", Mp3Path = "MONEY.mp3", TWIName = "Sika", TwiMp3Path = "SIKA.mp3"},
                new LetterAModel { EnglishName = "Colander", Image = "colander.png", Mp3Path = "COLANDER.mp3", TWIName = "Sɔne3", TwiMp3Path = "S)NE3.mp3"},
                new LetterAModel { EnglishName = "Key", Image = "key.png", Mp3Path = "KEY.mp3", TWIName = "Safoa", TwiMp3Path = "SAFOA.mp3"},
                new LetterAModel { EnglishName = "Knife", Image = "knife.png", Mp3Path = "KNIFE.mp3", TWIName = "Sekan", TwiMp3Path = "SEKAN.mp3"},
                new LetterAModel { EnglishName = "Ostrich", Image = "ostrich.png", Mp3Path = "OSTRICH.mp3", TWIName = "Sohori", TwiMp3Path = "SOHORI.mp3"},
                new LetterAModel { EnglishName = "Piano", Image = "piano.png", Mp3Path = "PIANO.mp3", TWIName = "sankuo", TwiMp3Path = "SNAKUO.mp3"},
                new LetterAModel { EnglishName = "Pillow", Image = "pillow.png", Mp3Path = "PILLOW.mp3", TWIName = "Sumiiɛ", TwiMp3Path = "SUMII3.mp3"},
                new LetterAModel { EnglishName = "Pupil", Image = "pupil.png", Mp3Path = "PUPIL.mp3", TWIName = "Sukuuni", TwiMp3Path = "SUKUUNI.mp3"},
                new LetterAModel { EnglishName = "Shovel", Image = "shovel.png", Mp3Path = "SHOVEL.mp3", TWIName = "Sofi", TwiMp3Path = "SOFI.mp3"},
                new LetterAModel { EnglishName = "Skirt", Image = "skirt.png", Mp3Path = "SKIRT.mp3", TWIName = "Slit", TwiMp3Path = "SLIT.mp3"},
                new LetterAModel { EnglishName = "Soap", Image = "soap.png", Mp3Path = "SOAP.mp3", TWIName = "Samina", TwiMp3Path = "SAMINA.mp3"},
                new LetterAModel { EnglishName = "Sponge", Image = "sponge.png", Mp3Path = "SPONGE.mp3", TWIName = "Sapɔ", TwiMp3Path = "SAP).mp3"},
                new LetterAModel { EnglishName = "Tiger", Image = "tiger.png", Mp3Path = "TIGER.mp3", TWIName = "Sebɔ", TwiMp3Path = "SEB).mp3"},
                new LetterAModel { EnglishName = "Worm", Image = "worm.png", Mp3Path = "WORM.mp3", TWIName = "Sonsono", TwiMp3Path = "SONSONO.mp3"},
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
