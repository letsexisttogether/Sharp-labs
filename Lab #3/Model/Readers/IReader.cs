using System.Collections.Generic;

namespace Model
{
    public interface IReader
    {
        IEnumerable<Applicant> ReadApplicants(string fileName);
        IEnumerable<Speciality> ReadSpecialities(string fileName);
        IEnumerable<ApplicantSpecialityConnection> ReadApSpConns(string fileName);
    }
}
