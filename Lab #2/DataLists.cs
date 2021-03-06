using System.Collections.Generic;
using MainModel;

namespace ModelRender
{
    public class DataLists
    {
        public List<Apartment> Apartments { get; } = new()
        {
            new()
            {
                Id = 1,
                Address = "Тараса Шевченко 17, б. 13 кв. 35",
                Floor = 15,
                Square = 86.3f
            },
            new()
            {
                Id = 2,
                Address = "Острізька, б. 3, кв. 17",
                Floor = 1,
                Square = 90f
            },
            new()
            {
                Id = 3,
                Address = "Володимирська, б. 14, кв. 13",
                Floor = 11,
                Square = 110.5f
            },
            new()
            {
                Id = 4,
                Address = "Мельнікова, б. 81, кв. 71",
                Floor = 15,
                Square = 31.5f
            },
            new()
            {
                Id = 5,
                Address = "Горицького, б. 42, кв. 89",
                Floor = 3,
                Square = 30f
            },
            new()
            {
                Id = 6,
                Address = "Прорізна, б. 78. кв. 12",
                Floor = 4,
                Square = 85.4f
            },
            new()
            {
                Id = 7,
                Address = "П. Орліка, б. 17, кв. 1",
                Floor = 4,
                Square = 83.5f
            },
            new()
            {
                Id = 8,
                Address = "Тараса Шевченко, б. 82. кв. 392",
                Floor = 4,
                Square = 90f
            },
            new()
            {
                Id = 9,
                Address = "Житомирська, б. 34, кв. 7",
                Floor = 15,
                Square = 35.5f
            },
            new()
            {
                Id = 10,
                Address = "Волинська, б. 42, кв. 4",
                Floor = 1,
                Square = 110.5f
            },
            new()
            {
                Id = 11,
                Address = "Широва, б. 23, кв. 2",
                Floor = 5,
                Square = 89.8f
            },
            new()
            {
                Id = 12,
                Address = "Копіленка, б. 71, кв. 1",
                Floor = 3,
                Square = 32f
            },
            new()
            {
                Id = 13,
                Address = "Інститутская, б. 1. кв. 5",
                Floor = 4,
                Square = 70f
            },
            new()
            {
                Id = 14,
                Address = "Фізкультури, б. 105, кв. 1",
                Floor = 5,
                Square = 90.9f
            },
            new()
            {
                Id = 15,
                Address = "Львівська, б. 99, кв. 3",
                Floor = 9,
                Square = 120f
            },
        };
        public List<Agency> Agencies { get; } = new()
        {
            new()
            {
                Id = 1,
                Title = "Продажа нерухомості",
                Address = "Інститутська, б. 30"
            },
            new()
            {
                Id = 2,
                Title = "BSeller",
                Address = "Львівська, б. 34",
            },
            new()
            {
                Id = 3,
                Title = "Plost",
                Address = "Пірогова, б. 38",


            },
            new()
            {
                Id = 4,
                Title = "Афірма",
                Address = "Лимова, б. 17",

            },
            new()
            {
                Id = 5,
                Title = "Fast flat",
                Address = "М. Коцюбинського, б. 25",

            }
        };
        public List<EstateAgent> EstateAgents { get; } = new()
        {
            new()
            {
                Id = 1,
                AgencyId = 1,
                Name = "Ігор",
                MobileNumber = "0997651464"
            },
            new()
            {
                Id = 2,
                AgencyId = 1,
                Name = "Вікторія",
                MobileNumber = "0988351016"
            },
            new()
            {
                Id = 3,
                AgencyId = 1,
                Name = "Олег",
                MobileNumber = "0678559016"
            },
            new()
            {
                Id = 4,
                AgencyId = 2,
                Name = "Владислав",
                MobileNumber = "0998561451"
            },
            new()
            {
                Id = 5,
                Name = "Олександр",
                AgencyId = 2,
                MobileNumber = "0957651485"
            },
            new()
            {
                Id = 6,
                AgencyId = 3,
                Name = "Єгор",
                MobileNumber = "0674510845"
            },
            new()
            {
                Id = 7,
                AgencyId = 4,
                Name = "Віктор",
                MobileNumber = "987656543"
            },
            new()
            {
                Id = 8,
                AgencyId = 4,
                Name = "Дитх'яр",
                MobileNumber = "0957867646"
            },
            new()
            {
                Id = 9,
                AgencyId = 4,
                Name = "Володимир",
                MobileNumber = "0987651819"
            },
            new()
            {
                Id = 10,
                AgencyId = 5,
                Name = "В'ячеслав",
                MobileNumber = "0959059806"
            },
            new()
            {
                Id = 11,
                AgencyId = 5,
                Name = "Олександр",
                MobileNumber = "0508956338"
            },
            new()
            {
                Id = 12,
                AgencyId = 5,
                Name = "Богдана",
                MobileNumber = "0994718909"
            },
            new()
            {
                Id = 13,
                AgencyId = 5,
                Name = "Богдан",
                MobileNumber = "0671238764"
            },
            new()
            {
                Id = 14,
                AgencyId = 5,
                Name = "Ігор",
                MobileNumber = "0994897659"
            }
        };
        public List<AgencyApartmentConnection> AgencyAppartmentConntections { get; } = new()
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
