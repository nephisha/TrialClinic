using System;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class AdministrationSteps
    {
        private readonly MenuPage menuPage = new MenuPage();
        private readonly UsersPage usersPage = new UsersPage();
        private readonly SponsorPage sponsorPage = new SponsorPage();
        private readonly LHDPage lhdPage = new LHDPage();
        private readonly CTUPage ctuPage = new CTUPage();

        [When(@"I create new (.*) user from the user menu option")]
        public void WhenICreateNewUserFromTheUserMenuOption(string user)
        {
            menuPage.SelectUsersFromToggleMenu();
            usersPage.ClickonCreateNewUser();
            usersPage.FillInUserDetailsAndClickCreate(user);
        }

        [Then(@"I should see the (.*) user created successfully")]
        public void ThenIShouldSeeTheUserCreatedSuccessfully(string user)
        {
            usersPage.SearchAndVerifyTheCreatedUser(user);
        }

        [When(@"I create new sponsor from the menu option")]
        public void WhenICreateNewSponsorFromTheUserMenuOption()
        {
            menuPage.SelectSponsorsFromToggleMenu();
            sponsorPage.ClickonCreateNewSponsor();
            sponsorPage.FillInSponsorDetailsAndClickCreate();
        }

        [Then(@"I should see the sponsor created successfully")]
        public void ThenIShouldSeeTheSponsorCreatedSuccessfully()
        {
            sponsorPage.SearchAndVerifyTheCreatedSponsor();
        }

        [When(@"I create new LHD from the menu option")]
        public void WhenICreateNewLhdFromTheUserMenuOption()
        {
            menuPage.SelectLHDsFromToggleMenu();
            lhdPage.ClickonCreateNewLHD();
            lhdPage.FillInLHDDetailsAndClickCreate();
        }

        [Then(@"I should see the LHD created successfully")]
        public void ThenIShouldSeeTheLhdCreatedSuccessfully()
        {
            lhdPage.SearchAndVerifyTheCreatedLHD();
        }

        [When(@"I create new CTU from the menu option")]
        public void WhenICreateNewCtuFromTheUserMenuOption()
        {
            menuPage.SelectCTUsFromToggleMenu();
            ctuPage.ClickonCreateNewCTU();
            ctuPage.FillInCTUDetailsAndClickCreate();
        }

        [Then(@"I should see the CTU created successfully")]
        public void ThenIShouldSeeTheCtuCreatedSuccessfully()
        {
            ctuPage.SearchAndVerifyTheCreatedCTU();
        }

        [When(@"I create new Hospital from the menu option")]
        public void WhenICreateNewHospitalFromTheMenuOption()
        {
            
        }

        [Then(@"I should see the Hospital created successfully")]
        public void ThenIShouldSeeTheHospitalCreatedSuccessfully()
        {
            
        }

        [Given(@"I have an existing active (.*) user")]
        public void GivenIHaveAnExistingActiveUser(string type)
        {
            menuPage.SelectUsersFromToggleMenu();
            usersPage.ClickonCreateNewUser();
            usersPage.FillInUserDetailsAndClickCreate(type);
        }

        [When(@"I change the (.*) user access to (.*) and details")]
        public void WhenIChangeTheUserAccessToAndDetails(string fromUser, string toUser)
        {
            usersPage.SearchAndEditTheCreatedUser(fromUser, toUser);
        }

        [Then(@"(.*) user should see the new changes")]
        public void ThenUserShouldSeeTheNewChanges(string type)
        {
            usersPage.SearchAndLoginAsTheEditedUser();
            menuPage.VerifyTheEditedUser(type);
        }

    }
}
