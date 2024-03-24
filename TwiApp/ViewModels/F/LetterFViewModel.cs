using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.F
{
    public class LetterFViewModel : INotifyPropertyChanged
    {
        private static LetterFViewModel instance;
        public static LetterFViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterFViewModel();
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

        public LetterFViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Beautiful", Image = "beautiful.jpg", Mp3Path = "BEAUTIFUL.mp3", TWIName = "Fɛfɛɛfɛ", TwiMp3Path = "FEEFEEFE.mp3"},
                new LetterAModel { EnglishName = "Bring it", Image = "bring.gif", Mp3Path = "BRINGIT.mp3", TWIName = "Fa bra", TwiMp3Path = "FABRA.mp3"},
                new LetterAModel { EnglishName = "Call", Image = "call.jpg", Mp3Path = "CALL.mp3", TWIName = "frɛ ", TwiMp3Path = "FR3.mp3"},
                new LetterAModel { EnglishName = "Flag", Image = "flag.jpg", Mp3Path = "FLAG.mp3", TWIName = "Frankaa", TwiMp3Path = "FRANKAA.mp3"},
                new LetterAModel { EnglishName = "Forgive", Image = "forgive.gif", Mp3Path = "FORGIVE.mp3", TWIName = "Fa kyɛ", TwiMp3Path = "FAKY3.mp3"},
                new LetterAModel { EnglishName = "Fufu", Image = "fufu.png", Mp3Path = "FUFU.mp3", TWIName = "Fufuo", TwiMp3Path = "FUFUO.mp3"},
                new LetterAModel { EnglishName = "Take", Image = "gift.jpg", Mp3Path = "TAKE.mp3", TWIName = "Fa", TwiMp3Path = "FA.mp3"},
                new LetterAModel { EnglishName = "Hand over", Image = "handover.png", Mp3Path = "HANDOVER.mp3", TWIName = "Fa Ma", TwiMp3Path = "FAMA.mp3"},
                new LetterAModel { EnglishName = "Miner", Image = "miner.jpg", Mp3Path = "MINER.mp3", TWIName = "Fagudeɛtuni", TwiMp3Path = "FAGUDE3TUNI.mp3"},
                new LetterAModel { EnglishName = "Oven", Image = "oven.jpg", Mp3Path = "OVEN.mp3", TWIName = "Fononoo", TwiMp3Path = "FONONOO.mp3"},
                new LetterAModel { EnglishName = "Put inside", Image = "putinside.jpg", Mp3Path = "PUTINSIDE.mp3", TWIName = "Fa to mu", TwiMp3Path = "FATOMU.mp3"},
                new LetterAModel { EnglishName = "Show", Image = "show.png", Mp3Path = "SHOW.mp3", TWIName = "Fa kyerɛ", TwiMp3Path = "FAKYER3.mp3"},
                new LetterAModel { EnglishName = "Take it Away", Image = "takeaway.jpg", Mp3Path = "TAKEITAWAY.mp3", TWIName = "Fa kɔ", TwiMp3Path = "FAK).mp3"},
                new LetterAModel { EnglishName = "Trap", Image = "trap.jpg", Mp3Path = "TRAP.mp3", TWIName = "Fidie", TwiMp3Path = "FIDIE.mp3"},
                new LetterAModel { EnglishName = "White", Image = "whiteimage.png", Mp3Path = "WHITE.mp3", TWIName = "Fitaa", TwiMp3Path = "FITAA.mp3"},
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
