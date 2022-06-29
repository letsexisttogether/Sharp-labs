using System;
using MainClasses;
using Render;
using Presentation_layer;

namespace Lab
{
    static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ValueEnterHelper enterHelper = new();
            MainObjectsCreator objectsCreator = new()
            {
                EnterHelper = enterHelper
            };

            UniversalCard universalCard = new();
            universalCard.ChangeUser(objectsCreator.CreatePassport());

            Menu mainMenu = new();
            mainMenu.Items = new()
            {
                new MenuItem("1. Змінити користувача карткою",
                () => universalCard.ChangeUser(objectsCreator.CreatePassport())),

                new MenuItem("2. Змінити страховий поліс",
                () => universalCard.ChangeInsuranse(objectsCreator.CreateInsurance())),

                new MenuItem("3. Змінити банківську картку",
                () => universalCard.ChangeBankCard(objectsCreator.CreateBankCard())),

                new MenuItem("4. Сплатити рахунки",
                () => universalCard.PayTheBills(enterHelper
                    .FloatValueEnter("Введіть сумму грошей за рахунки користувача: "))),

                new MenuItem("5. Перевірити баланс",
                () => universalCard.CheckMoneyAmount()),

                new MenuItem("6. Додати старховий випадок",
                () => universalCard.AddInsuranceCase(enterHelper.SelectInsuranseCase(),
                enterHelper.FloatValueEnter("Введіть ціну за поточний випадок страхування: "))),

                new MenuItem("7. Отримати виплату за страхування",
                () => universalCard.TakeMoneyFromInsuranse(enterHelper.SelectInsuranseCase())),
               
                new MenuItem("8. Отримати повну інформацію про універсальну картку",
                () => Console.WriteLine(universalCard)),

                new MenuItem("9. Вихід",
                () => mainMenu.IsExitWanted = true)
            };

            VariantSelector selector = new("\nОберіть пункт: ", 1, mainMenu.ItemsCount);


            while (mainMenu.IsExitWanted == false)
            {
                Console.Clear();
                mainMenu.PrintMenu();

                Console.WriteLine();
                mainMenu.Execute(selector.SelectVariant() - 1);

                Console.WriteLine("\nНатисніть будь-яку клавішу");
                Console.ReadLine();
            }
        }
    }
}