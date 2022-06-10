using HDFC;
using System; 

class CreditCardBenefitCalculatorFactory
{
    private ICreditCard _creditCard;

    public CreditCardBenefitCalculatorFactory(ICreditCard creditCard)
    {
        _creditCard = creditCard;
    }

    public int CalculateBenefit()
    {
        // System.Type creditCardType = typeof(_creditCard);
        // creditCardType

        int transactionAmount = 1000;
        int annualTransactionAmount = 100000;

        ICreditCardBenefitCalculator ccb = new MoneyBackBenefitCalculator();
        ccb.GetBenefit(transactionAmount);

        return 1;
    }

}