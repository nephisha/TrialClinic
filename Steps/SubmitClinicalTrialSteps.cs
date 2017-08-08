using CI.ClinicalTrials.RegressionTest.CommonMethods;
using CI.ClinicalTrials.RegressionTest.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CI.ClinicalTrials.RegressionTest.Steps
{
    [Binding]
    public class SubmitAClinicalTrialForThePatientSteps
    {
        private readonly LoginPage loginPage = new LoginPage();
        private readonly MenuPage menuPage = new MenuPage();
        private readonly SubmitTrialDetailsPage submitTrialDetailsPage = new SubmitTrialDetailsPage();
        private readonly MasterTrialListSearchPage masterTrialListSearchPage = new MasterTrialListSearchPage();
        private readonly MySiteTrialsPage mySiteTrialsPage = new MySiteTrialsPage();

        public string Title { get; } = "RegTest_" + PageHelper.RandomString(8);
        public string AdminUserName = "Emmanuel Russel";
        public string AdminPassword = "Welcome@123";
        public string CTUUserName = "Regression_CTU_User";
        public string CTUPassword = "Welcome@123";

        [Given(@"I login to Clinical Trial Application as Administrator")]
        public void GivenILoginToClinicalTrialApplicationAsAdministrator()
        {
            loginPage.LaunchTheApplication();
            loginPage.LoginToApplication(AdminUserName, AdminPassword);
        }

        [Given(@"I login to Clinical Trial Application as CTU User")]
        public void GivenILoginToClinicalTrialApplicationAsCTUUser()
        {
            loginPage.LaunchTheApplication();
            loginPage.LoginToApplication(CTUUserName, CTUPassword);
        }

        [When(@"I submit a new trial with details (.*) and (.*) and (.*)")]
        public void WhenISubmitANewTrialWithDetails(string sponsor, string design, string category)
        {
            menuPage.ClickOnToggleMenu();
            menuPage.SelectSubmitATrialFromToggleMenu();
            submitTrialDetailsPage.FillallTheTrialDetails(Title, sponsor, design, category);
            submitTrialDetailsPage.SubmitTrial();
        }

        [When(@"I cancel a new trial with entered details (.*) and (.*) and (.*)")]
        public void WhenICancelANewTrialWithEnteredDetails(string sponsor, string design, string category)
        {
            menuPage.ClickOnToggleMenu();
            menuPage.SelectSubmitATrialFromToggleMenu();
            submitTrialDetailsPage.FillallTheTrialDetails(Title, sponsor, design, category);
            submitTrialDetailsPage.CancelTrial();
        }

        [Then(@"I should see the new trial created successfully")]
        public void ThenIShouldSeeTheNewTrialCreatedSuccessfully()
        {
            masterTrialListSearchPage.SearchAndVerifyTheCreatedTrial(Title);
        }

        [Then(@"I should be shown with Master Trial List page")]
        public void ThenSheShouldBeShownWithMasterTrialListPage()
        {
            masterTrialListSearchPage.VerifyMasterTrialListSearchPageIsLoaded();
        }

        [Then(@"the new trial should not get created")]
        public void ThenTheNewTrialShouldNotGetCreated()
        {
            mySiteTrialsPage.VerifyMySiteTrialsPageIsLoaded();
        }
    }
}
