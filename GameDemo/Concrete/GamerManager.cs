using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        private ICheckPersonService _checkPersonService;
        public GamerManager(ICheckPersonService checkPersonService)
        {
            _checkPersonService = checkPersonService;
        }
        public void Add(Gamer gamer)
        {

            if (_checkPersonService.CheckOfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName +" "+gamer.LastName+"isimli oyuncu kayıt edildi.");
            }
            else
            {
                throw new Exception("Oyuncu doğrulanamadı");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu silindi!" + '\n');
        }

        public void Update(Gamer gamer)
        {
            if (_checkPersonService.CheckOfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu güncellendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız! Güncelleme başarısız!.");
            }
        }
    }
}
