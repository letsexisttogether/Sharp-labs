using System;
using Iterators;
using List_items;

namespace Lab5
{
    public static class Program
    {
        public static void Main()
        {
            List<int?> list = new List<int?>();
            list.Add(1);
            list.Add(2);
            list.Add(null);
            list.Add(4);
            list.Add(5);

            IIterator<int?> straightIterator = list.GetIterator();
            Console.WriteLine("В прямому порядку: ");
            do
            {
                Console.WriteLine(straightIterator.Current);
            }while(straightIterator.MoveNext());

            list.Reverse();

            IIterator<int?> backIterator = list.GetIterator();
            Console.WriteLine("\nВ зворотньому порядку");
            do
            {
                Console.WriteLine(backIterator.Current);
            }while(backIterator.MoveNext());
        }
    }
}