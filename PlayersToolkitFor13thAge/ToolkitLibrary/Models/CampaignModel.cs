using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class CampaignModel
    {
        public int CampaignID { get; set; }
        public string CampaignName { get; private set; }
        public List<UserModel> Players { get; set; } = new List<UserModel>();
        public UserModel UserRunningCampaign { get; private set; } = new UserModel();

        public void UpdateCampaignName(string newCampaignName) {
            CampaignName = newCampaignName;
        }

        public void UpdateUserRunningCampaign(UserModel newUserRunningCampaign) {
            UserRunningCampaign = newUserRunningCampaign;
        }
    }
}
