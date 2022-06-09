using System;
using System.Collections.Generic;

namespace Lab9.MainClasses
{
    public class Agency
    {
        public int AgencyId { get; init; }
        public string AgencyName { get; init; }
        public string AgencyAddress { get; init; }
        public List<EstateAgent> EstateAgents { get; init; }

        public Agency()
        {
            AgencyId = 0;
            AgencyName = String.Empty;
            AgencyAddress = String.Empty;
            EstateAgents = new();
        }

        public override string ToString()
        {
            string infoAsString = $"ID агенства: {AgencyId} Назва агенства: " +
                $"{AgencyName} Адреса агенства: {AgencyAddress}";
            foreach (EstateAgent agencyWorker in EstateAgents)
                String.Concat(infoAsString, agencyWorker);
            return infoAsString;
        }
    }
}
