using System;

namespace HDFC
{
    class MoneyBackCreditCard : ICreditCard
    {
        public string Name {
            get {
                return "Narasimha";
            }
        }

        public Guid Number => throw new NotImplementedException();

        public DateTime Expiry => throw new NotImplementedException();
    }
}
