using GameDemo.Entities;

namespace GameDemo.Services
{
    internal interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}