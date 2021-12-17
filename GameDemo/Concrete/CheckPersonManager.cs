using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CheckPersonManager : ICheckPersonService
    {
        public bool CheckOfRealPerson(Gamer gamer)
        {
            if (gamer.NationalityId==11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
