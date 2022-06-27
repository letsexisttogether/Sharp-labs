using System;
using System.Collections.Generic;

namespace Presentation_layer
{
    public class ConsoleQueriesPrinter
    {
        public void Print<TValue>(string message, IEnumerable<TValue> singleCollectionQuery)
        {
            Console.Clear();
            Console.WriteLine($"Ви обрали {message}\n");
            foreach (TValue element in singleCollectionQuery)
            {
                Console.WriteLine(element);
            }
        }

        public void Print<TKey, TValue>(string message, Dictionary<TKey, List<TValue>> multy)
        {
            Console.Clear();
            Console.WriteLine($"Ви обрали {message}\n");
            foreach (KeyValuePair<TKey, List<TValue>> pair in multy)
            {
                Console.WriteLine(pair.Key);
                foreach (TValue element in pair.Value)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine();
            }
        }
    }
}
