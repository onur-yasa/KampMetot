using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();

            gamer.ID = 1;
            gamer.FirstName = "Nasuh Onur";
            gamer.LastName = "YAŞA";
            gamer.NationalityId = 12345678910;
            gamer.UserName = "nasuh172";
            gamer.DateOfBirth = new DateTime(1997,1,1);

            GamerManager gamerManager = new GamerManager(new CheckPersonManager());
            gamerManager.Add(gamer);
            gamerManager.Remove(gamer);
            gamerManager.Update(gamer);

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Yaz indirimi";
            campaign.DiscountRate = 50;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            Game game1 = new Game { Id = 1, GameName = "PubG", GamePrice = 15 };
            Game game = new Game { Id = 2, GameName = "CSGO", GamePrice = 150 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer, game1);
            saleManager.CampaignSale(gamer, game, campaign);
            

        }
    }
}
