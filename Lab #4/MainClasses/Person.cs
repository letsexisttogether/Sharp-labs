using System;

namespace MainClasses
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; } = new DateOnly();
        public int MailIndex { get; set; }

        public override string ToString()
        {
            return $"Ім'я: {Name} Прізвище: {Surname} " +
                $"Ім'я по-батькові: {Patronymic} Дата народжаення: {Birthday}";
        }
    }
}
