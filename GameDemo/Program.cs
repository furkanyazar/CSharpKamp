using GameDemo.Entities;
using GameDemo.Managers;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 1, Firstname = "Furkan", LastName = "Yazar", DateOfBirth = new DateTime(1990, 1, 1), IdentityNumber = "12345678910" };
            List<Gamer> gamers = new List<Gamer> { gamer1 };
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            foreach (var gamer in gamers)
            {
                gamerManager.Add(gamer);
            }

            Game game1 = new Game { Id = 1, Name = "RDR 2", Price = 300, Campaigns = new List<Campaign>() };
            Game game2 = new Game { Id = 2, Name = "GTA 5", Price = 210, Campaigns = new List<Campaign>() };
            Game game3 = new Game { Id = 3, Name = "CP 2077", Price = 250, Campaigns = new List<Campaign>() };
            List<Game> games = new List<Game> { game1, game2, game3 };
            GameManager gameManager = new GameManager();
            foreach (var game in games)
            {
                gameManager.Add(game);
            }

            Campaign campaign1 = new Campaign { Id = 1, Name = "RDR2YAZ", Discount = 25, Game = game1 };
            Campaign campaign2 = new Campaign { Id = 2, Name = "GTA5KIS", Discount = 35, Game = game2 };
            Campaign campaign3 = new Campaign { Id = 3, Name = "RDR2SEPETTE", Discount = 10, Game = game1 };
            List<Campaign> campaigns = new List<Campaign> { campaign1, campaign2, campaign3 };
            CampaignManager campaignManager = new CampaignManager();
            foreach (var campaign in campaigns)
            {
                campaignManager.Add(campaign);
            }

            Order order1 = new Order() { Id = 1, Gamer = gamer1, Games = new List<Game> { game1, game2 } };
            Order order2 = new Order() { Id = 2, Gamer = gamer1, Games = new List<Game> { game2, game3 } };
            Order order3 = new Order() { Id = 3, Gamer = gamer1, Games = new List<Game> { game1, game3 } };
            Order order4 = new Order() { Id = 4, Gamer = gamer1, Games = new List<Game> { game1, game2, game3 } };
            List<Order> orders = new List<Order> { order1, order2, order3, order4 };
            OrderManager orderManager = new OrderManager();
            foreach (var order in orders)
            {
                orderManager.Add(order);
            }
        }
    }
}
