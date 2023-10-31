using System;
using System.Collections.Generic;
using System.Text;
using TwiApp.ViewModels;

namespace TwiApp.Models
{

    public class MoreModel : BaseViewModel
    {
        public string Name { get; set; }
        public bool isSelected { get; set; }

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
