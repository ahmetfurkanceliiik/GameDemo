using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGameSaleService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
