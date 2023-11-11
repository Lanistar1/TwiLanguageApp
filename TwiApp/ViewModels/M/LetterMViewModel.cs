using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.M
{

    public class LetterMViewModel : INotifyPropertyChanged
    {
        private static LetterMViewModel instance;
        public static LetterMViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterMViewModel();
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

        public LetterMViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bamboo", Image = "bamboo.png", Mp3Path = "mouseplay.mp3", TWIName = "Mpampro", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Bed", Image = "bed.png", Mp3Path = "spiderplay.mp3", TWIName = "Mpa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Children", Image = "children.png", Mp3Path = "rabbitplay.mp3", TWIName = "Mmɔfra", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Cocoyam", Image = "cocoyam.png", Mp3Path = "birdplay.mp3", TWIName = "Mankani", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "First aid box", Image = "firstaidbox.png", Mp3Path = "butterflyplay.mp3", TWIName = "Mmoa adakaa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Horn", Image = "horn.png", Mp3Path = "eyesplay.mp3", TWIName = "Mmɛn", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Mushroom", Image = "mushroom.png", Mp3Path = "frogplay.mp3", TWIName = "Mmire", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Pepper", Image = "pepper.png", Mp3Path = "chickenplay.mp3", TWIName = "Mako", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Photo album", Image = "photoalbum.png", Mp3Path = "mangoplay.mp3", TWIName = "Mfonin Krataa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Shoe", Image = "shoe.png", Mp3Path = "monkeyplay.mp3", TWIName = "Mpaboa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Squeeze", Image = "squeeze.png", Mp3Path = "mouthplay.mp3", TWIName = "Mia", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Towel", Image = "towel.png", Mp3Path = "pineplay.mp3", TWIName = "Mpopaho", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Window", Image = "window.png", Mp3Path = "pineplay.mp3", TWIName = "Mpoma", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Windy", Image = "windy.png", Mp3Path = "pineplay.mp3", TWIName = "Mframa", TwiMp3Path = ""},
                new LetterAModel { EnglishName = "Zoo", Image = "zoo.png", Mp3Path = "pineplay.mp3", TWIName = "Mmoa turo", TwiMp3Path = ""},
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
