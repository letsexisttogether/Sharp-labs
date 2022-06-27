using System;

namespace ModelRender
{
    public class ProperValueEnter
    {
        public int IntValueEnter(string message)
        {
            while (true)
            {
                Console.Write(message);
                int value;
                string str = Console.ReadLine();
                
                try
                {
                    value = Convert.ToInt32(str);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nФормат введених даних не є int. Спробуйте знов");
                    continue;
                }
                
                return value;
            }
        }

        public float FloatValueEnter(string message)
        {
            while (true)
            {
                Console.Write(message);
                float value;
                string str = Console.ReadLine();
                
                try
                {
                    value = Convert.ToSingle(str);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nФормат введених даних не є float. Спробуйте знов");
                    continue;
                }

                return value;
            }
        }

        public string StringValueEnter(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
