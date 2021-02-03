using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ToolkitLibrary.Tests
{
    public class TextTests
    {
        private readonly CampaignModel campaign = Factory.CreateCampaignModel();
        private readonly UserModel user = Factory.CreateUserModel();

        [Fact]
        public void CampaignModel_UpdateCampaignName_ShouldUpdateCampaignName() {
            var previous = campaign.CampaignName;
            campaign.UpdateCampaignName("New campaign name");
            var updated = campaign.CampaignName;
            Assert.NotEqual(previous, updated);
        }

        [Fact]
        public void CampaignModel_UpdateUserRunningCampaign_ShouldUpdateUserRunningCampaign() {
            var previous = campaign.UserRunningCampaign;
            campaign.UpdateUserRunningCampaign(user);
            var updated = campaign.UserRunningCampaign;
            Assert.NotEqual(previous, updated);
        }

        [Fact]
        public void UserModel_UpdateUsername_ShouldUpdateUsername() {
            var previous = user.Username;
            user.UpdateUsername("New username");
            var updated = user.Username;
            Assert.NotEqual(previous, updated);
        }

        [Fact]
        public void UserModel_UpdateEmailAddress_ShouldUpdateEmailAddress() {
            var previous = user.EmailAddress;
            user.UpdateEmailAddress("New email address");
            var updated = user.EmailAddress;
            Assert.NotEqual(previous, updated);
        }
    }
}
