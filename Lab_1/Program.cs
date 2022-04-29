using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_lab_1_v_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (true)
            {
                Console.Clear();
                Console.Write("Оберіть пункт:\n\n" +
                    "1. Вивід таблиці рієлторів\n" +
                    "2. Вивід агенства, ім'я яких містить більше, ніж одне слово\n" +
                    "3. Вивід агенств, сгрупованих за кількістью працівників\n" +
                    "4. Вивід агенств, адреса яких складається більше ніж з 15 символів\n" +
                    "і номер принаймні одного працівника починається на 099\n" +
                    "5. Сортування агенств по кількості літер у назві\n\n" +
                    "6. Вивід таблиці квартир\n" +
                    "7. Вивід квартир, які мають площу від 70 до 100\n" +
                    "8. Сортування квартир за площею у зворотньому порядку\n" +
                    "9. Грувування квартир за кількістью поверхів\n" +
                    "10. Сортування агенств за середньої ціною квартир, які вони продають\n\n" +
                    "11. Вивід агенств та квартир, які вони продають\n" +
                    "12. Сортування квартир за середньою ціною\n" +
                    "13. Вивід квартир, агенства яких мають від 2 до 4 працівників\n" +
                    "14. Вивід агенства, у яких назва будь-якої квартири починається на голосну\n" +
                    "15. Вивиід квартир з мінімальною і максимальною площею та їх агенств\n\n" +
                    "16. Вихід\n\n" +
                    "<< ");

                string select = Console.ReadLine();
                if (!int.TryParse(select, out int result) || result < 1 || result > 16)
                    continue;

                Console.Clear();

                // Вибір всіх рієлторів (SQL)
                if (select == "1")
                {
                    Console.WriteLine("Усі рієлтори:\n");

                    var resultList = from agency in AgencyList
                                     select agency.Estate_Agents;

                    foreach (var AgentsList in resultList)
                    {
                        foreach (var agent in AgentsList)
                            Console.Write(agent);
                        Console.WriteLine();

                    }
                }

                // Вибір агенств, ім'я яких містить більше одного слова (розширення)
                if (select == "2")
                {
                    Console.WriteLine("Агенства, ім'я яких містить більше двох слів:\n");

                    var resultList = AgencyList.Where(agency => agency.AgencyName.Contains(" "));

                    foreach (var agency in resultList)
                        Console.WriteLine(agency.ToShortString());
                }

                // Групування агенств за кількістю робітників (SQL)
                if (select == "3")
                {
                    Console.WriteLine("Групування агенств за кількістю робітників:\n");

                    var resultList = from agency in AgencyList
                                     group agency by agency.Estate_Agents.Count() into extraAgencyList
                                     select new
                                     {
                                         agentsCount = extraAgencyList.First().Estate_Agents.Count(),
                                         extraAgencyList
                                     };

                    foreach (var item in resultList)
                    {
                        Console.WriteLine($"Наступні агентсва містять {item.agentsCount} рієлторів:");
                        foreach (var agency in item.extraAgencyList)
                            Console.WriteLine(agency.ToShortString());
                        Console.WriteLine();
                    }
                }

                // Вивід агенств, адреса яких складається більше ніж з 15 символів
                // і номер принаймні одного працівника починається на 099 (розширення)
                if (select == "4")
                {
                    Console.WriteLine("Агенства, адреса яких складається більше ніж з 15 символів\n" +
                    "і номер принаймні одного працівника починається на 099:\n");

                    var resultList = AgencyList
                                    .Where(agency => agency.AgencyAddress.Length >= 15
                                     && agency.Estate_Agents
                                    .Any(agent => agent.AgentMobile > 990000000));

                    foreach (var agency in resultList)
                        Console.WriteLine(agency);
                }

                // Сортування агенств за кількістю букв у назві (SQL)
                if (select == "5")
                {
                    Console.WriteLine("Сортування агенств по кількості літер у назві:\n");

                    var resultList = from agency in AgencyList
                                     orderby agency.AgencyName.Length
                                     select agency;

                    foreach (var agency in resultList)
                        Console.WriteLine(agency.ToShortString());
                }    

                // Вибір всіх квартир (розширення)
                if (select == "6")
                {
                    Console.WriteLine("Все квартиры:");

                    var resultList = ApartmentList.Select(apartment => apartment);

                    foreach (var apartment in resultList)
                        Console.WriteLine(apartment);
                }

                // Вибір квартир, які мають площу від 75 до 100 м. кв. (SQL)
                if (select == "7")
                {
                    Console.WriteLine("Квартиры площиною від 75 до 100 м. кв:\n");

                    var resultList = from apartment in ApartmentList
                                     where apartment.ApartmentSquare >= 75
                                     && apartment.ApartmentSquare <= 100
                                     select apartment;

                    foreach (var apartment in resultList)
                        Console.WriteLine(apartment);
                }

                // Сортування квартир за площею у зворотньому порядку (розширення)
                if (select == "8")
                {
                    Console.WriteLine("Сортировка квартир по площади:\n");

                    var resultList = ApartmentList.OrderByDescending(apartment => apartment.ApartmentSquare);

                    foreach (var apartment in resultList)
                        Console.WriteLine(apartment);
                }

                // Групування кварти за кількістю поверхів (SQL)
                if (select == "9")
                {
                    Console.WriteLine("Групування квартир за поверхами: \n");

                    var resultList = from apartment in ApartmentList
                                     group apartment by apartment.ApartmentFloor into extraApartmentList
                                     select new
                                     {
                                         floor = extraApartmentList.First().ApartmentFloor,
                                         extraApartmentList
                                     };

                    foreach (var item in resultList)
                    {
                        Console.WriteLine($"На {item.floor} поверху розташовані наступні квартири: ");
                        foreach (var apartment in item.extraApartmentList)
                            Console.WriteLine(apartment);
                        Console.WriteLine();
                    }
                }

                // Сортування агенств за сереньою ціної всіх квартир, які вони продають (SQL) 
                // Переделать
                if (select == "10")
                {
                    Console.WriteLine("Сортування агенств за середньої ціною квартир, які вони продають:\n");

                    var resultList = AgencyList.GroupJoin(AgencyAppartmentList,
                        c => c.AgencyID, p => p.AgencyID, (c, p) => new
                        {
                            agencyInfo = c,
                            buildingAvgPrice = p.Average(apartment => apartment.AppartmentPrice)
                        })
                        .OrderBy(agency => agency.buildingAvgPrice);

                    foreach (var agency in resultList)
                        Console.WriteLine(agency.agencyInfo.ToShortString() + ", Середня ціна: " + agency.buildingAvgPrice);
                }

                // Агенства та квартири, які вони продають (розширення)
                if (select == "11")
                {
                    Console.WriteLine("Зв'язок агенств та квартир\n");

                    // У результаті запиту виходить нова таблиця,
                    // яка містить інформацію про квартиру та ID рієлтора
                    var apartmentAgencyID = ApartmentList.Join(AgencyAppartmentList,
                        item_1 => item_1.ApartmentID,
                        item_2 => item_2.AppartmentID,
                        (apartment, agency) => new
                        {
                            apartmentInfo = apartment,
                            agencyID = agency.AgencyID,
                            apartmentPrice = agency.AppartmentPrice
                        });
                    // Соединение квартир и агенств по ID агенства
                    var resultList = AgencyList.GroupJoin(apartmentAgencyID,
                        item_1 => item_1.AgencyID,
                        item_2 => item_2.agencyID,
                        (agency, apartment) => new
                        {
                            agencyInfo = agency,
                            extraApartmentList = apartment

                        });

                    foreach (var agency in resultList)
                    {
                        Console.WriteLine(agency.agencyInfo.ToShortString() + ":");
                        foreach (var apartment in agency.extraApartmentList)
                            Console.WriteLine(apartment.apartmentInfo + ", Ціна: " + apartment.apartmentPrice);
                        Console.WriteLine();

                    }
                }

                // Сортування квартир за середньою ціною (SQL)
                if (select == "12")
                {
                    Console.WriteLine("Сортування квартир за середньою ціною:\n");

                    // Знаходження середньої ціни кожної квартири
                    var priceGroup = from apartment in AgencyAppartmentList
                                     group apartment by apartment.AppartmentID
                                     into extraList
                                     select new
                                     {
                                         avgApartmentPrice = extraList.Average(apartment => apartment.AppartmentPrice),
                                         appartmentID = extraList.First().AppartmentID
                                     };
                    // З'єднання списку квартир та створенного списку з середньою ціною за ID квартири 
                    var resultList = from item_1 in ApartmentList
                                     join item_2 in priceGroup
                                     on item_1.ApartmentID equals item_2.appartmentID
                                     select new
                                     {
                                         apartmentInfo = item_1,
                                         avgApartmentPrice = item_2.avgApartmentPrice
                                     };

                    foreach (var apartment in resultList)
                        Console.WriteLine(apartment.apartmentInfo
                            + " Средня ціна: " + apartment.avgApartmentPrice);
                }

                // Квартири, які продаються агенствами, що мають принайні 2 працівника (розширення)
                if (select == "13")
                {
                    Console.WriteLine("Квартири, агенства яких мають від 2 до 4 працівників:\n");

                    var apartmentAgencyID = ApartmentList.Join(AgencyAppartmentList,
                       item_1 => item_1.ApartmentID,
                       item_2 => item_2.AppartmentID,
                       (apartment, agency) => new
                       {
                           apartmentInfo = apartment,
                           agencyID = agency.AgencyID,
                       });

                    var resultList = AgencyList.Where(agency => agency.Estate_Agents.Count() >= 2
                                                && agency.Estate_Agents.Count() <= 4)
                                                .Join(apartmentAgencyID,
                                                item_1 => item_1.AgencyID,
                                                item_2 => item_2.agencyID,
                                                (agency, apartment) => new
                                                {
                                                    apartmentInfo = apartment.apartmentInfo
                                                });

                    foreach (var apartment in resultList)
                        Console.WriteLine(apartment.apartmentInfo);
                }

                // Агенства, у яких адреса будь-якої квартири починаєтьяс на голосну (SQL)
                if (select == "14")
                {
                    Console.WriteLine("Агенства, у яких назва будь-якої квартири починається на голосну:\n");

                    // Список с квартирами, адрес которых начанается на гласную
                    var vowelApartmentList = from apartment in ApartmentList
                                             where apartment.ApartmentAddress.StartsWith("А")
                                             || apartment.ApartmentAddress.StartsWith("Е")
                                             || apartment.ApartmentAddress.StartsWith("Є")
                                             || apartment.ApartmentAddress.StartsWith("И")
                                             || apartment.ApartmentAddress.StartsWith("І")
                                             || apartment.ApartmentAddress.StartsWith("Ї")
                                             || apartment.ApartmentAddress.StartsWith("О")
                                             || apartment.ApartmentAddress.StartsWith("У")
                                             || apartment.ApartmentAddress.StartsWith("Ю")
                                             || apartment.ApartmentAddress.StartsWith("Я")
                                             select apartment.ApartmentID;
                    // Список с соответствием квартиры и ID агенства
                    var agencyIDList = from apartmentID in vowelApartmentList
                                       join agency in AgencyAppartmentList
                                       on apartmentID equals agency.AppartmentID
                                       select agency.AgencyID;

                    // Соединение списка с нужными ID агенств и общего списка агенств
                    var resultList = (from agencyID in agencyIDList
                                     join agency in AgencyList
                                     on agencyID equals agency.AgencyID
                                     select agency)
                                     .Distinct();

                    foreach (var agency in resultList)
                        Console.WriteLine(agency.ToShortString());

                }

                // Квартира з мінімальною і максимальною площею та їх агенств (розширення)
                if (select == "15")
                {
                    Console.WriteLine("Агенство и квартира з мінімальною та максимальною площіною:\n");

                    var orderedBySquareApartmentList = ApartmentList
                        .OrderBy(apartment => apartment.ApartmentSquare)
                        .ToList();

                    Apartment minSquareApartment = orderedBySquareApartmentList.First();
                    Apartment maxSquareApartment = orderedBySquareApartmentList.Last();

                    var resultList = AgencyAppartmentList
                        .Where(apartmentID => apartmentID.AppartmentID
                        .Equals(minSquareApartment.ApartmentID)
                        || apartmentID.AppartmentID
                        .Equals(maxSquareApartment.ApartmentID))
                        .Join(AgencyList,
                        apartment => apartment.AgencyID,
                        agency => agency.AgencyID,
                        (apartment, agency) => new
                        {
                            AgencyInfo = agency,
                            ApartmentID = apartment.AppartmentID
                        })
                        .GroupBy(item => item.ApartmentID)
                        .ToList();

                    // Для минимального значение 
                    Console.WriteLine($"Мінімальная площа\n{minSquareApartment}:");
                    foreach (var agency in resultList.First())
                        Console.WriteLine(agency.AgencyInfo.ToShortString());

                    // Для максимального значения 
                    Console.WriteLine("\nМаксимальна площа\n" + maxSquareApartment + ": ");
                    foreach (var agency in resultList.Last())
                        Console.WriteLine(agency.AgencyInfo.ToShortString());

                }

                // Умова виходу
                if (select != "16")
                {
                    Console.WriteLine("\nДля продовження натисність будь-яку клавішу");
                    Console.ReadKey(true);
                }
                else break;

                // New thoughts 
              
            }
        }

        // Список квартир на продажу
        static List<Apartment> ApartmentList = new List<Apartment>()
        {
            new Apartment(1, "Тараса Шевченко 17, б. 13 кв. 35", 15, 86.3),
            new Apartment(2, "Острізька, б. 3, кв. 17", 1, 90),
            new Apartment(3, "Володимирська, б. 14, кв. 13", 11, 110.5),
            new Apartment(4, "Мельнікова, б. 81, кв. 71", 15, 31.5),
            new Apartment(5, "Горицького, б. 42, кв. 89", 3, 30),
            new Apartment(6, "Прорізна, б. 78. кв. 12", 4, 85.4),
            new Apartment(7, "П. Орліка, б. 17, кв. 1", 2, 75),
            new Apartment(8, "Тараса Шевченко, б. 82. кв. 392", 4, 83.5),
            new Apartment(9, "Житомирська, б. 34, кв. 7", 15, 35.5),
            new Apartment(10, "Волинська, б. 42, кв. 4", 1, 110.5),
            new Apartment(11, "Широва, б. 23, кв. 2", 5, 89.8),
            new Apartment(12, "Копіленка, б. 71, кв. 1", 3, 32), 
            new Apartment(13, "Інститутская, б. 1. кв. 5", 4, 70),
            new Apartment(14, "Фізкультури, б. 105, кв. 1", 5, 90.9),
            new Apartment(15, "Львівська, б. 99, кв. 3", 9, 120)
        };

        //Список агенств по продаже квартир
        static List<Agency> AgencyList = new List<Agency>()
        {
            new Agency(1, "Продажа нерухомості", "Інститутська, 30",
                new List<Estate_Agent>()
                {
                    new Estate_Agent("Ігор", 997651464),
                    new Estate_Agent("Вікторія", 988351016),
                    new Estate_Agent("Ігро", 994897659)
                }),

            new Agency(2, "BSeller", "Львівська, 34",
                new List<Estate_Agent>()
                {
                    new Estate_Agent("Владислав", 998561451),
                    new Estate_Agent("Олександр", 957651485)
                }),

            new Agency(3, "Plost", "Пірогова, 38",
                new List<Estate_Agent>()
                {
                    new Estate_Agent("Єгор", 674510845)
                }),

            new Agency(4, "Афірма", "Лимова, 17",
                new List<Estate_Agent>()
                {
                    new Estate_Agent("Віктор", 987656543),
                    new Estate_Agent("Дитх'яр", 957867646),
                    new Estate_Agent("Володимир", 987651819),
                }),

            new Agency(5, "Fast flat", "М. Коцюбинського, 25", 
                new List<Estate_Agent>()
                {
                    new Estate_Agent("В'ячеслав", 959059806),
                    new Estate_Agent("Олександр", 508956338),
                    new Estate_Agent("Богдана", 994718909),
                    new Estate_Agent("Богдан", 671238764),
                    new Estate_Agent("Олег", 678559016),
                })

        };

        // Список для связи квартиры и агенства
        static List<AgencyAppartmentConnection> AgencyAppartmentList = new List<AgencyAppartmentConnection>()
        {
            // Первое агенство
            new AgencyAppartmentConnection(1, 1, 45000),
            new AgencyAppartmentConnection(1, 3, 120000),
            new AgencyAppartmentConnection(1, 6, 68000),
            new AgencyAppartmentConnection(1, 9, 41000),
            new AgencyAppartmentConnection(1, 14, 118000),
            // Второе агентво
            new AgencyAppartmentConnection(2, 3, 115000),
            new AgencyAppartmentConnection(2, 4, 35000),
            new AgencyAppartmentConnection(2, 5, 40000),
            new AgencyAppartmentConnection(2, 14, 110000),
            // Третье агенство
            new AgencyAppartmentConnection(3, 2, 100000),
            new AgencyAppartmentConnection(3, 9, 40500),
            new AgencyAppartmentConnection(3, 8, 70800),
            new AgencyAppartmentConnection(3, 11, 140000),
            new AgencyAppartmentConnection(3, 15, 300000),
            // Четвёртое агенство
            new AgencyAppartmentConnection(4, 2, 90000),
            new AgencyAppartmentConnection(4, 12, 34000),
            new AgencyAppartmentConnection(4, 13, 140000),
            // Пятое агенство
            new AgencyAppartmentConnection(5, 5, 32000),
            new AgencyAppartmentConnection(5, 7, 93000),
            new AgencyAppartmentConnection(5, 12, 30000),
            new AgencyAppartmentConnection(5, 13, 138000)
        };
    }
}
