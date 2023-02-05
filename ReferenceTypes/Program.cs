using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{

    //C# İyi Programcı Serisi : OOP için Referans Tipleri
    internal class Program
    {
        static void Main(string[] args)
        {          
            //int, decimal, float, enum, boolean gibi değişkenler değer tipdir. Value Types
            int sayi1 = 10; //Sayı 1'in değeri = 10
            int sayi2 = 20; //Sayı 2'nin değeri = 20

            sayi1 = sayi2; //Sayı 1'in değeri = Sayı 2'nin değeri
            sayi2 = 100; //Sayı 1'e Sayı 2'nin önceki değerini (20) atadığımız için artık Sayı 2'nin değerinin 100 olması hiç bir şeyi değiştirmez. Sayı 1 hala 20 olarak kalır.

            Console.WriteLine("Sayı 1: " + sayi1);

            //arrays,class,interface gibi yapılar referans tiplerdir. Reference Types

            int[] sayılar1 = new int[] { 1, 2, 3, }; //Sayılar 1'in elemanları 1,2 ve 3
            int[] sayılar2 = new int[] { 10, 20, 30, }; //Sayılar 2'nin elemanları 10,20 ve 30

            sayılar1 = sayılar2; // Burada yukarıdaki Sayılar 1'in elemanlarını Sayılar 2'nin elemanlarına eşitle demek yerine Sayılar 1'in adresini Sayılar 2'nin adresine eşitle diyoruz.
            sayılar2[0] = 1000; //Sayılar 2'nin 0. elemanını 1000 yaparsak iki dizi de birbirine aynı adres üzerinden bağlı oldukları için Sayılar 1 dizisinin 0. elemanı da 1000 olacaktır.

            Console.WriteLine("Sayılar1[0]: " + sayılar1[0]);
            

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Davut"; //Şu anda Person1'in adı Davut

            person2 = person1; //Adres eşitlemesi
            person1.FirstName = "Cihat"; //Şu anda Person1'in adı Cihat

            Console.WriteLine(person2.FirstName); //Son hali Cihat olarak yazdırır.

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12345678910";
            Employee employee = new Employee();

            //customer = employee; Yanlış kullanım
            Person person3 = customer; //Doğru kullanım

            Console.WriteLine(person3.FirstName); //Yukarıda customer'ın adını Salih olarak değiştirdik fakat ekrana person3'ün adını yazdırdık. Yukarıda ikisinin adresini birbirine bağladığımız için çıktı Salih olacaktır.
            Console.WriteLine(((Customer)person3).CreditCardNumber); //Burada Kredi Kartı Numarasını alabilmek için Boxing yani kutulama işlemi yapıyoruz.


            PersonManager personManager = new PersonManager();
            personManager.Add(customer);



            Console.ReadKey();
        }
    }

    class Person //Base Class - Ana Sınıf
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person //Customer bir Person'dur.
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person //Employee bir Person'dur
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
