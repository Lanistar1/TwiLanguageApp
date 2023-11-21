using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.L
{
    public class LetterLViewModel : INotifyPropertyChanged
    {
        private static LetterLViewModel instance;
        public static LetterLViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterLViewModel();
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

        public LetterLViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Calendar", Image = "calendar.png", Mp3Path = "calendar.mp3", TWIName = "Kalanda", TwiMp3Path = "KALANDA.mp3"},
                new LetterAModel { EnglishName = "Bus", Image = "bus.png", Mp3Path = "Bus.mp3", TWIName = "Lɔre", TwiMp3Path = "L)RE.mp3"},
                new LetterAModel { EnglishName = "Car", Image = "car.png", Mp3Path = "CAR.mp3", TWIName = "Lɔre", TwiMp3Path = "L)RE.mp3"},
                new LetterAModel { EnglishName = "Fashionable", Image = "fahionable.jpg", Mp3Path = "birdplay.mp3", TWIName = "Laif", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Football", Image = "football.png", Mp3Path = "FOOTBALL.mp3", TWIName = "Bɔɔlɔ", TwiMp3Path = "B))LO.mp3"},
                new LetterAModel { EnglishName = "Soft fried plantain", Image = "friedplantain.png", Mp3Path = "SOFTFRIEDPLANTAIN.mp3", TWIName = "kelewele", TwiMp3Path = "KELEWELE.mp3"},
                new LetterAModel { EnglishName = "Galon", Image = "galon.png", Mp3Path = "GALON.mp3", TWIName = "Galɔn", TwiMp3Path = "GAL)N.mp3"},
                new LetterAModel { EnglishName = "Letter", Image = "letter.png", Mp3Path = "LETTER.mp3", TWIName = "Lɛtɛ", TwiMp3Path = "L3T3.mp3"},
                new LetterAModel { EnglishName = "Lottery", Image = "lottery.png", Mp3Path = "LOTTERY.mp3", TWIName = "Lotto", TwiMp3Path = "LOTTO.mp3"},
                new LetterAModel { EnglishName = "Ludo", Image = "ludo.png", Mp3Path = "LUDO.mp3", TWIName = "Ludu", TwiMp3Path = "LUDU.mp3"},
                new LetterAModel { EnglishName = "Macaroni", Image = "macaroni.png", Mp3Path = "MARCORONI.mp3", TWIName = "Taalia", TwiMp3Path = "TALIA.mp3"},
                new LetterAModel { EnglishName = "Police", Image = "policeman2.png", Mp3Path = "POLICE.mp3", TWIName = "Polisini", TwiMp3Path = "polisini.mp3"},
                new LetterAModel { EnglishName = "Slippers", Image = "sandals.png", Mp3Path = "SLIPPERS.mp3", TWIName = "Kyalewɔte", TwiMp3Path = "KYALEW)TE.mp3"},
                new LetterAModel { EnglishName = "Skirt", Image = "skirt.png", Mp3Path = "SKIRT.mp3", TWIName = "Slit", TwiMp3Path = "SLIT.mp3"},
                new LetterAModel { EnglishName = "Street", Image = "street.png", Mp3Path = "STREET.mp3", TWIName = "Lɔre kwan", TwiMp3Path = "L)REKWAN.mp3"},
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
