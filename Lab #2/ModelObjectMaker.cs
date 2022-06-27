using System;
using System.Xml.Linq;
using System.Xml;
using MainModel;

namespace ModelRender
{
    public class ModelObjectMaker
    {
        public Apartment MakeApartment(XElement element)
        {
            return new Apartment()
            {
                Id = Convert.ToInt32(element.Element("id").Value),
                Address = element.Element("address").Value,
                Floor = Convert.ToInt32(element.Element("floor").Value),
                Square = Convert.ToSingle(element.Element("square").Value)
            };
        }
        public Agency MakeAgency(XElement element)
        {
            return new Agency()
            {
                Id = Convert.ToInt32(element.Element("id").Value),
                Title = element.Element("title").Value,
                Address = element.Element("address").Value,
            };
        }
        public EstateAgent MakeEstateAgent(XElement element)
        {
            return new EstateAgent()
            {
                Id = Convert.ToInt32(element.Element("id").Value),
                AgencyId = Convert.ToInt32(element.Element("agencyId").Value),
                Name = element.Element("name").Value,
                MobileNumber = element.Element("mobileNumber").Value
            };
        }

        public Apartment MakeApartment(XmlNode node)
        {
            return new Apartment()
            {
                Id = Convert.ToInt32(node["id"].Value),
                Address = node["address"].Value,
                Floor = Convert.ToInt32(node["floor"].Value),
                Square = Convert.ToSingle(node["square"].Value)
            };
        }
        public Agency MakeAgency(XmlNode node)
        {
            return new Agency()
            {
                Id = Convert.ToInt32(node["id"].Value),
                Title = node["title"].Value,
                Address = node["address"].Value
            };
        }
        public EstateAgent MakeEstateAgent(XmlNode node)
        {
            return new EstateAgent()
            {
                Id = Convert.ToInt32(node["id"].Value),
                AgencyId = Convert.ToInt32(node["agencyId"].Value),
                Name = node["name"].Value,
                MobileNumber = node["mobileNumber"].Value
            };
        }

        public Apartment MakeApartment(ProperValueEnter vEnter)
        {
            return new Apartment
            {
                Id = vEnter.IntValueEnter("Введіть ID: "),
                Address = vEnter.StringValueEnter("Введіть адресу: "),
                Floor = vEnter.IntValueEnter("Введіть поверх: "),
                Square = vEnter.FloatValueEnter("Введіть площу квартири: ")
            };
        }
        public Agency MakeAgency(ProperValueEnter vEnter)
        {
            return new Agency()
            {
                Id = vEnter.IntValueEnter("Введіть ID: "),
                Title = vEnter.StringValueEnter("Введіть назву агенства: "),
                Address = vEnter.StringValueEnter("Введіть адресу агенства:")
            };
        }
        public EstateAgent MakeEstateAgent(ProperValueEnter valueEnter)
        {
            return new EstateAgent()
            {
                Id = valueEnter.IntValueEnter("Введіть ID: "),
                AgencyId = valueEnter.IntValueEnter("Введіть ID агенства: "),
                Name = valueEnter.StringValueEnter("Введіт ім'я:"),
                MobileNumber = valueEnter.StringValueEnter("Введіть мобільний номер: ")
            };
        }
        public AgencyApartmentConnection MakeAgencyApartmentConnection(ProperValueEnter valueEnter)
        {
            return new AgencyApartmentConnection()
            {
                AgencyId = valueEnter.IntValueEnter("Введіть ID агенства: "),
                ApartmentId = valueEnter.IntValueEnter("Введить ID квартири: "),
                ApartmentPrice = valueEnter.IntValueEnter("Введіть ціну за квартиру: ")
            };
        }
    }
}
