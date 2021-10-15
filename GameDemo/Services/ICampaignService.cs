using GameDemo.Entities;

namespace GameDemo.Services
{
    internal interface ICampaignService
    {
        void Add(Campaign campaign);

        void Update(Campaign campaign);

        void Delete(Campaign campaign);
    }
}