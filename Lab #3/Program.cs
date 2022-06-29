using System;
using System.Collections.Generic;
using System.Linq;
using Fabrics;
using Model;
using Builders;

namespace AlexLab
{
    static public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            IFileRenderFabric fileRender = new XmlRender();
            IReader reader = fileRender.GetReader();

            List<Applicant> applicants = reader.ReadApplicants("XmlFiles/Applicants.xml").ToList();

            fileRender = new TxtRender();
            IWriter writer = fileRender.GetWriter();
            writer.WriteApplicants("TxtFiles/Applicants.txt", applicants);

            reader = fileRender.GetReader();
            List<Speciality> specialities = reader.ReadSpecialities("TxtFiles/Specialities.txt").ToList();

            List<ApplicantSpecialityConnection> connections =
                reader.ReadApSpConns("TxtFiles/ApplicantSpecialityConnection.txt").ToList();

            fileRender = new XmlRender();
            writer = fileRender.GetWriter();
            writer.WriteAgApConns("XmlFiles/ApSpConns.xml", connections);
        }
    }
}