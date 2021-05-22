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
        public List<UserModel> Players { get; set; } = Factory.CreateUserModelList();
        public UserModel UserRunningCampaign { get; private set; } = Factory.CreateUserModel();

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
