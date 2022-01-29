using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added. " + customer.FirstName + " " + customer.LastName + "\n");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Removed. " + customer.FirstName + " " + customer.LastName + "\n");
        }
        public void ListCustomers(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer ID: " + customer.Id + "\nFirst Name: " + customer.FirstName + "\nLast Name: " + customer.LastName + "\nBalance: " + customer.Balance + "\n");
            }
        }
    }
}
