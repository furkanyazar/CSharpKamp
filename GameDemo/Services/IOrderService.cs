using GameDemo.Entities;

namespace GameDemo.Services
{
    internal interface IOrderService
    {
        void Add(Order order);

        void Delete(Order order);
    }
}
