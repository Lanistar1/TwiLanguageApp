using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiApp.Models;
using TwiApp.Models.A;
using TwiApp.Views.Home;
using TwiApp.Views.More;
using Xamarin.Forms;

namespace TwiApp.ViewModels
{
    public class MoreViewmodel : BaseViewModel
    {
        private List<MoreModel> contentList;
        public List<MoreModel> ContentList
        {
            get => contentList;
            set
            {
                contentList = value;
                OnPropertyChanged(nameof(ContentList));
            }
        }

        private List<MoreModel> selectedItems;
        public List<MoreModel> SelectedItems
        {
            get => selectedItems;
            set
            {
                selectedItems = value;
                OnPropertyChanged(nameof(SelectedItems));
            }
        }

        public MoreViewmodel(INavigation navigation)
        {
            Navigation = navigation;

            // Initialize your content list
            ContentList = new List<MoreModel>
            {
                new MoreModel { Name = "Greetings", Image = "greeting.png"},
                new MoreModel { Name = "Fruits", Image = "fruit.png"},
                new MoreModel { Name = "Animals", Image = "animal.png"},
                new MoreModel { Name = "Human", Image = "human.png"},
                new MoreModel { Name = "Days", Image = "days.png"},
                new MoreModel { Name = "Colors", Image = "closure.png"},
                new MoreModel { Name = "Family", Image = "family.png"},
                new MoreModel { Name = "Numbers", Image = "numbers.png"},
                new MoreModel { Name = "Introduction", Image = "intro.png"},
                new MoreModel { Name = "Pronouns", Image = "pronoun.png"},
                new MoreModel { Name = "Human body", Image = "body.png"},
             
            };

            TappedCommand = new Command<MoreModel>(async (model) => await GetTappedExecute(model));

        }

        public Command TappedCommand { get; }


        private async Task GetTappedExecute(MoreModel model)
        {
            try
            {
                if (model.Name.Contains("Greetings"))
                {

                    await Navigation.PushAsync(new GreetingPage());

                }
                else if(model.Name.Contains("Fruits"))
                {
                    await Navigation.PushAsync(new VegetablePage());
                }
                else if (model.Name.Contains("Animals"))
                {
                    await Navigation.PushAsync(new AnimalPage());
                }
                else if (model.Name.Contains("Human"))
                {
                    await Navigation.PushAsync(new HumanPage());
                }
                else if (model.Name.Contains("Days"))
                {
                    await Navigation.PushAsync(new DaysOfWeekPage());
                }
                else if (model.Name.Contains("Colors"))
                {
                    await Navigation.PushAsync(new ColourPage());
                }
                else if (model.Name.Contains("Family"))
                {
                    await Navigation.PushAsync(new FamilyPage());
                }
                else if (model.Name.Contains("Numbers"))
                {
                    await Navigation.PushAsync(new NumberPage());
                }
                else if (model.Name.Contains("Introduction"))
                {
                    await Navigation.PushAsync(new IntroducionPage());
                }
                else if (model.Name.Contains("Human body"))
                {
                    await Navigation.PushAsync(new HumanBodyPage());
                }
                else
                {
                    await Navigation.PushAsync(new PronounPage());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }

}
