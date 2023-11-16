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
                new LetterAModel { EnglishName = "Bottle", Image = "bottle.png", Mp3Path = "BOTTLE.mp3", TWIName = "Toa", TwiMp3Path = "TOA.mp3"},
                new LetterAModel { EnglishName = "Car", Image = "car.png", Mp3Path = "CAR.mp3", TWIName = "Teaseɛnam", TwiMp3Path = "TEASE3NAM.mp3"},
                new LetterAModel { EnglishName = "Cockroach", Image = "cockroach.png", Mp3Path = "COCKROACH.mp3", TWIName = "Tɛfrɛ", TwiMp3Path = "T3FR3.mp3"},
                new LetterAModel { EnglishName = "Drums", Image = "drums.png", Mp3Path = "DRUMS.mp3", TWIName = "Twene", TwiMp3Path = "TWENE.mp3"},
                new LetterAModel { EnglishName = "Feather", Image = "feather.png", Mp3Path = "FEATHER.mp3", TWIName = "Takra", TwiMp3Path = "TAKRA.mp3"},
                new LetterAModel { EnglishName = "Jar", Image = "jar.png", Mp3Path = "JAR.mp3", TWIName = "Tumpan", TwiMp3Path = "TUMPAN.mp3"},
                new LetterAModel { EnglishName = "Pen", Image = "pen.png", Mp3Path = "PEN.mp3", TWIName = "Twerɛdua", TwiMp3Path = "TWER3DUA.mp3"},
                new LetterAModel { EnglishName = "Pencil", Image = "pencil.png", Mp3Path = "PENCIL.mp3", TWIName = "Twerɛdua", TwiMp3Path = "TWER3DUA.mp3"},
                new LetterAModel { EnglishName = "Stamp", Image = "stamp.png", Mp3Path = "STAMP.mp3", TWIName = "Tim", TwiMp3Path = "TIM.mp3"},
                new LetterAModel { EnglishName = "Tea", Image = "tea.png", Mp3Path = "TEA.mp3", TWIName = "Tii", TwiMp3Path = "TII.mp3"},
                new LetterAModel { EnglishName = "Toffee", Image = "toffee.png", Mp3Path = "TOFFEE.mp3", TWIName = "Tɔfe", TwiMp3Path = "T)FE.mp3"},
                new LetterAModel { EnglishName = "Toilet", Image = "toilet.png", Mp3Path = "TOILET.mp3", TWIName = "Tiafi", TwiMp3Path = "TIAFI.mp3"},
                new LetterAModel { EnglishName = "Tongue", Image = "tongue.png", Mp3Path = "TONGUE.mp3", TWIName = "Tɛkyerɛma", TwiMp3Path = "T3KYER3MA.mp3"},
                new LetterAModel { EnglishName = "Write", Image = "write.png", Mp3Path = "WRITE.mp3", TWIName = "Twerε", TwiMp3Path = "TWER3.mp3"},
                new LetterAModel { EnglishName = "Writing board", Image = "writingboard.png", Mp3Path = "WRITINGBOARD.mp3", TWIName = "Twerɛpono", TwiMp3Path = "TWER3PONO.mp3"},
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
