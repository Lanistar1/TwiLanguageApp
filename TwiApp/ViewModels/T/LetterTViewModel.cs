using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.T
{

    public class LetterTViewModel : INotifyPropertyChanged
    {
        private static LetterTViewModel instance;
        public static LetterTViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterTViewModel();
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

        public LetterTViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bottle", Image = "bottle.png", Mp3Path = "mouseplay.mp3", TWIName = "Toa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Car", Image = "car.png", Mp3Path = "spiderplay.mp3", TWIName = "Teaseɛnam", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cockroach", Image = "cockroach.png", Mp3Path = "rabbitplay.mp3", TWIName = "Tɛfrɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Drums", Image = "drums.png", Mp3Path = "birdplay.mp3", TWIName = "Twene", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Feather", Image = "feather.png", Mp3Path = "butterflyplay.mp3", TWIName = "Takra", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Jar", Image = "jar.png", Mp3Path = "eyesplay.mp3", TWIName = "Tumpan", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pen", Image = "pen.png", Mp3Path = "frogplay.mp3", TWIName = "Twerɛdua", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pencil", Image = "pencil.png", Mp3Path = "chickenplay.mp3", TWIName = "Twerɛdua", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Stamp", Image = "stamp.png", Mp3Path = "mangoplay.mp3", TWIName = "Timtim", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Tea", Image = "tea.png", Mp3Path = "monkeyplay.mp3", TWIName = "Tii", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Toffee", Image = "toffee.png", Mp3Path = "mouthplay.mp3", TWIName = "Tɔfe", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Toilet", Image = "toilet.png", Mp3Path = "pineplay.mp3", TWIName = "Tiafi", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Tongue", Image = "tongue.png", Mp3Path = "pineplay.mp3", TWIName = "Tɛkyerɛma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Write", Image = "write.png", Mp3Path = "pineplay.mp3", TWIName = "Twerε", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Writing board", Image = "writingboard.png", Mp3Path = "pineplay.mp3", TWIName = "Twerɛpono", TwiMp3Path = ""},
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
