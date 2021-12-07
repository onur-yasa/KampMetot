using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
          
            Console.WriteLine("Müşteri Id:" +musteri.Id+" " +"Müsteri adı: " + musteri.Name + " " +"Müsteri Soyadı: " +musteri.LastName);
        }
        public void MusteriDel(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id:" + musteri.Id+" " + "Müsteri adı: " + musteri.Name + " " + "Müsteri Soyadı: " + musteri.LastName);
        }
        public void MusteriList(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id:" + musteri.Id+" " + "Müsteri adı: " + musteri.Name + " " + "Müsteri Soyadı: " + musteri.LastName);
        }
    }
}
