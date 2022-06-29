using Model;

namespace Builders
{
    public class MedicalSpecialityBuilder : ISpecialityBuilder
    {
        Speciality _speciality = new();

        public void SetId(int id)
        {
            _speciality.Id = id;
        }
        public void SetTitle(string title)
        {
            _speciality.Title = title;
        }
        public void AddMainSubjects()
        {
            _speciality.RequiredSubjects.Add(Subject.Українська_мова, 0.3f);
            _speciality.RequiredSubjects.Add(Subject.Математика_стандарт, 0.3f);
            _speciality.RequiredSubjects.Add(Subject.Біологія, 0.4f);
        }
        public void AddExtraSubject()
        {
            _speciality.RequiredSubjects.Add(Subject.Хімія, 0.4f);
        }
        public Speciality GetSpeciality()
        {
            _speciality.Type = SpecialityType.Медична;
            Speciality specialityKeeper = _speciality;
            _speciality = new();
            return specialityKeeper;
        }
    }
}
