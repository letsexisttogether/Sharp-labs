using System;
using System.Collections.Generic;

namespace Presentation_layer
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public int ItemsCount { get { return Items.Count; } }
        public bool IsExitWanted { get; set; }

        public Menu()
        {
            IsExitWanted = false;
            Items = new();
        }

        public void PrintMenu()
        {
            foreach (MenuItem menuItem in Items)
            {
                Console.WriteLine(menuItem);
            }
        }

        public void Execute(int itemIndex)
        {
            Items[itemIndex].Execute();
        }

    }
}
