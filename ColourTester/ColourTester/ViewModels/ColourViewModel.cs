using ColourTester.Models;
using Xamarin.Forms;

namespace ColourTester.ViewModels
{
    public class ColourViewModel
    {
        public string Name { get; set; }
        public Color Colour { get; set; }

        public ColourViewModel(ColourModel model)
        {
            Name = model.Name;
            Colour = model.Colour;
        }
    }
}