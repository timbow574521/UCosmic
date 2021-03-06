﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17626
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UCosmic.Www.Mvc.Areas.RecruitmentAgencies
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class RA_US_0002_ConfigureRecruitmentAgencyModuleForAcademicInstitutionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RA_US_0002.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RA_US_0002 - Configure Recruitment Agency Module for Academic Institution", "In order to customize the recruitment agency module for my institution\r\nAs a recr" +
                    "utiment agency supervisor\r\nI want to configure certain recruitment agency module" +
                    " options", ProgrammingLanguage.CSharp, new string[] {
                        "RepsModule"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "RA_US_0002 - Configure Recruitment Agency Module for Academic Institution")))
            {
                UCosmic.Www.Mvc.Areas.RecruitmentAgencies.RA_US_0002_ConfigureRecruitmentAgencyModuleForAcademicInstitutionFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Navigate to Recruitment Agency Module Configuration pages")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "RA_US_0002 - Configure Recruitment Agency Module for Academic Institution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("RepsModule")]
        public virtual void NavigateToRecruitmentAgencyModuleConfigurationPages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Recruitment Agency Module Configuration pages", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 20
    testRunner.Given("I have signed in as \"supervisor1@uc.edu\" with password \"asdfasdf\"");
#line 21
    testRunner.When("I browse to the Home page");
#line 22
    testRunner.Then("I should see a \"Representatives\" link");
#line 24
    testRunner.When("I click the \"Representatives\" link");
#line 25
    testRunner.Then("I should see a page at the \"www.uc.edu/recruitment-agencies\" url");
#line 26
    testRunner.And("I should see a \"Configure module\" link");
#line 28
    testRunner.When("I click the \"Configure module\" link");
#line 29
    testRunner.Then("I should see a page at the \"www.uc.edu/recruitment-agencies/configure\" url");
#line 30
    testRunner.And("I should see a \"Welcome Message\" link");
#line 31
    testRunner.And("I should see a \"Notifications\" link");
#line 33
    testRunner.When("I click the \"Welcome Message\" link");
#line 34
    testRunner.Then("I should see a page at the \"www.uc.edu/recruitment-agencies/configure/welcome-mes" +
                    "sage\" url");
#line 35
    testRunner.And("I should see a \"Notifications\" link");
#line 37
    testRunner.When("I click the \"Notifications\" link");
#line 38
    testRunner.Then("I should see a page at the \"www.uc.edu/recruitment-agencies/configure/notificatio" +
                    "ns\" url");
#line 39
    testRunner.And("I should see a \"Welcome message\" link");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Prevent unauthorized navigation to the Recruitment Agency Module Configuration pa" +
            "ges")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "RA_US_0002 - Configure Recruitment Agency Module for Academic Institution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("RepsModule")]
        public virtual void PreventUnauthorizedNavigationToTheRecruitmentAgencyModuleConfigurationPages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Prevent unauthorized navigation to the Recruitment Agency Module Configuration pa" +
                    "ges", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 45
 testRunner.Given("I have signed in as \"supervisor1@suny.edu\" with password \"asdfasdf\"");
#line 46
 testRunner.When("I browse to the \"www.uc.edu/recruitment-agencies\" url");
#line 47
    testRunner.Then("I should not see a \"Configure module\" link");
#line 49
    testRunner.When("I browse to the \"www.uc.edu/recruitment-agencies/configure\" url");
#line 50
    testRunner.Then("I should see a 404 Not Found page");
#line 52
    testRunner.When("I browse to the \"www.uc.edu/recruitment-agencies/configure/welcome-message\" url");
#line 53
    testRunner.Then("I should see a 404 Not Found page");
#line 55
    testRunner.When("I browse to the \"www.uc.edu/recruitment-agencies/configure/notifications\" url");
#line 56
    testRunner.Then("I should see a 404 Not Found page");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Prevent anonymous navigation to the Recruitment Agency Module Configuration pages" +
            "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "RA_US_0002 - Configure Recruitment Agency Module for Academic Institution")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("RepsModule")]
        public virtual void PreventAnonymousNavigationToTheRecruitmentAgencyModuleConfigurationPages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Prevent anonymous navigation to the Recruitment Agency Module Configuration pages" +
                    "", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 62
    testRunner.Given("I have signed out");
#line 63
 testRunner.When("I browse to the \"www.uc.edu/recruitment-agencies\" url");
#line 64
    testRunner.Then("I should not see a \"Configure module\" link");
#line 66
    testRunner.When("I browse to the \"www.uc.edu/recruitment-agencies/configure\" url");
#line 67
    testRunner.Then("I should see a 404 Not Found page");
#line 69
    testRunner.When("I browse to the \"www.uc.edu/recruitment-agencies/configure/welcome-message\" url");
#line 70
    testRunner.Then("I should see a 404 Not Found page");
#line 72
    testRunner.When("I browse to the \"www.uc.edu/recruitment-agencies/configure/notifications\" url");
#line 73
    testRunner.Then("I should see a 404 Not Found page");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
