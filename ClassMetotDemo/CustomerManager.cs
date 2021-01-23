using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            
            Console.WriteLine(customer.customerName + " " +customer.customerSurname + " " + "sistemimize eklenmiştir.");
            
        }
        public void List(Customer[] customers)
        {
            Console.WriteLine("\n-Kayıtlı Listesi");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.customerId +" : "+ customer.customerName+" "+customer.customerSurname);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.customerName +" "+customer.customerSurname +" "+ "sistemimizden silinmiştir.");
        }
    }
}
