using GameDemo.Entities;

namespace GameDemo.Services
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);

        void Update(Gamer gamer);

        void Delete(Gamer gamer);
    }
}
