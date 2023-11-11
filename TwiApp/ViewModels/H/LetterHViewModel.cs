using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.H
{

    public class LetterHViewModel : INotifyPropertyChanged
    {
        private static LetterHViewModel instance;
        public static LetterHViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterHViewModel();
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

        public LetterHViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Arrange", Image = "arrange.png", Mp3Path = "mouseplay.mp3", TWIName = "Hyehyɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Blow", Image = "blow.png", Mp3Path = "spiderplay.mp3", TWIName = "Hu", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Burn", Image = "burn.png", Mp3Path = "rabbitplay.mp3", TWIName = "Hye", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Hammer", Image = "hammer.png", Mp3Path = "birdplay.mp3", TWIName = "Hama", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Jump", Image = "jump.png", Mp3Path = "butterflyplay.mp3", TWIName = "Huri", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Look", Image = "look.png", Mp3Path = "eyesplay.mp3", TWIName = "Hwɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Nose", Image = "nose.png", Mp3Path = "frogplay.mp3", TWIName = "Hwene", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pour", Image = "pour.png", Mp3Path = "chickenplay.mp3", TWIName = "Hwie", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Put on shirt clip art", Image = "putonshirtclipart.png", Mp3Path = "mangoplay.mp3", TWIName = "Hyɛ atade", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Restart", Image = "restart.png", Mp3Path = "monkeyplay.mp3", TWIName = "Hyɛ ase bio", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Shine", Image = "shine.png", Mp3Path = "mouthplay.mp3", TWIName = "Hyer3n", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Smell", Image = "smell.png", Mp3Path = "pineplay.mp3", TWIName = "Hwia", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Start", Image = "start.png", Mp3Path = "pineplay.mp3", TWIName = "Hyɛ aseɛ", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Wobble", Image = "wobble.png", Mp3Path = "pineplay.mp3", TWIName = "Himhim", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Yawning", Image = "yawning.png", Mp3Path = "pineplay.mp3", TWIName = "Hram", TwiMp3Path = ""},
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
