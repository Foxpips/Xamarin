using System.Linq;
using ColourTester.Elements.Custom;
using ColourTester.ViewModels;
using Xamarin.Forms;

namespace ColourTester.Pages
{
    public class ColourView : ContentPage
    {
        public ColourView(ColourCollectionViewModel viewModel)
        {
            Title = "Colour View";
            var textCells = viewModel.ColourModels.Select(colourViewModel => new TextCell { Text = colourViewModel.Name, TextColor = colourViewModel.Colour });
            Content = new CustomElement().Create(textCells, TableIntent.Form, Title);
        }
    }

    public class ColourCell : ViewCell
    {
        public ColourCell()
        {
            var grid = new Grid
            {
                Padding = new Thickness(5, 10, 0, 0),
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(10, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(2, GridUnitType.Star)},
                    new ColumnDefinition
                    {
                        Width = new GridLength(25,GridUnitType.Absolute)
                    },
                    new ColumnDefinition {Width = new GridLength(2, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(10, GridUnitType.Star)}
                }
            };

            var colourLabel = new Label();
            colourLabel.SetBinding(Label.TextProperty, "Name");
            colourLabel.SetBinding(VisualElement.BackgroundColorProperty, "Colour");

            grid.Children.Add(colourLabel);

            View = grid;
        }
    }
}