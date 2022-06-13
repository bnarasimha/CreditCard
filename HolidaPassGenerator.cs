namespace HDFCCreditCard{
    class HolidayPassGenerator{
        private int _annualAmount;

        public HolidayPassGenerator(int annualAmount){
            _annualAmount  =annualAmount;
        }

        public string getHolidayPass(){
            if(_annualAmount >= 100000)
                return "KERALA_1WEEK_HOLIDAY";
            else
                return string.Empty;
        }
    }
}