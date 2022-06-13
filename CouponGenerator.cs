namespace HDFCCreditCard
{
    public class CouponGenerator
    {
        private int _couponAmount;
        public CouponGenerator(int amount){
            _couponAmount = amount;
        }   
        public string getCouponCode(){
            return "DOMINOS_FLAT" + _couponAmount;
        }
    }
}