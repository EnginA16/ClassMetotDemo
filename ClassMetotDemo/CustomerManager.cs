using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi : " + customer.Ad + " " + customer.Soyad);
        }

        public void Listele(Customer customer)
        {
            Console.WriteLine("Müşteri listelendi : " + customer.Ad + " " + customer.Soyad);
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine("Müşteri silindi : " + customer.Ad + " " + customer.Soyad);
        }
    }
}
