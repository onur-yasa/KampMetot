using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" adlı oyun sisteme eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun sisteme silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun sisteme güncellendi");
        }
    }
}
