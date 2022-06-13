namespace HDFCCreditCard
{
    class RegaliaCreditCardBenefit : ICreditCardBenefit
    {
        private TransactionServiceProvider _transactionServiceProvider;
        private CreditCardTransaction _creditCardTransaction;
        private int _rewardPoints = 0;
        private ICreditCard creditCard;

        public RegaliaCreditCardBenefit(){
            _transactionServiceProvider = new TransactionServiceProvider();
            _creditCardTransaction = _transactionServiceProvider.getLatestTransaction();  
            creditCard = new RegaliaCreditCard(); 
        }

        public void calculateBenefit()
        {
           _rewardPoints = (_creditCardTransaction.transactionAmount/150) * 4;
        }

        public void printBenefit(){
            Console.WriteLine("Hi, " + _creditCardTransaction.customer.Name + ". You have spent " + _creditCardTransaction.transactionAmount + " on " + creditCard.Name + " Credit Card. So your total reward points for this transaction is: " + _rewardPoints);
        }
    }
}