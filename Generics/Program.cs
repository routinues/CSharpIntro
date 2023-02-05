using System;
using System.Collections.Generic;

namespace Generics
{
    //C# İyi Programcı Serisi : Generic Yapıları Yapısal Mantığıyla Anlamak
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> sehirler = new List<string>(); //Sehirler adında bir liste oluştur.
            sehirler.Add("Ankara"); //Sehirler listesine "Ankara"'yı ekle.
            Console.WriteLine(sehirler.Count); //Sehirler listesinin içindeki veri sayısını ölçüyoruz. (Count)

            MyList<string> sehirler2 = new MyList<string>(); //Sehirler2 adında bir liste oluştur.
            sehirler2.Add("Ankara"); //Sehirler2 listesine "Ankara"'yı ekle.
            Console.WriteLine(sehirler.Count); //Sehirler2 listesinin içindeki veri sayısını ölçüyoruz. (Count)

            Console.ReadKey();
        }
    }

    internal class MyList<T> //Generic class yapısı
    {
        private T[] _array;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _array = new T[_array.Length + 1];
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}