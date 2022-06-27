using System;
using System.Collections.Generic;
using MainModel;
using XmlRender;
using ModelRender;
using Presentation_layer;

namespace Lab9
{
    static class Program
    {
        static void Pause()
        {
            Console.WriteLine("\nДля продовження натисніть будь-яку клавішу");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            ModelObjectMaker maker = new();
            ProperValueEnter valueEnter = new();
            
            // First part
            List<Apartment> apartments = new();
            List<Agency> agencies = new();
            List<EstateAgent> estateAgents = new();
            List<AgencyApartmentConnection> agApCon = new();

            Menu firstMenu = new();
            firstMenu.Items = new()
            {
                new MenuItem("1. Додати нову квартиру",
                    () => apartments.Add(maker.MakeApartment(valueEnter))),
                
                new MenuItem("2. Додати нове агенство",
                    () => agencies.Add(maker.MakeAgency(valueEnter))),
                
                new MenuItem("3. Додати нового працівника",
                    () => estateAgents.Add(maker.MakeEstateAgent(valueEnter))),
                
                new MenuItem("4. Додати нове з'єднання агенства и квартири",
                    () => agApCon.Add(maker.MakeAgencyApartmentConnection(valueEnter))),
                
                new MenuItem("5. Додати заготовлені списки", () =>
                    {
                        DataLists data = new();
                        apartments = data.Apartments;
                        agencies = data.Agencies;
                        estateAgents = data.EstateAgents;
                        agApCon = data.AgencyAppartmentConntections;
                    }),

                new MenuItem("6. Зберігти",
                    () => firstMenu.IsExitWanted = true)
            };
            MenuItemSelector fistMenuSelector = new(1, firstMenu.ItemsCount);

            while (!firstMenu.IsExitWanted)
            {
                firstMenu.PrintMenu("Меню заповдення документів");
                firstMenu.ExecuteSelectedItem(fistMenuSelector.SelectItem());
                Pause();
            }

            // Second Part
            Writer writer = new();
            writer.AddGroupOfElements("XmlDocuments/Apartments.xml", "Apartments",
                apartments);
            writer.AddGroupOfElements("XmlDocuments/Agencies.xml", "Agencies",
                agencies);
            writer.AddGroupOfElements("XmlDocuments/EstateAgents.xml", "EstateAgents",
                estateAgents);
            writer.AddGroupOfElements("XmlDocuments/AgencyApartmentConnections.xml",
                "AgencyApartmentConnections", agApCon);

            ConsoleQueriesPrinter printer = new();
            Reader reader = new();

            // Third part 
            Menu secondMenu = new();
            secondMenu.Items = new()
            {
                new MenuItem("1. Всі агенти", 
                () => printer.Print("всіх агентів",
                reader.GetAllEstateAgents("XmlDocuments/EstateAgents.xml"))),

                new MenuItem("2. Агенства з двома та більше словами в імені",
                () => printer.Print("агенства з двома та більше словами в імені",
                reader.GetAgenciesWithMoreThanOneWordName("XmlDocuments/Agencies.xml"))), 
                
                new MenuItem("3. Всі агенства",
                () => printer.Print("всі агенства",
                reader.GetAgencies("XmlDocuments/Agencies.xml"))),

                new MenuItem("4. Всі квартири",
                () => printer.Print("всі квартири",
                reader.GetApartments("XmlDocuments/Apartments.xml"))),

                new MenuItem("18. Вихід", () => secondMenu.IsExitWanted = true)
            };

            while(!secondMenu.IsExitWanted)
            {
                secondMenu.PrintMenu("Головне меню програми");
                secondMenu.ExecuteSelectedItem(fistMenuSelector.SelectItem());
                Pause();
            }
        }
    }
}

