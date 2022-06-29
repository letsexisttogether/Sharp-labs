using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Builders;

namespace Model
{
    public class TxtReader : IReader
    {
        public IEnumerable<Applicant> ReadApplicants(string fileName)
        {
            if (fileName.Split('.').Last() != "txt")
            {
                return new List<Applicant>();
            }

            List<Applicant> applicants = new();
            string[] lines = File.ReadAllLines(fileName);

            for(int i = 0; i < lines.Length; i += 9) 
            {
                Dictionary<Subject, float> subjects = new();
                subjects.Add((Subject)Enum.Parse(typeof(Subject), lines[i + 5].Split(' ').First()),
                        Convert.ToSingle(lines[i + 5].Split(' ').Last()));
                subjects.Add((Subject)Enum.Parse(typeof(Subject), lines[i + 6].Split(' ').First()),
                        Convert.ToSingle(lines[i + 6].Split(' ').Last()));
                subjects.Add((Subject)Enum.Parse(typeof(Subject), lines[i + 7].Split(' ').First()),
                        Convert.ToSingle(lines[i + 7].Split(' ').Last()));

                applicants.Add(new()
                {
                    Id = Convert.ToInt32(lines[i]),
                    Name = lines[i + 1],
                    Surname = lines[i + 2],
                    Partonymic = lines[i + 3],
                    birthDay = new(Convert.ToInt32(lines[i + 4].Split('.')[0]),
                        Convert.ToInt32(lines[i + 4].Split('.')[1]), 
                        Convert.ToInt32(lines[i + 4].Split('.')[2])),
                    Subjects = subjects
                });

            }
            return applicants;
        }
        public IEnumerable<Speciality> ReadSpecialities(string fileName)
        {
            if (fileName.Split('.').Last() != "txt")
            {
                return new List<Speciality>();
            }

            List<Speciality> specialities = new();

            string[] lines = File.ReadAllLines(fileName);
            ISpecialityBuilder builder;

            for (int i = 0; i < lines.Length; i += 5)
            {
                int id = Convert.ToInt32(lines[i]);
                string title = lines[i + 1];
                SpecialityType type = (SpecialityType)Enum.Parse(typeof(SpecialityType), lines[i + 2]);
                bool hasExtraSubject = Convert.ToBoolean(lines[i + 3]);

                builder = BuilderSelector(type);
                builder.SetId(id);
                builder.SetTitle(title);
                builder.AddMainSubjects();
                if(hasExtraSubject)
                {
                    builder.AddExtraSubject();
                }
                specialities.Add(builder.GetSpeciality());
            }
            return specialities;
        }
        public IEnumerable<ApplicantSpecialityConnection> ReadApSpConns(string fileName)
        {
            if(fileName.Split('.').Last() != "txt")
            {
                return new List<ApplicantSpecialityConnection>();
            }

            List<ApplicantSpecialityConnection> apSpCon = new();
            string[] lines = File.ReadAllLines(fileName);
            
            for(int i = 0; i < lines.Length; i += 3)
            {
                apSpCon.Add(new()
                {
                    IdApplicant = Convert.ToInt32(lines[i]),
                    IdSpeciality = Convert.ToInt32(lines[i + 1])
                });
            }

            return apSpCon;
        }

        private ISpecialityBuilder BuilderSelector(SpecialityType type)
        {
            if (type == SpecialityType.Художня)
            {
                return new ArtSpecialityBuilder();
            }
            else if (type == SpecialityType.Економічна)
            {
                return new EcomonicSpecialityBuilder();
            }
            else if (type == SpecialityType.Медична)
            {
                return new MedicalSpecialityBuilder();
            }
            return new ITSpecialityBuilder();
        }
    }
}
