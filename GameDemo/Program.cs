using GameDemo.Entities;
using GameDemo.Managers;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 1, Firstname = "Furkan", LastName = "Yazar", DateOfBirth = new DateTime(1998, 5, 10), IdentityNumber = "37985023748" };
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game { Id = 1, Name = "RDR 2", Price = 300, Campaigns = new List<Campaign>() };
            Game game2 = new Game { Id = 2, Name = "GTA 5", Price = 210, Campaigns = new List<Campaign>() };
            Game game3 = new Game { Id = 3, Name = "CB 2077", Price = 250, Campaigns = new List<Campaign>() };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            Campaign campaign1 = new Campaign { Id = 1, Name = "RDR2YAZ", Discount = 25 };
            Campaign campaign2 = new Campaign { Id = 2, Name = "GTA5KIS", Discount = 35 };
            Campaign campaign3 = new Campaign { Id = 3, Name = "RDR2SEPETTE", Discount = 10 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1, game1);
            campaignManager.Add(campaign2, game2);
            campaignManager.Add(campaign3, game1);

            Order order1 = new Order() { Id = 1, Gamer = gamer1, Games = new List<Game> { game1, game2 } };
            Order order2 = new Order() { Id = 2, Gamer = gamer1, Games = new List<Game> { game3 } };
            Order order3 = new Order() { Id = 3, Gamer = gamer1, Games = new List<Game> { game3, game2 } };
            OrderManager orderManager = new OrderManager();
            orderManager.Add(order1);
            orderManager.Add(order2);
            orderManager.Add(order3);
        }
    }
}
