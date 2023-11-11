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
                new LetterAModel { EnglishName = "Bonfire", Image = "bonfire.png", Mp3Path = "mouseplay.mp3", TWIName = "Gyatanaa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Charcoal", Image = "charcoal.png", Mp3Path = "spiderplay.mp3", TWIName = "Gyabidie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fire", Image = "fire.png", Mp3Path = "rabbitplay.mp3", TWIName = "Gya", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Firewood", Image = "firewood.png", Mp3Path = "birdplay.mp3", TWIName = "Gyentia", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Garri", Image = "Gari.png", Mp3Path = "butterflyplay.mp3", TWIName = "Gari", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hurricane", Image = "hurricane.png", Mp3Path = "eyesplay.mp3", TWIName = "Gyampanturudu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Kitchen", Image = "kitchen.png", Mp3Path = "frogplay.mp3", TWIName = "Gyaade", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Lion", Image = "lion.png", Mp3Path = "chickenplay.mp3", TWIName = "Gyata", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Onion", Image = "onion.png", Mp3Path = "mangoplay.mp3", TWIName = "Gyeene", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Stand", Image = "stand.png", Mp3Path = "monkeyplay.mp3", TWIName = "Gyina", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Standthere", Image = "standthere.png", Mp3Path = "mouthplay.mp3", TWIName = "Gyina h)", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Stop", Image = "stop.png", Mp3Path = "pineplay.mp3", TWIName = "Gyae", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Stop crying", Image = "stopcrying.png", Mp3Path = "pineplay.mp3", TWIName = "Gyae su", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Take", Image = "take.png", Mp3Path = "pineplay.mp3", TWIName = "Gye", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Torch", Image = "torch.png", Mp3Path = "pineplay.mp3", TWIName = "Gyatɛn", TwiMp3Path = ""},
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
