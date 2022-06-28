using System;

namespace MainClasses
{
    public class UniversalCard
    {
        private Passport _passport = new();
        private Insurance? _insurance = new();
        private BankCard? _card = new();

        public void ChangeUser(Passport passport)
        {
            _passport = passport;
            _insurance = null;
            _card = null;
        }

        public void ChangeInsuranse(Insurance insurance)
        {
            _insurance = insurance;
        }
        public void ChangeBankCard(BankCard bankCard)
        {
            _card = bankCard;
        }

        public void AddInsuranceCase(InsuranceCase insuranceCase, float moneyAmount)
        {
            if (_insurance is null)
            {
                Console.WriteLine("У поточного користувача немає жодного страхового полісу");
            }
            else if (!_insurance.AddInsuranceCase(insuranceCase, moneyAmount))
            {
                Console.WriteLine("Сталася помилка, такий страховий випадок вже існує");
            }
            else
            {
                Console.WriteLine("Страховий випадок успішно додано");
            }

        }
        public void TakeMoneyFromInsuranse(InsuranceCase insuranceCase)
        {
            if(_insurance is null)
            {
                Console.WriteLine("У поточної людини немає жодного полісу");
            }
            else if(_card is null)
            {
                Console.WriteLine("Наразі немає приєднаної карти");
            }
            else
            {
                float moneyAmount = _insurance.TakeMoneyFromInsurance(insuranceCase);
                if (moneyAmount <= 0)
                {
                    Console.WriteLine("Сталася помилка. Спробуйте повторити операцію.");
                }
                else
                {
                    _card.AddMoney(moneyAmount);
                }
            }
        }

        public void PayTheBills(float billsMoneyAmount)
        {
            if (_card is null)
            {
                Console.WriteLine("Наразі немає приєднаної картки");
            }
            else if (!_card.TakeMoney(billsMoneyAmount))
            {
                Console.WriteLine("На рахунку недостатньо коштів");
            }
            else
            {
                Console.WriteLine("Всі рахунки було сплачено");
            }
        }
        public void CheckMoneyAmount()
        {
            if(_card is not null)
            {
                Console.WriteLine($"На балансі: {_card.CurrentMoneyAmount} грн");
            }
            else
            {
                Console.WriteLine("Наразі немає приєднаної картки");
            }
        }

        public override string ToString()
        {
            return $"{_passport} " +
                $"\n\n{_insurance}\n{_card}"; 
        }
    }
}
