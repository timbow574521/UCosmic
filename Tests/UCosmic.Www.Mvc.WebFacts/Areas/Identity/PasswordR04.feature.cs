﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
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
    public partial class ResetPasswordFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PasswordR04.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ResetPassword", "     In order to sign into UCosmic.com after forgetting my password\r\n     As a UC" +
                    "osmic user\r\n     I want to reset my password using my email address", ProgrammingLanguage.CSharp, new string[] {
                        "ResetPassword"});
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ResetPassword")))
            {
                UCosmic.Www.Mvc.Areas.Identity.ResetPasswordFeature.FeatureSetup(null);
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
        
        public virtual void ResetPasswordUnsuccessfullyWithInvalidEmailAddress(string emailAddress, string emailError, string serverValidationError, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PasswordR04"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reset Password unsuccessfully with invalid email address", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("I have signed out");
#line 10
 testRunner.And("I have clicked the \"Sign In\" link");
#line 11
 testRunner.And("I have seen a page at the \"sign-in\" url");
#line 12
 testRunner.And("I have clicked the \"forgot your password\" link");
#line 13
 testRunner.And("I have seen a page at the \"i-forgot-my-password\" url");
#line 14
 testRunner.When(string.Format("I type \"{0}\" into the \"EmailAddress\" text box on the Reset Password form", emailAddress));
#line 15
 testRunner.And("I click the \"Send Confirmation Email\" button on the Reset Password form");
#line 16
 testRunner.Then(string.Format("I should see the error message \"{0}\" for the \"EmailAddress\" text box on the Reset" +
                        " Password form", emailError));
#line 17
 testRunner.And(string.Format("I should see the validation error message \"{0}\" for the \"EmailAddress\" text box o" +
                        "n the Reset Password form", serverValidationError));
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Reset Password unsuccessfully with invalid email address")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PasswordR04")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailError", "Email Address is required.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ServerValidationError", "")]
        public virtual void ResetPasswordUnsuccessfullyWithInvalidEmailAddress_()
        {
            this.ResetPasswordUnsuccessfullyWithInvalidEmailAddress("", "Email Address is required.", "", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Reset Password unsuccessfully with invalid email address")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PasswordR04")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "invalid email")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "invalid email")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailError", "Please enter a valid email address.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ServerValidationError", "")]
        public virtual void ResetPasswordUnsuccessfullyWithInvalidEmailAddress_InvalidEmail()
        {
            this.ResetPasswordUnsuccessfullyWithInvalidEmailAddress("invalid email", "Please enter a valid email address.", "", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Reset Password unsuccessfully with invalid email address")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PasswordR04")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "not-signed-up@gmail.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "not-signed-up@gmail.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailError", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ServerValidationError", "A user account with the email address \'not-signed-up@gmail.com\' could not be foun" +
            "d.")]
        public virtual void ResetPasswordUnsuccessfullyWithInvalidEmailAddress_Not_Signed_UpGmail_Com()
        {
            this.ResetPasswordUnsuccessfullyWithInvalidEmailAddress("not-signed-up@gmail.com", "", "A user account with the email address \'not-signed-up@gmail.com\' could not be foun" +
                    "d.", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Reset Password form successfully dismiss by clicking Cancel button")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PasswordR05")]
        public virtual void ResetPasswordFormSuccessfullyDismissByClickingCancelButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reset Password form successfully dismiss by clicking Cancel button", new string[] {
                        "PasswordR05"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
    testRunner.Given("I have signed out");
#line 28
 testRunner.And("I have clicked the \"Sign In\" link");
#line 29
 testRunner.And("I have seen a page at the \"sign-in\" url");
#line 30
 testRunner.And("I have clicked the \"forgot your password\" link");
#line 31
    testRunner.And("I have seen a page at the \"i-forgot-my-password\" url");
#line 32
    testRunner.When("I click the \"Cancel\" button on the Reset Password form");
#line 33
    testRunner.Then("I should see a page at the \"sign-in\" url");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion