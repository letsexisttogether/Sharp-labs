using Lab9.MainClasses;
using System.Collections.Generic;

namespace SolutionItems
{
    public class DataListsHolder
    {
        public List<Apartment> Apartments { get; init; }
            = new()
            {
                new()
                {
                    ApartmentId = 1,
                    ApartmentAddress = "Тараса Шевченко 17, б. 13 кв. 35",
                    ApartmentFloor = 15,
                    ApartmentSquare = 86.3
                },
                new()
                {
                    ApartmentId = 2,
                    ApartmentAddress = "Острізька, б. 3, кв. 17",
                    ApartmentFloor = 1,
                    ApartmentSquare = 90
                },
                new()
                {
                    ApartmentId = 3,
                    ApartmentAddress = "Володимирська, б. 14, кв. 13",
                    ApartmentFloor = 11,
                    ApartmentSquare = 110.5
                },
                new()
                {
                    ApartmentId = 4,
                    ApartmentAddress = "Мельнікова, б. 81, кв. 71",
                    ApartmentFloor = 15,
                    ApartmentSquare = 31.5
                },
                new()
                {
                    ApartmentId = 5,
                    ApartmentAddress = "Горицького, б. 42, кв. 89",
                    ApartmentFloor = 3,
                    ApartmentSquare = 30
                },
                new()
                {
                    ApartmentId = 6,
                    ApartmentAddress = "Прорізна, б. 78. кв. 12",
                    ApartmentFloor = 4,
                    ApartmentSquare = 85.4
                },
                new()
                {
                    ApartmentId = 7,
                    ApartmentAddress = "П. Орліка, б. 17, кв. 1",
                    ApartmentFloor = 4,
                    ApartmentSquare = 83.5
                },
                new()
                {
                    ApartmentId = 8,
                    ApartmentAddress = "Тараса Шевченко, б. 82. кв. 392",
                    ApartmentFloor = 4,
                    ApartmentSquare = 90
                },
                new()
                {
                    ApartmentId = 9,
                    ApartmentAddress = "Житомирська, б. 34, кв. 7",
                    ApartmentFloor = 15,
                    ApartmentSquare = 35.5
                },
                new()
                {
                    ApartmentId = 10,
                    ApartmentAddress = "Волинська, б. 42, кв. 4",
                    ApartmentFloor = 1,
                    ApartmentSquare = 110.5
                },
                new()
                {
                    ApartmentId = 11,
                    ApartmentAddress = "Широва, б. 23, кв. 2",
                    ApartmentFloor = 5,
                    ApartmentSquare = 89.8
                },
                new()
                {
                    ApartmentId = 12,
                    ApartmentAddress = "Копіленка, б. 71, кв. 1",
                    ApartmentFloor = 3,
                    ApartmentSquare = 32
                },
                new()
                {
                    ApartmentId = 13,
                    ApartmentAddress = "Інститутская, б. 1. кв. 5",
                    ApartmentFloor = 4,
                    ApartmentSquare = 70
                },
                new()
                {
                    ApartmentId = 14,
                    ApartmentAddress = "Фізкультури, б. 105, кв. 1",
                    ApartmentFloor = 5,
                    ApartmentSquare = 90.9
                },
                new()
                {
                    ApartmentId = 15,
                    ApartmentAddress = "Львівська, б. 99, кв. 3",
                    ApartmentFloor = 9,
                    ApartmentSquare = 120
                },
            };

        public List<Agency> Agencies { get; init; }
            = new()
            {
                new()
                {
                    AgencyId = 1,
                    AgencyName = "Продажа нерухомості",
                    AgencyAddress = "Інститутська, б. 30",
                    EstateAgents = new()
                    {
                        new()
                        {
                            AgentName = "Ігор",
                            AgentMobile = "0997651464"
                        },
                        new()
                        {
                            AgentName = "Вікторія",
                            AgentMobile = "0988351016"
                        },
                        new()
                        {
                            AgentName = "Олег",
                            AgentMobile = "0678559016"
                        }
                    }
                },
                new()
                {
                    AgencyId = 2,
                    AgencyName = "BSeller",
                    AgencyAddress = "Львівська, б. 34",
                    EstateAgents = new()
                    {
                        new()
                        {
                            AgentName = "Владислав",
                            AgentMobile = "0998561451"
                        },
                        new()
                        {
                            AgentName = "Олександр",
                            AgentMobile = "0957651485"
                        }
                    }
                },
                new()
                {
                    AgencyId = 3,
                    AgencyName = "Plost",
                    AgencyAddress = "Пірогова, б. 38",
                    EstateAgents = new()
                    {
                        new()
                        {
                            AgentName = "Єгор",
                            AgentMobile = "0674510845"
                        }
                    }

                },
                new()
                {
                    AgencyId = 4,
                    AgencyName = "Афірма",
                    AgencyAddress = "Лимова, б. 17",
                    EstateAgents = new()
                    {
                        new()
                        {
                            AgentName = "Віктор",
                            AgentMobile = "987656543"
                        },
                        new()
                        {
                            AgentName = "Дитх'яр",
                            AgentMobile = "0957867646"
                        },
                        new()
                        {
                            AgentName = "Володимир",
                            AgentMobile = "0987651819"
                        }
                    }
                },
                new()
                {
                    AgencyId = 5,
                    AgencyName = "Fast flat",
                    AgencyAddress = "М. Коцюбинського, б. 25",
                    EstateAgents = new()
                    {
                        new()
                        {
                            AgentName = "В'ячеслав",
                            AgentMobile = "0959059806"
                        },
                        new()
                        {
                            AgentName = "Олександр",
                            AgentMobile = "0508956338"
                        },
                        new()
                        {
                            AgentName = "Богдана",
                            AgentMobile = "0994718909"
                        },
                        new()
                        {
                            AgentName = "Богдан",
                            AgentMobile = "0671238764"
                        },
                        new()
                        {
                            AgentName = "Ігор",
                            AgentMobile = "0994897659"
                        }
                    }
                }
            };

        public List<AgencyAppartmentConnection> AgencyAppartmentConnections { get; init; }
            = new()
            {
                new()
                {
                    AgencyId = 1,
                    ApartmentId = 1,
                    ApartmentPrice = 45000
                },
                new()
                {
                    AgencyId = 1,
                    ApartmentId = 3,
                    ApartmentPrice = 120000
                },
                new()
                {
                    AgencyId = 1,
                    ApartmentId = 6,
                    ApartmentPrice = 68000
                },
                new()
                {
                    AgencyId = 1,
                    ApartmentId = 9,
                    ApartmentPrice = 41000
                },
                new()
                {
                    AgencyId = 1,
                    ApartmentId = 14,
                    ApartmentPrice = 118000
                },
                new()
                {
                    AgencyId = 2,
                    ApartmentId = 3,
                    ApartmentPrice = 115000
                },
                new()
                {
                    AgencyId = 2,
                    ApartmentId = 4,
                    ApartmentPrice = 35000
                },
                new()
                {
                    AgencyId = 2,
                    ApartmentId = 5,
                    ApartmentPrice = 40000
                },
                new()
                {
                    AgencyId = 2,
                    ApartmentId = 6,
                    ApartmentPrice = 110000
                },
                new()
                {
                    AgencyId = 3,
                    ApartmentId = 2,
                    ApartmentPrice = 100000
                },
                new()
                {
                    AgencyId = 3,
                    ApartmentId = 9,
                    ApartmentPrice = 40500
                },
                new()
                { 
                    AgencyId = 3,
                    ApartmentId = 8, 
                    ApartmentPrice = 70800,
                },
                new()
                {
                    AgencyId = 3, 
                    ApartmentId = 11,
                    ApartmentPrice = 140000
                },
                new()
                {
                    AgencyId = 3,
                    ApartmentId = 15, 
                    ApartmentPrice = 300000
                },
                new()
                {
                    AgencyId = 4, 
                    ApartmentId = 5, 
                    ApartmentPrice = 90000
                },
                new()
                {
                    AgencyId = 4,
                    ApartmentId = 12,
                    ApartmentPrice = 34000
                },
                new()
                {
                    AgencyId = 4,
                    ApartmentId = 13,
                    ApartmentPrice = 140000
                },
                new()
                {
                    AgencyId = 5, 
                    ApartmentId = 5,
                    ApartmentPrice = 32000
                },
                new()
                {
                    AgencyId = 5,
                    ApartmentId = 7,
                    ApartmentPrice = 93000
                },
                new()
                {
                    AgencyId = 5,
                    ApartmentId = 12,
                    ApartmentPrice = 30000
                },
                new()
                {
                    AgencyId = 5,
                    ApartmentId = 13,
                    ApartmentPrice = 138000
                }
            };
    }
}
