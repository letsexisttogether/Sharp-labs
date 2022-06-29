using Model;

namespace Builders
{
    public class ArtSpecialityBuilder : ISpecialityBuilder 
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
            _speciality.RequiredSubjects.Add(Subject.Математика_стандарт, 0.4f);
            _speciality.RequiredSubjects.Add(Subject.Українська_мова, 0.4f);
            _speciality.RequiredSubjects.Add(Subject.Географія, 0.2f);
        }
        public void AddExtraSubject()
        {
            _speciality.RequiredSubjects.Add(Subject.Англійська_мова, 0.2f);
        }
        public Speciality GetSpeciality()
        {
            _speciality.Type = SpecialityType.Художня;
            Speciality specialityKeeper = _speciality;
            _speciality = new();
            return specialityKeeper;
        }
    }
}
