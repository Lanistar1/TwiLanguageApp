using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.K
{

    public class LetterKViewModel : INotifyPropertyChanged
    {
        private static LetterKViewModel instance;
        public static LetterKViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterKViewModel();
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

        public LetterKViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Banana", Image = "banana.png", Mp3Path = "BANANA.mp3", TWIName = "Kwadu", TwiMp3Path = "KWADU.mp3"},
                new LetterAModel { EnglishName = "Basket", Image = "basket.png", Mp3Path = "BASKET.mp3", TWIName = "Kɛntɛn", TwiMp3Path = "K3NT3N.mp3"},
                new LetterAModel { EnglishName = "Cocoa", Image = "cocoa.png", Mp3Path = "COCOA.mp3", TWIName = "Kookoo", TwiMp3Path = "KOOKOO.mp3"},
                new LetterAModel { EnglishName = "Coconut", Image = "coconut.png", Mp3Path = "COCONUT.mp3", TWIName = "Kube", TwiMp3Path = "KUBE.mp3"},
                new LetterAModel { EnglishName = "Coconut tree", Image = "coconuttree.png", Mp3Path = "COCONUTTREE.mp3", TWIName = "Kube dua", TwiMp3Path = "KUBEDUA.mp3"},
                new LetterAModel { EnglishName = "Cup", Image = "cup.png", Mp3Path = "CUP.mp3", TWIName = "Kuruwa", TwiMp3Path = "KURUWA.mp3"},
                new LetterAModel { EnglishName = "Dog", Image = "dog.png", Mp3Path = "DOG.mp3", TWIName = "Kraman", TwiMp3Path = "KRAMAN.mp3"},
                new LetterAModel { EnglishName = "Egg", Image = "egg.png", Mp3Path = "EGG.mp3", TWIName = "Kosua", TwiMp3Path = "KOSUA.mp3"},
                new LetterAModel { EnglishName = "Fox", Image = "fox.png", Mp3Path = "FOX.mp3", TWIName = "Krada", TwiMp3Path = "KRADA.mp3"},
                new LetterAModel { EnglishName = "Lightbulb", Image = "lightbulb.png", Mp3Path = "LIGHTBULB.mp3", TWIName = "Kanea", TwiMp3Path = "KANEA.mp3"},
                new LetterAModel { EnglishName = "Porcupine", Image = "porcupine.png", Mp3Path = "POCUPINE.mp3", TWIName = "kɔtɔkɔ", TwiMp3Path = "K)T)K).mp3"},
                new LetterAModel { EnglishName = "Ring", Image = "ring.png", Mp3Path = "RING.mp3", TWIName = "Kawa", TwiMp3Path = "KAWA.mp3"},
                new LetterAModel { EnglishName = "Television", Image = "television.png", Mp3Path = "TELEVISION.mp3", TWIName = "kasamfoni", TwiMp3Path = "KASAMFONI.mp3"},
                new LetterAModel { EnglishName = "Umbrella", Image = "umbrella.png", Mp3Path = "UMBRELLA.mp3", TWIName = "Kyiniiɛ", TwiMp3Path = "KYINII3.mp3"},
                new LetterAModel { EnglishName = "Wasp", Image = "wasp.png", Mp3Path = "WASP.mp3", TWIName = "Kotokurodu", TwiMp3Path = "KOTOKURODU.mp3"},
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
