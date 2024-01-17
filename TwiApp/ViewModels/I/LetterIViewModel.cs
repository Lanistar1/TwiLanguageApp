using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.I
{
    public class LetterIViewModel : INotifyPropertyChanged
    {
        private static LetterIViewModel instance;
        public static LetterIViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterIViewModel();
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

        public LetterIViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Ask", Image = "ask.png", Mp3Path = "ASK.mp3", TWIName = "Bisa", TwiMp3Path = "BISA.mp3"},
                new LetterAModel { EnglishName = "Bicycle", Image = "bycicle.jpg", Mp3Path = "BICYCLE.mp3", TWIName = "Basikere", TwiMp3Path = "BASIKERE.mp3"},
                new LetterAModel { EnglishName = "Happy New Year", Image = "chrismas.jpg", Mp3Path = "HAPPYNEWYEAR.mp3", TWIName = "Afehyiapa", TwiMp3Path = "AFEHYIAPA.mp3"},
                new LetterAModel { EnglishName = "Cocoyam", Image = "cocoyam.jpg", Mp3Path = "COCOYAM.mp3", TWIName = "Mankani", TwiMp3Path = "MANKANI.mp3"},
                new LetterAModel { EnglishName = "Eat", Image = "eat.png", Mp3Path = "EAT.mp3", TWIName = "Didi", TwiMp3Path = "DIDI.mp3"},
                new LetterAModel { EnglishName = "Eyebrow", Image = "eyebrow3.jpg", Mp3Path = "EYEBROW.mp3", TWIName = "Aniakyinwi", TwiMp3Path = "ANIAKYNWI.mp3"},
                new LetterAModel { EnglishName = "greet", Image = "greet.jpg", Mp3Path = "GREET.mp3", TWIName = "Kyea", TwiMp3Path = "KYEA.mp3"},
                new LetterAModel { EnglishName = "Jump", Image = "jump.png", Mp3Path = "JUMP.mp3", TWIName = "Huri", TwiMp3Path = "HURI.mp3"},
                new LetterAModel { EnglishName = "Meeting", Image = "meeting.jpg", Mp3Path = "MEETING.mp3", TWIName = "Nhyiamu", TwiMp3Path = "NHYIAMU.mp3"},
                new LetterAModel { EnglishName = "Occiput", Image = "occiput.jpg", Mp3Path = "OCCIPUT.mp3", TWIName = "Atikɔ", TwiMp3Path = "ATIK).mp3"},
                new LetterAModel { EnglishName = "Shoulder", Image = "shoulder.jpg", Mp3Path = "SHOULDER.mp3", TWIName = "Abɛtiri", TwiMp3Path = "AB3TIRI.mp3"},
                new LetterAModel { EnglishName = "Squeeze", Image = "squeeze.jpg", Mp3Path = "SQUEEZE.mp3", TWIName = "Mia", TwiMp3Path = "MIA.mp3"},
                new LetterAModel { EnglishName = "Sugar", Image = "sugar.jpg", Mp3Path = "SUGAR.mp3", TWIName = "Asikyire", TwiMp3Path = "ASIKYIRE.mp3"},
                new LetterAModel { EnglishName = "Poor person", Image = "poorman.jpg", Mp3Path = "POORPERSON.mp3", TWIName = "Ohiani", TwiMp3Path = "OHINANI.mp3"},
                new LetterAModel { EnglishName = "Sun", Image = "sun.jpg", Mp3Path = "SUN.mp3", TWIName = "Awia ", TwiMp3Path = "AWIA.mp3"},
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
