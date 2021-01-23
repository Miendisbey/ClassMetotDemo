using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerId = 101;
            customer1.customerName = "İlker";
            customer1.customerSurname = "Gürhan";
            customer1.customerAge = 24;
            customer1.customerWeight = 80;
            customer1.customerHeight = 170;

            Customer customer2 = new Customer();
            customer2.customerId = 102;
            customer2.customerName = "İlayda Sena";
            customer2.customerSurname = "Aslaner";
            customer2.customerAge = 21;
            customer2.customerWeight = 53;
            customer2.customerHeight = 170;
            
            Customer customer3 = new Customer();
            customer3.customerId = 103;
            customer3.customerName = "Tayfun";
            customer3.customerSurname = "Koçoğlu";
            customer3.customerAge = 26;
            customer3.customerWeight = 95;
            customer3.customerHeight = 178;

            Customer[] customers = new Customer[] {customer1 ,customer2 ,customer3 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("-Sisteme Kayıt İçin Bekletiliyor");
                Console.WriteLine("\n" +"Name : "+ customer.customerName);
                Console.WriteLine("Surname : " + customer.customerSurname);
                Console.WriteLine("Id : " + customer.customerId);
                Console.WriteLine("Age : " + customer.customerAge);
                Console.WriteLine("Weight : " + customer.customerWeight);
                Console.WriteLine("Height : " + customer.customerHeight + "\n");

            }

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("-SİSTEME EKLENENLER" + "\n");
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.List(customers);
            Console.WriteLine("\nSİSTEMDEN SİLİNENLER\n");
            customerManager.Delete(customer3);
        }
    }
}
