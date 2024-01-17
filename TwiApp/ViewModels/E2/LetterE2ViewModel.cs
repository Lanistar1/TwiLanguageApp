using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;

namespace TwiApp.ViewModels.E2
{

    public class LetterE2ViewModel : INotifyPropertyChanged
    {
        private static LetterE2ViewModel instance;
        public static LetterE2ViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterE2ViewModel();
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

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }


        private int currentIndex;

        public LetterE2ViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Buffalo", Image = "buffalo.gif", Mp3Path = "BUFFALO.mp3", TWIName = "Ɛkoɔ", TwiMp3Path = "3KO).mp3"},
                new LetterAModel { EnglishName = "Grass", Image = "grass.jpg", Mp3Path = "GRASS.mp3", TWIName = "Ɛserε", TwiMp3Path = "3SER3.mp3"},
                new LetterAModel { EnglishName = "Hat", Image = "hat.jpg", Mp3Path = "HAT.mp3", TWIName = "Ɛkyε", TwiMp3Path = "3KY3.mp3"},
                new LetterAModel { EnglishName = "Honey", Image = "honey.jpg", Mp3Path = "HONEY.mp3", TWIName = "Ɛwoɔ", TwiMp3Path = "3WO).mp3"},
                new LetterAModel { EnglishName = "Knot", Image = "knot.jpg", Mp3Path = "KNOT.mp3", TWIName = "Ɛpɔ", TwiMp3Path = "3P).mp3"},
                new LetterAModel { EnglishName = "Meat", Image = "meat2.jpg", Mp3Path = "MEAT.mp3", TWIName = "Ɛnam", TwiMp3Path = "3NAM.mp3"},
                new LetterAModel { EnglishName = "Melon", Image = "melon.jpg", Mp3Path = "MELON.mp3", TWIName = "Ɛferɛ", TwiMp3Path = "3FER3.mp3"},
                new LetterAModel { EnglishName = "Rice", Image = "rice2.jpg", Mp3Path = "RICE.mp3", TWIName = "Ɛmo", TwiMp3Path = "3MO.mp3"},
                new LetterAModel { EnglishName = "Rice ball", Image = "riceball.jpg", Mp3Path = "RICEBALL.mp3", TWIName = "Ɛmotuo", TwiMp3Path = "3MOTUO.mp3"},
                new LetterAModel { EnglishName = "Road", Image = "road.gif", Mp3Path = "ROAD.mp3", TWIName = "Ɛkwan", TwiMp3Path = "3KWAN.mp3"},
                new LetterAModel { EnglishName = "Room", Image = "room.jpg", Mp3Path = "ROOM.mp3", TWIName = "Ɛdan", TwiMp3Path = "3DAN.mp3"},
                new LetterAModel { EnglishName = "Sea", Image = "sea.jpg", Mp3Path = "SEA.mp3", TWIName = "Ɛpo", TwiMp3Path = "3PO.mp3"},
                new LetterAModel { EnglishName = "Sleep", Image = "sleep.jpg", Mp3Path = "SLEEP.mp3", TWIName = "Ɛnna", TwiMp3Path = "3NNA.mp3"},
                new LetterAModel { EnglishName = "Stone", Image = "stone.JPG", Mp3Path = "STONE.mp3", TWIName = "Ɛboɔ", TwiMp3Path = "3BO).mp3"},
                new LetterAModel { EnglishName = "Teeth", Image = "teeth.jpg", Mp3Path = "TEETH.mp3", TWIName = "Ɛse", TwiMp3Path = "3SE.mp3"},
            };
            currentIndex = 0;
            SelectedContent = ContentList.FirstOrDefault();

            Title = "Letter ɛ";
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
