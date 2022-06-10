using System;

namespace HDFC
{
    interface ICreditCardBenefitCalculator
    {
        public string GetBenefit(int transactionAmount);
    }
} 