using CI.ClinicalTrials.RegressionTest.Base;
using CI.ClinicalTrials.RegressionTest.CommonMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CI.ClinicalTrials.RegressionTest.Pages
{
    public class MenuPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "regToggleMenu")]
        private IWebElement ToggleMenu { get; set; }

        [FindsBy(How = How.Id, Using = "regDashboard")]
        private IWebElement Dashboard { get; set; }

        [FindsBy(How = How.Id, Using = "regMasterTrials")]
        private IWebElement MasterTrials { get; set; }

        [FindsBy(How = How.Id, Using = "regSubmitATrial")]
        private IWebElement SubmitATrial { get; set; }

        [FindsBy(How = How.Id, Using = "regMySiteTrial")]
        private IWebElement MySiteTrials { get; set; }

        [FindsBy(How = How.Id, Using = "regSignOffMySite")]
        private IWebElement SignOffMySiteTrials { get; set; }

        [FindsBy(How = How.Id, Using = "regAdministration")]
        private IWebElement Administration { get; set; }

        [FindsBy(How = How.Id, Using = "regUsers")]
        private IWebElement Users { get; set; }

        [FindsBy(How = How.Id, Using = "regSponsors")]
        private IWebElement Sponsors { get; set; }

        [FindsBy(How = How.Id, Using = "regLHDs")]
        private IWebElement LHDs { get; set; }

        [FindsBy(How = How.Id, Using = "regCTUs")]
        private IWebElement CTUs { get; set; }

        [FindsBy(How = How.Id, Using = "regHospitalListing")]
        private IWebElement HospitalListing { get; set; }

        [FindsBy(How = How.Id, Using = "regReportPeriods")]
        private IWebElement ReportPeriods { get; set; }

        [FindsBy(How = How.Id, Using = "regReportPeriodsSubMenu")]
        private IWebElement ReportPeriodsSubMenu { get; set; }

        [FindsBy(How = How.Id, Using = "regExtensions")]
        private IWebElement Extensions { get; set; }

        [FindsBy(How = How.Id, Using = "regSignOffHistory")]
        private IWebElement SignOffHistory { get; set; }

        [FindsBy(How = How.Id, Using = "regReconciliation")]
        private IWebElement Reconciliation { get; set; }

        [FindsBy(How = How.Id, Using = "regAdjustments")]
        private IWebElement Adjustments { get; set; }

        [FindsBy(How = How.Id, Using = "regPayment")]
        private IWebElement Payment { get; set; }

        [FindsBy(How = How.Id, Using = "regPeriodicCoreFunding")]
        private IWebElement PeriodicCoreFunding { get; set; }

        [FindsBy(How = How.Id, Using = "regGlobalAuditHistory")]
        private IWebElement GlobalAuditHistory { get; set; }

        public void ClickOnToggleMenu()
        {
            ToggleMenu.Click();
        }

        public void SelectSubmitATrialFromToggleMenu()
        {
            PageHelper.WaitForElement(Driver, SubmitATrial).Click();
        }

        public void SelectMasterTrialFromToggleMenu()
        {
            PageHelper.WaitForElement(Driver, MasterTrials).Click();
        }

        public void SelectUsersFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, Users).Click();
        }

        public void SelectSponsorsFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, Sponsors).Click();
        }

        public void SelectLHDsFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, LHDs).Click();
        }

        public void SelectCTUsFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, Administration).Click();
            PageHelper.WaitForElement(Driver, CTUs).Click();
        }

        public void SelectMySiteTrialsFromToggleMenu()
        {
            ClickOnToggleMenu();
            PageHelper.WaitForElement(Driver, MySiteTrials).Click();
        }

        public void VerifyTheEditedUser(string type)
        {
            
        }
    }
}
