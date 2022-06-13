namespace HDFCCreditCard{
    public class TransactionServiceProvider {
        private CreditCardTransaction? _creditCardTransaction;
        public CreditCardTransaction getLatestTransaction(){
            _creditCardTransaction = new CreditCardTransaction(){
                customer = new Customer() { Name = "Narasimha" },
                transactionAmount = 1000
            };
            return _creditCardTransaction;
        }

        public CreditCardTransaction getAnnualTransaction(){
            _creditCardTransaction = new CreditCardTransaction(){
                customer = new Customer() { Name = "Narasimha" },
                transactionAmount = 100000
            };
            return _creditCardTransaction;
        }
    }
}