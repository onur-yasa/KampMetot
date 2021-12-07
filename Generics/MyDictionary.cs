using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyDictionary<T>
    {
        T[] items;
        public MyDictionary()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] temparray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i <temparray.Length ; i++)
            {
                items[i] = temparray[i];

            }
            items[items.Length - 1] = item;
        }
        public void Print()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        public int Count
        {
            get { return items.Length; }
        }
    }
}
