using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor----> yukarıdaki classı new lediğimizde otomatik çalışıyor. New lediğimz anda arrayi oluşturduk ve sıfır elamanlı olarak verdik.
        public MyList()
        {
            items = new T[0];
        }
        //elimizde sıfır elamanlı bir dzizi var ve artık diziye elaman ekleyebiliriz.(altta.)
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];   //new lediğimizde referans numarası uçuyordu, o yüzden o referansı birine tutturmamız lazım. 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
    }
}
