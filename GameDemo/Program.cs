using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game {GameName="GTA IV",GameCategory="Macera",GamePrice=250 };
            Game game2 = new Game { GameName = "COD", GameCategory = "Macera", GamePrice = 350 };
            Game game3 = new Game { GameName = "Counter Strike ", GameCategory = "Savaş", GamePrice = 250 };


            Gamer gamer1 = new Gamer{ Id=1,FirstName="Ahmet Furkan",LastName="Çelik",NationalityId="12641879648",DateOfBirth=new DateTime(1998,9,23)};
            Gamer gamer2 = new Gamer { Id = 2, FirstName = "Sevde ", LastName = "Özcan", NationalityId = "43256845741", DateOfBirth = new DateTime(1998, 10, 3) };
            Gamer gamer3 = new Gamer { Id = 3, FirstName = "Eda", LastName = "Elitaş", NationalityId = "12644879584", DateOfBirth = new DateTime(1993, 8, 8) };


            Campaign campaign1 = new Campaign {CampaignName="Yaz Kampanyası",DiscountRate=20 };
            Campaign campaign2 = new Campaign { CampaignName = "İlk Alış Kampanyası", DiscountRate = 10 };




            GamerManager gamerManager = new GamerManager(new VerificationManager());
           
            gamerManager.Add(gamer2);
            

            Console.WriteLine("******************");
            Console.WriteLine(" ");

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            Console.WriteLine("******************");
            Console.WriteLine(" ");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            Console.WriteLine("******************");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(game1, gamer1, campaign1);
            gameSaleManager.Sale(game2, gamer2, campaign2);



        }
    }
}
