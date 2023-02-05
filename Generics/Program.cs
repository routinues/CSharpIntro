using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    //C# İyi Programcı Serisi : Generic Yapıları Yapısal Mantığıyla Anlamak
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            Console.ReadKey();
        }
    }

    class MyList<T> //Generic class
    {
        T[] _array;

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
