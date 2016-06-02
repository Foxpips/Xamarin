using System;
using System.Collections.Generic;
using System.Linq;
using ColourTester.Models;
using ColourTester.Services;

namespace ColourTester.ViewModels
{
    public class ColourCollectionViewModel
    {
        public string Title => "Colour Palette";
        public IEnumerable<ColourViewModel> ColourModels { get; set; }

        public ColourCollectionViewModel(IColourDataService colourDataService, Func<ColourModel, ColourViewModel> colourViewModelFactory)
        {
            var colourModels = colourDataService.GetColours();
            ColourModels = colourModels.Select(colourViewModelFactory).ToList();
        }
    }
}