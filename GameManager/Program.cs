using GameManager.Concrete;
using GameManager.Entities;
using System;

namespace GameManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "mekancık";
            customer.Id = 1;
            customer.FirstName = "mekan";
            customer.LastName = "Erdem";
            customer.NationalityId = 234567654323;
            customer.DateOfBirth = new DateTime(1998, 12, 08);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "öğrenci kampanyası";
            campaign.Explanation = "öğrencilere %30 indirim";

            Game game = new Game();
            game.Name = "GTA CITY";
            game.Id = 1;
            game.price = 190;

            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);
                
            CampaignManager campaingManager = new CampaignManager();
            campaingManager.Add(campaign);
            campaingManager.Delete(campaign);
            campaingManager.Update(campaign);


            GameManagers gameManagers = new GameManagers();
            gameManagers.Add(game);
            gameManagers.Delete(game);
            gameManagers.Update(game);

        }
    }
}
