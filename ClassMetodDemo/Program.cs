using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.ID = 1;
            customer.CustomerName = "Engin";
            customer.CustomerSurname = "Demiroğ";
            customer.Phone = 11111111111;
            customer.Adress = "Diyarbakır";
            customer.Email = "aaaaaaaa@aaa.com";

            Customer customer2 = new Customer();
            customer2.ID = 2;
            customer2.CustomerName = "Ali";
            customer2.CustomerSurname = "Veli";
            customer2.Phone = 22222222222;
            customer2.Adress = "Bartın";
            customer2.Email = "aaaaaaab@aaa.com";

            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customer);
            customerManager.CustomerAdd(customer2);

            Customer[] customers = new Customer[] { customer, customer2 };

            Console.WriteLine();
            Console.WriteLine("----------Müşteriler-----------");

            customerManager.CustomerLists(customers);

            customerManager.CustomerDelete(customer);
        }
    }
}
