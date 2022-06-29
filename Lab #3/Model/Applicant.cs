using System;
using System.Text;
using System.Collections.Generic;

namespace Model
{
    public class Applicant 
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Surname { get; init; } = string.Empty;
        public string Partonymic { get; init; } = string.Empty;
        public DateOnly birthDay { get; init; } = new DateOnly();

        public Dictionary<Subject, float> Subjects { get; init; } = new();

        public override string ToString()
        {
            StringBuilder infoString = new($"Ідентефикатор: {Id} Ім'я: {Name} Прізвище: {Surname} " +
                $"По-батькові: {Partonymic} Дата народження: {birthDay}\n");
            foreach(KeyValuePair<Subject, float> subject in Subjects)
            {
                infoString.Append($"Предмет: {subject.Key} Бали: {subject.Value}\n");
            }
            return infoString.ToString();
        }
    }
}
