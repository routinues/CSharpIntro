using System;

namespace Constructors
{
    //C# İyi Programcı Serisi : Constructor Yapısı
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Davut", LastName = "Ergün", City = "İstanbul" }; //Customer türünde customer adında bir sınıf oluşturuyoruz.

            Customer customer2 = new Customer(); //Buradaki kullanımın yukarıdaki kullanımdan işlev olarak hiçbir farkı yok.
            customer2.Id = 1;
            customer2.FirstName = "Davut";
            customer2.LastName = "Ergün";
            customer2.City = "İstanbul";

            Customer customer3 = new Customer(2, "Davut", "Ergün", "İstanbul");

            Console.WriteLine(customer2.FirstName);

            Console.ReadKey();
        }
    }

    internal class Customer
    {
        public Customer() //Customer1'de çalışan yapı.
        {
        }

        //Default Constructor
        public Customer(int id, string firstName, string lastName, string city) //Customer2'de çalışan yapı.
        {
            //20. satırda customer2'nin adını yazdırmak için eşleştirme işlemi yapıyoruz.
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}