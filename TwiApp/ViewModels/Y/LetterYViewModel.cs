using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.Y
{

    public class LetterYViewModel : INotifyPropertyChanged
    {
        private static LetterYViewModel instance;
        public static LetterYViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterYViewModel();
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

        public LetterYViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Belly", Image = "belly.png", Mp3Path = "mouseplay.mp3", TWIName = "Yafunu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Blade", Image = "blade.png", Mp3Path = "spiderplay.mp3", TWIName = "Yiwan", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Boat", Image = "boat.png", Mp3Path = "rabbitplay.mp3", TWIName = "Yiri", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Camel", Image = "camel.png", Mp3Path = "birdplay.mp3", TWIName = "Yoma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fish", Image = "fish3.png", Mp3Path = "butterflyplay.mp3", TWIName = "Yi mpataa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Friend", Image = "friend.png", Mp3Path = "eyesplay.mp3", TWIName = "Yɔnkoɔ"},
                new LetterAModel { EnglishName = "Haircut", Image = "haircut.png", Mp3Path = "frogplay.mp3", TWIName = "Yi tirinwi", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hairdye", Image = "hairdye.png", Mp3Path = "chickenplay.mp3", TWIName = "Yomo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hurry", Image = "hurry3.png", Mp3Path = "mangoplay.mp3", TWIName = "Yen Ntem", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Jesus", Image = "jesus.png", Mp3Path = "monkeyplay.mp3", TWIName = "Yesu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Lost", Image = "lost.png", Mp3Path = "mouthplay.mp3", TWIName = "Yera", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Quiet girl", Image = "quietgirl.png", Mp3Path = "pineplay.mp3", TWIName = "Ye diin", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sick", Image = "sick.png", Mp3Path = "pineplay.mp3", TWIName = "Yare", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Try again", Image = "tryagain.png", Mp3Path = "pineplay.mp3", TWIName = "Y3 bio", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Us", Image = "us.png", Mp3Path = "pineplay.mp3", TWIName = "Yen", TwiMp3Path = ""},
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
