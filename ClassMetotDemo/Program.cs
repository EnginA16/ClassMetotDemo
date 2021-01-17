using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Ad = "Ahmet";
            customer1.Soyad = "Yılmaz";
            customer1.Id = 01;           

            Customer customer2 = new Customer();
            customer2.Ad = "Mehmet";
            customer2.Soyad = "Öztürk";
            customer2.Id = 02;

            Customer customer3 = new Customer();
            customer3.Ad = "Ayşe";
            customer3.Soyad = "Demir";
            customer3.Id = 03;           


            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Ad : " + customer.Ad);
                Console.WriteLine("Soyad : " + customer.Soyad);
                Console.WriteLine("Id : " + customer.Id);
                Console.WriteLine("--------------------");

            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customer1);
            customerManager.Ekle(customer2);
            customerManager.Ekle(customer3);
            Console.WriteLine("--------------------");

            customerManager.Listele(customer1);
            customerManager.Listele(customer2);
            customerManager.Listele(customer3);
            Console.WriteLine("--------------------");

            customerManager.Sil(customer1);
            customerManager.Sil(customer2);
            customerManager.Sil(customer3);

        }
    }
}
