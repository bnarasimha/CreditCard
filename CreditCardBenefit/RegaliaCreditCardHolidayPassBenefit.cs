namespace HDFCCreditCard
{
    class RegaliaCreditCardHolidayPassBenefit : ICreditCardBenefit
    {
        private TransactionServiceProvider _transactionServiceProvider;
        private CreditCardTransaction _creditCardTransaction;
        private string _holidayPass = string.Empty;
        private ICreditCard creditCard;

        public RegaliaCreditCardHolidayPassBenefit(){
            _transactionServiceProvider = new TransactionServiceProvider();
            _creditCardTransaction = _transactionServiceProvider.getAnnualTransaction();  
            creditCard = new RegaliaCreditCard(); 
        }

        public void calculateBenefit()
        {
            HolidayPassGenerator holidayPassGenerator = new HolidayPassGenerator(_creditCardTransaction.transactionAmount);
            _holidayPass = holidayPassGenerator.getHolidayPass();
        }

        public void printBenefit(){
            if(_creditCardTransaction.transactionAmount >= 100000){
                Console.WriteLine("Hi, " + _creditCardTransaction.customer.Name + ". You have spent " + _creditCardTransaction.transactionAmount + " on " + creditCard.Name + " Credit Card in the entire year. So as a reward here is your Holiday Pass: " + _holidayPass + ". Please enjoy.");
            }
            else{
                Console.WriteLine("Hi, " + _creditCardTransaction.customer.Name + ". Thank you for using " + creditCard.Name + " Credit Card.");
            }
        }
    }
}