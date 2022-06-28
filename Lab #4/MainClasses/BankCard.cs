namespace MainClasses
{
    public class BankCard
    {
        public string Number { get; init; } = string.Empty;
        public float CurrentMoneyAmount { get; set; }
        public float MoneyLimit { get; init; }

        public bool AddMoney(float moneyAmount)
        {
            float tempMoneyAmount = CurrentMoneyAmount + moneyAmount;
            if (tempMoneyAmount > MoneyLimit)
            {
                return false;
            }
            CurrentMoneyAmount = tempMoneyAmount;
            return true;
        }
        public bool TakeMoney(float moneyAmount)
        {
            float tempMoneyAmount = CurrentMoneyAmount - moneyAmount;
            if(tempMoneyAmount < 0)
            {
                return false;
            }
            CurrentMoneyAmount = tempMoneyAmount;
            return true;
        }

        public override string ToString()
        {
            return $"Банківська картка:\nНомер картки: {Number} Кількість грошей: {CurrentMoneyAmount} грн " +
                $"Допустима кількість грошей: {MoneyLimit} грн";
        }
    }
}
