using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwiApp.Models.A;
using TwiApp.ViewModels.A;

namespace TwiApp.ViewModels.c
{

    public class LetterCViewModel : INotifyPropertyChanged
    {
        private static LetterCViewModel instance;
        public static LetterCViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LetterCViewModel();
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

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private int currentIndex;

        public LetterCViewModel()
        {
            // Initialize your content list
            ContentList = new List<LetterAModel>
            {
                new LetterAModel { EnglishName = "Eagle", Image = "baldeagle.png", Mp3Path = "EAGLE.mp3", TWIName = "ɔkɔdeɛ", TwiMp3Path = ")K)DE3.mp3"},
                new LetterAModel { EnglishName = "Cat", Image = "cat.png", Mp3Path = "CAT.mp3", TWIName = "ɔkra", TwiMp3Path = ")KRA.mp3"},
                new LetterAModel { EnglishName = "Clock", Image = "clock.png", Mp3Path = "CLOCK.mp3", TWIName = "ɔdɔn", TwiMp3Path = ")D)N.mp3"},
                new LetterAModel { EnglishName = "Deer", Image = "deer.png", Mp3Path = "DEER.mp3", TWIName = "ɔforoteɛ", TwiMp3Path = ")FOROTE3.mp3"},
                new LetterAModel { EnglishName = "Duiker", Image = "duiker.png", Mp3Path = "DUIKER.mp3", TWIName = "ɔtwe", TwiMp3Path = ")TWE.mp3"},
                new LetterAModel { EnglishName = "Elephant", Image = "elephant.png", Mp3Path = "ELEPHANT.mp3", TWIName = "ɔsono", TwiMp3Path = ")SONO.mp3"},
                new LetterAModel { EnglishName = "Hunter", Image = "Hunter.png", Mp3Path = "HUNTER.mp3", TWIName = "ɔbɔmmɔfoɔ", TwiMp3Path = ")B)FO).mp3"},
                new LetterAModel { EnglishName = "Lazy", Image = "lazy.png", Mp3Path = "Lazy.mp3", TWIName = "ɔkwadwofoɔ", TwiMp3Path = ")KWADWOFO).mp3"},
                new LetterAModel { EnglishName = "Mason", Image = "Mason.png", Mp3Path = "MASON.mp3", TWIName = "ɔdansifoɔ", TwiMp3Path = ")DANSIFO).mp3"},
                new LetterAModel { EnglishName = "Priest", Image = "Priest.png", Mp3Path = "PRIEST.mp3", TWIName = "ɔsofo", TwiMp3Path = ")S)FO.mp3"},
                new LetterAModel { EnglishName = "Queen", Image = "Queen.png", Mp3Path = "QUEEN.mp3", TWIName = "ɔhemaa", TwiMp3Path = ")HEMAA.mp3"},
                new LetterAModel { EnglishName = "Rock", Image = "rock.png", Mp3Path = "ROCK.mp3", TWIName = "ɔbotan", TwiMp3Path = ")BOTAN.mp3"},
                new LetterAModel { EnglishName = "Snake", Image = "snake.png", Mp3Path = "SNAKE.mp3", TWIName = "ɔwɔ", TwiMp3Path = ")w).mp3"},
                new LetterAModel { EnglishName = "Soldier", Image = "soldier.png", Mp3Path = "SOLDIER.mp3", TWIName = "ɔsraani", TwiMp3Path = ")SRAANI.mp3"},
                new LetterAModel { EnglishName = "Teacher", Image = "teacher.png", Mp3Path = "TEACHER.mp3", TWIName = "ɔkyerɛkyerɛni", TwiMp3Path = ")KYER3KYER3NI.mp3"},
            };
            currentIndex = 0;
            SelectedContent = ContentList.FirstOrDefault();

            Title = "Letter Ↄ";

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
