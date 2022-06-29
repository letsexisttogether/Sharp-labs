using System;
using System.Collections.Generic;
using MainClasses;
using Presentation_layer;

namespace Render
{
    public class ValueEnterHelper
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
                    Console.WriteLine("Формат введених даних не є int. Спробуйте знов");
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
        
        public DateOnly DataOnlyValueEnter(string message)
        {
            Console.WriteLine(message);
            VariantSelector yearSelector = new("Введіть рік: ", 1970, DateTime.Now.Year);
            VariantSelector monthSelector = new("Введіть місяць: ", 1, 12);
            VariantSelector daySelector = new("Введіть день: ", 1, 31);
            return new DateOnly(yearSelector.SelectVariant(), 
                monthSelector.SelectVariant(), daySelector.SelectVariant());
        }
      
        public InsuranceCase SelectInsuranseCase()
        {
            List<InsuranceCase> cases = new()
            {
                InsuranceCase.ДТП,
                InsuranceCase.Вивіх,
                InsuranceCase.Перелом,
                InsuranceCase.Побої,
                InsuranceCase.Смерть
            };
            int i = 1;
            foreach (InsuranceCase iCase in cases)
            {
                Console.WriteLine($"{i++}. {iCase}");
            }
            VariantSelector insuranseCaseSelector = new("Оберіть випадок страхування: ", 1, cases.Count);
            return cases[insuranseCaseSelector.SelectVariant() - 1];
        }
    }
}
