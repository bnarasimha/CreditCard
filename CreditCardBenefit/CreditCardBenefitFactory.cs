using HDFCCreditCard;
using System; 

namespace HDFCCreditCard {
    public class CreditCardBenefitFactory
    {
        public static ICreditCardBenefit getCreditCardBenefit(string cardType){
            if(cardType == "MoneyBack"){
                return new MoneyBackCreditCardBenefit();
            }
            else if(cardType == "Regalia"){
                return new RegaliaCreditCardBenefit();
            }
            else if(cardType == "RegaliaHolidayPass"){
                return new RegaliaCreditCardHolidayPassBenefit();
            }
            else{
                return new MilleniaCreditCardBenefit();
            }
        }
    }
}