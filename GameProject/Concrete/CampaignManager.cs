using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {

        public void DefineCampaigns(Campaigns campaigns)
        {
            Console.WriteLine("Kmapanya Tanımlandı");  
        }

        public void Delete(Campaigns campaigns)
        {
            Console.WriteLine("Kmapanya Silindi");
        }

        public void Update(Campaigns campaigns)
        {
            Console.WriteLine("Kmapanya Güncellendi");
        }

  
    }
}
