using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ICampaignService
    {
        void Delete(Campaigns campaigns);

        void DefineCampaigns(Campaigns campaigns);
        void Update(Campaigns campaigns);

    }
}
