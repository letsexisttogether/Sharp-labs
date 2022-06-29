using Model;

namespace Builders
{
    public interface ISpecialityBuilder
    {
        void SetId(int id);

        void SetTitle(string title);

        void AddMainSubjects();

        void AddExtraSubject();

        Speciality GetSpeciality();
    }
}
