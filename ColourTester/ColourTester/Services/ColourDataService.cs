using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ColourTester.Models;
using Xamarin.Forms;

namespace ColourTester.Services
{
    public class ColourDataService : IColourDataService
    {
        public IEnumerable<ColourModel> GetColours()
        {
            //            yield return new ColourModel {Colour = Color.Blue}; 
            //            yield return new ColourModel {Colour = Color.Red}; 
            //            yield return new ColourModel {Colour = Color.Teal}; 
            //            yield return new ColourModel {Colour = Color.Yellow}; 

            foreach (FieldInfo info in typeof (Color).GetRuntimeFields())
            {
                if (info.IsPublic && info.IsStatic && info.FieldType == typeof (Color))
                {
                    yield return new ColourModel {Colour = ((Color) info.GetValue(null)), Name = info.Name};
                }
            }
        }
    }
}