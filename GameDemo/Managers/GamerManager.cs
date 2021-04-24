using GameDemo.Entities;
using GameDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Managers
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.Firstname + " adlı oyuncu eklendi");
            }
            else
            {
                Console.WriteLine(gamer.Firstname + " adlı oyuncu doğrulanamadı");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Firstname + " adlı oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Firstname + " adlı oyuncu güncellendi");
        }
    }
}
