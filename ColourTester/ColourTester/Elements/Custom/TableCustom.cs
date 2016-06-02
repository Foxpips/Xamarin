using System.Collections.Generic;
using Xamarin.Forms;

namespace ColourTester.Elements.Custom
{
    public class CustomElement : ICustomElement<TableView>
    {
        public TableView Create(IEnumerable<Cell> items, TableIntent format, string title = "Title")
        {
            return new TableView
            {
                Intent = format,
                Root = new TableRoot(title)
                {
                    new TableSection
                    {
                        items
                    }
                }
            };
        }


        public TableView Create()
        {
            throw new System.NotImplementedException();
        }
    }
}