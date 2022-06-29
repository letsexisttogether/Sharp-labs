using System.Collections.Generic;
using System.Linq;
using System.Xml;


namespace Model
{
    public class XMLWriter : IWriter
    {
        public void WriteApplicants(string fileName, List<Applicant> applicants)
        {
            if (fileName.Split('.').Last() != "xml")
            {
                return;
            }

            XmlWriterSettings newFileSettings = new XmlWriterSettings();
            newFileSettings.Indent = true;
            using XmlWriter writer = XmlWriter.Create(fileName, newFileSettings);

            writer.WriteStartDocument();
            writer.WriteStartElement("Applicants");

            foreach (Applicant applicant in applicants)
            {
                writer.WriteStartElement("Applicant");

                writer.WriteElementString("Id" , applicant.Id.ToString());
                writer.WriteElementString("Name", applicant.Name);
                writer.WriteElementString("Surname", applicant.Surname);
                writer.WriteElementString("Patronymic", applicant.Partonymic);
                writer.WriteElementString("Birthday", applicant.birthDay.ToString());
                writer.WriteStartElement("Subjects");
                foreach(KeyValuePair<Subject, float> subjects in applicant.Subjects)
                {
                    writer.WriteStartElement("Subject");
                    writer.WriteElementString("Title", subjects.Key.ToString());
                    writer.WriteElementString("Score", subjects.Value.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
        public void WriteSpecialities(string fileName, List<Speciality> specialities)
        {
            if (fileName.Split('.').Last() != "xml")
            {
                return;
            }

            XmlWriterSettings newFileSettings = new XmlWriterSettings();
            newFileSettings.Indent = true;
            using XmlWriter writer = XmlWriter.Create(fileName, newFileSettings);

            writer.WriteStartDocument();
            writer.WriteStartElement("Specialities");

            foreach(Speciality speciality in specialities)
            {
                writer.WriteStartElement("Speciality");


                writer.WriteElementString("Id", speciality.Id.ToString());
                writer.WriteElementString("Title", speciality.Title);
                writer.WriteElementString("Type", speciality.Type.ToString());
                writer.WriteStartElement("Subjects");
                foreach (KeyValuePair<Subject, float> subjects in speciality.RequiredSubjects)
                {
                    writer.WriteStartElement("Subject");
                    writer.WriteElementString("Title", subjects.Key.ToString());
                    writer.WriteElementString("Rate", subjects.Value.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteEndElement();
            }


            writer.WriteEndElement();
        }
        public void WriteAgApConns(string fileName, List<ApplicantSpecialityConnection> agApConns)
        {
            if(fileName.Split('.').Last() != "xml")
            {
                return;
            }

            XmlWriterSettings newFileSettings = new XmlWriterSettings();
            newFileSettings.Indent = true;
            using XmlWriter writer = XmlWriter.Create(fileName, newFileSettings);

            writer.WriteStartDocument();
            writer.WriteStartElement("ApplicantSpecialityConnections");

            foreach(ApplicantSpecialityConnection apSpConn in agApConns)
            {
                writer.WriteStartElement("ApplicantSpecialityConnection");
                
                writer.WriteElementString("IdApplicant", apSpConn.IdApplicant.ToString());
                writer.WriteElementString("IdSpeciality", apSpConn.IdSpeciality.ToString());
                
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
