using GameDemo.Entities;
using GameDemo.Services;
using System;

namespace GameDemo.Managers
{
    internal class OrderManager : IOrderService
    {
        public void Add(Order order)
        {
            double price = 0;

            foreach (var item in order.Games)
            {
                price += item.Price;
            }

            Console.WriteLine("Oyunlar " + order.Gamer.Firstname + " adlı oyuncuya " + price + " TL fiyata satıldı");
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Sipariş iptal edildi");
        }
    }
}