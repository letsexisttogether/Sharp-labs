using System;
using System.Collections.Generic;
using System.Linq;
using Lab9.MainClasses;

namespace SolutionItems
{
    public class QueriesExecutor
    {
        // #1
        public IEnumerable<EstateAgent> GetAllAgents(IEnumerable<Agency> agencies)
        {
            return agencies.SelectMany(agency => agency.EstateAgents);
        }

        // #2
        public IEnumerable<Agency> GetAgenciesWithMoreThanOneWordName(IEnumerable<Agency> agencies)
        {
            return agencies.Where(agency => agency.AgencyName.Contains(' '));
        }

        // #3
        public IEnumerable<IGrouping<int, Agency>> GetAgenciesGroupedByWorkersCount(IEnumerable<Agency> agencies)
        {
            return from agency in agencies
                   group agency by agency.EstateAgents.Count();
        }

        // #4
        public IEnumerable<Agency> GetAgenciesWithHighAddressLength(IEnumerable<Agency> agencies)
        {
            return agencies.Where(agency => agency.AgencyAddress.Length > 15
            && agency.EstateAgents.Any(estateAgent => estateAgent.AgentMobile.StartsWith("099")));
        }

        // #5
        public IEnumerable<Agency> GetAgenciesOrderedByNameLength(IEnumerable<Agency> agencies)
        {
            return from agency in agencies
                   orderby agency.AgencyName.Length
                   select agency;
        }

        // #6
        public IEnumerable<Agency> GetAgencyWithSpecificWorkerName(IEnumerable<Agency> agencies, 
            string specificName)
        {
            return agencies
                   .Where(agency => agency.EstateAgents
                   .Any(estateAgent => estateAgent.AgentName == specificName));
        }

        // #7
        public IEnumerable<Apartment> GetApartmentsWithParticularSquare(IEnumerable<Apartment> apartments,
            int minSquare, int manSquare)
        {
            return from apartment in apartments
                   where apartment.ApartmentSquare >= minSquare
                   && apartment.ApartmentSquare <= manSquare
                   select apartment;
        }

        // #8
        public IEnumerable<Apartment> GetApartmentsOrderedBySquareDescending(IEnumerable<Apartment> apartments)
        {
            return apartments.OrderByDescending(apartment => apartment.ApartmentSquare);
        }

        // #9
        public IEnumerable<IGrouping<int, Apartment>> GetApartmentsGroupedByFloor
            (IEnumerable<Apartment> apartments)
        {
            return from apartment in apartments
                   orderby apartment.ApartmentFloor
                   group apartment by apartment.ApartmentFloor;
        }

        // #10
        public IEnumerable<Agency> GetAgencyOrderedByAvgApartmentPrice(IEnumerable<Agency> agencies, 
            IEnumerable<AgencyAppartmentConnection> agencyAppartmentConnections)
        {
            return agencies.GroupJoin(agencyAppartmentConnections,
                agency => agency.AgencyId,
                agApCon => agApCon.AgencyId,
                (agency, agApCon) => new
                {
                    AgencyInfo = agency,
                    ApartmentAvgPrive = agApCon.Average(apartment => apartment.ApartmentPrice)
                })
                .OrderBy(agency => agency.ApartmentAvgPrive)
                .Select(agency => agency.AgencyInfo);
        }

        // #11
        public IEnumerable<Apartment> GetApartmentsSoldByMoreThanFourPeople(IEnumerable<Apartment> apartments,
            IEnumerable<Agency> agencies, IEnumerable<AgencyAppartmentConnection> agencyAppartmentConnections)
        {
            IEnumerable<int> agencyIds = from agency in agencies
                                         where agency.EstateAgents.Count() >= 4
                                         select agency.AgencyId;

            IEnumerable<int> apartmentIds = (from agency in agencyAppartmentConnections
                                             join agencyId in agencyIds
                                             on agency.AgencyId equals agencyId
                                             select agency.ApartmentId)
                                            .Distinct();

            return from apartment in apartments
                   join apartmentId in apartmentIds
                   on apartment.ApartmentId equals apartmentId
                   select apartment;
        }

        // #12
        public IEnumerable<Agency> GetAgencyOfHighestFloorApartment(IEnumerable<Apartment> apartments,
            IEnumerable<Agency> agencies, IEnumerable<AgencyAppartmentConnection> agencyAppartmentConnections)
        {
            int highestFloor = apartments.Max(apartment => apartment.ApartmentFloor);
            IEnumerable<int> hightesFloorApartmentIds = apartments
                .Where(apartment => apartment.ApartmentFloor == highestFloor)
                .Select(apartment => apartment.ApartmentId);
            
            IEnumerable<int> higestFloorAgencyIds = agencyAppartmentConnections
                .Join(hightesFloorApartmentIds,
                agApCon => agApCon.ApartmentId,
                hfApartmentId => hfApartmentId,
                (apartment, hfApartmentId) => apartment.AgencyId)
                .Distinct();

            return agencies
                .Join(higestFloorAgencyIds,
                agency => agency.AgencyId,
                hfAgencyId => hfAgencyId,
                (agency, hdAgencyId) => agency);
        }

        // #13
        public IEnumerable<Agency> GetAgencyOrderedByApartmentsCount(IEnumerable<Agency> agencies, 
            IEnumerable<AgencyAppartmentConnection> agencyAppartmentConnections)
        {
            return from agency in
                       from agApCon in agencyAppartmentConnections
                       join agency in agencies
                       on agApCon.AgencyId equals agency.AgencyId
                       group agency by agApCon.AgencyId into agencyGroup
                       select new
                       {
                           agency = agencyGroup.FirstOrDefault(),
                           agecniesCount = agencyGroup.Count()
                       }
                   orderby agency.agecniesCount
                   select agency.agency;
        }

        // #14
        public IEnumerable<Apartment> GetApartmentsWithHigherAndLowestPrice(IEnumerable<Apartment> apartments,
            IEnumerable<AgencyAppartmentConnection> agencyAppartmentConnections)
        {
            int? highestPrice = agencyAppartmentConnections.Max(agApCon => agApCon.ApartmentPrice);
            int? lowestPrice = agencyAppartmentConnections.Min(agApCon => agApCon.ApartmentPrice);

            IEnumerable<Apartment> highestPriceApartmentsId = agencyAppartmentConnections
                .Where(agApCon => agApCon.ApartmentPrice == highestPrice)
                .Join(apartments,
                agApCon => agApCon.ApartmentId,
                apartment => apartment.ApartmentId,
                (agApCon, apartment) => apartment);
            
            IEnumerable<Apartment> lowestPriceApartmentsId = agencyAppartmentConnections
                .Where(agApCon => agApCon.ApartmentPrice == lowestPrice)
                .Join(apartments,
                agApCon => agApCon.ApartmentId,
                apartment => apartment.ApartmentId,
                (agApCon, apartment) => apartment);

            return highestPriceApartmentsId.Concat(lowestPriceApartmentsId);
        }

        // #15 
        public IEnumerable<Agency> GetAgenciesOrderedByApartmentPriceSum(IEnumerable<Agency> agencies,
            IEnumerable<AgencyAppartmentConnection> agencyAppartmentConnections)
        {
            IEnumerable<int> agecnyIds = from item in
                                             from agApCon in agencyAppartmentConnections
                                             group agApCon by agApCon.AgencyId into agApConGroup
                                             select new
                                             {
                                                 agencyId = agApConGroup.First().AgencyId,
                                                 sumPrice = agApConGroup.Sum(agApCon => agApCon.ApartmentPrice)
                                             }
                                         orderby item.sumPrice
                                         select item.agencyId;

            return from agencyId in agecnyIds
                   join agecny in agencies
                   on agencyId equals agecny.AgencyId
                   select agecny;
        }
    }
}