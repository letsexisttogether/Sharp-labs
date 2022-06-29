using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class TxtWriter : IWriter
    {
        public void WriteApplicants(string fileName, List<Applicant> applicants)
        {
            if(fileName.Split('.').Last() != "txt")
            {
                return;
            }

            List<string> lines = new();

            foreach(Applicant applicant in applicants)
            {
                lines.Add(applicant.Id.ToString());
                lines.Add(applicant.Name);
                lines.Add(applicant.Surname);
                lines.Add(applicant.Partonymic);
                lines.Add($"{applicant.birthDay.Year}.{applicant.birthDay.Month}.{applicant.birthDay.Day}");
                foreach(KeyValuePair<Subject, float> subjects in applicant.Subjects)
                {
                    lines.Add($"{subjects.Key} {subjects.Value}");
                }
                lines.Add("");
            }

            File.WriteAllLines(fileName, lines);
        }
        public void WriteSpecialities(string fileName, List<Speciality> specialities)
        {
            if(fileName.Split('.').Last() != "txt")
            {
                return;
            }

            List<string> lines = new();

            foreach (Speciality speciality in specialities)
            {
                lines.Add(speciality.Id.ToString());
                lines.Add(speciality.Title);
                lines.Add(speciality.Type.ToString());
                if(speciality.RequiredSubjects.Count == 4)
                {
                    lines.Add("true");
                }
                else
                {
                    lines.Add("false");
                }
                lines.Add("");
            }
            File.WriteAllLines(fileName, lines);
        }
        public void WriteAgApConns(string fileName, List<ApplicantSpecialityConnection> agApConns)
        {
            if (fileName.Split('.').Last() != "txt")
            {
                return;
            }
            
            List<string> lines = new();

            foreach(ApplicantSpecialityConnection apSpConn in agApConns)
            {
                lines.Add(apSpConn.IdApplicant.ToString());
                lines.Add(apSpConn.IdSpeciality.ToString());
                lines.Add("");
            }
        }
    }
}
