using System.Collections.Generic;

namespace Model
{
    public interface IWriter
    {
        void WriteApplicants(string fileName, List<Applicant> applicants);
        void WriteSpecialities(string fileName, List<Speciality> specialities);
        void WriteAgApConns(string fileName, List<ApplicantSpecialityConnection> agApConns);
    }
}
