using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.W
{
    public class LetterWViewModel : INotifyPropertyChanged
    {
        private static LetterWViewModel instance;
        public static LetterWViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterWViewModel();
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

        public LetterWViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Aeroplane", Image = "aeroplane.jpg", Mp3Path = "AEROPLANE.mp3", TWIName = "Wiemhyɛn", TwiMp3Path = "WIEMHY3N.mp3"},
                new LetterAModel { EnglishName = "Asleep", Image = "asleep.png", Mp3Path = "ASLEEP.mp3", TWIName = "Wada", TwiMp3Path = "WADA.mp3"},
                new LetterAModel { EnglishName = "Chew", Image = "chew.png", Mp3Path = "CHEW.mp3", TWIName = "We", TwiMp3Path = "WE.mp3"},
                new LetterAModel { EnglishName = "Chimney", Image = "chimney.jpg", Mp3Path = "CHIMNEY.mp3", TWIName = "Wusikwan", TwiMp3Path = "WUSIKWAN.mp3"},
                new LetterAModel { EnglishName = "Sky", Image = "clouds.png", Mp3Path = "SKY.mp3", TWIName = "Wiem", TwiMp3Path = "WIEM.mp3"},
                new LetterAModel { EnglishName = "Crawl", Image = "crawl.png", Mp3Path = "CRAWL.mp3", TWIName = "Wea", TwiMp3Path = "WEA.mp3"},
                new LetterAModel { EnglishName = "Finish", Image = "finish.jpg", Mp3Path = "FINISH.mp3", TWIName = "Wie", TwiMp3Path = "WIE.mp3"},
                new LetterAModel { EnglishName = "Inject", Image = "inject.jpg", Mp3Path = "INJECT.mp3", TWIName = "Wɔ paneɛ", TwiMp3Path = "W)PANE3.mp3"},
                new LetterAModel { EnglishName = "Mortar", Image = "mortar.jpg", Mp3Path = "MORTAR.mp3", TWIName = "Waduro", TwiMp3Path = "WADURO.mp3"},
                new LetterAModel { EnglishName = "Pestle", Image = "mortarandpestle.jpg", Mp3Path = "PESTLE.mp3", TWIName = "wᴐma", TwiMp3Path = "W)MMA.mp3"},
                new LetterAModel { EnglishName = "Pilot", Image = "pilot.gif", Mp3Path = "PILOT.mp3", TWIName = "Wiemhyɛnkani", TwiMp3Path = "WIEMHY3NKANI.mp3"},
                new LetterAModel { EnglishName = "Rice and beans", Image = "ricewithbeans.png", Mp3Path = "RICEANDBEANS.mp3", TWIName = "Waakye", TwiMp3Path = "WAAKYE.mp3"},
                new LetterAModel { EnglishName = "Smoke", Image = "smoke.jpg", Mp3Path = "SMOKE.mp3", TWIName = "Wusie", TwiMp3Path = "WUSIE.mp3"},
                new LetterAModel { EnglishName = "World", Image = "world.jpg", Mp3Path = "WORLD.mp3", TWIName = "Wiase", TwiMp3Path = "WIASE.mp3"},
                new LetterAModel { EnglishName = "You", Image = "you.png", Mp3Path = "YOU.mp3", TWIName = "Wo", TwiMp3Path = "WO.mp3"},
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
