using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Create(Games games);
        void Update(Games games);
        void Delete(Games games);

        List<Games> GetGames();
        List<Games> GetGamesByCampaign(int campaignId);
        Games GetGame(int CampaignId);
    }
}
