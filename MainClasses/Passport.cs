using System;
using System.Collections.Generic;

namespace MainClasses
{
    public class Passport
    {
        public Person PassportOwner { private get; init; } = new();
        public string Number { get; init; } = string.Empty;
        public string RegestrationAddress { get; init; } = string.Empty;
        public DateOnly ActiveByDate { get; init; } = new();

        public override string ToString()
        {
            return $"Користувач: {PassportOwner.ToString()}\nПаспортні дані: " +
                $"Номер: {Number} Адреса реєстрації: {RegestrationAddress} " +
                $"Дійсний до: {ActiveByDate}";
        }
    }
}
