using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
        public class SalesManager
    {
        public void Sale(Campaign campaign,Customer customer,Game game)
        {
            Console.WriteLine(game.Name+"adlı oyun"+customer.Name+"adlı kişiye"+campaign.Name+"adlı kampanya uygulanarak satıldı");
        }
    }
}
