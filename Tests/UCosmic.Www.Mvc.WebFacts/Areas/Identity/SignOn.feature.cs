﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17379
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UCosmic.Www.Mvc.Areas.Identity
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SignOnFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SignOn.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Sign On", "  In order to access my protected information\r\n  As a UCosmic user\r\n  I want to s" +
                    "ign on using my email address", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Sign On")))
            {
                UCosmic.Www.Mvc.Areas.Identity.SignOnFeature.FeatureSetup(null);
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line 8
    testRunner.When("I am not signed on");
#line 9
    testRunner.Then("I should see a \"Sign On\" link");
#line 11
    testRunner.When("I click the \"Sign On\" link");
#line 12
    testRunner.Then("I should see the Sign On page");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sign On fails when email address is empty")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sign On")]
        public virtual void SignOnFailsWhenEmailAddressIsEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign On fails when email address is empty", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 16
    testRunner.When("I click the \"Next >>\" submit button");
#line 17
    testRunner.Then("I should see the Required error message for the Email Address text field");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sign On fails when email address is invalid")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sign On")]
        public virtual void SignOnFailsWhenEmailAddressIsInvalid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign On fails when email address is invalid", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 21
    testRunner.When("I type \"invalid\" into the Email Address text field");
#line 22
    testRunner.And("I click the \"Next >>\" submit button");
#line 23
    testRunner.Then("I should see the Invalid error message for the Email Address text field");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sign On fails when email address is ineligible")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sign On")]
        public virtual void SignOnFailsWhenEmailAddressIsIneligible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign On fails when email address is ineligible", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 27
    testRunner.When("I type \"test@gmail.com\" into the Email Address text field");
#line 28
    testRunner.And("I click the \"Next >>\" submit button");
#line 29
    testRunner.Then("I should see the \'test@gmail.com is Ineligible\' error message for the Email Addre" +
                    "ss text field");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sign On redirects to Enter Password page for local accounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Sign On")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ClearSigningEmailAddress")]
        public virtual void SignOnRedirectsToEnterPasswordPageForLocalAccounts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign On redirects to Enter Password page for local accounts", new string[] {
                        "ClearSigningEmailAddress"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 34
    testRunner.When("I type \"any1@suny.edu\" into the Email Address text field");
#line 35
    testRunner.And("I click the \"Next >>\" submit button");
#line 36
    testRunner.Then("I should see the Enter Password page");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion