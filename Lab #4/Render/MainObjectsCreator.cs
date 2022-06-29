using System;
using System.Collections.Generic;
using MainClasses;

namespace Render
{
    public class MainObjectsCreator
    {
        public ValueEnterHelper EnterHelper { private get; init; } = new();
        public Passport CreatePassport()
        {
            string number;
            while(true)
            {
                number = EnterHelper.StringValueEnter("Введіть номер паспорту (10 цифр): ");
                if(number.Length != 10)
                {
                    Console.WriteLine("Ви ввели невірну кількість знаків для номеру паспорта");
                    continue;
                }
                break;
            }
            return new Passport()
            {
                Number = number,
                ActiveByDate = EnterHelper.DataOnlyValueEnter("Паспорт діє до: "),
                RegestrationAddress = EnterHelper.StringValueEnter("Введіть адресу реєстарції паспорту: "),
                PassportOwner = new Person()
                {
                    Name = EnterHelper.StringValueEnter("Введіть ім'я користувача: "),
                    Surname = EnterHelper.StringValueEnter("Введіть прізвище користувача: "),
                    Patronymic = EnterHelper.StringValueEnter("Введіть ім'я по-батькові користувача: "),
                    Birthday = EnterHelper.DataOnlyValueEnter("Введіть дату народження користувача: ")
                }
            };
        }
        public Insurance CreateInsurance()
        {
            Dictionary<InsuranceCase, float> cases = new();
            cases.Add(EnterHelper.SelectInsuranseCase(), 
                EnterHelper.FloatValueEnter("Введіть ціну за поточний старховий випадок: "));

            return new Insurance()
            {
                ActiveByDate = EnterHelper.DataOnlyValueEnter("Страхування діє до"),
                Cases = cases
            };
        }
        public BankCard CreateBankCard()
        {

            string number;
            while(true)
            {
                number = EnterHelper.StringValueEnter("Введіть номер картки (17 цифр): ");
                if(number.Length != 17)
                {
                    Console.WriteLine("Ви ввели невірну кількість символів для номеру картки");
                    continue;
                }
                break;
            }
            float limit;
            float moneyAmount;
            while (true)
            {
                limit = EnterHelper.FloatValueEnter("Введіть ліміт грошей: ");
                moneyAmount = EnterHelper.FloatValueEnter("Введіть баланс картки: ");
                
                if(moneyAmount > limit)
                {
                    Console.WriteLine("Ваш ліміт не дозволяє встановити таку кількість грошей." +
                        "Спобуйте знов");
                    continue;
                }
                break;
            }

            return new BankCard()
            {
                Number = number,
                MoneyLimit = limit,
                CurrentMoneyAmount = moneyAmount
            };
        }
    }
}
