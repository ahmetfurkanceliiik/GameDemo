using System;
using GameDemo.Abstract;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" oyunu eklendi. "+"Fiyatı : "+game.GamePrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu silindi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu güncellendi. ");
        }
    }
}
