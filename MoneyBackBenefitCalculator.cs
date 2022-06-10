using HDFC;

namespace HDFC
{
    class MoneyBackBenefitCalculator : ICreditCardBenefitCalculator
    {
        public string GetBenefit(int transactionAmount)
        {
           int cashback = (transactionAmount/1000) * 10;
           return string.Empty;
        }
    }
}