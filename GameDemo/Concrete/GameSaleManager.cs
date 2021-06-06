using System;
using GameDemo.Abstract;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
   public class GameSaleManager : IGameSaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            double  Price= game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);
            Console.WriteLine(game.GameName+" oyunu"+gamer.FirstName+" "+gamer.LastName+" kişisine satıldı");
            Console.WriteLine("Oyunun indirimli fiyatı: "+Price+" TL");
            Console.WriteLine("Uygulanan indirim fiyatı:" +" %"+campaign.DiscountRate);
            
        }
    }
}
