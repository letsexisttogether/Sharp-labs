using System;
using System.Collections.Generic;
using SolutionItems;
using ExtraService;

namespace Lab9
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            QueriesExecutor qryExecutor = new();
            ConsoleQueriesPrinter printer = new();
            DataListsHolder dataLists = new();

            PrintAndQueriesConnector printQryCon = new(qryExecutor, printer, dataLists);

            Menu menu = new();
            menu.Items = new()
            {
                new MenuItem("1. Отримати всіх агентів", printQryCon.PrintAllAgents),

                new MenuItem("2. Отримати агентсва, назва яких складається більше ніж з 2-х слів",
                printQryCon.PrintAgenciesWithMoreThanOneWordName),

                new MenuItem("3. Отримати агенства, згруповані за кількістю працівників",
                printQryCon.PrintAgenciesGroupedByWorkersCount),

                new MenuItem("4. Отримати агенство з найдовшою адресою",
                printQryCon.PrintAgenciesWithHighAddressLength),

                new MenuItem("5. Отримати агенства, сортовані за довжиною назви",
                printQryCon.PrintAgenciesSortedByNameLength),

                new MenuItem("6. Отримати агента з заданим ім'ям",
                printQryCon.PrintAgencyWithSpecificWorkerName),

                new MenuItem("7. Отримати квартири з заданою площою",
                printQryCon.PrintApartmentsWithParticularSquare),

                new MenuItem("8. Отримати квартири, сортовані за площою у зоворньому порядку",
                printQryCon.PrintApartmentsOrderedBySquareDescending),

                new MenuItem("9. Отримати квартири, згруповані за поверхами",
                printQryCon.PrintApartmentsGroupedByFloor),

                new MenuItem("10. Отримати агенства, сортовані за сереньою ціною квартир, які вони продають",
                printQryCon.PrintAgencyOrderedByAvgApartmentPrice),

                new MenuItem("11. Отрмати квартири, які продають агентсва з кількістю агентів більше чотирьох",
                printQryCon.PrintApartmentsSoldByMoreThanFourPeople),

                new MenuItem("12. Отримати агенства з найвищіми квартирами",
                printQryCon.PrintAgencyOfHighestFloorApartment),

                new MenuItem("13. Отримати агенства, сортовані за кількістью продаваємих квартир",
                printQryCon.PrintAgencySortedByApartmentsCount),

                new MenuItem("14. Отримати квартири з найвищою та найнижчою ціною",
                printQryCon.PrintApartmentsWithHigherAndLowestPrice),

                new MenuItem("15. Отримати агентва, сортовані за сумою цін продаваємих квартир",
                printQryCon.PrintAgenciesOrderedByApartmentPriceSum),

                new MenuItem("\n16. Вихід", () => menu.IsExitWanted = true)
            };

            MenuItemSelector selector = new(1, menu.ItemsCount);

            while(!menu.IsExitWanted)
            {
                menu.PrintMenu();
                menu.ExecuteSelectedItem(selector.SelectItem());
                
                Console.WriteLine("\nДля продовження натисніть будь-яку клавішу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
