using System;
using System.Collections.Generic;

namespace Model
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public SpecialityType Type { get; set; }
        public Dictionary<Subject, float> RequiredSubjects { get; set; } = new();

        public override string ToString()
        {
            string infoString = $"Ідентифікатор спеціальності: {Id} Назва: {Title}\n" +
                $"Предмети: \n";
            foreach(KeyValuePair<Subject, float> subject in RequiredSubjects)
            {
                infoString = String.Concat(infoString, $"Назва: {subject.Key} " +
                    $"Коефіцієнт: {subject.Value}\n");
            }
            return infoString;
        }
    }
}
