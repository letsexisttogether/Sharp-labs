using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_lab_1_v_9
{
    /// <summary>
    /// Для зберігання данних о квартирі 
    /// </summary>
    class Apartment
    {
        /// <summary>
        /// Шифр квартири
        /// </summary>
        public int ApartmentID { get; private set; }
        /// <summary>
        /// Адреса квартири
        /// </summary>
        public string ApartmentAddress { get; private set; }
        /// <summary>
        /// Поверх квартири
        /// </summary>
        public int ApartmentFloor { get; private set; }
        /// <summary>
        /// Загальна площа квартири в м. кв.
        /// </summary>
        public double ApartmentSquare { get; private set; }
        
        /// <summary>
        /// Конструктор за замовчуванням 
        /// </summary>
        public Apartment()
        {
            ApartmentID = 0;
            ApartmentAddress = "No address given";
            ApartmentFloor = 0;
            ApartmentSquare = 0;
        }
        /// <summary>
        /// Конструктор з параметрами
        /// </summary>
        public Apartment(int newApartmentID, string newApartmentAddress, int newApartmentFloor, double newApartmentSquare)
        {
            ApartmentID = newApartmentID;
            ApartmentAddress = newApartmentAddress;
            ApartmentFloor = newApartmentFloor;
            ApartmentSquare = newApartmentSquare;
        }

        /// <summary>
        /// Перевантажений метод для отримання всіх даних об'єкту у вигляді рядка 
        /// </summary>
        /// <returns>Рядок з даними всі полей</returns>
        public override string ToString()
        {
            return $"ID: {ApartmentID}, Адреса: {ApartmentAddress} " +
                $"Поверх квартири: {ApartmentFloor}, Площа: {ApartmentSquare}";
        }
    }
    /// <summary>
    /// Для зберігання даних о рієлторі
    /// </summary>
    class Estate_Agent
    {
        /// <summary>
        /// Ім'я рієлтора
        /// </summary>
        public string AgentName { get; private set; }
        /// <summary>
        /// Мобільний телефон рієлтора
        /// </summary>
        public long AgentMobile { get; private set; }

        /// <summary>
        /// Конструктор за замовчуванням
        /// </summary>
        public Estate_Agent()
        {
            AgentName = "No name given";
            AgentMobile = 0;
        }
        /// <summary>
        /// Конструктор з параметрами
        /// </summary>
        public Estate_Agent(string newAgentName, long newAgentMobile)
        {
            AgentName = newAgentName;
            AgentMobile = newAgentMobile;
        }
        /// <summary>
        /// Переванажений метод для отримання всі даних рієлтора у вигляді рядка
        /// </summary>
        /// <returns>Ім'я та мобільний телефон рієлтора</returns>
        public override string ToString()
        {
            return $"Ім'я: {AgentName}, Мобільний телефон: {AgentMobile}\n";
        }
    }
    /// <summary>
    /// Для хранения даних об агенстві
    /// </summary>
    class Agency
    {
        /// <summary>
        /// Шифр агенства
        /// </summary>
        public int AgencyID { get; private set; }
        /// <summary>
        /// Назва агенства
        /// </summary>
        public string AgencyName { get; private set; }
        /// <summary>
        /// Адреса агенства
        /// </summary>
        public string AgencyAddress { get; private set; }
        /// <summary>
        /// Список рієлторів, які належать агенству
        /// </summary>
        public List<Estate_Agent> Estate_Agents { get; private set; }

        /// <summary>
        /// Конструктор за замовчуванням
        /// </summary>
        public Agency()
        {
            AgencyID = 0;
            AgencyName = "No name given";
            AgencyAddress = "No address given";
            Estate_Agents = new List<Estate_Agent>();
        }
        /// <summary>
        /// Конструктор з параметрами
        /// </summary>
        public Agency(int newID, string newName, string newAddress, List<Estate_Agent> newEstateList)
        {
            AgencyID = newID;
            AgencyName = newName;
            AgencyAddress = newAddress;
            Estate_Agents = newEstateList;
        }
        /// <summary>
        /// Перевантажений метод для отримання всіх даних агенства у вигляді рядка
        /// </summary>
        /// <returns>Шифр агентсва, назва, адреса та дані всіх рієлторів</returns>
        public override string ToString()
        {
            string AllFieldsInfo = $"ID: {AgencyID}, Назва: {AgencyName}, Адреса: {AgencyAddress}"
                + "\nСписок всіх рієлторів:\n";
            foreach (var realtor in Estate_Agents)
                AllFieldsInfo += realtor.ToString();
            return AllFieldsInfo;
        }
        /// <summary>
        /// Перевантажений метод для отримання даних агенства.
        /// Не повертає дані рієлторі, які прцюють в агенстві
        /// </summary>
        /// <returns>Шифр агенства, назва та адреса</returns>
        public string ToShortString()
        {
            return $"ID: {AgencyID}, Назва: {AgencyName}, Адреса: {AgencyAddress}, " +
                $"Кількість агентів: {Estate_Agents.Count()}";
        }
    }
    /// <summary>
    /// Для зв'язку квартири та агенства
    /// </summary>
    class AgencyAppartmentConnection
    {
        /// <summary>
        /// Шифр агенства
        /// </summary>
        public int AgencyID { get; private set; }
        /// <summary>
        /// Шифр квартири
        /// </summary>
        public int AppartmentID { get; private set; }
        /// <summary>
        /// Ціна за квартиру в $
        /// </summary>
        public int AppartmentPrice { get; private set; }

        /// <summary>
        /// Конструктор за замовчуванням
        /// </summary>
        public AgencyAppartmentConnection()
        {
            AgencyID = 0;
            AppartmentID = 0;
            AppartmentPrice = 0;
        }
        /// <summary>
        /// Конструктор з параметрами
        /// </summary>
        public AgencyAppartmentConnection(int newAgencyID, int newAppartmentID, int newPrice)
        {
            AgencyID = newAgencyID;
            AppartmentID = newAppartmentID;
            AppartmentPrice = newPrice;
        }
    }
}
