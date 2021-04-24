using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services
{
    interface IOrderService
    {
        void Add(Order order, List<Game> games);
        void Delete(Order order);
    }
}
