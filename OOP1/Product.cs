using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product //Entity-varlık bu tip classlarda sadece ö zellik olur.
    {
        //snippet------>prop
        public int Id { get; set; }
        public int CategoryId { get; set; }
        //ürün ismi
        public string ProductName { get; set; }
        //ürün birim fiyatı
        public double UnitPrice { get; set; }
        //ürün stok adedi
        public int UnitsInStock { get; set; }

        //CRUD  -EKLEME,OKUMAK,GÜNCELLEMEK,SİLMEK

    }
}
