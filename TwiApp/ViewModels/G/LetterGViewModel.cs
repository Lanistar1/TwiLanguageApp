using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.G
{
    public class LetterGViewModel : INotifyPropertyChanged
    {
        private static LetterGViewModel instance;
        public static LetterGViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterGViewModel();
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

        public LetterGViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bonfire", Image = "bonfire.gif", Mp3Path = "BONFIRE.mp3", TWIName = "Gyatanaa", TwiMp3Path = "GYATANAA.mp3"},
                new LetterAModel { EnglishName = "Charcoal", Image = "Charcoal.jpg", Mp3Path = "CHARCOAL.mp3", TWIName = "Gyabidie", TwiMp3Path = "GYABIDIE.mp3"},
                new LetterAModel { EnglishName = "Fire", Image = "fire.JPG", Mp3Path = "FIRE.mp3", TWIName = "Gya", TwiMp3Path = "GYA.mp3"},
                new LetterAModel { EnglishName = "Firewood", Image = "firewood.jpg", Mp3Path = "FIREWOOD.mp3", TWIName = "Gyentia", TwiMp3Path = "GYENTIA.mp3"},
                new LetterAModel { EnglishName = "Garri", Image = "Gari.png", Mp3Path = "GARI.mp3", TWIName = "Gari", TwiMp3Path = "GARE.mp3"},
                new LetterAModel { EnglishName = "Hurricane", Image = "hurricane.jpg", Mp3Path = "HURRICANE.mp3", TWIName = "Gyampanturudu", TwiMp3Path = "GYAMPANTRUDU.mp3"},
                new LetterAModel { EnglishName = "Kitchen", Image = "kitchen.png", Mp3Path = "KITCHEN.mp3", TWIName = "Gyaade", TwiMp3Path = "GYAADE.mp3"},
                new LetterAModel { EnglishName = "Lion", Image = "lion.jpg", Mp3Path = "LION.mp3", TWIName = "Gyata", TwiMp3Path = "GYATA.mp3"},
                new LetterAModel { EnglishName = "Onion", Image = "onion.jpg", Mp3Path = "ONION.mp3", TWIName = "Gyeene", TwiMp3Path = "GYEENE.mp3"},
                new LetterAModel { EnglishName = "Stand", Image = "stand.jpg", Mp3Path = "STAND.mp3", TWIName = "Gyina", TwiMp3Path = "GYINA.mp3"},
                new LetterAModel { EnglishName = "Stand there", Image = "standthere.jpg", Mp3Path = "STANDTHERE.mp3", TWIName = "Gyina hᴐ", TwiMp3Path = "GYINAH).mp3"},
                new LetterAModel { EnglishName = "Stop", Image = "stop.png", Mp3Path = "STOP.mp3", TWIName = "Gyae", TwiMp3Path = "GYAE.mp3"},
                new LetterAModel { EnglishName = "Stop crying", Image = "stopcrying.png", Mp3Path = "STOPCRYING.mp3", TWIName = "Gyae su", TwiMp3Path = "GYAESU.mp3"},
                new LetterAModel { EnglishName = "Take", Image = "take.gif", Mp3Path = "TAKE.mp3", TWIName = "Gye", TwiMp3Path = "GYE.mp3"},
                new LetterAModel { EnglishName = "Torch", Image = "torch.jpg", Mp3Path = "TORCH.mp3", TWIName = "Gyatɛn", TwiMp3Path = "GYAT3N.mp3"},
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
