namespace HDFCCreditCard
{
    class MilleniaCreditCardBenefit : ICreditCardBenefit
    {
        #region Properties
        private TransactionServiceProvider _transactionServiceProvider;
        private CreditCardTransaction _creditCardTransaction;
        private int _couponAmount = 0;
        private CouponGenerator? couponGenerator;
        private ICreditCard creditCard;
        #endregion

        #region Methods
        public MilleniaCreditCardBenefit(){
            _transactionServiceProvider = new TransactionServiceProvider();
            _creditCardTransaction = _transactionServiceProvider.getLatestTransaction();
            creditCard = new MilleniaCreditCard();        
        }

        public void calculateBenefit()
        {
           _couponAmount = (_creditCardTransaction.transactionAmount/20);
           if(_creditCardTransaction.transactionAmount < 1000)
                _couponAmount = 0;
           else if(_couponAmount > 200)
                _couponAmount = 200;
        }

        public void printBenefit(){
            couponGenerator = new CouponGenerator(_couponAmount);
            string couponCode = couponGenerator.getCouponCode();
            if(_couponAmount > 0){
                Console.WriteLine("Hi, " + _creditCardTransaction.customer.Name + ". You have spent " + _creditCardTransaction.transactionAmount + " on " + creditCard.Name + " Credit Card. So as a reward, here is your coupon code: " + couponCode);
            }
            else{
                Console.WriteLine("Hi, " + _creditCardTransaction.customer.Name + ". Thank you for using Millenia Credit Card.");
            }
        }
        #endregion
    }
}