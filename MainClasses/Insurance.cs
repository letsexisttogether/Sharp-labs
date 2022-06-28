using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace MainClasses
{
    public class Insurance
    {
        public Dictionary<InsuranceCase, float> Cases { get; init; } = new();
        public DateOnly ActiveByDate { get; init; }
        
        public float TakeMoneyFromInsurance(InsuranceCase insuranceCase)
        {
            if(!Cases.Any(iCase => iCase.Key == insuranceCase))
            {
                return 0.0f;
            }
            return Cases
                .Where(iCase => iCase.Key == insuranceCase)
                .Select(iCase => iCase.Value).FirstOrDefault();
        }
        public bool AddInsuranceCase(InsuranceCase insuranceCase, float moneyAmount)
        {
            if(Cases.Any(iCase => iCase.Key == insuranceCase))
            {
                return false;
            }
            Cases.Add(insuranceCase, moneyAmount);
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new($"Страховий поліс:\nДійсний до: {ActiveByDate}\n");
            foreach(KeyValuePair<InsuranceCase, float> iCase in Cases)
            {
                sb.AppendLine($"Випадок: {iCase.Key} Сума виплати: {iCase.Value} грн");
            }
            return sb.ToString();
        }

    }
}
