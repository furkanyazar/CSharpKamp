using GameDemo.Entities;
using GameDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Managers
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            campaign.Game.Price -= campaign.Game.Price * campaign.Discount / 100;
            Console.WriteLine(campaign.Name + " adlı kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı kampanya güncellendi");
        }
    }
}
