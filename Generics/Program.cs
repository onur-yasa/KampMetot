using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Nasuh Onur");
            isimler.Print();
            Console.WriteLine(isimler.Count);

            isimler.Add("Onur");
            isimler.Add("Ayça");
            isimler.Print();
            Console.WriteLine(isimler.Count);
        }
    }
}
