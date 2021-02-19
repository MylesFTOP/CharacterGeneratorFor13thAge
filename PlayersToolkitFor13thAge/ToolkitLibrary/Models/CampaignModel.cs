using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class CampaignModel
    {
        public int CampaignId { get; private set; }
        public string CampaignName { get; private set; }
        // TODO: Remove coupling on properties
        public List<UserModel> Players { get; set; } = new List<UserModel>();
        public UserModel UserRunningCampaign { get; private set; } = new UserModel();

        public void UpdateCampaignId(int newCampaignId) {
            CampaignId = newCampaignId;
        }

        public void UpdateCampaignName(string newCampaignName) {
            CampaignName = newCampaignName;
        }

        public void UpdateUserRunningCampaign(UserModel newUserRunningCampaign) {
            UserRunningCampaign = newUserRunningCampaign;
        }
    }
}
