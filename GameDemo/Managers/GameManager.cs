﻿using GameDemo.Entities;
using GameDemo.Services;
using System;

namespace GameDemo.Managers
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun güncellendi");
        }
    }
}