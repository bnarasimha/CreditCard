namespace HDFCCreditCard
{
    class MoneyBackCreditCardBenefit : ICreditCardBenefit
    {
        private TransactionServiceProvider _transactionServiceProvider;
        private CreditCardTransaction _creditCardTransaction;
        private int _cashBackAmount = 0;
        private ICreditCard _creditCard;

        public MoneyBackCreditCardBenefit(){
            _transactionServiceProvider = new TransactionServiceProvider();
            _creditCardTransaction = _transactionServiceProvider.getLatestTransaction();
            _creditCard = new MoneyBackCreditCard();        
        }

        public void calculateBenefit()
        {
            _cashBackAmount = (_creditCardTransaction.transactionAmount/1000) * 10;
        }

        public void printBenefit(){
            Console.WriteLine("Hi, " + _creditCardTransaction.customer.Name + ". You have spent " + _creditCardTransaction.transactionAmount + " on " + _creditCard.Name + " Credit Card. So the cashback for the transaction is: " + _cashBackAmount);
        }
    }
}