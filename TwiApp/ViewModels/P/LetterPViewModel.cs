using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.P
{

    public class LetterPViewModel : INotifyPropertyChanged
    {
        private static LetterPViewModel instance;
        public static LetterPViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterPViewModel();
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

        public LetterPViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Avocadopear", Image = "avocadopear.png", Mp3Path = "mouseplay.mp3", TWIName = "Paya", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Bread", Image = "bread.png", Mp3Path = "spiderplay.mp3", TWIName = "Paanoo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Broom", Image = "broom.png", Mp3Path = "rabbitplay.mp3", TWIName = "Praeɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Horse", Image = "horse.png", Mp3Path = "birdplay.mp3", TWIName = "Pɔnkɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hyena", Image = "hyena.png", Mp3Path = "butterflyplay.mp3", TWIName = "Pataku", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Injury", Image = "injury.png", Mp3Path = "eyesplay.mp3", TWIName = "Piri", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Jockey", Image = "jockey.png", Mp3Path = "frogplay.mp3", TWIName = "Pɔnkɔkafoɔ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Needle", Image = "needle.png", Mp3Path = "chickenplay.mp3", TWIName = "Paneɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Octopus", Image = "octopus.png", Mp3Path = "mangoplay.mp3", TWIName = "Posena", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Owl", Image = "owl.png", Mp3Path = "monkeyplay.mp3", TWIName = "Patuo", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pig", Image = "pig.png", Mp3Path = "mouthplay.mp3", TWIName = "Prako", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Policeman", Image = "policeman.png", Mp3Path = "pineplay.mp3", TWIName = "Polisini", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Sweep", Image = "sweep.png", Mp3Path = "pineplay.mp3", TWIName = "Pra", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Table", Image = "table.png", Mp3Path = "pineplay.mp3", TWIName = "Pono", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Underpants", Image = "underpants.png", Mp3Path = "pineplay.mp3", TWIName = "Pioto", TwiMp3Path = ""},
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
