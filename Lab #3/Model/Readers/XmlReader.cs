using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Model
{
    public class XmlReader : IReader
    {
        private XElement? GetFileRoot(string fileName)
        {
            if (fileName.Split('.').Last() != "xml")
                return null;
            return XDocument.Load(fileName).Root;
        }

        public IEnumerable<Applicant> ReadApplicants(string fileName)
        {
            XElement? root = GetFileRoot(fileName);

            if(root is null)
            {
                return new List<Applicant>();
            }

            return root.Elements("Applicant")
                .Select(applicant => new Applicant()
                {
                    Id = Convert.ToInt32(applicant.Element("Id").Value),
                    Name = applicant.Element("Name").Value,
                    Surname = applicant.Element("Surname").Value,
                    Partonymic = applicant.Element("Patronymic").Value,
                    birthDay = new DateOnly(Convert.ToInt32(applicant.Element("Birthday").Value.Split('.')[2]),
                        Convert.ToInt32(applicant.Element("Birthday").Value.Split('.')[1]),
                        Convert.ToInt32(applicant.Element("Birthday").Value.Split('.')[0])),
                    Subjects = 
                        applicant.Elements("Subject").Select(subject => subject)
                        .ToDictionary(keySelector : x => (Subject)Enum.Parse(typeof(Subject), 
                        x.Element("Title").Value), 
                        elementSelector : x => Convert.ToSingle(x.Element("Score").Value))
                });;
                
        }
        public IEnumerable<Speciality> ReadSpecialities(string fileName)
        {
            XElement? root = GetFileRoot(fileName);

            if (root is null)
            {
                return new List<Speciality>();
            }

            return root.Elements("Speciality")
                .Select(speciality => new Speciality()
                {
                    Id = Convert.ToInt32(speciality.Element("Id").Value),
                    Title = speciality.Element("Title").Value,
                    Type = (SpecialityType)Enum.Parse(typeof(SpecialityType), speciality.Element("Type").Value),
                    RequiredSubjects = speciality.Elements("Subject").Select(subject => subject)
                        .ToDictionary(keySelector: x => (Subject)Enum.Parse(typeof(Subject),
                        x.Element("Title").Value),
                        elementSelector: x => Convert.ToSingle(x.Element("Rate").Value))
                });
        }
        public IEnumerable<ApplicantSpecialityConnection> ReadApSpConns(string fileName)
        {
            XElement? root = GetFileRoot(fileName);

            if (root is null)
            {
                return new List<ApplicantSpecialityConnection>();
            }

            return root.Elements("ApplicantSpecialityConnection")
                .Select(apSpConn => new ApplicantSpecialityConnection()
                {
                    IdApplicant = Convert.ToInt32(apSpConn.Element("IdApplicant").Value),
                    IdSpeciality = Convert.ToInt32(apSpConn.Element("IdSpeciality").Value)
                });
        }
    }
}
