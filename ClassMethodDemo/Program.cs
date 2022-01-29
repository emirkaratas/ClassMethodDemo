using System;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, Balance = 5000, FirstName = "Emir", LastName = "Karataş" };
            Customer customer2 = new Customer() { Id = 2, Balance = 10000, FirstName = "Bilge", LastName = "Yılmaz" };

            Customer[] customers = new Customer[] { customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer2);
            customerManager.Delete(customer1);
            customerManager.ListCustomers(customers);
        }
    }
}
