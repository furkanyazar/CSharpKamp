using GameDemo.Entities;

namespace GameDemo.Services
{
    internal interface IGameService
    {
        void Add(Game game);

        void Update(Game game);

        void Delete(Game game);
    }
}