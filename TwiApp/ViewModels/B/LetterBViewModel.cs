using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.B
{

    public class LetterBViewModel : INotifyPropertyChanged
    {
        private static LetterBViewModel instance;
        public static LetterBViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterBViewModel();
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

        public LetterBViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Archery", Image = "archery.jpg", Mp3Path = "ARCHERY.mp3", TWIName = "Bɛmmatoɔ", TwiMp3Path = "BEMMATO).mp3"},
                new LetterAModel { EnglishName = "Football", Image = "ball.jpg", Mp3Path = "FOOTBALL.mp3", TWIName = "Bɔɔlo", TwiMp3Path = "B))LO.mp3"},
                new LetterAModel { EnglishName = "Bread", Image = "bread.jpg", Mp3Path = "bread.mp3", TWIName = "Brodo", TwiMp3Path = "BRODO.mp3"},
                new LetterAModel { EnglishName = "Bucket", Image = "bucket.jpg", Mp3Path = "BUCKET.mp3", TWIName = "Bokiti", TwiMp3Path = "BOKITI.mp3"},
                new LetterAModel { EnglishName = "Cassava", Image = "cassava.jpg", Mp3Path = "CASSAVA.mp3", TWIName = "Bankye", TwiMp3Path = "BANKYE.mp3"},
                new LetterAModel { EnglishName = "Charcoal", Image = "Charcoal.jpg", Mp3Path = "CHARCOAL.mp3", TWIName = "Bidie", TwiMp3Path = "BIDIE.mp3"},
                new LetterAModel { EnglishName = "Grapes", Image = "grapes.jpg", Mp3Path = "GRAPES.mp3", TWIName = "Bobe", TwiMp3Path = "BOBE.mp3"},
                new LetterAModel { EnglishName = "Kola nut", Image = "kolanut.jpg", Mp3Path = "KOLANUT.mp3", TWIName = "Bese", TwiMp3Path = "BESE.mp3"},
                new LetterAModel { EnglishName = "Matches", Image = "matches.png", Mp3Path = "MATCHES.mp3", TWIName = "Burogya", TwiMp3Path = "BUROGYA.mp3"},
                new LetterAModel { EnglishName = "Pawpaw", Image = "pawpaw.jpg", Mp3Path = "PAWPAW.mp3", TWIName = "Borɔferɛ", TwiMp3Path = "BOR)FER3.mp3"},
                new LetterAModel { EnglishName = "Ribbon", Image = "ribbon.jpg", Mp3Path = "RIBBON.mp3", TWIName = "Bamma", TwiMp3Path = "BAMMA.mp3"},
                new LetterAModel { EnglishName = "Sack", Image = "sack.jpg", Mp3Path = "SACK.mp3", TWIName = "Bɔtɔ", TwiMp3Path = "B)T).mp3"},
                new LetterAModel { EnglishName = "Shark", Image = "Shark.jpg", Mp3Path = "SHARK.mp3", TWIName = "Boodede/Bonsu", TwiMp3Path = "BONSU.mp3"},
                new LetterAModel { EnglishName = "Smock", Image = "smock.jpg", Mp3Path = "SMOCK.mp3", TWIName = "Batakari", TwiMp3Path = "BATAKARI.mp3"},
                new LetterAModel { EnglishName = "Yam", Image = "yam.jpg", Mp3Path = "YAM.mp3", TWIName = "Bayerɛ", TwiMp3Path = "BAYER3.mp3"},
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
