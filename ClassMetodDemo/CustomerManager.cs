using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi: " + customer.CustomerName + " " + customer.CustomerSurname);
        }

        public void CustomerLists(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerSurname);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Phone);
                Console.WriteLine("------------------------------");
            }
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " müşterisi silindi");
        }
    }
}