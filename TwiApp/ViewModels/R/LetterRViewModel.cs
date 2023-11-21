using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.R
{

    public class LetterRViewModel : INotifyPropertyChanged
    {
        private static LetterRViewModel instance;
        public static LetterRViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterRViewModel();
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

        public LetterRViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Boss", Image = "boss.png", Mp3Path = "boss.mp3", TWIName = "Adwumawura", TwiMp3Path = "adwumawura.mp3"},
                new LetterAModel { EnglishName = "Broom", Image = "broom.png", Mp3Path = "BROOM.mp3", TWIName = "praeɛ", TwiMp3Path = "PRAE3.mp3"},
                new LetterAModel { EnglishName = "Calendar", Image = "calendar.png", Mp3Path = "calendar.mp3", TWIName = "Asranna", TwiMp3Path = "asranna.mp3"},
                new LetterAModel { EnglishName = "Call", Image = "call.png", Mp3Path = "CALL.mp3", TWIName = "Frɛ", TwiMp3Path = "FR3.mp3"},
                new LetterAModel { EnglishName = "Cat", Image = "cat.png", Mp3Path = "CAT.mp3", TWIName = "Ɔkra", TwiMp3Path = ")KRA.mp3"},
                new LetterAModel { EnglishName = "Child", Image = "child.png", Mp3Path = "child.mp3", TWIName = "Abɔfra", TwiMp3Path = "abofra.mp3"},
                new LetterAModel { EnglishName = "Come", Image = "come.png", Mp3Path = "COME.mp3", TWIName = "Bra", TwiMp3Path = "BRA.mp3"},
                new LetterAModel { EnglishName = "Playground", Image = "field.png", Mp3Path = "PLAYGROUND.mp3", TWIName = "Agoprama so", TwiMp3Path = "Agopramaso.mp3"},
                new LetterAModel { EnglishName = "Hawk", Image = "halk.png", Mp3Path = "HAWK.mp3", TWIName = "Akoroma", TwiMp3Path = "AKOROMA.mp3"},
                new LetterAModel { EnglishName = "Laughter", Image = "laugh.png", Mp3Path = "laughter.mp3", TWIName = "Sereɛ", TwiMp3Path = "sere3.mp3"},
                new LetterAModel { EnglishName = "Pawpaw", Image = "pawpaw.png", Mp3Path = "PAWPAW.mp3", TWIName = "Bɔfrɛ", TwiMp3Path = "BOR)FER3.mp3"},
                new LetterAModel { EnglishName = "Pineapple", Image = "pineapple.png", Mp3Path = "PINEAPPLE.mp3", TWIName = "Abrɔbɛ", TwiMp3Path = "ABR)B3.mp3"},
                new LetterAModel { EnglishName = "Turkey", Image = "turkey.png", Mp3Path = "turkey.mp3", TWIName = "Kurokurokoko", TwiMp3Path = "krokrokoko.mp3"},
                new LetterAModel { EnglishName = "Wind", Image = "wind.png", Mp3Path = "WIND.mp3", TWIName = "Mframa", TwiMp3Path = "MFRAMA.mp3"},
                new LetterAModel { EnglishName = "Yam", Image = "yam.png", Mp3Path = "YAM.mp3", TWIName = "Bayerɛ", TwiMp3Path = "BAYER3.mp3"},
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
