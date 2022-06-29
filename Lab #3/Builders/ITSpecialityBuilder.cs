using Model;

namespace Builders
{
    public class ITSpecialityBuilder : ISpecialityBuilder
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
            _speciality.RequiredSubjects.Add(Subject.Українська_мова_література, 0.3f);
            _speciality.RequiredSubjects.Add(Subject.Математика_профільна, 0.3f);
            _speciality.RequiredSubjects.Add(Subject.Англійська_мова, 0.2f);
        }

        public void AddExtraSubject()
        {
            _speciality.RequiredSubjects.Add(Subject.Фізика, 0.2f);
        }

        public Speciality GetSpeciality()
        {
            _speciality.Type = SpecialityType.IT;
            Speciality specialityKeeper = _speciality;
            _speciality = new();
            return specialityKeeper;
        }
    }
}
