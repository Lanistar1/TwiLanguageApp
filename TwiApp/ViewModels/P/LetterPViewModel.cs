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
                new LetterAModel { EnglishName = "Avocado / Pear", Image = "avocadopear.jpg", Mp3Path = "PEAR.mp3", TWIName = "Paya", TwiMp3Path = "PAYA.mp3"},
                new LetterAModel { EnglishName = "Bread", Image = "bread.jpg", Mp3Path = "bread.mp3", TWIName = "Paanoo", TwiMp3Path = "PAANOO.mp3"},
                new LetterAModel { EnglishName = "Broom", Image = "broom.jpg", Mp3Path = "BROOM.mp3", TWIName = "Praeɛ", TwiMp3Path = "PRAE3.mp3"},
                new LetterAModel { EnglishName = "Horse", Image = "horse.jpg", Mp3Path = "horse.mp3", TWIName = "Pɔnkɔ", TwiMp3Path = "P)NK).mp3"},
                new LetterAModel { EnglishName = "Hyena", Image = "hyena.gif", Mp3Path = "hyena.mp3", TWIName = "Pataku", TwiMp3Path = "pataku.mp3"},
                new LetterAModel { EnglishName = "Injury", Image = "injury.gif", Mp3Path = "INJURY.mp3", TWIName = "Pira", TwiMp3Path = "PIRA.mp3"},
                new LetterAModel { EnglishName = "Jockey", Image = "jockey.gif", Mp3Path = "JOCKEY.mp3", TWIName = "Pɔnkɔkafoɔ", TwiMp3Path = "P)NK)KAFO).mp3"},
                new LetterAModel { EnglishName = "Needle", Image = "needle.png", Mp3Path = "NEEDLE.mp3", TWIName = "Paneɛ", TwiMp3Path = "PANE3.mp3"},
                new LetterAModel { EnglishName = "Octopus", Image = "octopus.jpg", Mp3Path = "OCTOPUS.mp3", TWIName = "Posena", TwiMp3Path = "POSENA.mp3"},
                new LetterAModel { EnglishName = "Owl", Image = "owl.png", Mp3Path = "OWL.mp3", TWIName = "Patuo", TwiMp3Path = "PATUO.mp3"},
                new LetterAModel { EnglishName = "Pig", Image = "pig.jpg", Mp3Path = "PIG.mp3", TWIName = "Prako", TwiMp3Path = "PRAKO.mp3"},
                new LetterAModel { EnglishName = "Policeman", Image = "policeman.jpg", Mp3Path = "policeman.mp3", TWIName = "Polisini", TwiMp3Path = "polisini.mp3"},
                new LetterAModel { EnglishName = "Sweep", Image = "sweep.jpg", Mp3Path = "SWEEP.mp3", TWIName = "Pra", TwiMp3Path = "PRA.mp3"},
                new LetterAModel { EnglishName = "Table", Image = "table.jpg", Mp3Path = "TABLE.mp3", TWIName = "Pono", TwiMp3Path = "PONO.mp3"},
                new LetterAModel { EnglishName = "Pants", Image = "underpants.jpg", Mp3Path = "PANTS.mp3", TWIName = "Pioto", TwiMp3Path = "PIOTO.mp3"},
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
