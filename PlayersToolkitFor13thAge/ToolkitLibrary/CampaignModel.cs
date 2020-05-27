using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class CampaignModel
    {
        public string CampaignName { get; set; }
        public int CampaignID { get; set; }
        public List<UserModel> Players { get; set; } = new List<UserModel>();
        public UserModel GM { get; set; } = new UserModel();
    }
}
