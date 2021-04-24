using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services
{
    interface ICampaignService
    {
        void Add(Campaign campaign, Game game);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
