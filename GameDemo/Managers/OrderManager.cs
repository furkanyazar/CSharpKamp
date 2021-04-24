using GameDemo.Entities;
using GameDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Managers
{
    class OrderManager : IOrderService
    {
        public void Add(Order order, List<Game> games)
        {
            double price = CalculatePrice(games);

            foreach (var game in games)
            {
                order.Games.Add(game);
            }

            Console.WriteLine("Oyunlar " + order.Gamer.Firstname + " adlı oyuncuya " + price + " TL fiyata satıldı");
        }

        public void Delete(Order order)
        {
            double price = CalculatePrice(order.Games);

            Console.WriteLine(order.Gamer.Firstname + " adlı oyuncuya " + price + " TL iade edildi");
        }

        public double CalculatePrice(List<Game> games)
        {
            double price = 0;

            foreach (var game in games)
            {
                price += game.Price;

                foreach (var campaigns in game.Campaigns)
                {
                    price -= game.Price * campaigns.Discount / 100;
                }
            }

            return Math.Round(price, 2);
        }
    }
}
