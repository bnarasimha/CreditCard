namespace HDFCCreditCard
{
    class Program
    {
        static ICreditCardBenefit? creditCardBenefit;
        public static void Main(string[] args)
        {
            GreetCustomerWithBenefits();
        }

        public static void GreetCustomerWithBenefits(){
            creditCardBenefit = CreditCardBenefitFactory.getCreditCardBenefit("RegaliaHolidayPass");

            creditCardBenefit.calculateBenefit();
            creditCardBenefit.printBenefit();
        }
    }
}