using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.O
{

    public class LetterOViewModel : INotifyPropertyChanged
    {
        private static LetterOViewModel instance;
        public static LetterOViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterOViewModel();
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

        public LetterOViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "African", Image = "african.png", Mp3Path = "AFRICAN.mp3", TWIName = "Obibini", TwiMp3Path = "OBIBINI.mp3"},
                new LetterAModel { EnglishName = "Alligator", Image = "alligator.png", Mp3Path = "ALLIGATOR.mp3", TWIName = "Okyekye", TwiMp3Path = "OKYEKYE.mp3"},
                new LetterAModel { EnglishName = "Boardgame", Image = "boardgame.png", Mp3Path = "BOARDGAME.mp3", TWIName = "Oware", TwiMp3Path = "OWARE.mp3"},
                new LetterAModel { EnglishName = "Boat", Image = "boat.png", Mp3Path = "BOAT.mp3", TWIName = "Obonto", TwiMp3Path = "OBONTO.mp3"},
                new LetterAModel { EnglishName = "Caterpillar", Image = "caterpillar.png", Mp3Path = "CATERPILLAR.mp3", TWIName = "Osa", TwiMp3Path = "OSA.mp3"},
                new LetterAModel { EnglishName = "Dishonest person", Image = "dishonest.png", Mp3Path = "DISHONESTPERSON.mp3", TWIName = "Okotomponi", TwiMp3Path = "OKOTONPONI.mp3"},
                new LetterAModel { EnglishName = "Fireman", Image = "fireman.png", Mp3Path = "FIREMAN.mp3", TWIName = "Odumgya", TwiMp3Path = "ODUMGYA.mp3"},
                new LetterAModel { EnglishName = "Gentleman", Image = "gentleman.png", Mp3Path = "GENTLEMAN.mp3", TWIName = "Owura", TwiMp3Path = "OWURA.mp3"},
                new LetterAModel { EnglishName = "Pharmacist", Image = "pharmacist.png", Mp3Path = "PHARMACIST.mp3", TWIName = "Oduyɛfo)", TwiMp3Path = "ODUY3FO).mp3"},
                new LetterAModel { EnglishName = "Professor", Image = "professor.png", Mp3Path = "PROFESSOR.mp3", TWIName = "Okunini", TwiMp3Path = "OKUNINI.mp3"},
                new LetterAModel { EnglishName = "Rain", Image = "rain.png", Mp3Path = "RAIN.mp3", TWIName = "Osuo", TwiMp3Path = "OSUO.mp3"},
                new LetterAModel { EnglishName = "Scarecrow", Image = "scarecrow.png", Mp3Path = "SCARECROW.mp3", TWIName = "Oberekutu", TwiMp3Path = "OBREKUTU.mp3"},
                new LetterAModel { EnglishName = "Sheep", Image = "sheep.png", Mp3Path = "SHEEP.mp3", TWIName = "Odwan", TwiMp3Path = "ODWAN.mp3"},
                new LetterAModel { EnglishName = "Squirrel", Image = "squirrel.png", Mp3Path = "SQUIRREL.mp3", TWIName = "Opuro", TwiMp3Path = "OPURO.mp3"},
                new LetterAModel { EnglishName = "Sun", Image = "sun.png", Mp3Path = "SUN.mp3", TWIName = "Owia", TwiMp3Path = "OWIA.mp3"},
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
