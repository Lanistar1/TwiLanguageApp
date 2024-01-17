using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.D
{
    public class LetterDViewModel : INotifyPropertyChanged
    {
        private static LetterDViewModel instance;
        public static LetterDViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterDViewModel();
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

        public LetterDViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Bell", Image = "bell.jpg", Mp3Path = "BELL.mp3", TWIName = "Dɔn", TwiMp3Path = "D)N.mp3"},
                new LetterAModel { EnglishName = "Bone", Image = "Bone.png", Mp3Path = "BONE.mp3", TWIName = "Dompe", TwiMp3Path = "DOMPE.mp3"},
                new LetterAModel { EnglishName = "Cauldron", Image = "cauldron.jpg", Mp3Path = "CAULDRON.mp3", TWIName = "Dadesɛn", TwiMp3Path = "DADESEN.mp3" },
                new LetterAModel { EnglishName = "Crocodile", Image = "crocodile.png", Mp3Path = "CROCODILE.mp3", TWIName = "Dɛnkyɛm", TwiMp3Path = "D3NKY3M.mp3"},
                new LetterAModel { EnglishName = "Doctor", Image = "handleme.jpg", Mp3Path = "DOCTOR.mp3", TWIName = "ᴐyaresafoᴐ/dᴐkota", TwiMp3Path = "DOKOTA.mp3"},
                new LetterAModel { EnglishName = "Dining table", Image = "diningtable.jpg", Mp3Path = "DININGTABLE.mp3", TWIName = "Didi pono", TwiMp3Path = "DIDIPONO.mp3"},
                new LetterAModel { EnglishName = "Duck", Image = "duck.jpg", Mp3Path = "DUCK.mp3", TWIName = "Dabodabo", TwiMp3Path = "DABODABO.mp3"},
                new LetterAModel { EnglishName = "Eat", Image = "eat.png", Mp3Path = "EAT.mp3", TWIName = "Didi", TwiMp3Path = "DIDI.mp3"},
                new LetterAModel { EnglishName = "Fish hook", Image = "fishhook.jpg", Mp3Path = "FISHHOOK.mp3", TWIName = "Darewa", TwiMp3Path = "DAREWA.mp3"},
                new LetterAModel { EnglishName = "Kenkey", Image = "kenkey.jpg", Mp3Path = "KENKEY.mp3", TWIName = "Dɔkono", TwiMp3Path = "D)KONO.mp3"},
                new LetterAModel { EnglishName = "Metal", Image = "metal.png", Mp3Path = "METAL.mp3", TWIName = "Dadeɛ", TwiMp3Path = "DADE3.mp3"},
                new LetterAModel { EnglishName = "Nail", Image = "nail.jpg", Mp3Path = "NAIL.mp3", TWIName = "Dadewa", TwiMp3Path = "DADEWA.mp3"},
                new LetterAModel { EnglishName = "Newspaper", Image = "newspaper.jpg", Mp3Path = "NEWSPAPER.mp3", TWIName = "Dawaurobɔ krataa", TwiMp3Path = "DAWUROBOKRATAA.mp3"},
                new LetterAModel { EnglishName = "Noise", Image = "noise.png", Mp3Path = "NOISE.mp3", TWIName = "Dede", TwiMp3Path = "DEDE.mp3"},
                new LetterAModel { EnglishName = "Tree", Image = "tree.JPG", Mp3Path = "TREE.mp3", TWIName = "Dua", TwiMp3Path = "DUA.mp3"},
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
