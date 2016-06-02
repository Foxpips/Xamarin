using System.Collections.Generic;
using Xamarin.Forms;

namespace ColourTester.Elements.Custom
{
    public interface ICustomElement<out TType> : ICustomItem<TType> where TType : Element
    {
        TType Create(IEnumerable<Cell> items, TableIntent format, string title = "");
    }


    public interface ICustomItem<out TType>
    {
        TType Create();
    }
}