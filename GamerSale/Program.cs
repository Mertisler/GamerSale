using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                BirthYear = 2000,
                FirstName = "Mert",
                LastName = "işler",
                NationalityId = 123456


            };
            IGamerService gamerService = new GamerManager(new UserValiditaionManager());
            gamerService.Add(gamer);
            gamerService.Delete(gamer);
            gamerService.Update(gamer);
            Console.WriteLine("*************************");
            Campaign campaign = new Campaign() { DiscountAmount = 40 };
            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign);
            campaignService.Delete(campaign);
            Console.WriteLine("*************************");
            Game game = new Game() { GameName = "Candy Crash", Price = 245 };
            IGameSaleService gameSaleService = new GameSaleManager();
            gameSaleService.Sale(game, gamer);
            gameSaleService.MakeDiscount(game, gamer, campaign);
            Console.ReadLine();





        }
       
    }
}
