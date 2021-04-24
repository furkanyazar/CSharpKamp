using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services
{
    interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}
