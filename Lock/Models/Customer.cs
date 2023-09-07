namespace Locks.Models
{
    internal class Customer
    {
        public List<string> CustomerIds { get; set; }

        public Customer()
        {
            CustomerIds = new List<string>();
        }

        public void AddCustomer(string customerId)
        {
            CustomerIds.Add(customerId);
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", CustomerIds));
        }
    }
}
