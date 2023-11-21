using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.E
{

    public class LetterEViewModel : INotifyPropertyChanged
    {
        private static LetterEViewModel instance;
        public static LetterEViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterEViewModel();
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

        public LetterEViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bird's nest", Image = "birdnest.jpg", Mp3Path = "NEST.mp3", TWIName = "Ebuo", TwiMp3Path = "EBUO.mp3"},
                new LetterAModel { EnglishName = "Bird's cage", Image = "birdscage.png", Mp3Path = "BirdCage.mp3", TWIName = "Ebuo", TwiMp3Path = "EBUO.mp3"},
                new LetterAModel { EnglishName = "Darkness", Image = "darkness.png", Mp3Path = "DARKNESS.mp3", TWIName = "Esum", TwiMp3Path = "ESUM.mp3"},
                new LetterAModel { EnglishName = "Fire", Image = "fire.png", Mp3Path = "FIRE.mp3", TWIName = "Egya", TwiMp3Path = "EGYA.mp3"},
                new LetterAModel { EnglishName = "Five", Image = "five.png", Mp3Path = "FIVE.mp3", TWIName = "Enum", TwiMp3Path = "ENUM.mp3"},
                new LetterAModel { EnglishName = "Forge", Image = "forge.png", Mp3Path = "FORGE.mp3", TWIName = "Ebura", TwiMp3Path = "EBURA.mp3"},
                new LetterAModel { EnglishName = "Gun", Image = "gun.png", Mp3Path = "GUN.mp3", TWIName = "Etuo", TwiMp3Path = "ETUO.mp3"},
                new LetterAModel { EnglishName = "Head", Image = "head.png", Mp3Path = "HEAD.mp3", TWIName = "Etire", TwiMp3Path = "ETIRE.mp3"},
                new LetterAModel { EnglishName = "Home work", Image = "homework.png", Mp3Path = "HOMEWORK.mp3", TWIName = "Efie dwumadie", TwiMp3Path = "EFIEDWUMADIE.mp3"},
                new LetterAModel { EnglishName = "House", Image = "house.png", Mp3Path = "HOUSE.mp3", TWIName = "Efie", TwiMp3Path = "EFIE.mp3"},
                new LetterAModel { EnglishName = "Louse", Image = "lice.png", Mp3Path = "LOUSE.mp3", TWIName = "Edwie", TwiMp3Path = "EDWIE.mp3"},
                new LetterAModel { EnglishName = "Sore", Image = "pain.png", Mp3Path = "SORE.mp3", TWIName = "Ekuro", TwiMp3Path = "EKURO.mp3"},
                new LetterAModel { EnglishName = "Scary", Image = "scary.png", Mp3Path = "SCARY.mp3", TWIName = "Ehu", TwiMp3Path = "EHU.mp3"},
                new LetterAModel { EnglishName = "Ten", Image = "ten.png", Mp3Path = "TEN.mp3", TWIName = "Edu", TwiMp3Path = "EDU.mp3"},
                new LetterAModel { EnglishName = "Weather", Image = "weather.png", Mp3Path = "WEATHER.mp3", TWIName = "Ewiem", TwiMp3Path = "EWIEM(.mp3"},
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
