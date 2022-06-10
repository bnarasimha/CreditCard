namespace HDFC
{
    interface ICreditCard
    {
        public string Name { get; }
        public Guid Number { get; }
        public DateTime Expiry { get; }   
    }
}

