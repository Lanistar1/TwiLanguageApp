using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.D
{
    public class LetterDViewModel : INotifyPropertyChanged
    {
        private static LetterDViewModel instance;
        public static LetterDViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterDViewModel();
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

        public LetterDViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bell", Image = "bell.png", Mp3Path = "mouseplay.mp3", TWIName = "Dɔn", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Bone", Image = "Bone.png", Mp3Path = "spiderplay.mp3", TWIName = "Dompe", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cauldron", Image = "cauldron.png", Mp3Path = "rabbitplay.mp3", TWIName = "Dadesɛn", TwiMp3Path = "" },
                new LetterAModel { EnglishName = "Crocodile", Image = "crocodile.png", Mp3Path = "birdplay.mp3", TWIName = "Dɛnkyɛm", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "ɔyaresafoɔ", Image = "handleme.png", Mp3Path = "butterflyplay.mp3", TWIName = "Dɔkota", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Dining table", Image = "diningtable.png", Mp3Path = "eyesplay.mp3", TWIName = "Didipono", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Duck", Image = "duck.png", Mp3Path = "frogplay.mp3", TWIName = "Dabodabo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Eat", Image = "eat.png", Mp3Path = "chickenplay.mp3", TWIName = "Didi", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Fish hook", Image = "fishhook.png", Mp3Path = "mangoplay.mp3", TWIName = "Darewa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Kenkey", Image = "kenkey.png", Mp3Path = "monkeyplay.mp3", TWIName = "Dɔkono", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Metal", Image = "metal.png", Mp3Path = "mouthplay.mp3", TWIName = "Dadeɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Nail", Image = "nail.png", Mp3Path = "pineplay.mp3", TWIName = "Dadewa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Newspaper", Image = "newspaper.png", Mp3Path = "pineplay.mp3", TWIName = "Dawaurobɔ krataa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Noise", Image = "noise.png", Mp3Path = "pineplay.mp3", TWIName = "Dede", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Tree", Image = "tree.png", Mp3Path = "pineplay.mp3", TWIName = "Dua", TwiMp3Path = ""},
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
