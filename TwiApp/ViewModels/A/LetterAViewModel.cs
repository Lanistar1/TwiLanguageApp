using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TwiApp.Models.A;
using Xamarin.Forms;

namespace TwiApp.ViewModels.A
{

    public class LetterAViewModel : INotifyPropertyChanged
    {
        private static LetterAViewModel instance;
        public static LetterAViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterAViewModel();
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

        public LetterAViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Mouse", Image = "mouse.png", Mp3Path = "MOUSE.mp3", TWIName = "Akura", TwiMp3Path = "AKURA.mp3"},
                new LetterAModel { EnglishName = "Spider", Image = "spider.png", Mp3Path = "SPIDER.mp3", TWIName = "Ananse", TwiMp3Path = "ANANSE.mp3"},
                new LetterAModel { EnglishName = "Rabbit", Image = "rabbit.png", Mp3Path = "RABBIT.mp3", TWIName = "Adanko", TwiMp3Path = "ADANKO.mp3"},
                new LetterAModel { EnglishName = "Bird", Image = "Bird.png", Mp3Path = "BIRD.mp3", TWIName = "Anomaa", TwiMp3Path = "ANOMAA.mp3"},
                new LetterAModel { EnglishName = "Butterfly", Image = "butterfly2.png", Mp3Path = "BUTTERFLY.mp3", TWIName = "Afrafrant", TwiMp3Path = "AFRAFRANT).mp3"},
                new LetterAModel { EnglishName = "Eyes", Image = "eye2.png", Mp3Path = "EYES.mp3", TWIName = "Ani", TwiMp3Path = "ANI.mp3"},
                new LetterAModel { EnglishName = "Frog", Image = "frog2.png", Mp3Path = "FROG.mp3", TWIName = "Apɔtrɔ", TwiMp3Path = "AP)TR).mp3"},
                new LetterAModel { EnglishName = "Chicken", Image = "chicken.png", Mp3Path = "CHICKEN.mp3", TWIName = "Akokɔ", TwiMp3Path = "AKOK).mp3"},
                new LetterAModel { EnglishName = "Mango", Image = "mango2.png", Mp3Path = "MANGO.mp3", TWIName = "Amango", TwiMp3Path = "AMANGO.mp3"},
                new LetterAModel { EnglishName = "Monkey", Image = "monkey2.png", Mp3Path = "MONKEY.mp3", TWIName = "Adoe", TwiMp3Path = "ADOE.mp3"},
                new LetterAModel { EnglishName = "Mouth", Image = "mouth2.png", Mp3Path = "MOUTH.mp3", TWIName = "Ano", TwiMp3Path = "ANO.mp3"},
                new LetterAModel { EnglishName = "Pineapple", Image = "pine.png", Mp3Path = "PINEAPPLE.mp3", TWIName = "Abrɔbɛ", TwiMp3Path = "ABR)B3.mp3"},
                new LetterAModel { EnglishName = "Chair", Image = "chair.png", Mp3Path = "CHAIR.mp3", TWIName = "Akonnwa", TwiMp3Path = "AKONNWA.mp3"},
                new LetterAModel { EnglishName = "Orange", Image = "orange2.png", Mp3Path = "ORANGE.mp3", TWIName = "Ankaa", TwiMp3Path = "ANKAA.mp3"},
                new LetterAModel { EnglishName = "Scissors", Image = "scissor2.png", Mp3Path = "SCISSORS.mp3", TWIName = "Apasoᴐ", TwiMp3Path = "APASO).mp3"},
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
