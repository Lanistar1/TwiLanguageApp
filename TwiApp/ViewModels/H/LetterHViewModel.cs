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
                new LetterAModel { EnglishName = "Arrange", Image = "arrange.jpg", Mp3Path = "ARRANGE.mp3", TWIName = "Hyehyɛ", TwiMp3Path = "HYEHY3.mp3"},
                new LetterAModel { EnglishName = "Blow", Image = "blow.png", Mp3Path = "BLOW.mp3", TWIName = "Hu", TwiMp3Path = "HU.mp3"},
                new LetterAModel { EnglishName = "Burn", Image = "burn.jpg", Mp3Path = "BURN.mp3", TWIName = "Hye", TwiMp3Path = "HYE.mp3"},
                new LetterAModel { EnglishName = "Hammer", Image = "hammer.gif", Mp3Path = "HAMMER.mp3", TWIName = "Hama", TwiMp3Path = "HAMA.mp3"},
                new LetterAModel { EnglishName = "Jump", Image = "jump.png", Mp3Path = "JUMP.mp3", TWIName = "Huri", TwiMp3Path = "HURI.mp3"},
                new LetterAModel { EnglishName = "Look", Image = "look.gif", Mp3Path = "LOOK.mp3", TWIName = "Hwɛ", TwiMp3Path = "HW3.mp3"},
                new LetterAModel { EnglishName = "Nose", Image = "nose.png", Mp3Path = "NOSE.mp3", TWIName = "Hwene", TwiMp3Path = "HWENE.mp3"},
                new LetterAModel { EnglishName = "Pour", Image = "pour.jpg", Mp3Path = "POUR.mp3", TWIName = "Hwie", TwiMp3Path = "HWIE.mp3"},
                new LetterAModel { EnglishName = "Put on Shirt", Image = "putonshirtclipart.jpg", Mp3Path = "PutonShirt.mp3", TWIName = "Hyɛ atade", TwiMp3Path = "Hy3ataade.mp3"},
                new LetterAModel { EnglishName = "Restart", Image = "restart.jpg", Mp3Path = "RESTART.mp3", TWIName = "Hyɛ aseɛ bio", TwiMp3Path = "HY3ASE3BIO.mp3"},
                new LetterAModel { EnglishName = "Shine", Image = "shine.png", Mp3Path = "Shine.mp3", TWIName = "Hyer3n", TwiMp3Path = "HYER3N.mp3"},
                new LetterAModel { EnglishName = "Smell", Image = "smell.jpg", Mp3Path = "SMELL.mp3", TWIName = "Hwia", TwiMp3Path = "HWIA.mp3"},
                new LetterAModel { EnglishName = "Start", Image = "start.jpg", Mp3Path = "START.mp3", TWIName = "Hyɛ aseɛ", TwiMp3Path = "HY3ASE3.mp3"},
                new LetterAModel { EnglishName = "Wobble", Image = "wobble.jpg", Mp3Path = "WOBBLE.mp3", TWIName = "Hinhim", TwiMp3Path = "HINHIM.mp3"},
                new LetterAModel { EnglishName = "Yawn", Image = "yawning.jpg", Mp3Path = "YAWN.mp3", TWIName = "Hram", TwiMp3Path = "HRAM.mp3"},
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
