using SolutionItems;

namespace ExtraService
{
    public class PrintAndQueriesConnector
    {
        private QueriesExecutor _qryExecutor;
        private ConsoleQueriesPrinter _printer;
        private DataListsHolder _dataLists;

        public PrintAndQueriesConnector(QueriesExecutor qryExecutor, ConsoleQueriesPrinter printer,
               DataListsHolder dataLists)
        {
            this._qryExecutor = qryExecutor;
            this._printer = printer;
            this._dataLists = dataLists;
        }

        public void PrintAllAgents()
        {
            _printer.Print("всіх агентів", _qryExecutor.GetAllAgents(_dataLists.Agencies));
        }

        public void PrintAgenciesWithMoreThanOneWordName()
        {
            _printer.Print("всі агентсва, ім'я яких складається більше ніж з 2-х слів",
                _qryExecutor.GetAgenciesWithMoreThanOneWordName(_dataLists.Agencies));
        }

        public void PrintAgenciesGroupedByWorkersCount()
        {
            _printer.Print("агенства, згруповані за кількістю працівників",
                _qryExecutor.GetAgenciesGroupedByWorkersCount(_dataLists.Agencies));
        }

        public void PrintAgenciesWithHighAddressLength()
        {
            _printer.Print("агенства з найдовшою адресою",
                _qryExecutor.GetAgenciesWithHighAddressLength(_dataLists.Agencies));
        }

        public void PrintAgenciesSortedByNameLength()
        {
            _printer.Print("агенства, сортовані за довжиною назви",
                _qryExecutor.GetAgenciesOrderedByNameLength(_dataLists.Agencies));
        }

        public void PrintAgencyWithSpecificWorkerName()
        {
            _printer.Print("агента з ім'ям Ігор",
                _qryExecutor.GetAgencyWithSpecificWorkerName(_dataLists.Agencies, "Ігор"));
        }

        public void PrintApartmentsWithParticularSquare()
        {
            _printer.Print("квартири з площою від 75 до 100",
                _qryExecutor.GetApartmentsWithParticularSquare(_dataLists.Apartments, 75, 100));
        }

        public void PrintApartmentsOrderedBySquareDescending()
        {
            _printer.Print("квартири, сортовані за площою у зоворньому порядку",
                _qryExecutor.GetApartmentsOrderedBySquareDescending(_dataLists.Apartments));
        }

        public void PrintApartmentsGroupedByFloor()
        {
            _printer.Print("квартири, згруповані за поверхами",
                _qryExecutor.GetApartmentsGroupedByFloor(_dataLists.Apartments));
        }

        public void PrintAgencyOrderedByAvgApartmentPrice()
        {
            _printer.Print("агенства, сортовані за сереньою ціною квартир, які вони продають",
                _qryExecutor.GetAgencyOrderedByAvgApartmentPrice(_dataLists.Agencies,
                _dataLists.AgencyAppartmentConnections));
        }

        public void PrintApartmentsSoldByMoreThanFourPeople()
        {
            _printer.Print(" квартири, які продають агентсва з кількістю агентів більше чотирьох",
                _qryExecutor.GetApartmentsSoldByMoreThanFourPeople(_dataLists.Apartments,
                _dataLists.Agencies, _dataLists.AgencyAppartmentConnections));
        }

        public void PrintAgencyOfHighestFloorApartment()
        {
            _printer.Print("агенства з найвищіми квартирами",
                _qryExecutor.GetAgencyOfHighestFloorApartment(_dataLists.Apartments,
                _dataLists.Agencies, _dataLists.AgencyAppartmentConnections));
        }

        public void PrintAgencySortedByApartmentsCount()
        {
            _printer.Print("агенства, сортовані за кількістью продаваємих квартир",
                _qryExecutor.GetAgencyOrderedByApartmentsCount(_dataLists.Agencies,
                _dataLists.AgencyAppartmentConnections));
        }

        public void PrintApartmentsWithHigherAndLowestPrice()
        {
            _printer.Print("квартири з найвищою та найнижчою ціною",
                _qryExecutor.GetApartmentsWithHigherAndLowestPrice(_dataLists.Apartments,
                _dataLists.AgencyAppartmentConnections));
        }

        public void PrintAgenciesOrderedByApartmentPriceSum()
        {
            _printer.Print("агентва, сортовані за сумою цін продаваємих квартир",
                _qryExecutor.GetAgenciesOrderedByApartmentPriceSum(_dataLists.Agencies,
                _dataLists.AgencyAppartmentConnections));
        }
    }
}

