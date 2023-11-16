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
                new LetterAModel { EnglishName = "Stomach", Image = "belly.png", Mp3Path = "STOMACH.mp3", TWIName = "Yafunu", TwiMp3Path = "YAFUNU.mp3"},
                new LetterAModel { EnglishName = "Blade", Image = "blade.png", Mp3Path = "BLADE.mp3", TWIName = "Yiwan", TwiMp3Path = "YIWAN.mp3"},
                new LetterAModel { EnglishName = "Boat", Image = "boat.png", Mp3Path = "BOAT.mp3", TWIName = "Yiri", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Camel", Image = "camel.png", Mp3Path = "CAMEL.mp3", TWIName = "Yoma", TwiMp3Path = "YOMA.mp3"},
                new LetterAModel { EnglishName = "Go fishing", Image = "fish3.png", Mp3Path = "FISH.mp3", TWIName = "Yi mpataa", TwiMp3Path = "YIMPATAA.mp3"},
                new LetterAModel { EnglishName = "Friend", Image = "friend.png", Mp3Path = "FRIENDSHIP.mp3", TWIName = "Yɔnkoɔ", TwiMp3Path = "Y)NKO).mp3"},
                new LetterAModel { EnglishName = "Haircut", Image = "haircut.png", Mp3Path = "HAIRCUT.mp3", TWIName = "Yi tirinwi", TwiMp3Path = "YITIRINWI.mp3"},
                new LetterAModel { EnglishName = "Hairdye", Image = "hairdye.png", Mp3Path = "HAIRDYE.mp3", TWIName = "Yomo", TwiMp3Path = "YOMO.mp3"},
                new LetterAModel { EnglishName = "Hurry", Image = "hurry3.png", Mp3Path = "HURRY.mp3", TWIName = "Yɛ ntɛm", TwiMp3Path = "Y3NT3M.mp3"},
                new LetterAModel { EnglishName = "Jesus", Image = "jesus.png", Mp3Path = "JESUS.mp3", TWIName = "Yesu", TwiMp3Path = "YESU.mp3"},
                new LetterAModel { EnglishName = "Lost", Image = "lost.png", Mp3Path = "LOST.mp3", TWIName = "Yera", TwiMp3Path = "YERA.mp3"},
                new LetterAModel { EnglishName = "Be quiet", Image = "quietgirl.png", Mp3Path = "BEQUIET.mp3", TWIName = "Ye diin", TwiMp3Path = "Y3DINN.mp3"},
                new LetterAModel { EnglishName = "Sick", Image = "sick.png", Mp3Path = "SICK.mp3", TWIName = "Yare", TwiMp3Path = "YARE.mp3"},
                new LetterAModel { EnglishName = "Try again", Image = "tryagain.png", Mp3Path = "TRYAGAIN.mp3", TWIName = "Y3 bio", TwiMp3Path = "Y3BIO.mp3"},
                new LetterAModel { EnglishName = "Us", Image = "us.png", Mp3Path = "US.mp3", TWIName = "Yɛn", TwiMp3Path = "Y3N.mp3"},
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
