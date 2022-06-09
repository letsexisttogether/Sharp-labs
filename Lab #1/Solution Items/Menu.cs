﻿using System;
using System.Collections.Generic;
using SolutionItems;

namespace ExtraService
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
            Console.WriteLine("Головне меню\n");
            foreach (MenuItem menuItem in Items)
            {
                Console.WriteLine(menuItem);
            }
        }

        public void ExecuteSelectedItem(int itemIndex)
        {
            Items[itemIndex].ExecuteSelectedAction();
        }

    }
}

