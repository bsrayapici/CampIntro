using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Create(Games games)
        {
            Console.WriteLine("Oyun yaratıldı");
        }

        public void Delete(Games games)
        {
            Console.WriteLine("Oyun silindi");
        }

        public Games GetGame(int CampaignId)
        {
            Games game1 = new Games { CampaignId=1,GameName="CT", Id=2 };

            if (game1.CampaignId==CampaignId)
            {
                return game1;
            }
            return null;
        }

        public List<Games> GetGames()
        {
            throw new NotImplementedException();
        }

        public List<Games> GetGamesByCampaign(int campaignId)
        {
            return new List<Games>();
        }

        public void Update(Games games)
        {
            Console.WriteLine("Oyun Güncellendi");
        }
    }
}
