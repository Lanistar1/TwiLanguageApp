using System;
using System.Collections.Generic;
using System.Text;
using TwiApp.ViewModels;

namespace TwiApp.Models.A
{
    public class LetterAModel : BaseViewModel
    {
        public string EnglishName { get; set; }
        public string TWIName { get; set; }
        public string Mp3Path { get; set; }
        public string TwiMp3Path { get; set; }

        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
    }
}
