using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services
{
    interface IOrderService
    {
        void Add(Order order);
        void Delete(Order order);
    }
}
