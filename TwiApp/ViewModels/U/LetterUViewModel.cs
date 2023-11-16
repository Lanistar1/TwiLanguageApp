using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.U
{
    public class LetterUViewModel : INotifyPropertyChanged
    {
        private static LetterUViewModel instance;
        public static LetterUViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterUViewModel();
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

        public LetterUViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Banana", Image = "banana.png", Mp3Path = "BANANA.mp3", TWIName = "Kwadu", TwiMp3Path = "KWADU.mp3"},
                new LetterAModel { EnglishName = "Black", Image = "black.png", Mp3Path = "BLACK.mp3", TWIName = "Tuntun", TwiMp3Path = "TUNTUM.mp3"},
                new LetterAModel { EnglishName = "Blow", Image = "blow.png", Mp3Path = "BLOW.mp3", TWIName = "Hu", TwiMp3Path = "HU.mp3"},
                new LetterAModel { EnglishName = "Jump", Image = "boxJump.png", Mp3Path = "JUMP.mp3", TWIName = "Huri", TwiMp3Path = "HURI.mp3"},
                new LetterAModel { EnglishName = "Cry", Image = "crying.png", Mp3Path = "CRY.mp3", TWIName = "Su", TwiMp3Path = "SU.mp3"},
                new LetterAModel { EnglishName = "Fear", Image = "fear.png", Mp3Path = "FEAR.mp3", TWIName = "Suro", TwiMp3Path = "SURO.mp3"},
                new LetterAModel { EnglishName = "Fly", Image = "fly.png", Mp3Path = "FLY.mp3", TWIName = "Tu", TwiMp3Path = "TU.mp3"},
                new LetterAModel { EnglishName = "Food", Image = "food.png", Mp3Path = "FOOD.mp3", TWIName = "Aduane", TwiMp3Path = "ADUANE.mp3"},
                new LetterAModel { EnglishName = "Hold", Image = "hold.png", Mp3Path = "HOLD.mp3", TWIName = "sᴐ mu", TwiMp3Path = "S)MU.mp3"},
                new LetterAModel { EnglishName = "Measure", Image = "measure.png", Mp3Path = "MEASURE.mp3", TWIName = "Susu", TwiMp3Path = "MEASURE.mp3"},
                new LetterAModel { EnglishName = "Rat", Image = "rat.png", Mp3Path = "RAT.mp3", TWIName = "Akura", TwiMp3Path = "AKURA.mp3"},
                new LetterAModel { EnglishName = "Rice balls", Image = "riceballs.png", Mp3Path = "RICEBALL.mp3", TWIName = "Emotuo", TwiMp3Path = "3MOTUO.mp3"},
                new LetterAModel { EnglishName = "Shout", Image = "shout.png", Mp3Path = "SHOUT.mp3", TWIName = "Tea mu", TwiMp3Path = "TEAMU.mp3"},
                new LetterAModel { EnglishName = "Sibling", Image = "sibling.png", Mp3Path = "SIBLING.mp3", TWIName = "Nua", TwiMp3Path = "NUA.mp3"},
                new LetterAModel { EnglishName = "Water", Image = "water.png", Mp3Path = "WATER.mp3", TWIName = "Nsuo", TwiMp3Path = "NSUO.mp3"},
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
