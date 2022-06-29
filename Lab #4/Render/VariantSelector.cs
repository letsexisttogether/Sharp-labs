using System;
using Render;

namespace Presentation_layer
{
    public class VariantSelector
    {
        private readonly string _message;
        private readonly int _minValue;
        private readonly int _maxValue;

        public VariantSelector(string message, int minValue, int maxValue)
        {
            _message = message;
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public int SelectVariant()
        {
            ValueEnterHelper enterHelper = new();
            while (true)
            {
                int value = enterHelper.IntValueEnter(_message);

                if (value < _minValue || value > _maxValue)
                {
                    Console.WriteLine("Ви не коректний варіант. Спробуйте знов");
                    continue;
                }
                return value;
            }
        }
    }
}
