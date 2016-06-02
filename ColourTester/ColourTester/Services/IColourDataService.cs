using System.Collections.Generic;
using ColourTester.Models;

namespace ColourTester.Services
{
    public interface IColourDataService
    {
        IEnumerable<ColourModel> GetColours();
    }
}