using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //C# İyi Programcı Serisi : Interfaceler
    internal class Program
    {
        private static void Main(string[] args)
        {
            //IPersonManager personManager = new IPersonManager(); //IPersonManager bir Interface'dir ve Interface'ler new'lenemez!!
            //personManager.Add();

            //IPersonManager customerManager = new CustomerManager(); //Doğru kullanım. IPersonManager yerine CustomerManager new'liyoruz.

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

            Console.ReadKey();
        }
    }

    internal interface IPersonManager
    {
        //unimplemented opertaion
        void Add();

        void Update();
    }

    //inherits - class -------------------- implements - interface
    internal class CustomerManager : IPersonManager // İki nokta üst üste c# dilinde implement işlemi için kullanılır.
    {
        public void Add()
        {
            //Müşteri Ekleme Kodları
            Console.WriteLine("Müşteri Eklendi!");
        }

        public void Update()
        {
            //Müşteri Güncelleme Kodları
            Console.WriteLine("Müşteri Güncellendi!");
        }
    }

    internal class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel Ekleme Kodları
            Console.WriteLine("Personel Eklendi!");
        }

        public void Update()
        {
            //Personel Güncelleme Kodları
            Console.WriteLine("Personel Güncellendi!");
        }
    }

    internal class InternManager : IPersonManager
    {
        public void Add()
        {
            //Stajyer Ekleme Komutları
            Console.WriteLine("Stajyer Eklendi!");
        }

        public void Update()
        {
            //Stajyer Güncelleme Komuları
            Console.WriteLine("Stajyer Güncellendi!");
        }
    }

    internal class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}